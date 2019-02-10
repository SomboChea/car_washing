using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS_PROJECT
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
            Data.TestConnection(this);
            ControlBox = false;
            FullMode.Fullscreen(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Trim() != "" && txtpass.Text.Trim() != "")
            {
                Helper.Username = Data.ExecuteScale("Select Name from Employee where Username='" + txtname.Text.Trim() + "' or Email='" + txtname.Text.Trim() + "'") + "";
                string PosID = Data.ExecuteScale("Select PosID from Employee where Username='" + txtname.Text + "' or Email='" + txtname.Text + "' and Password='" + txtpass.Text + "' and Status='Enable'") + "";
                if (PosID == "1")
                {
                    new frmDashboard().ShowDialog(); this.Hide();
                }
                else if (PosID == "2")
                {
                    new frmSellService().ShowDialog(); this.Hide();
                }
                else
                {
                    MetroMessageBox.Show(this, "You are no right to Access", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Helper.Username = "";
                }
            }

            txtname.Text = "";
            txtpass.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.Connection.Close();
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnDBSetting_Click(object sender, EventArgs e)
        {
            new DBSetting().ShowDialog();
        }
    }
}