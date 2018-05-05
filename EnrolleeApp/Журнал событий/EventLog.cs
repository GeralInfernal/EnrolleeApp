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
    public partial class EventLog : Form
    {
        public EventLog()
        {
            InitializeComponent();
        }

        private void EventLog_Load(object sender, EventArgs e)
        {
            DataTable dt;
            if (!MainForm.DB.Get_log(out dt))
            {
                this.Close();
                return;
            }

            foreach (DataRow i in dt.Rows)
            {
                dgvEvents.Rows.Add(i[0].ToString(), i[1].ToString(), i[2].ToString(), i[3].ToString());
            }
            tsl_EventsCount.Text = "Количество записей: " + dt.Rows.Count.ToString();
        }

        private void tsmiClearLog_Click(object sender, EventArgs e)
        {

        }
    }
}
