namespace MIS_PROJECT
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtname = new MetroFramework.Controls.MetroTextBox();
            this.txtpass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnsignin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDBSetting = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(272, 435);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Username:";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // txtname
            // 
            this.txtname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtname.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtname.Lines = new string[0];
            this.txtname.Location = new System.Drawing.Point(379, 435);
            this.txtname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtname.MaxLength = 32767;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtname.SelectedText = "";
            this.txtname.Size = new System.Drawing.Size(283, 26);
            this.txtname.Style = MetroFramework.MetroColorStyle.Green;
            this.txtname.TabIndex = 1;
            this.txtname.UseCustomBackColor = true;
            this.txtname.UseCustomForeColor = true;
            this.txtname.UseSelectable = true;
            this.txtname.UseStyleColors = true;
            // 
            // txtpass
            // 
            this.txtpass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtpass.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtpass.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtpass.Lines = new string[0];
            this.txtpass.Location = new System.Drawing.Point(379, 489);
            this.txtpass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpass.MaxLength = 32767;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpass.SelectedText = "";
            this.txtpass.Size = new System.Drawing.Size(283, 26);
            this.txtpass.Style = MetroFramework.MetroColorStyle.Green;
            this.txtpass.TabIndex = 3;
            this.txtpass.UseCustomBackColor = true;
            this.txtpass.UseCustomForeColor = true;
            this.txtpass.UseSelectable = true;
            this.txtpass.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(272, 490);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Password:";
            // 
            // btnexit
            // 
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(567, 563);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(94, 34);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsignin
            // 
            this.btnsignin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsignin.BackColor = System.Drawing.Color.Green;
            this.btnsignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignin.ForeColor = System.Drawing.Color.White;
            this.btnsignin.Location = new System.Drawing.Point(379, 563);
            this.btnsignin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.Size = new System.Drawing.Size(113, 34);
            this.btnsignin.TabIndex = 5;
            this.btnsignin.Text = "SIGN IN";
            this.btnsignin.UseVisualStyleBackColor = false;
            this.btnsignin.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(211, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 75);
            this.label1.TabIndex = 7;
            this.label1.Text = "Car Washing System";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(396, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 55);
            this.label2.TabIndex = 8;
            this.label2.Text = "Login";
            // 
            // btnDBSetting
            // 
            this.btnDBSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDBSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnDBSetting.BackgroundImage = global::MIS_PROJECT.Properties.Resources.Settings_icon;
            this.btnDBSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDBSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBSetting.ForeColor = System.Drawing.Color.White;
            this.btnDBSetting.Location = new System.Drawing.Point(49, 561);
            this.btnDBSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDBSetting.Name = "btnDBSetting";
            this.btnDBSetting.Size = new System.Drawing.Size(36, 38);
            this.btnDBSetting.TabIndex = 9;
            this.btnDBSetting.UseVisualStyleBackColor = false;
            this.btnDBSetting.Click += new System.EventHandler(this.btnDBSetting_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::MIS_PROJECT.Properties.Resources.car_washing;
            this.pictureBox1.Location = new System.Drawing.Point(216, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(927, 632);
            this.Controls.Add(this.btnDBSetting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsignin);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.metroLabel1);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmLogin";
            this.Padding = new System.Windows.Forms.Padding(20, 36, 20, 20);
            this.Resizable = false;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtname;
        private MetroFramework.Controls.MetroTextBox txtpass;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnsignin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDBSetting;
    }
}

