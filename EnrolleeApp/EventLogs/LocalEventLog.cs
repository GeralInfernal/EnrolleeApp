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
            dgvEvents.Rows.Clear();

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
        private void tsmiContext_Click(object sender, EventArgs e)
        {

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
            int rows = dgvEvents.RowCount + 1;
            int columns = 4;
            wordDocument.Tables.Add(range, rows, columns, ref behiavor, ref autoFitBehiavor);
            wordDocument.Tables[0].Cell(1, 1).Range.Text = "Идентификатор";
            wordDocument.Tables[0].Cell(1, 2).Range.Text = "Событие";
            wordDocument.Tables[0].Cell(1, 3).Range.Text = "Дата";
            wordDocument.Tables[0].Cell(1, 4).Range.Text = "Описание";

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    wordDocument.Tables[1].Cell(i + 2, j + 1).Range.Text = dgvEvents[j, i].Value.ToString();
                }
            }
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


        #region Печать и предварительный просмотр

        private void tsmiPrint_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument.Print();
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest,
            int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width,
                this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void tsmiPreview_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.WindowState = FormWindowState.Maximized;
            dlg.Document = printDocument;
            dlg.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        #endregion
    

        private void LocalEventLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = dr;
        }
    }
}
