namespace MIS_PROJECT
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new MetroFramework.Controls.MetroTile();
            this.btnservice = new MetroFramework.Controls.MetroTile();
            this.btnEmp = new MetroFramework.Controls.MetroTile();
            this.btnReport = new MetroFramework.Controls.MetroTile();
            this.btnInvoice = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnservice);
            this.panel1.Controls.Add(this.btnEmp);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnInvoice);
            this.panel1.Location = new System.Drawing.Point(89, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 579);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.ActiveControl = null;
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(820, 392);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(189, 184);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.TileImage = global::MIS_PROJECT.Properties.Resources.smartphone;
            this.btnLogout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnLogout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnLogout.UseCustomBackColor = true;
            this.btnLogout.UseCustomForeColor = true;
            this.btnLogout.UseSelectable = true;
            this.btnLogout.UseStyleColors = true;
            this.btnLogout.UseTileImage = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnservice
            // 
            this.btnservice.ActiveControl = null;
            this.btnservice.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnservice.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnservice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnservice.Location = new System.Drawing.Point(383, 191);
            this.btnservice.Name = "btnservice";
            this.btnservice.Size = new System.Drawing.Size(626, 194);
            this.btnservice.TabIndex = 1;
            this.btnservice.Text = "SERVICE";
            this.btnservice.TileImage = global::MIS_PROJECT.Properties.Resources.badge;
            this.btnservice.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnservice.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnservice.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnservice.UseCustomBackColor = true;
            this.btnservice.UseCustomForeColor = true;
            this.btnservice.UseSelectable = true;
            this.btnservice.UseStyleColors = true;
            this.btnservice.UseTileImage = true;
            this.btnservice.Click += new System.EventHandler(this.btnservice_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.ActiveControl = null;
            this.btnEmp.AutoSize = true;
            this.btnEmp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEmp.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEmp.ForeColor = System.Drawing.Color.White;
            this.btnEmp.Location = new System.Drawing.Point(3, 191);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(374, 194);
            this.btnEmp.TabIndex = 1;
            this.btnEmp.Text = "EMPLOYEE";
            this.btnEmp.TileImage = global::MIS_PROJECT.Properties.Resources.users;
            this.btnEmp.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmp.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnEmp.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnEmp.UseCustomBackColor = true;
            this.btnEmp.UseCustomForeColor = true;
            this.btnEmp.UseSelectable = true;
            this.btnEmp.UseStyleColors = true;
            this.btnEmp.UseTileImage = true;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // btnReport
            // 
            this.btnReport.ActiveControl = null;
            this.btnReport.BackColor = System.Drawing.Color.SlateBlue;
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(3, 391);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(810, 185);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "REPORT";
            this.btnReport.TileImage = global::MIS_PROJECT.Properties.Resources.increasing_stocks_graphic_of_bars;
            this.btnReport.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReport.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnReport.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnReport.UseCustomBackColor = true;
            this.btnReport.UseCustomForeColor = true;
            this.btnReport.UseSelectable = true;
            this.btnReport.UseStyleColors = true;
            this.btnReport.UseTileImage = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.ActiveControl = null;
            this.btnInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvoice.BackColor = System.Drawing.Color.DeepPink;
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.Location = new System.Drawing.Point(3, 3);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(1006, 182);
            this.btnInvoice.TabIndex = 0;
            this.btnInvoice.Text = "INVOICE QUEUE";
            this.btnInvoice.TileImage = global::MIS_PROJECT.Properties.Resources.hospital_supplies;
            this.btnInvoice.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInvoice.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnInvoice.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnInvoice.UseCustomBackColor = true;
            this.btnInvoice.UseCustomForeColor = true;
            this.btnInvoice.UseSelectable = true;
            this.btnInvoice.UseStyleColors = true;
            this.btnInvoice.UseTileImage = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(150, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(889, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wecome to Car Washing System Management";
            // 
            // lbDateTime
            // 
            this.lbDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lbDateTime.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbDateTime.Location = new System.Drawing.Point(694, 25);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(127, 27);
            this.lbDateTime.TabIndex = 2;
            this.lbDateTime.Text = "DateTime: ";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(485, 801);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "SETEC INSTITUTE";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 835);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmDashboard";
            this.Resizable = false;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDashboard_FormClosing);
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile btnEmp;
        private MetroFramework.Controls.MetroTile btnInvoice;
        private MetroFramework.Controls.MetroTile btnservice;
        private MetroFramework.Controls.MetroTile btnReport;
        private MetroFramework.Controls.MetroTile btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
    }
}