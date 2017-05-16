namespace quanlyrenluyen.Forms
{
    partial class Form_Taikhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Taikhoan));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.dataGrv_Taikhoan = new System.Windows.Forms.DataGridView();
            this.maTkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanQuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketquarenluyenDataSet = new quanlyrenluyen.ketquarenluyenDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Matkhau = new System.Windows.Forms.TextBox();
            this.tb_Phanquyen = new System.Windows.Forms.TextBox();
            this.tb_Mataikhoan = new System.Windows.Forms.TextBox();
            this.lb_Phanquyen = new System.Windows.Forms.Label();
            this.lb_Matkhau = new System.Windows.Forms.Label();
            this.lb_MaTk = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bt_them = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.taiKhoanTableAdapter = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.TaiKhoanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrv_Taikhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            // 
            // dataGrv_Taikhoan
            // 
            this.dataGrv_Taikhoan.AllowUserToAddRows = false;
            this.dataGrv_Taikhoan.AllowUserToDeleteRows = false;
            this.dataGrv_Taikhoan.AutoGenerateColumns = false;
            this.dataGrv_Taikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrv_Taikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTkDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn,
            this.phanQuyenDataGridViewTextBoxColumn});
            this.dataGrv_Taikhoan.DataSource = this.taiKhoanBindingSource;
            this.dataGrv_Taikhoan.Location = new System.Drawing.Point(0, 166);
            this.dataGrv_Taikhoan.Name = "dataGrv_Taikhoan";
            this.dataGrv_Taikhoan.ReadOnly = true;
            this.dataGrv_Taikhoan.Size = new System.Drawing.Size(336, 153);
            this.dataGrv_Taikhoan.TabIndex = 0;
            this.dataGrv_Taikhoan.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrv_Taikhoan_CellEnter);
            // 
            // maTkDataGridViewTextBoxColumn
            // 
            this.maTkDataGridViewTextBoxColumn.DataPropertyName = "MaTk";
            this.maTkDataGridViewTextBoxColumn.HeaderText = "Mã tài khoản";
            this.maTkDataGridViewTextBoxColumn.Name = "maTkDataGridViewTextBoxColumn";
            this.maTkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            this.matKhauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phanQuyenDataGridViewTextBoxColumn
            // 
            this.phanQuyenDataGridViewTextBoxColumn.DataPropertyName = "PhanQuyen";
            this.phanQuyenDataGridViewTextBoxColumn.HeaderText = "Phân Quyền";
            this.phanQuyenDataGridViewTextBoxColumn.Name = "phanQuyenDataGridViewTextBoxColumn";
            this.phanQuyenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.ketquarenluyenDataSet;
            // 
            // ketquarenluyenDataSet
            // 
            this.ketquarenluyenDataSet.DataSetName = "ketquarenluyenDataSet";
            this.ketquarenluyenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Matkhau);
            this.groupBox1.Controls.Add(this.tb_Phanquyen);
            this.groupBox1.Controls.Add(this.tb_Mataikhoan);
            this.groupBox1.Controls.Add(this.lb_Phanquyen);
            this.groupBox1.Controls.Add(this.lb_Matkhau);
            this.groupBox1.Controls.Add(this.lb_MaTk);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 137);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // tb_Matkhau
            // 
            this.tb_Matkhau.Location = new System.Drawing.Point(80, 58);
            this.tb_Matkhau.Name = "tb_Matkhau";
            this.tb_Matkhau.Size = new System.Drawing.Size(79, 21);
            this.tb_Matkhau.TabIndex = 13;
            // 
            // tb_Phanquyen
            // 
            this.tb_Phanquyen.Location = new System.Drawing.Point(80, 96);
            this.tb_Phanquyen.Name = "tb_Phanquyen";
            this.tb_Phanquyen.Size = new System.Drawing.Size(79, 21);
            this.tb_Phanquyen.TabIndex = 11;
            // 
            // tb_Mataikhoan
            // 
            this.tb_Mataikhoan.Location = new System.Drawing.Point(80, 20);
            this.tb_Mataikhoan.Name = "tb_Mataikhoan";
            this.tb_Mataikhoan.Size = new System.Drawing.Size(79, 21);
            this.tb_Mataikhoan.TabIndex = 10;
            // 
            // lb_Phanquyen
            // 
            this.lb_Phanquyen.AutoSize = true;
            this.lb_Phanquyen.Location = new System.Drawing.Point(6, 99);
            this.lb_Phanquyen.Name = "lb_Phanquyen";
            this.lb_Phanquyen.Size = new System.Drawing.Size(64, 13);
            this.lb_Phanquyen.TabIndex = 9;
            this.lb_Phanquyen.Text = "Phân quyền";
            // 
            // lb_Matkhau
            // 
            this.lb_Matkhau.AutoSize = true;
            this.lb_Matkhau.Location = new System.Drawing.Point(6, 61);
            this.lb_Matkhau.Name = "lb_Matkhau";
            this.lb_Matkhau.Size = new System.Drawing.Size(51, 13);
            this.lb_Matkhau.TabIndex = 7;
            this.lb_Matkhau.Text = "Mật khẩu";
            this.lb_Matkhau.Click += new System.EventHandler(this.lb_Matkhau_Click);
            // 
            // lb_MaTk
            // 
            this.lb_MaTk.AutoSize = true;
            this.lb_MaTk.Location = new System.Drawing.Point(6, 23);
            this.lb_MaTk.Name = "lb_MaTk";
            this.lb_MaTk.Size = new System.Drawing.Size(68, 13);
            this.lb_MaTk.TabIndex = 6;
            this.lb_MaTk.Text = "Mã tài khoản";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.bt_them);
            this.groupControl1.Controls.Add(this.bt_Xoa);
            this.groupControl1.Controls.Add(this.bt_Luu);
            this.groupControl1.Controls.Add(this.bt_Sua);
            this.groupControl1.Location = new System.Drawing.Point(170, 9);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(166, 130);
            this.groupControl1.TabIndex = 23;
            this.groupControl1.Text = "Công cụ";
            // 
            // bt_them
            // 
            this.bt_them.Image = ((System.Drawing.Image)(resources.GetObject("bt_them.Image")));
            this.bt_them.Location = new System.Drawing.Point(6, 30);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(74, 40);
            this.bt_them.TabIndex = 5;
            this.bt_them.Text = "Thêm";
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click_1);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("bt_Xoa.Image")));
            this.bt_Xoa.Location = new System.Drawing.Point(6, 76);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(74, 39);
            this.bt_Xoa.TabIndex = 8;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click_1);
            // 
            // bt_Luu
            // 
            this.bt_Luu.Enabled = false;
            this.bt_Luu.Image = ((System.Drawing.Image)(resources.GetObject("bt_Luu.Image")));
            this.bt_Luu.Location = new System.Drawing.Point(86, 76);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(75, 39);
            this.bt_Luu.TabIndex = 7;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Image = ((System.Drawing.Image)(resources.GetObject("bt_Sua.Image")));
            this.bt_Sua.Location = new System.Drawing.Point(86, 30);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(75, 40);
            this.bt_Sua.TabIndex = 6;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Danh sách tài khoản:";
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Taikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrv_Taikhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Taikhoan";
            this.Text = "Tài khoản";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Taikhoan_FormClosed);
            this.Load += new System.EventHandler(this.Form_Taikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrv_Taikhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private System.Windows.Forms.DataGridView dataGrv_Taikhoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_Phanquyen;
        private System.Windows.Forms.Label lb_Matkhau;
        private System.Windows.Forms.Label lb_MaTk;
        private System.Windows.Forms.TextBox tb_Matkhau;
        private System.Windows.Forms.TextBox tb_Phanquyen;
        private System.Windows.Forms.TextBox tb_Mataikhoan;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton bt_them;
        private DevExpress.XtraEditors.SimpleButton bt_Xoa;
        private DevExpress.XtraEditors.SimpleButton bt_Luu;
        private DevExpress.XtraEditors.SimpleButton bt_Sua;
        private System.Windows.Forms.Label label1;
        private ketquarenluyenDataSet ketquarenluyenDataSet;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private ketquarenluyenDataSetTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phanQuyenDataGridViewTextBoxColumn;
    }
}