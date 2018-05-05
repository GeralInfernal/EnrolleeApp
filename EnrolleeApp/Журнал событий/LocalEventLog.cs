using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace EnrolleeApp
{
    public partial class LocalEventLog : Form
    {
        public LocalEventLog()
        {
            InitializeComponent();
        }

        private DialogResult dr = DialogResult.Cancel;

        private void LocalEventLog_Load(object sender, EventArgs e)
        {
            DataTable dt;
            if(!MainForm.LocalDB.Get_log(out dt))
            {
                this.Close();
                return;
            }

            foreach (DataRow i in dt.Rows)
            {
                dgvEvents.Rows.Add(i[0].ToString(), i[1].ToString(), i[2].ToString(), i[3].ToString());
            }
            tsl_EventsCounter.Text = "Количество записей: " + dt.Rows.Count.ToString();
        }

        private void tsmiAbout2_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEvents.Rows.Count == 0) return;
                sfdLog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                if (sfdLog.ShowDialog() == DialogResult.OK)
                {
                    string catalog = sfdLog.FileName;
                    string[] ext = new string[2];
                    ext = catalog.Split('.');
                    if (ext[1] == "docx")
                    {
                        var wordApp = new Word.Application();
                        wordApp.Visible = false;

                        var wordDocument = wordApp.Documents.Open(System.IO.Directory.GetCurrentDirectory() + "\\Report templates\\template_log.docx");
                        ReplaseWords("{date}", DateTime.Now.ToLongDateString(), wordDocument);
                        ReplaseWordsToTable("{table}", wordDocument);

                        wordDocument.SaveAs(@sfdLog.FileName);
                        wordDocument.Close();
                        MainForm.LocalDB.Add_log("Выгрузка журнала событий", "Формат: docx; Обработано строк: " + Convert.ToString(dgvEvents.Rows.Count.ToString()));
                        tsl_PrevOpStatus.Text = "Журнал успешно выгружен!";
                    }
                    else
                    {
                        string[] str = new string[dgvEvents.Rows.Count];
                        int ind = 0;
                        foreach (DataGridViewRow i in dgvEvents.Rows)
                        {
                            foreach (DataGridViewCell j in i.Cells)
                            {
                                str[ind] = str[ind] + Convert.ToString(j.Value) + " ";
                            }
                            ind++;
                        }
                        System.IO.File.WriteAllLines(sfdLog.FileName, str);
                        MainForm.LocalDB.Add_log("Выгрузка журнала событий", "Формат: docx; Обработано строк: " + Convert.ToString(str.Length));
                        tsl_PrevOpStatus.Text = "Журнал успешно выгружен!";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReplaseWords(string to_replace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: to_replace, ReplaceWith: text);
        }
        private void ReplaseWordsToTable(string to_replace, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: "{table}");

            Object behiavor = Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            Object autoFitBehiavor = Word.WdAutoFitBehavior.wdAutoFitFixed;
            range.Tables.Add(range, dgvEvents.Rows.Count + 1, dgvEvents.Columns.Count + 1, ref behiavor, ref autoFitBehiavor);

            Word.Table table = wordDocument.Tables[1];
            table.Range.Font.Size = 12;

            int rows = dgvEvents.RowCount + 1;
            int columns = dgvEvents.ColumnCount;

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    table.Cell(i + 2, j + 1).Range.Text = dgvEvents[j, i].Value.ToString();
                }
            }
        }

        private void Export()
        {
            Word.Application wordapp = new Word.Application();
            wordapp.Visible = true;
            Object template = System.IO.Directory.GetCurrentDirectory() + "\\Report templates\\template_log.docx";
            Object newTemplate = false;
            Object documentType = Word.WdNewDocumentType.wdNewBlankDocument;
            Object visible = true;
            Word._Document worddoc;
            //Создаем документ
            worddoc = wordapp.Documents.Add(ref template, ref newTemplate, ref documentType, ref visible);

            Object bookmarkNameObj = "id";
            Word.Range bookmarkRange = null;
            bookmarkRange = worddoc.Bookmarks.get_Item(ref bookmarkNameObj).Range;
            bookmarkRange.Text = "Идентификатор";

            bookmarkNameObj = "event";
            bookmarkRange = null;
            bookmarkRange = worddoc.Bookmarks.get_Item(ref bookmarkNameObj).Range;
            bookmarkRange.Text = "Событие";

            bookmarkNameObj = "date";
            bookmarkRange = null;
            bookmarkRange = worddoc.Bookmarks.get_Item(ref bookmarkNameObj).Range;
            bookmarkRange.Text = "Дата";

            bookmarkNameObj = "desc";
            bookmarkRange = null;
            bookmarkRange = worddoc.Bookmarks.get_Item(ref bookmarkNameObj).Range;
            bookmarkRange.Text = "Описание";

            Object behiavor = Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            Object autoFitBehiavor = Word.WdAutoFitBehavior.wdAutoFitFixed;
            int rows = dgvEvents.RowCount + 1;
            int columns = 4;
            worddoc.Tables.Add(bookmarkRange, rows, columns, ref behiavor, ref autoFitBehiavor);
            worddoc.Tables[1].Cell(1, 1).Range.Text = "Идентификатор";
            worddoc.Tables[1].Cell(1, 2).Range.Text = "Событие";
            worddoc.Tables[1].Cell(1, 3).Range.Text = "Дата";
            worddoc.Tables[1].Cell(1, 4).Range.Text = "Описание";
            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    worddoc.Tables[1].Cell(i + 2, j + 1).Range.Text = dgvEvents[j, i].Value.ToString();
                }
            }
        }

        private void LocalEventLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = dr;
        }

        private void tsmiShowID_Click(object sender, EventArgs e)
        {
            if (tsmiShowID.Checked)
            {
                tsmiShowID.Checked = false;
                dgvEvents.Columns["log_id"].Visible = false;
            }
            else
            {
                tsmiShowID.Checked = true;
                dgvEvents.Columns["log_id"].Visible = true;
            }
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (dgvEvents.Rows.Count == 0) return;
            DialogResult dr = MessageBox.Show("Вы точно очистить журнал событий?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                if (!MainForm.LocalDB.Clear_log())
                {
                    MainForm.LocalDB.Add_log("Очищен локальный журнал", "Удалено строк: " + dgvEvents.Rows.Count.ToString());
                    dgvEvents.Rows.Clear();
                }
            }
            LocalEventLog_Load(this, new EventArgs());
        }
    }
}
