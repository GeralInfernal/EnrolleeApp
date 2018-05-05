using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace EnrolleeApp
{
    public partial class TableViewer : Form
    {
        public TableViewer(string table_name, string sql)
        {
            InitializeComponent();

            query = sql;
            this.Text = table_name;
            TableViewer_Load(this, new EventArgs());
        }

        private DialogResult result = DialogResult.Cancel;
        private string query;

        private void TableViewer_Load(object sender, EventArgs e)
        {
            DataTable dt;
            if (!MainForm.DB.RunQuery(query, out dt))
            {
                this.Close();
                return;
            }

            dgvTable.DataSource = dt;
            dgvTable.Update();

            tsl_RowsCount.Text = "Количество записей: " + dt.Rows.Count.ToString();
        }

        private void TableViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = result;
        }

        #region Меню

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

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        #endregion

        #region Cправка

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void tsmiHelp_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"EnrolleeAppHelp.chm");
            }
            catch
            {
                MessageBox.Show("Неудается найти файл справки!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTable.Rows.Count == 0) return;
                sfdTable.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                if (sfdTable.ShowDialog() == DialogResult.OK)
                {
                    string catalog = sfdTable.FileName;
                    string[] ext = new string[2];
                    ext = catalog.Split('.');
                    if (ext[1] == "docx")
                    {
                        var wordApp = new Word.Application();
                        wordApp.Visible = false;

                        var wordDocument = wordApp.Documents.Open(System.IO.Directory.GetCurrentDirectory() + "\\Report templates\\template_log.docx");
                        ReplaseWords("{date}", DateTime.Now.ToLongDateString(), wordDocument);
                        ReplaseWordsToTable("{table}", wordDocument);

                        wordDocument.SaveAs(@sfdTable.FileName);
                        wordDocument.Close();
                        MainForm.DB.Add_log("Выгрузка таблицы " + this.Text, "Формат: docx; Обработано строк: " + Convert.ToString(dgvTable.Rows.Count.ToString()));
                        tsl_PrevOpResult.Text = "Таблица успешно сохранена в формате docx!";
                    }
                    else
                    {
                        string[] str = new string[dgvTable.Rows.Count];
                        int ind = 0;
                        foreach (DataGridViewRow i in dgvTable.Rows)
                        {
                            foreach (DataGridViewCell j in i.Cells)
                            {
                                str[ind] = str[ind] + Convert.ToString(j.Value) + " ";
                            }
                            ind++;
                        }
                        System.IO.File.WriteAllLines(sfdTable.FileName, str);
                        MainForm.LocalDB.Add_log("Выгрузка таблицы " + this.Text, "Формат: txt; Обработано строк: " + Convert.ToString(str.Length));
                        tsl_PrevOpResult.Text = "Таблица успешно сохранена в формате txt!";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
            range.Tables.Add(range, dgvTable.Rows.Count + 1, dgvTable.Columns.Count + 1, ref behiavor, ref autoFitBehiavor);

            Word.Table table = wordDocument.Tables[1];
            table.Range.Font.Size = 12;

            int rows = dgvTable.RowCount + 1;
            int columns = dgvTable.ColumnCount;

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    table.Cell(i + 2, j + 1).Range.Text = dgvTable[j, i].Value.ToString();
                }
            }
        }
    }
}
