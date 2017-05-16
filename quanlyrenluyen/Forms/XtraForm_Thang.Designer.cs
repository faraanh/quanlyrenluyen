namespace quanlyrenluyen.Forms
{
    partial class XtraForm_Thang
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
            System.Windows.Forms.Label maHvLabel;
            System.Windows.Forms.Label maDiemTruLabel;
            System.Windows.Forms.Label maDiemCongLabel;
            System.Windows.Forms.Label thangNamLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm_Thang));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.họTênDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngàyGhiNhậnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thànhTíchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viPhạmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renluyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketquarenluyenDataSet2 = new quanlyrenluyen.ketquarenluyenDataSet2();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bt_Thoat = new DevExpress.XtraEditors.SimpleButton();
            this.bt_them = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbbDiemtru = new System.Windows.Forms.ComboBox();
            this.diemTruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketquarenluyenDataSet = new quanlyrenluyen.ketquarenluyenDataSet();
            this.cbbDiemcong = new System.Windows.Forms.ComboBox();
            this.diemCongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maHvTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.diemTruTableAdapter = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.DiemTruTableAdapter();
            this.diemCongTableAdapter = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.DiemCongTableAdapter();
            this.ketquarenluyenDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketquarenluyenDataSet1 = new quanlyrenluyen.ketquarenluyenDataSet1();
            this.view1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_1TableAdapter = new quanlyrenluyen.ketquarenluyenDataSet1TableAdapters.View_1TableAdapter();
            this.renluyenTableAdapter = new quanlyrenluyen.ketquarenluyenDataSet2TableAdapters.renluyenTableAdapter();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::quanlyrenluyen.Forms.WaitForm1), true, true);
            maHvLabel = new System.Windows.Forms.Label();
            maDiemTruLabel = new System.Windows.Forms.Label();
            maDiemCongLabel = new System.Windows.Forms.Label();
            thangNamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renluyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diemTruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemCongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maHvTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maHvLabel
            // 
            maHvLabel.AutoSize = true;
            maHvLabel.Location = new System.Drawing.Point(11, 40);
            maHvLabel.Name = "maHvLabel";
            maHvLabel.Size = new System.Drawing.Size(72, 13);
            maHvLabel.TabIndex = 2;
            maHvLabel.Text = "Tên học viên:";
            // 
            // maDiemTruLabel
            // 
            maDiemTruLabel.AutoSize = true;
            maDiemTruLabel.Location = new System.Drawing.Point(283, 76);
            maDiemTruLabel.Name = "maDiemTruLabel";
            maDiemTruLabel.Size = new System.Drawing.Size(48, 13);
            maDiemTruLabel.TabIndex = 8;
            maDiemTruLabel.Text = "Vi phạm:";
            // 
            // maDiemCongLabel
            // 
            maDiemCongLabel.AutoSize = true;
            maDiemCongLabel.Location = new System.Drawing.Point(283, 40);
            maDiemCongLabel.Name = "maDiemCongLabel";
            maDiemCongLabel.Size = new System.Drawing.Size(61, 13);
            maDiemCongLabel.TabIndex = 6;
            maDiemCongLabel.Text = "Thành tích:";
            // 
            // thangNamLabel
            // 
            thangNamLabel.AutoSize = true;
            thangNamLabel.Location = new System.Drawing.Point(11, 76);
            thangNamLabel.Name = "thangNamLabel";
            thangNamLabel.Size = new System.Drawing.Size(64, 13);
            thangNamLabel.TabIndex = 4;
            thangNamLabel.Text = "Tháng năm:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.họTênDataGridViewTextBoxColumn,
            this.ngàyGhiNhậnDataGridViewTextBoxColumn,
            this.thànhTíchDataGridViewTextBoxColumn,
            this.viPhạmDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.renluyenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(577, 182);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // họTênDataGridViewTextBoxColumn
            // 
            this.họTênDataGridViewTextBoxColumn.DataPropertyName = "Họ tên";
            this.họTênDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.họTênDataGridViewTextBoxColumn.Name = "họTênDataGridViewTextBoxColumn";
            this.họTênDataGridViewTextBoxColumn.ReadOnly = true;
            this.họTênDataGridViewTextBoxColumn.Width = 130;
            // 
            // ngàyGhiNhậnDataGridViewTextBoxColumn
            // 
            this.ngàyGhiNhậnDataGridViewTextBoxColumn.DataPropertyName = "Ngày ghi nhận";
            this.ngàyGhiNhậnDataGridViewTextBoxColumn.HeaderText = "Ngày ghi nhận";
            this.ngàyGhiNhậnDataGridViewTextBoxColumn.Name = "ngàyGhiNhậnDataGridViewTextBoxColumn";
            this.ngàyGhiNhậnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thànhTíchDataGridViewTextBoxColumn
            // 
            this.thànhTíchDataGridViewTextBoxColumn.DataPropertyName = "Thành tích";
            this.thànhTíchDataGridViewTextBoxColumn.HeaderText = "Thành tích";
            this.thànhTíchDataGridViewTextBoxColumn.Name = "thànhTíchDataGridViewTextBoxColumn";
            this.thànhTíchDataGridViewTextBoxColumn.ReadOnly = true;
            this.thànhTíchDataGridViewTextBoxColumn.Width = 150;
            // 
            // viPhạmDataGridViewTextBoxColumn
            // 
            this.viPhạmDataGridViewTextBoxColumn.DataPropertyName = "Vi phạm";
            this.viPhạmDataGridViewTextBoxColumn.HeaderText = "Vi phạm";
            this.viPhạmDataGridViewTextBoxColumn.Name = "viPhạmDataGridViewTextBoxColumn";
            this.viPhạmDataGridViewTextBoxColumn.ReadOnly = true;
            this.viPhạmDataGridViewTextBoxColumn.Width = 150;
            // 
            // renluyenBindingSource
            // 
            this.renluyenBindingSource.DataMember = "renluyen";
            this.renluyenBindingSource.DataSource = this.ketquarenluyenDataSet2;
            // 
            // ketquarenluyenDataSet2
            // 
            this.ketquarenluyenDataSet2.DataSetName = "ketquarenluyenDataSet2";
            this.ketquarenluyenDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.bt_Thoat);
            this.groupControl1.Controls.Add(this.bt_them);
            this.groupControl1.Controls.Add(this.bt_Xoa);
            this.groupControl1.Controls.Add(this.bt_Luu);
            this.groupControl1.Controls.Add(this.bt_Sua);
            this.groupControl1.Location = new System.Drawing.Point(1, 129);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(577, 82);
            this.groupControl1.TabIndex = 25;
            this.groupControl1.Text = "Công cụ";
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("bt_Thoat.Image")));
            this.bt_Thoat.Location = new System.Drawing.Point(465, 29);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(75, 40);
            this.bt_Thoat.TabIndex = 9;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // bt_them
            // 
            this.bt_them.Image = ((System.Drawing.Image)(resources.GetObject("bt_them.Image")));
            this.bt_them.Location = new System.Drawing.Point(7, 28);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(74, 40);
            this.bt_them.TabIndex = 5;
            this.bt_them.Text = "Thêm";
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("bt_Xoa.Image")));
            this.bt_Xoa.Location = new System.Drawing.Point(247, 29);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(74, 39);
            this.bt_Xoa.TabIndex = 8;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Luu
            // 
            this.bt_Luu.Enabled = false;
            this.bt_Luu.Image = ((System.Drawing.Image)(resources.GetObject("bt_Luu.Image")));
            this.bt_Luu.Location = new System.Drawing.Point(357, 29);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(75, 39);
            this.bt_Luu.TabIndex = 7;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click_1);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Image = ((System.Drawing.Image)(resources.GetObject("bt_Sua.Image")));
            this.bt_Sua.Location = new System.Drawing.Point(127, 28);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(75, 40);
            this.bt_Sua.TabIndex = 6;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dateTimePicker1);
            this.groupControl2.Controls.Add(this.cbbDiemtru);
            this.groupControl2.Controls.Add(maHvLabel);
            this.groupControl2.Controls.Add(this.cbbDiemcong);
            this.groupControl2.Controls.Add(this.maHvTextEdit);
            this.groupControl2.Controls.Add(thangNamLabel);
            this.groupControl2.Controls.Add(maDiemCongLabel);
            this.groupControl2.Controls.Add(maDiemTruLabel);
            this.groupControl2.Location = new System.Drawing.Point(1, 1);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(577, 109);
            this.groupControl2.TabIndex = 29;
            this.groupControl2.Text = "Thông tin điểm học viên";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 21);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // cbbDiemtru
            // 
            this.cbbDiemtru.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.diemTruBindingSource, "TenDiemTru", true));
            this.cbbDiemtru.DataSource = this.diemTruBindingSource;
            this.cbbDiemtru.DisplayMember = "TenDiemTru";
            this.cbbDiemtru.FormattingEnabled = true;
            this.cbbDiemtru.Location = new System.Drawing.Point(345, 73);
            this.cbbDiemtru.Name = "cbbDiemtru";
            this.cbbDiemtru.Size = new System.Drawing.Size(195, 21);
            this.cbbDiemtru.TabIndex = 25;
            this.cbbDiemtru.ValueMember = "TenDiemTru";
            // 
            // diemTruBindingSource
            // 
            this.diemTruBindingSource.DataMember = "DiemTru";
            this.diemTruBindingSource.DataSource = this.ketquarenluyenDataSet;
            // 
            // ketquarenluyenDataSet
            // 
            this.ketquarenluyenDataSet.DataSetName = "ketquarenluyenDataSet";
            this.ketquarenluyenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbDiemcong
            // 
            this.cbbDiemcong.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.diemCongBindingSource, "TenDiemCong", true));
            this.cbbDiemcong.DataSource = this.diemCongBindingSource;
            this.cbbDiemcong.DisplayMember = "TenDiemCong";
            this.cbbDiemcong.FormattingEnabled = true;
            this.cbbDiemcong.Location = new System.Drawing.Point(345, 37);
            this.cbbDiemcong.Name = "cbbDiemcong";
            this.cbbDiemcong.Size = new System.Drawing.Size(195, 21);
            this.cbbDiemcong.TabIndex = 26;
            this.cbbDiemcong.ValueMember = "TenDiemCong";
            // 
            // diemCongBindingSource
            // 
            this.diemCongBindingSource.DataMember = "DiemCong";
            this.diemCongBindingSource.DataSource = this.ketquarenluyenDataSet;
            // 
            // maHvTextEdit
            // 
            this.maHvTextEdit.Location = new System.Drawing.Point(83, 37);
            this.maHvTextEdit.Name = "maHvTextEdit";
            this.maHvTextEdit.Size = new System.Drawing.Size(147, 20);
            this.maHvTextEdit.TabIndex = 3;
            // 
            // diemTruTableAdapter
            // 
            this.diemTruTableAdapter.ClearBeforeFill = true;
            // 
            // diemCongTableAdapter
            // 
            this.diemCongTableAdapter.ClearBeforeFill = true;
            // 
            // ketquarenluyenDataSetBindingSource
            // 
            this.ketquarenluyenDataSetBindingSource.DataSource = this.ketquarenluyenDataSet;
            this.ketquarenluyenDataSetBindingSource.Position = 0;
            // 
            // ketquarenluyenDataSet1
            // 
            this.ketquarenluyenDataSet1.DataSetName = "ketquarenluyenDataSet1";
            this.ketquarenluyenDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view1BindingSource
            // 
            this.view1BindingSource.DataMember = "View_1";
            this.view1BindingSource.DataSource = this.ketquarenluyenDataSet1;
            // 
            // view_1TableAdapter
            // 
            this.view_1TableAdapter.ClearBeforeFill = true;
            // 
            // renluyenTableAdapter
            // 
            this.renluyenTableAdapter.ClearBeforeFill = true;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // XtraForm_Thang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 423);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "XtraForm_Thang";
            this.Text = "Rèn luyện";
            this.Load += new System.EventHandler(this.XtraForm_Thang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renluyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diemTruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemCongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maHvTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton bt_them;
        private DevExpress.XtraEditors.SimpleButton bt_Xoa;
        private DevExpress.XtraEditors.SimpleButton bt_Luu;
        private DevExpress.XtraEditors.SimpleButton bt_Sua;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbbDiemtru;
        private System.Windows.Forms.ComboBox cbbDiemcong;
        private DevExpress.XtraEditors.TextEdit maHvTextEdit;
        private ketquarenluyenDataSet ketquarenluyenDataSet;
        private System.Windows.Forms.BindingSource diemTruBindingSource;
        private ketquarenluyenDataSetTableAdapters.DiemTruTableAdapter diemTruTableAdapter;
        private System.Windows.Forms.BindingSource diemCongBindingSource;
        private ketquarenluyenDataSetTableAdapters.DiemCongTableAdapter diemCongTableAdapter;
        private DevExpress.XtraEditors.SimpleButton bt_Thoat;
        private System.Windows.Forms.BindingSource ketquarenluyenDataSetBindingSource;
        private ketquarenluyenDataSet1 ketquarenluyenDataSet1;
        private System.Windows.Forms.BindingSource view1BindingSource;
        private ketquarenluyenDataSet1TableAdapters.View_1TableAdapter view_1TableAdapter;
        private ketquarenluyenDataSet2 ketquarenluyenDataSet2;
        private System.Windows.Forms.BindingSource renluyenBindingSource;
        private ketquarenluyenDataSet2TableAdapters.renluyenTableAdapter renluyenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn họTênDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngàyGhiNhậnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thànhTíchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viPhạmDataGridViewTextBoxColumn;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}