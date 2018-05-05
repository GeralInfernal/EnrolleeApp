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
    public partial class Polity : Form
    {
        public Polity()
        {
            InitializeComponent();
        }

        private DialogResult result = DialogResult.Cancel;

        private void Polity_Load(object sender, EventArgs e)
        {
            DataTable dt;
            if (!MainForm.DB.Get_polity(out dt))
            {
                this.Close();
                return;
            }

            foreach (DataRow i in dt.Rows)
            {
                dgvPolity.Rows.Add(i[0].ToString(), i[1].ToString(), i[2].ToString(), i[3].ToString());
            }
            tsl_PolityCount.Text = "Количество записей: " + dt.Rows.Count.ToString();
        }

        private void Polity_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = result;
        }
    }
}
