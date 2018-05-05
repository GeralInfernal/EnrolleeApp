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
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        private DialogResult result = DialogResult.Cancel;

        private void Base_Load(object sender, EventArgs e)
        {
            DataTable dt;
            if (!MainForm.DB.Get_base(out dt))
            {
                this.Close();
                return;
            }

            foreach (DataRow i in dt.Rows)
            {
                dgvBase.Rows.Add(i[0].ToString(), i[1].ToString());
            }
            tsl_BaseCount.Text = "Количество записей: " + dt.Rows.Count.ToString();
        }

        private void Base_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = result;
        }
    }
}
