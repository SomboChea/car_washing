namespace MIS_PROJECT.Frm
{
    partial class frmMainReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridData = new MetroFramework.Controls.MetroGrid();
            this.btnPreview = new MetroFramework.Controls.MetroButton();
            this.btnDaily = new MetroFramework.Controls.MetroButton();
            this.btnWeekly = new MetroFramework.Controls.MetroButton();
            this.cbShowby = new MetroFramework.Controls.MetroComboBox();
            this.lbShowby = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.lbRec = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.lbTotalAmount = new MetroFramework.Controls.MetroLabel();
            this.btnPreviewAll = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // gridData
            // 
            this.gridData.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.gridData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.gridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridData.DefaultCellStyle = dataGridViewCellStyle13;
            this.gridData.EnableHeadersVisualStyles = false;
            this.gridData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridData.Location = new System.Drawing.Point(24, 232);
            this.gridData.MultiSelect = false;
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            this.gridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gridData.RowHeadersWidth = 15;
            this.gridData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.gridData.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.gridData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridData.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.gridData.RowTemplate.Height = 24;
            this.gridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridData.Size = new System.Drawing.Size(1172, 443);
            this.gridData.Style = MetroFramework.MetroColorStyle.Silver;
            this.gridData.TabIndex = 2;
            this.gridData.UseCustomBackColor = true;
            this.gridData.UseCustomForeColor = true;
            this.gridData.UseStyleColors = true;
            this.gridData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellDoubleClick);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.DeepPink;
            this.btnPreview.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(847, 691);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(165, 44);
            this.btnPreview.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseCustomBackColor = true;
            this.btnPreview.UseCustomForeColor = true;
            this.btnPreview.UseSelectable = true;
            this.btnPreview.UseStyleColors = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnDaily
            // 
            this.btnDaily.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDaily.DisplayFocus = true;
            this.btnDaily.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDaily.ForeColor = System.Drawing.Color.White;
            this.btnDaily.Location = new System.Drawing.Point(286, 107);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Size = new System.Drawing.Size(452, 61);
            this.btnDaily.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDaily.TabIndex = 4;
            this.btnDaily.Text = "Daily";
            this.btnDaily.UseCustomBackColor = true;
            this.btnDaily.UseCustomForeColor = true;
            this.btnDaily.UseSelectable = true;
            this.btnDaily.UseStyleColors = true;
            this.btnDaily.Click += new System.EventHandler(this.btnDaily_Click);
            // 
            // btnWeekly
            // 
            this.btnWeekly.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnWeekly.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnWeekly.ForeColor = System.Drawing.Color.White;
            this.btnWeekly.Location = new System.Drawing.Point(744, 107);
            this.btnWeekly.Name = "btnWeekly";
            this.btnWeekly.Size = new System.Drawing.Size(452, 61);
            this.btnWeekly.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnWeekly.TabIndex = 5;
            this.btnWeekly.Text = "Weekly";
            this.btnWeekly.UseCustomBackColor = true;
            this.btnWeekly.UseCustomForeColor = true;
            this.btnWeekly.UseSelectable = true;
            this.btnWeekly.UseStyleColors = true;
            this.btnWeekly.Click += new System.EventHandler(this.btnWeekly_Click);
            // 
            // cbShowby
            // 
            this.cbShowby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowby.FormattingEnabled = true;
            this.cbShowby.ItemHeight = 24;
            this.cbShowby.Items.AddRange(new object[] {
            "All",
            "Washing",
            "Oil",
            "Drink"});
            this.cbShowby.Location = new System.Drawing.Point(113, 189);
            this.cbShowby.Name = "cbShowby";
            this.cbShowby.Size = new System.Drawing.Size(192, 30);
            this.cbShowby.TabIndex = 6;
            this.cbShowby.UseSelectable = true;
            this.cbShowby.SelectedIndexChanged += new System.EventHandler(this.cbShowby_SelectedIndexChanged);
            // 
            // lbShowby
            // 
            this.lbShowby.AutoSize = true;
            this.lbShowby.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbShowby.Location = new System.Drawing.Point(23, 189);
            this.lbShowby.Name = "lbShowby";
            this.lbShowby.Size = new System.Drawing.Size(84, 25);
            this.lbShowby.TabIndex = 7;
            this.lbShowby.Text = "Show by:";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroButton1.DisplayFocus = true;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(24, 107);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(256, 61);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "All";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // lbRec
            // 
            this.lbRec.AutoSize = true;
            this.lbRec.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbRec.Location = new System.Drawing.Point(24, 691);
            this.lbRec.Name = "lbRec";
            this.lbRec.Size = new System.Drawing.Size(110, 25);
            this.lbRec.TabIndex = 9;
            this.lbRec.Text = "Records:  All";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1055, 691);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 44);
            this.btnBack.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.UseStyleColors = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.AutoSize = true;
            this.lbTotalAmount.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbTotalAmount.Location = new System.Drawing.Point(300, 691);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(153, 25);
            this.lbTotalAmount.TabIndex = 11;
            this.lbTotalAmount.Text = "Total Amount:  All";
            // 
            // btnPreviewAll
            // 
            this.btnPreviewAll.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnPreviewAll.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPreviewAll.ForeColor = System.Drawing.Color.White;
            this.btnPreviewAll.Location = new System.Drawing.Point(661, 691);
            this.btnPreviewAll.Name = "btnPreviewAll";
            this.btnPreviewAll.Size = new System.Drawing.Size(165, 44);
            this.btnPreviewAll.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPreviewAll.TabIndex = 12;
            this.btnPreviewAll.Text = "Preview All";
            this.btnPreviewAll.UseCustomBackColor = true;
            this.btnPreviewAll.UseCustomForeColor = true;
            this.btnPreviewAll.UseSelectable = true;
            this.btnPreviewAll.UseStyleColors = true;
            this.btnPreviewAll.Click += new System.EventHandler(this.btnPreviewAll_Click);
            // 
            // frmMainReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1219, 758);
            this.Controls.Add(this.btnPreviewAll);
            this.Controls.Add(this.lbTotalAmount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbRec);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.lbShowby);
            this.Controls.Add(this.cbShowby);
            this.Controls.Add(this.btnWeekly);
            this.Controls.Add(this.btnDaily);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.gridData);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmMainReports";
            this.Resizable = false;
            this.Text = "frmMainReports";
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid gridData;
        private MetroFramework.Controls.MetroButton btnPreview;
        private MetroFramework.Controls.MetroButton btnDaily;
        private MetroFramework.Controls.MetroButton btnWeekly;
        private MetroFramework.Controls.MetroComboBox cbShowby;
        private MetroFramework.Controls.MetroLabel lbShowby;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel lbRec;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroLabel lbTotalAmount;
        private MetroFramework.Controls.MetroButton btnPreviewAll;
    }
}