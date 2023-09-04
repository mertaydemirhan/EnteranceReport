namespace EntrySystemReport
{
    partial class Reports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.DGVReport = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.dtEndDate = new MetroFramework.Controls.MetroDateTime();
            this.dtStDate = new MetroFramework.Controls.MetroDateTime();
            this.btnAllValues = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGetToday = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDuzenle = new MetroFramework.Controls.MetroButton();
            this.grpEdit = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnGetValues = new MetroFramework.Controls.MetroButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPersonal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtEditEntry = new MetroFramework.Controls.MetroDateTime();
            this.dtEditExit = new MetroFramework.Controls.MetroDateTime();
            this.txtExitTime = new System.Windows.Forms.MaskedTextBox();
            this.txtEntryTime = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReport)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.grpEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVReport
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVReport.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGVReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReport.DoubleBuffered = true;
            this.DGVReport.EnableHeadersVisualStyles = false;
            this.DGVReport.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DGVReport.HeaderForeColor = System.Drawing.Color.Azure;
            this.DGVReport.Location = new System.Drawing.Point(12, 188);
            this.DGVReport.MultiSelect = false;
            this.DGVReport.Name = "DGVReport";
            this.DGVReport.ReadOnly = true;
            this.DGVReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVReport.Size = new System.Drawing.Size(644, 262);
            this.DGVReport.TabIndex = 0;
            this.DGVReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVReport_CellClick);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.grpEdit);
            this.grpSearch.Controls.Add(this.btnDuzenle);
            this.grpSearch.Controls.Add(this.dtEndDate);
            this.grpSearch.Controls.Add(this.dtStDate);
            this.grpSearch.Controls.Add(this.btnAllValues);
            this.grpSearch.Controls.Add(this.bunifuThinButton21);
            this.grpSearch.Controls.Add(this.btnGetToday);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.bunifuCustomLabel2);
            this.grpSearch.Controls.Add(this.bunifuCustomLabel1);
            this.grpSearch.Location = new System.Drawing.Point(12, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(644, 170);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Arama";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(79, 63);
            this.dtEndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(557, 29);
            this.dtEndDate.TabIndex = 9;
            // 
            // dtStDate
            // 
            this.dtStDate.CalendarForeColor = System.Drawing.Color.SeaGreen;
            this.dtStDate.CalendarMonthBackground = System.Drawing.Color.SeaGreen;
            this.dtStDate.CalendarTitleBackColor = System.Drawing.Color.SeaGreen;
            this.dtStDate.Location = new System.Drawing.Point(80, 20);
            this.dtStDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStDate.Name = "dtStDate";
            this.dtStDate.Size = new System.Drawing.Size(557, 29);
            this.dtStDate.TabIndex = 8;
            // 
            // btnAllValues
            // 
            this.btnAllValues.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAllValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAllValues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAllValues.BorderRadius = 0;
            this.btnAllValues.ButtonText = "Hepsini Sorgula";
            this.btnAllValues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllValues.DisabledColor = System.Drawing.Color.Gray;
            this.btnAllValues.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAllValues.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAllValues.Iconimage")));
            this.btnAllValues.Iconimage_right = null;
            this.btnAllValues.Iconimage_right_Selected = null;
            this.btnAllValues.Iconimage_Selected = null;
            this.btnAllValues.IconMarginLeft = 0;
            this.btnAllValues.IconMarginRight = 0;
            this.btnAllValues.IconRightVisible = true;
            this.btnAllValues.IconRightZoom = 0D;
            this.btnAllValues.IconVisible = true;
            this.btnAllValues.IconZoom = 90D;
            this.btnAllValues.IsTab = false;
            this.btnAllValues.Location = new System.Drawing.Point(268, 127);
            this.btnAllValues.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAllValues.Name = "btnAllValues";
            this.btnAllValues.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAllValues.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAllValues.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAllValues.selected = false;
            this.btnAllValues.Size = new System.Drawing.Size(122, 37);
            this.btnAllValues.TabIndex = 7;
            this.btnAllValues.Text = "Hepsini Sorgula";
            this.btnAllValues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllValues.Textcolor = System.Drawing.Color.White;
            this.btnAllValues.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllValues.Click += new System.EventHandler(this.btnAllValues_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Excel\'e Aktar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Silver;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Brown;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(9, 127);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(127, 39);
            this.bunifuThinButton21.TabIndex = 2;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnGetToday
            // 
            this.btnGetToday.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGetToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGetToday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGetToday.BorderRadius = 0;
            this.btnGetToday.ButtonText = "Bugünü Sorgula";
            this.btnGetToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetToday.DisabledColor = System.Drawing.Color.Gray;
            this.btnGetToday.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGetToday.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGetToday.Iconimage")));
            this.btnGetToday.Iconimage_right = null;
            this.btnGetToday.Iconimage_right_Selected = null;
            this.btnGetToday.Iconimage_Selected = null;
            this.btnGetToday.IconMarginLeft = 0;
            this.btnGetToday.IconMarginRight = 0;
            this.btnGetToday.IconRightVisible = true;
            this.btnGetToday.IconRightZoom = 0D;
            this.btnGetToday.IconVisible = true;
            this.btnGetToday.IconZoom = 90D;
            this.btnGetToday.IsTab = false;
            this.btnGetToday.Location = new System.Drawing.Point(399, 127);
            this.btnGetToday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGetToday.Name = "btnGetToday";
            this.btnGetToday.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGetToday.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGetToday.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGetToday.selected = false;
            this.btnGetToday.Size = new System.Drawing.Size(149, 37);
            this.btnGetToday.TabIndex = 2;
            this.btnGetToday.Text = "Bugünü Sorgula";
            this.btnGetToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetToday.Textcolor = System.Drawing.Color.White;
            this.btnGetToday.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetToday.Click += new System.EventHandler(this.btnGetToday_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "Ara";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearch.Iconimage")));
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 90D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(551, 126);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(88, 37);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Ara";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(6, 73);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(67, 13);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Bitiş Tarihi";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(6, 30);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(68, 13);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Baş. Tarihi";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(144, 127);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(116, 37);
            this.btnDuzenle.TabIndex = 10;
            this.btnDuzenle.Text = "Düzenleme Yap";
            this.btnDuzenle.UseSelectable = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // grpEdit
            // 
            this.grpEdit.Controls.Add(this.txtEntryTime);
            this.grpEdit.Controls.Add(this.txtExitTime);
            this.grpEdit.Controls.Add(this.dtEditExit);
            this.grpEdit.Controls.Add(this.dtEditEntry);
            this.grpEdit.Controls.Add(this.bunifuCustomLabel7);
            this.grpEdit.Controls.Add(this.bunifuCustomLabel6);
            this.grpEdit.Controls.Add(this.lblPersonal);
            this.grpEdit.Controls.Add(this.bunifuCustomLabel5);
            this.grpEdit.Controls.Add(this.btnGetValues);
            this.grpEdit.Controls.Add(this.bunifuCustomLabel4);
            this.grpEdit.Controls.Add(this.bunifuCustomLabel3);
            this.grpEdit.Location = new System.Drawing.Point(9, 14);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Size = new System.Drawing.Size(442, 107);
            this.grpEdit.TabIndex = 2;
            this.grpEdit.TabStop = false;
            this.grpEdit.Text = "Düzenle";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(292, 49);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(63, 13);
            this.bunifuCustomLabel3.TabIndex = 1;
            this.bunifuCustomLabel3.Text = "Giriş saati";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(290, 78);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(65, 13);
            this.bunifuCustomLabel4.TabIndex = 2;
            this.bunifuCustomLabel4.Text = "Çıkış saati";
            // 
            // btnGetValues
            // 
            this.btnGetValues.Location = new System.Drawing.Point(295, 10);
            this.btnGetValues.Name = "btnGetValues";
            this.btnGetValues.Size = new System.Drawing.Size(141, 30);
            this.btnGetValues.TabIndex = 5;
            this.btnGetValues.Text = "Veritabanına Yaz";
            this.btnGetValues.UseSelectable = true;
            this.btnGetValues.Click += new System.EventHandler(this.btnGetValues_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(2, 16);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(64, 13);
            this.bunifuCustomLabel5.TabIndex = 6;
            this.bunifuCustomLabel5.Text = "Personel :";
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Location = new System.Drawing.Point(76, 16);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(0, 13);
            this.lblPersonal.TabIndex = 7;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(4, 49);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(68, 13);
            this.bunifuCustomLabel6.TabIndex = 8;
            this.bunifuCustomLabel6.Text = "Giriş Tarihi";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(6, 78);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(66, 13);
            this.bunifuCustomLabel7.TabIndex = 9;
            this.bunifuCustomLabel7.Text = "Çıkış tarihi";
            // 
            // dtEditEntry
            // 
            this.dtEditEntry.CalendarForeColor = System.Drawing.Color.SeaGreen;
            this.dtEditEntry.CalendarMonthBackground = System.Drawing.Color.SeaGreen;
            this.dtEditEntry.CalendarTitleBackColor = System.Drawing.Color.SeaGreen;
            this.dtEditEntry.CustomFormat = "dd.MM.yyyy";
            this.dtEditEntry.Location = new System.Drawing.Point(79, 39);
            this.dtEditEntry.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEditEntry.Name = "dtEditEntry";
            this.dtEditEntry.Size = new System.Drawing.Size(207, 29);
            this.dtEditEntry.TabIndex = 11;
            // 
            // dtEditExit
            // 
            this.dtEditExit.CalendarForeColor = System.Drawing.Color.SeaGreen;
            this.dtEditExit.CalendarMonthBackground = System.Drawing.Color.SeaGreen;
            this.dtEditExit.CalendarTitleBackColor = System.Drawing.Color.SeaGreen;
            this.dtEditExit.CustomFormat = "dd.MM.yyyy";
            this.dtEditExit.Location = new System.Drawing.Point(78, 70);
            this.dtEditExit.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEditExit.Name = "dtEditExit";
            this.dtEditExit.Size = new System.Drawing.Size(207, 29);
            this.dtEditExit.TabIndex = 12;
            // 
            // txtExitTime
            // 
            this.txtExitTime.Location = new System.Drawing.Point(360, 77);
            this.txtExitTime.Mask = "00:00:00";
            this.txtExitTime.Name = "txtExitTime";
            this.txtExitTime.Size = new System.Drawing.Size(74, 20);
            this.txtExitTime.TabIndex = 14;
            this.txtExitTime.ValidatingType = typeof(System.DateTime);
            // 
            // txtEntryTime
            // 
            this.txtEntryTime.Location = new System.Drawing.Point(360, 46);
            this.txtEntryTime.Mask = "00:00:00";
            this.txtEntryTime.Name = "txtEntryTime";
            this.txtEntryTime.Size = new System.Drawing.Size(74, 20);
            this.txtEntryTime.TabIndex = 15;
            this.txtEntryTime.ValidatingType = typeof(System.DateTime);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(666, 462);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.DGVReport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Reports";
            this.Text = "57 Colleges - Entry Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVReport)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpEdit.ResumeLayout(false);
            this.grpEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DGVReport;
        private System.Windows.Forms.GroupBox grpSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnGetToday;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuFlatButton btnAllValues;
        private MetroFramework.Controls.MetroDateTime dtStDate;
        private MetroFramework.Controls.MetroDateTime dtEndDate;
        private MetroFramework.Controls.MetroButton btnDuzenle;
        private System.Windows.Forms.GroupBox grpEdit;
        private MetroFramework.Controls.MetroDateTime dtEditExit;
        private MetroFramework.Controls.MetroDateTime dtEditEntry;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPersonal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private MetroFramework.Controls.MetroButton btnGetValues;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.MaskedTextBox txtExitTime;
        private System.Windows.Forms.MaskedTextBox txtEntryTime;
    }
}

