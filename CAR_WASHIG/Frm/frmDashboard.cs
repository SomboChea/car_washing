using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MIS_PROJECT
{
    public partial class frmDashboard : MetroForm
    {
        public frmDashboard()
        {
            InitializeComponent();
            ControlBox = false;
            FullMode.Fullscreen(this);
            this.Text = "Dashboard | Welcome - " + Helper.Username;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            new frmInvoice().ShowDialog();
        }

        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnservice_Click(object sender, EventArgs e)
        {
            new frmAdd().ShowDialog();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            new frmEmployee().ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new Frm.frmMainReports().ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbDateTime.Text = "Date: " + DateTime.Now.ToString("dd/MM/yyyy") + " - Time: " + DateTime.Now.TimeOfDay.ToString("hh\\:mm\\:ss");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
