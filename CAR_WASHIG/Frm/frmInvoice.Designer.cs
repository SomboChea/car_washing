namespace MIS_PROJECT
{
    partial class frmInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            this.listStatus = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btncheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listStatus
            // 
            this.listStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listStatus.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listStatus.FullRowSelect = true;
            this.listStatus.GridLines = true;
            this.listStatus.Location = new System.Drawing.Point(31, 131);
            this.listStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listStatus.MultiSelect = false;
            this.listStatus.Name = "listStatus";
            this.listStatus.Size = new System.Drawing.Size(904, 404);
            this.listStatus.TabIndex = 0;
            this.listStatus.UseCompatibleStateImageBehavior = false;
            this.listStatus.View = System.Windows.Forms.View.Details;
            this.listStatus.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            this.listStatus.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listStatus.DoubleClick += new System.EventHandler(this.listStatus_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Guest ID";
            this.columnHeader1.Width = 190;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount";
            this.columnHeader2.Width = 271;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 379;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(31, 87);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "STATUS :";
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.Color.SteelBlue;
            this.btncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncheck.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.ForeColor = System.Drawing.Color.White;
            this.btncheck.Location = new System.Drawing.Point(943, 131);
            this.btncheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(139, 38);
            this.btncheck.TabIndex = 2;
            this.btncheck.Text = "Check IN";
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1113, 555);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmInvoice";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Text = "Invoice Queue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInvoice_FormClosing);
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listStatus;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}