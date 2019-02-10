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

namespace MIS_PROJECT
{
    public partial class DBSetting : MetroForm
    {
        public DBSetting()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Resizable = false;
            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ControlBox = false;

            reloadCheck();
        }

        INIParser mySetting = new INIParser("Settings.ini"); //Used

        //AuthType
        string section = "SQL Server Authentication";
        string section2 = "Windows Authentication";

        private void reloadCheck(byte auth = 0)
        {
            byte type = auth;

            try
            {
                type = byte.Parse(mySetting.Read("AuthType"));
            }
            catch (Exception)
            {
                type = 0;
            }

            if (type == 0)
            {
                txtHost.Text = mySetting.Read("hostname", section2);
                cbAuthentication.SelectedIndex = 0;
                UserPassEnable(false);
            }
            else
            {
                setAuthSQL();
                UserPassEnable(true);
            }
        }

        private void setAuthSQL()
        {
            cbAuthentication.SelectedIndex = 1;
            txtHost.Text = mySetting.Read("hostname", section);
            txtUsername.Text = mySetting.Read("username", section);
            txtPassword.Text = mySetting.Read("password", section);
        }

        private void UserPassEnable(bool enable)
        {
            if (enable)
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                lbPass.ForeColor = System.Drawing.Color.Black;
                lbUser.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                lbPass.ForeColor = System.Drawing.Color.LightGray;
                lbUser.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                saveSetting((byte)cbAuthentication.SelectedIndex);
                MessageBox.Show("Saved!", "DB Setting");
                reloadCheck();
            }
            catch (Exception)
            {
                MessageBox.Show("Saving error!", "DB Setting");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnApply_Click(sender, e);
            this.Close();
        }

        private void saveSetting(byte auth)
        {
            if (auth.Equals(1))
            {
                mySetting.Write("AuthType", 1 + "");
                mySetting.Write("hostname", txtHost.Text, section);
                mySetting.Write("dbname", "PSMS2", section);
                mySetting.Write("username", txtUsername.Text, section);
                mySetting.Write("password", txtPassword.Text, section);
            }
            else
            {
                mySetting.Write("AuthType", 0 + "");
                mySetting.Write("hostname", txtHost.Text, section2);
                mySetting.Write("dbname", "PSMS2", section2);
            }


        }

        private void DBSetting_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAuthentication.SelectedIndex == 0)
            {
                txtHost.Text = mySetting.Read("hostname", section2);
                UserPassEnable(false);
            }
            else
            {
                setAuthSQL();
                UserPassEnable(true);
            }
        }
    }
}
