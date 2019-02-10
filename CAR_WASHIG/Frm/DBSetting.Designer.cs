namespace MIS_PROJECT
{
    partial class DBSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbAuthentication = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lbPass = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.lbUser = new MetroFramework.Controls.MetroLabel();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnApply = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtHost = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cbAuthentication
            // 
            this.cbAuthentication.FormattingEnabled = true;
            this.cbAuthentication.ItemHeight = 23;
            this.cbAuthentication.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cbAuthentication.Location = new System.Drawing.Point(157, 131);
            this.cbAuthentication.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAuthentication.Name = "cbAuthentication";
            this.cbAuthentication.Size = new System.Drawing.Size(212, 29);
            this.cbAuthentication.Style = MetroFramework.MetroColorStyle.Lime;
            this.cbAuthentication.TabIndex = 21;
            this.cbAuthentication.UseCustomBackColor = true;
            this.cbAuthentication.UseCustomForeColor = true;
            this.cbAuthentication.UseSelectable = true;
            this.cbAuthentication.SelectedIndexChanged += new System.EventHandler(this.cbAuthentication_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(17, 135);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(136, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Authentication : ";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbPass.Location = new System.Drawing.Point(78, 226);
            this.lbPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(101, 25);
            this.lbPass.Style = MetroFramework.MetroColorStyle.Lime;
            this.lbPass.TabIndex = 19;
            this.lbPass.Text = "Password  : ";
            this.lbPass.UseCustomBackColor = true;
            this.lbPass.UseCustomForeColor = true;
            this.lbPass.UseStyleColors = true;
            // 
            // txtPassword
            // 
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(182, 223);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(186, 24);
            this.txtPassword.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtPassword.TabIndex = 18;
            this.txtPassword.UseCustomBackColor = true;
            this.txtPassword.UseCustomForeColor = true;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseStyleColors = true;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbUser.Location = new System.Drawing.Point(78, 181);
            this.lbUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(103, 25);
            this.lbUser.Style = MetroFramework.MetroColorStyle.Lime;
            this.lbUser.TabIndex = 17;
            this.lbUser.Text = "Username : ";
            this.lbUser.UseCustomBackColor = true;
            this.lbUser.UseCustomForeColor = true;
            this.lbUser.UseStyleColors = true;
            // 
            // txtUsername
            // 
            this.txtUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(182, 181);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(186, 24);
            this.txtUsername.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtUsername.TabIndex = 16;
            this.txtUsername.UseCustomBackColor = true;
            this.txtUsername.UseCustomForeColor = true;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.UseStyleColors = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(56, 302);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 24);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseCustomForeColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(278, 302);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(66, 24);
            this.btnApply.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnApply.TabIndex = 14;
            this.btnApply.Text = "Apply";
            this.btnApply.UseCustomBackColor = true;
            this.btnApply.UseCustomForeColor = true;
            this.btnApply.UseSelectable = true;
            this.btnApply.UseStyleColors = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(17, 83);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Hostname : ";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // txtHost
            // 
            this.txtHost.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtHost.Lines = new string[0];
            this.txtHost.Location = new System.Drawing.Point(157, 83);
            this.txtHost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHost.MaxLength = 32767;
            this.txtHost.Multiline = true;
            this.txtHost.Name = "txtHost";
            this.txtHost.PasswordChar = '\0';
            this.txtHost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHost.SelectedText = "";
            this.txtHost.Size = new System.Drawing.Size(211, 24);
            this.txtHost.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtHost.TabIndex = 12;
            this.txtHost.UseCustomBackColor = true;
            this.txtHost.UseCustomForeColor = true;
            this.txtHost.UseSelectable = true;
            this.txtHost.UseStyleColors = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(189, 302);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 24);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DBSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 366);
            this.Controls.Add(this.cbAuthentication);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DBSetting";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "DBSetting";
            this.Load += new System.EventHandler(this.DBSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbAuthentication;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lbPass;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel lbUser;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnApply;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtHost;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}