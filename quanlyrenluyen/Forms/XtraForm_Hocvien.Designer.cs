namespace quanlyrenluyen.Forms
{
    partial class XtraForm_Hocvien
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
            System.Windows.Forms.Label maLopLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label queQuanLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm_Hocvien));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maHvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.hocVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketquarenluyenDataSet = new quanlyrenluyen.ketquarenluyenDataSet();
            this.hocVienTableAdapter = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.HocVienTableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.btChonanh = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbQuequan = new System.Windows.Forms.TextBox();
            this.tbHoten = new System.Windows.Forms.TextBox();
            this.tbMahocvien = new System.Windows.Forms.TextBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.cbbMalop = new System.Windows.Forms.ComboBox();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.TableAdapterManager();
            this.lopTableAdapter = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.LopTableAdapter();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btTimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbTimkiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.bt_them = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.fKHocVienLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::quanlyrenluyen.Forms.WaitForm1), true, true);
            maHvLabel = new System.Windows.Forms.Label();
            maLopLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            queQuanLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKHocVienLopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maHvLabel
            // 
            maHvLabel.AutoSize = true;
            maHvLabel.Location = new System.Drawing.Point(196, 39);
            maHvLabel.Name = "maHvLabel";
            maHvLabel.Size = new System.Drawing.Size(68, 13);
            maHvLabel.TabIndex = 0;
            maHvLabel.Text = "Mã học viên:";
            // 
            // maLopLabel
            // 
            maLopLabel.AutoSize = true;
            maLopLabel.Location = new System.Drawing.Point(196, 92);
            maLopLabel.Name = "maLopLabel";
            maLopLabel.Size = new System.Drawing.Size(28, 13);
            maLopLabel.TabIndex = 2;
            maLopLabel.Text = "Lớp:";
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(196, 64);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(43, 13);
            hoTenLabel.TabIndex = 4;
            hoTenLabel.Text = "Họ tên:";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Location = new System.Drawing.Point(196, 120);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(49, 13);
            gioiTinhLabel.TabIndex = 6;
            gioiTinhLabel.Text = "Giới tính:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Location = new System.Drawing.Point(196, 152);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(58, 13);
            ngaySinhLabel.TabIndex = 8;
            ngaySinhLabel.Text = "Ngày sinh:";
            // 
            // queQuanLabel
            // 
            queQuanLabel.AutoSize = true;
            queQuanLabel.Location = new System.Drawing.Point(196, 181);
            queQuanLabel.Name = "queQuanLabel";
            queQuanLabel.Size = new System.Drawing.Size(58, 13);
            queQuanLabel.TabIndex = 10;
            queQuanLabel.Text = "Quê quán:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHvDataGridViewTextBoxColumn,
            this.maLopDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.GioiTinh,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.queQuanDataGridViewTextBoxColumn,
            this.Image});
            this.dataGridView1.DataSource = this.hocVienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(852, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // maHvDataGridViewTextBoxColumn
            // 
            this.maHvDataGridViewTextBoxColumn.DataPropertyName = "MaHv";
            this.maHvDataGridViewTextBoxColumn.HeaderText = "Mã học viên";
            this.maHvDataGridViewTextBoxColumn.Name = "maHvDataGridViewTextBoxColumn";
            this.maHvDataGridViewTextBoxColumn.ReadOnly = true;
            this.maHvDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maHvDataGridViewTextBoxColumn.Width = 150;
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "Lớp";
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            this.maLopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoTenDataGridViewTextBoxColumn.Width = 200;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // queQuanDataGridViewTextBoxColumn
            // 
            this.queQuanDataGridViewTextBoxColumn.DataPropertyName = "QueQuan";
            this.queQuanDataGridViewTextBoxColumn.HeaderText = "Quê quán";
            this.queQuanDataGridViewTextBoxColumn.Name = "queQuanDataGridViewTextBoxColumn";
            this.queQuanDataGridViewTextBoxColumn.ReadOnly = true;
            this.queQuanDataGridViewTextBoxColumn.Width = 150;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Ảnh";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.Visible = false;
            // 
            // hocVienBindingSource
            // 
            this.hocVienBindingSource.DataMember = "HocVien";
            this.hocVienBindingSource.DataSource = this.ketquarenluyenDataSet;
            // 
            // ketquarenluyenDataSet
            // 
            this.ketquarenluyenDataSet.DataSetName = "ketquarenluyenDataSet";
            this.ketquarenluyenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hocVienTableAdapter
            // 
            this.hocVienTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Controls.Add(this.txtImage);
            this.groupControl1.Controls.Add(this.btChonanh);
            this.groupControl1.Controls.Add(this.dateTimePicker1);
            this.groupControl1.Controls.Add(this.tbQuequan);
            this.groupControl1.Controls.Add(this.tbHoten);
            this.groupControl1.Controls.Add(this.tbMahocvien);
            this.groupControl1.Controls.Add(this.rdbNu);
            this.groupControl1.Controls.Add(this.rdbNam);
            this.groupControl1.Controls.Add(this.cbbMalop);
            this.groupControl1.Controls.Add(maHvLabel);
            this.groupControl1.Controls.Add(maLopLabel);
            this.groupControl1.Controls.Add(hoTenLabel);
            this.groupControl1.Controls.Add(gioiTinhLabel);
            this.groupControl1.Controls.Add(ngaySinhLabel);
            this.groupControl1.Controls.Add(queQuanLabel);
            this.groupControl1.Location = new System.Drawing.Point(2, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(444, 218);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin học viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(43, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(43, 217);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(91, 21);
            this.txtImage.TabIndex = 30;
            this.txtImage.Visible = false;
            // 
            // btChonanh
            // 
            this.btChonanh.Location = new System.Drawing.Point(56, 185);
            this.btChonanh.Name = "btChonanh";
            this.btChonanh.Size = new System.Drawing.Size(75, 23);
            this.btChonanh.TabIndex = 27;
            this.btChonanh.Text = "Chọn ảnh";
            this.btChonanh.Click += new System.EventHandler(this.btChonanh_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(270, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 21);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // tbQuequan
            // 
            this.tbQuequan.Location = new System.Drawing.Point(270, 178);
            this.tbQuequan.Name = "tbQuequan";
            this.tbQuequan.Size = new System.Drawing.Size(151, 21);
            this.tbQuequan.TabIndex = 25;
            // 
            // tbHoten
            // 
            this.tbHoten.Location = new System.Drawing.Point(270, 61);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(151, 21);
            this.tbHoten.TabIndex = 24;
            // 
            // tbMahocvien
            // 
            this.tbMahocvien.Location = new System.Drawing.Point(270, 34);
            this.tbMahocvien.Name = "tbMahocvien";
            this.tbMahocvien.Size = new System.Drawing.Size(151, 21);
            this.tbMahocvien.TabIndex = 23;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(323, 120);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(39, 17);
            this.rdbNu.TabIndex = 22;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(271, 120);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(46, 17);
            this.rdbNam.TabIndex = 21;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // cbbMalop
            // 
            this.cbbMalop.DataSource = this.lopBindingSource;
            this.cbbMalop.DisplayMember = "MaLop";
            this.cbbMalop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMalop.FormattingEnabled = true;
            this.cbbMalop.Location = new System.Drawing.Point(270, 89);
            this.cbbMalop.Name = "cbbMalop";
            this.cbbMalop.Size = new System.Drawing.Size(151, 21);
            this.cbbMalop.TabIndex = 14;
            this.cbbMalop.ValueMember = "MaLop";
            this.cbbMalop.TextChanged += new System.EventHandler(this.cbbMalop_TextChanged);
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.ketquarenluyenDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChuyenNganhTableAdapter = null;
            this.tableAdapterManager.DiemCongTableAdapter = null;
            this.tableAdapterManager.DiemTableAdapter = null;
            this.tableAdapterManager.DiemTruTableAdapter = null;
            this.tableAdapterManager.GvcnTableAdapter = null;
            this.tableAdapterManager.HocVienTableAdapter = this.hocVienTableAdapter;
            this.tableAdapterManager.KhoaHocTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = this.lopTableAdapter;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = quanlyrenluyen.ketquarenluyenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupBox2);
            this.groupControl2.Controls.Add(this.bt_them);
            this.groupControl2.Controls.Add(this.bt_Xoa);
            this.groupControl2.Controls.Add(this.bt_Luu);
            this.groupControl2.Controls.Add(this.bt_Sua);
            this.groupControl2.Location = new System.Drawing.Point(445, 1);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(409, 218);
            this.groupControl2.TabIndex = 26;
            this.groupControl2.Text = "Công cụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btRefresh);
            this.groupBox2.Controls.Add(this.btTimkiem);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbbTimkiem);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 126);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btRefresh
            // 
            this.btRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btRefresh.Image")));
            this.btRefresh.Location = new System.Drawing.Point(229, 79);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(93, 39);
            this.btRefresh.TabIndex = 34;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btTimkiem
            // 
            this.btTimkiem.Enabled = false;
            this.btTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btTimkiem.Image")));
            this.btTimkiem.Location = new System.Drawing.Point(229, 23);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(93, 39);
            this.btTimkiem.TabIndex = 33;
            this.btTimkiem.Text = "Tìm kiếm";
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 21);
            this.label10.TabIndex = 32;
            this.label10.Text = "Tiêu chí tìm kiếm";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 21);
            this.label9.TabIndex = 31;
            this.label9.Text = "Nhập từ khóa";
            // 
            // cbbTimkiem
            // 
            this.cbbTimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbbTimkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimkiem.FormattingEnabled = true;
            this.cbbTimkiem.Items.AddRange(new object[] {
            "Mã học viên",
            "Lớp",
            "Tên"});
            this.cbbTimkiem.Location = new System.Drawing.Point(6, 90);
            this.cbbTimkiem.Name = "cbbTimkiem";
            this.cbbTimkiem.Size = new System.Drawing.Size(179, 24);
            this.cbbTimkiem.TabIndex = 30;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(6, 42);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(183, 22);
            this.txtTimKiem.TabIndex = 9;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // bt_them
            // 
            this.bt_them.Image = ((System.Drawing.Image)(resources.GetObject("bt_them.Image")));
            this.bt_them.Location = new System.Drawing.Point(17, 39);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(74, 40);
            this.bt_them.TabIndex = 5;
            this.bt_them.Text = "Thêm";
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("bt_Xoa.Image")));
            this.bt_Xoa.Location = new System.Drawing.Point(113, 40);
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
            this.bt_Luu.Location = new System.Drawing.Point(306, 40);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(75, 39);
            this.bt_Luu.TabIndex = 7;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Image = ((System.Drawing.Image)(resources.GetObject("bt_Sua.Image")));
            this.bt_Sua.Location = new System.Drawing.Point(211, 40);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(75, 40);
            this.bt_Sua.TabIndex = 6;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Danh sách học viên:";
            // 
            // fKHocVienLopBindingSource
            // 
            this.fKHocVienLopBindingSource.DataMember = "FK_HocVien_Lop";
            this.fKHocVienLopBindingSource.DataSource = this.lopBindingSource;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // XtraForm_Hocvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "XtraForm_Hocvien";
            this.Text = "Quản lý học viên";
            this.Load += new System.EventHandler(this.XtraForm_Hocvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKHocVienLopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ketquarenluyenDataSet ketquarenluyenDataSet;
        private System.Windows.Forms.BindingSource hocVienBindingSource;
        private ketquarenluyenDataSetTableAdapters.HocVienTableAdapter hocVienTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private ketquarenluyenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbbMalop;
        private ketquarenluyenDataSetTableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbQuequan;
        private System.Windows.Forms.TextBox tbHoten;
        private System.Windows.Forms.TextBox tbMahocvien;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton bt_them;
        private DevExpress.XtraEditors.SimpleButton bt_Xoa;
        private DevExpress.XtraEditors.SimpleButton bt_Luu;
        private DevExpress.XtraEditors.SimpleButton bt_Sua;
        private DevExpress.XtraEditors.SimpleButton btChonanh;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbTimkiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private DevExpress.XtraEditors.SimpleButton btTimkiem;
        private DevExpress.XtraEditors.SimpleButton btRefresh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource fKHocVienLopBindingSource;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Image;
    }
}