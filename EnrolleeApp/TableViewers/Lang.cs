using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrolleeApp
{
    public partial class Lang : Form
    {
        public Lang()
        {
            InitializeComponent();
        }

        private DialogResult result = DialogResult.Cancel;

        private void Lang_Load(object sender, EventArgs e)
        {
            DataTable dt;
            if (!MainForm.DB.Get_lang(out dt))
            {
                this.Close();
                return;
            }

            foreach (DataRow i in dt.Rows)
            {
                dgvLang.Rows.Add(i[0].ToString(), i[1].ToString(), i[2].ToString(), i[3].ToString());
            }
            tsl_LangCount.Text = "Количество записей: " + dt.Rows.Count.ToString();
        }

        private void Lang_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = result;
        }
    }
}
