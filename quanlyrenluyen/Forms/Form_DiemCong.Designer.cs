namespace quanlyrenluyen.Forms
{
    partial class Form_DiemCong
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
            System.Windows.Forms.Label maDiemCongLabel;
            System.Windows.Forms.Label tenDiemCongLabel;
            System.Windows.Forms.Label diemCongLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DiemCong));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.dataGrv_Diemcong = new System.Windows.Forms.DataGridView();
            this.maDiemCongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDiemCongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemCongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemCongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketquarenluyenDataSet = new quanlyrenluyen.ketquarenluyenDataSet();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bt_them = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tb_diemcong = new DevExpress.XtraEditors.TextEdit();
            this.maDiemCongTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenDiemCongTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gvcnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvcnTableAdapter = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.GvcnTableAdapter();
            this.tableAdapterManager = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.TableAdapterManager();
            this.diemCongTableAdapter = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.DiemCongTableAdapter();
            maDiemCongLabel = new System.Windows.Forms.Label();
            tenDiemCongLabel = new System.Windows.Forms.Label();
            diemCongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrv_Diemcong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemCongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_diemcong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maDiemCongTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenDiemCongTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvcnBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maDiemCongLabel
            // 
            maDiemCongLabel.AutoSize = true;
            maDiemCongLabel.Location = new System.Drawing.Point(6, 43);
            maDiemCongLabel.Name = "maDiemCongLabel";
            maDiemCongLabel.Size = new System.Drawing.Size(76, 13);
            maDiemCongLabel.TabIndex = 0;
            maDiemCongLabel.Text = "Mã điểm cộng:";
            // 
            // tenDiemCongLabel
            // 
            tenDiemCongLabel.AutoSize = true;
            tenDiemCongLabel.Location = new System.Drawing.Point(6, 69);
            tenDiemCongLabel.Name = "tenDiemCongLabel";
            tenDiemCongLabel.Size = new System.Drawing.Size(76, 13);
            tenDiemCongLabel.TabIndex = 2;
            tenDiemCongLabel.Text = "Tên điểm cộng";
            // 
            // diemCongLabel
            // 
            diemCongLabel.AutoSize = true;
            diemCongLabel.Location = new System.Drawing.Point(6, 95);
            diemCongLabel.Name = "diemCongLabel";
            diemCongLabel.Size = new System.Drawing.Size(57, 13);
            diemCongLabel.TabIndex = 4;
            diemCongLabel.Text = "Điểm cộng";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            // 
            // dataGrv_Diemcong
            // 
            this.dataGrv_Diemcong.AllowUserToAddRows = false;
            this.dataGrv_Diemcong.AllowUserToDeleteRows = false;
            this.dataGrv_Diemcong.AutoGenerateColumns = false;
            this.dataGrv_Diemcong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrv_Diemcong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDiemCongDataGridViewTextBoxColumn,
            this.tenDiemCongDataGridViewTextBoxColumn,
            this.diemCongDataGridViewTextBoxColumn});
            this.dataGrv_Diemcong.DataSource = this.diemCongBindingSource;
            this.dataGrv_Diemcong.Location = new System.Drawing.Point(264, 29);
            this.dataGrv_Diemcong.Name = "dataGrv_Diemcong";
            this.dataGrv_Diemcong.ReadOnly = true;
            this.dataGrv_Diemcong.Size = new System.Drawing.Size(326, 237);
            this.dataGrv_Diemcong.TabIndex = 0;
            this.dataGrv_Diemcong.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrv_Gvcn_CellEnter);
            // 
            // maDiemCongDataGridViewTextBoxColumn
            // 
            this.maDiemCongDataGridViewTextBoxColumn.DataPropertyName = "MaDiemCong";
            this.maDiemCongDataGridViewTextBoxColumn.HeaderText = "Mã điểm cộng";
            this.maDiemCongDataGridViewTextBoxColumn.Name = "maDiemCongDataGridViewTextBoxColumn";
            this.maDiemCongDataGridViewTextBoxColumn.ReadOnly = true;
            this.maDiemCongDataGridViewTextBoxColumn.Width = 80;
            // 
            // tenDiemCongDataGridViewTextBoxColumn
            // 
            this.tenDiemCongDataGridViewTextBoxColumn.DataPropertyName = "TenDiemCong";
            this.tenDiemCongDataGridViewTextBoxColumn.HeaderText = "Tên điểm cộng";
            this.tenDiemCongDataGridViewTextBoxColumn.Name = "tenDiemCongDataGridViewTextBoxColumn";
            this.tenDiemCongDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenDiemCongDataGridViewTextBoxColumn.Width = 150;
            // 
            // diemCongDataGridViewTextBoxColumn
            // 
            this.diemCongDataGridViewTextBoxColumn.DataPropertyName = "DiemCong";
            this.diemCongDataGridViewTextBoxColumn.HeaderText = "Điểm cộng";
            this.diemCongDataGridViewTextBoxColumn.Name = "diemCongDataGridViewTextBoxColumn";
            this.diemCongDataGridViewTextBoxColumn.ReadOnly = true;
            this.diemCongDataGridViewTextBoxColumn.Width = 70;
            // 
            // diemCongBindingSource
            // 
            this.diemCongBindingSource.DataMember = "DiemCong";
            this.diemCongBindingSource.DataSource = this.ketquarenluyenDataSet;
            // 
            // ketquarenluyenDataSet
            // 
            this.ketquarenluyenDataSet.DataSetName = "ketquarenluyenDataSet";
            this.ketquarenluyenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.bt_them);
            this.groupControl1.Controls.Add(this.bt_Xoa);
            this.groupControl1.Controls.Add(this.bt_Luu);
            this.groupControl1.Controls.Add(this.bt_Sua);
            this.groupControl1.Location = new System.Drawing.Point(0, 136);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(258, 130);
            this.groupControl1.TabIndex = 23;
            this.groupControl1.Text = "Công cụ";
            // 
            // bt_them
            // 
            this.bt_them.Image = ((System.Drawing.Image)(resources.GetObject("bt_them.Image")));
            this.bt_them.Location = new System.Drawing.Point(37, 30);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(74, 40);
            this.bt_them.TabIndex = 5;
            this.bt_them.Text = "Thêm";
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click_1);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("bt_Xoa.Image")));
            this.bt_Xoa.Location = new System.Drawing.Point(37, 76);
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
            this.bt_Luu.Location = new System.Drawing.Point(143, 76);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(75, 39);
            this.bt_Luu.TabIndex = 7;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Image = ((System.Drawing.Image)(resources.GetObject("bt_Sua.Image")));
            this.bt_Sua.Location = new System.Drawing.Point(143, 30);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(75, 40);
            this.bt_Sua.TabIndex = 6;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Danh sách các điểm cộng:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.tb_diemcong);
            this.groupControl2.Controls.Add(maDiemCongLabel);
            this.groupControl2.Controls.Add(this.maDiemCongTextEdit);
            this.groupControl2.Controls.Add(tenDiemCongLabel);
            this.groupControl2.Controls.Add(this.tenDiemCongTextEdit);
            this.groupControl2.Controls.Add(diemCongLabel);
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(258, 130);
            this.groupControl2.TabIndex = 31;
            this.groupControl2.Text = "Thông tin";
            // 
            // tb_diemcong
            // 
            this.tb_diemcong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.diemCongBindingSource, "TenDiemCong", true));
            this.tb_diemcong.Location = new System.Drawing.Point(95, 92);
            this.tb_diemcong.Name = "tb_diemcong";
            this.tb_diemcong.Size = new System.Drawing.Size(158, 20);
            this.tb_diemcong.TabIndex = 5;
            // 
            // maDiemCongTextEdit
            // 
            this.maDiemCongTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.diemCongBindingSource, "MaDiemCong", true));
            this.maDiemCongTextEdit.Location = new System.Drawing.Point(95, 40);
            this.maDiemCongTextEdit.Name = "maDiemCongTextEdit";
            this.maDiemCongTextEdit.Size = new System.Drawing.Size(158, 20);
            this.maDiemCongTextEdit.TabIndex = 1;
            // 
            // tenDiemCongTextEdit
            // 
            this.tenDiemCongTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.diemCongBindingSource, "TenDiemCong", true));
            this.tenDiemCongTextEdit.Location = new System.Drawing.Point(95, 66);
            this.tenDiemCongTextEdit.Name = "tenDiemCongTextEdit";
            this.tenDiemCongTextEdit.Size = new System.Drawing.Size(158, 20);
            this.tenDiemCongTextEdit.TabIndex = 3;
            // 
            // gvcnBindingSource
            // 
            this.gvcnBindingSource.DataMember = "Gvcn";
            this.gvcnBindingSource.DataSource = this.ketquarenluyenDataSet;
            // 
            // gvcnTableAdapter
            // 
            this.gvcnTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChuyenNganhTableAdapter = null;
            this.tableAdapterManager.DiemCongTableAdapter = null;
            this.tableAdapterManager.DiemTableAdapter = null;
            this.tableAdapterManager.DiemTruTableAdapter = null;
            this.tableAdapterManager.GvcnTableAdapter = this.gvcnTableAdapter;
            this.tableAdapterManager.HocVienTableAdapter = null;
            this.tableAdapterManager.KhoaHocTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = quanlyrenluyen.ketquarenluyenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // diemCongTableAdapter
            // 
            this.diemCongTableAdapter.ClearBeforeFill = true;
            // 
            // Form_DiemCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 269);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dataGrv_Diemcong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_DiemCong";
            this.Text = "Quản lý điểm cộng";
            this.Load += new System.EventHandler(this.Form_Gvcn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrv_Diemcong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemCongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_diemcong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maDiemCongTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenDiemCongTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvcnBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private System.Windows.Forms.DataGridView dataGrv_Diemcong;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton bt_them;
        private DevExpress.XtraEditors.SimpleButton bt_Xoa;
        private DevExpress.XtraEditors.SimpleButton bt_Luu;
        private DevExpress.XtraEditors.SimpleButton bt_Sua;
        private System.Windows.Forms.Label label1;
        private ketquarenluyenDataSet ketquarenluyenDataSet;
        private System.Windows.Forms.BindingSource gvcnBindingSource;
        private ketquarenluyenDataSetTableAdapters.GvcnTableAdapter gvcnTableAdapter;
        private ketquarenluyenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource diemCongBindingSource;
        private ketquarenluyenDataSetTableAdapters.DiemCongTableAdapter diemCongTableAdapter;
        private DevExpress.XtraEditors.TextEdit maDiemCongTextEdit;
        private DevExpress.XtraEditors.TextEdit tenDiemCongTextEdit;
        private DevExpress.XtraEditors.TextEdit tb_diemcong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDiemCongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDiemCongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemCongDataGridViewTextBoxColumn;
    }
}