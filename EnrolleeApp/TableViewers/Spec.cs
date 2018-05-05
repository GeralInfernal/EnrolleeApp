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
    public partial class Spec : Form
    {
        public Spec()
        {
            InitializeComponent();
        }

        private DialogResult result = DialogResult.Cancel;

        private void Spec_Load(object sender, EventArgs e)
        {
            DataTable dt;
            if (!MainForm.DB.Get_spec(out dt))
            {
                this.Close();
                return;
            }

            dsSpec.Tables.Add(dt);
            bsSpec.DataSource = dsSpec;
            bsSpec.DataMember = "dt";
            dgvSpec.DataSource = bsSpec;

            /*
            foreach (DataRow i in dt.Rows)
            {
                dgvEvents.Rows.Add(i[0].ToString(), i[1].ToString(), i[2].ToString(), i[3].ToString());
            }
            tsl_EventsCounter.Text = "Количество записей: " + dt.Rows.Count.ToString();
            */
        }

        private void Spec_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = result;
        }
    }
}
