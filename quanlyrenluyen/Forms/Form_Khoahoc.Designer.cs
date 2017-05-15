namespace quanlyrenluyen.Forms
{
    partial class Form_Khoahoc
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
            System.Windows.Forms.Label maKhoaLabel;
            System.Windows.Forms.Label nienKhoaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Khoahoc));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.dataGrv_Khoahoc = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bt_them = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.ketquarenluyenDataSet = new quanlyrenluyen.ketquarenluyenDataSet();
            this.gvcnBindingSource = new System.Windows.Forms.BindingSource();
            this.gvcnTableAdapter = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.GvcnTableAdapter();
            this.tableAdapterManager = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.TableAdapterManager();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.maKhoaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.khoaHocBindingSource = new System.Windows.Forms.BindingSource();
            this.nienKhoaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.khoaHocTableAdapter = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.KhoaHocTableAdapter();
            this.maKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nienKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maKhoaLabel = new System.Windows.Forms.Label();
            nienKhoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrv_Khoahoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvcnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maKhoaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nienKhoaTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Location = new System.Drawing.Point(12, 28);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(51, 13);
            maKhoaLabel.TabIndex = 0;
            maKhoaLabel.Text = "Mã khóa:";
            // 
            // nienKhoaLabel
            // 
            nienKhoaLabel.AutoSize = true;
            nienKhoaLabel.Location = new System.Drawing.Point(12, 53);
            nienKhoaLabel.Name = "nienKhoaLabel";
            nienKhoaLabel.Size = new System.Drawing.Size(58, 13);
            nienKhoaLabel.TabIndex = 2;
            nienKhoaLabel.Text = "Niên khóa:";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            // 
            // dataGrv_Khoahoc
            // 
            this.dataGrv_Khoahoc.AllowUserToAddRows = false;
            this.dataGrv_Khoahoc.AllowUserToDeleteRows = false;
            this.dataGrv_Khoahoc.AutoGenerateColumns = false;
            this.dataGrv_Khoahoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrv_Khoahoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhoaDataGridViewTextBoxColumn,
            this.nienKhoaDataGridViewTextBoxColumn});
            this.dataGrv_Khoahoc.DataSource = this.khoaHocBindingSource;
            this.dataGrv_Khoahoc.Location = new System.Drawing.Point(190, 1);
            this.dataGrv_Khoahoc.Name = "dataGrv_Khoahoc";
            this.dataGrv_Khoahoc.ReadOnly = true;
            this.dataGrv_Khoahoc.Size = new System.Drawing.Size(237, 207);
            this.dataGrv_Khoahoc.TabIndex = 0;
            this.dataGrv_Khoahoc.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrv_Khoahoc_CellEnter_1);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.bt_them);
            this.groupControl1.Controls.Add(this.bt_Xoa);
            this.groupControl1.Controls.Add(this.bt_Luu);
            this.groupControl1.Controls.Add(this.bt_Sua);
            this.groupControl1.Location = new System.Drawing.Point(0, 81);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(189, 126);
            this.groupControl1.TabIndex = 23;
            this.groupControl1.Text = "Công cụ";
            // 
            // bt_them
            // 
            this.bt_them.Image = ((System.Drawing.Image)(resources.GetObject("bt_them.Image")));
            this.bt_them.Location = new System.Drawing.Point(12, 30);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(74, 40);
            this.bt_them.TabIndex = 5;
            this.bt_them.Text = "Thêm";
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click_1);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("bt_Xoa.Image")));
            this.bt_Xoa.Location = new System.Drawing.Point(12, 76);
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
            this.bt_Luu.Location = new System.Drawing.Point(100, 76);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(75, 39);
            this.bt_Luu.TabIndex = 7;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Image = ((System.Drawing.Image)(resources.GetObject("bt_Sua.Image")));
            this.bt_Sua.Location = new System.Drawing.Point(100, 30);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(75, 40);
            this.bt_Sua.TabIndex = 6;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click_1);
            // 
            // ketquarenluyenDataSet
            // 
            this.ketquarenluyenDataSet.DataSetName = "ketquarenluyenDataSet";
            this.ketquarenluyenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // groupControl2
            // 
            this.groupControl2.Controls.Add(maKhoaLabel);
            this.groupControl2.Controls.Add(this.maKhoaTextEdit);
            this.groupControl2.Controls.Add(nienKhoaLabel);
            this.groupControl2.Controls.Add(this.nienKhoaTextEdit);
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(189, 81);
            this.groupControl2.TabIndex = 31;
            this.groupControl2.Text = "Thông tin";
            // 
            // maKhoaTextEdit
            // 
            this.maKhoaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoaHocBindingSource, "MaKhoa", true));
            this.maKhoaTextEdit.Location = new System.Drawing.Point(77, 25);
            this.maKhoaTextEdit.Name = "maKhoaTextEdit";
            this.maKhoaTextEdit.Size = new System.Drawing.Size(100, 20);
            this.maKhoaTextEdit.TabIndex = 1;
            // 
            // khoaHocBindingSource
            // 
            this.khoaHocBindingSource.DataMember = "KhoaHoc";
            this.khoaHocBindingSource.DataSource = this.ketquarenluyenDataSet;
            // 
            // nienKhoaTextEdit
            // 
            this.nienKhoaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoaHocBindingSource, "NienKhoa", true));
            this.nienKhoaTextEdit.Location = new System.Drawing.Point(77, 50);
            this.nienKhoaTextEdit.Name = "nienKhoaTextEdit";
            this.nienKhoaTextEdit.Size = new System.Drawing.Size(100, 20);
            this.nienKhoaTextEdit.TabIndex = 3;
            // 
            // khoaHocTableAdapter
            // 
            this.khoaHocTableAdapter.ClearBeforeFill = true;
            // 
            // maKhoaDataGridViewTextBoxColumn
            // 
            this.maKhoaDataGridViewTextBoxColumn.DataPropertyName = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn.HeaderText = "Mã Khóa học";
            this.maKhoaDataGridViewTextBoxColumn.Name = "maKhoaDataGridViewTextBoxColumn";
            this.maKhoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nienKhoaDataGridViewTextBoxColumn
            // 
            this.nienKhoaDataGridViewTextBoxColumn.DataPropertyName = "NienKhoa";
            this.nienKhoaDataGridViewTextBoxColumn.HeaderText = "Niên khóa";
            this.nienKhoaDataGridViewTextBoxColumn.Name = "nienKhoaDataGridViewTextBoxColumn";
            this.nienKhoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form_Khoahoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 213);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dataGrv_Khoahoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Khoahoc";
            this.Text = "Quản lý khóa học";
            this.Load += new System.EventHandler(this.Form_Khoahoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrv_Khoahoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvcnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maKhoaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nienKhoaTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private System.Windows.Forms.DataGridView dataGrv_Khoahoc;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton bt_them;
        private DevExpress.XtraEditors.SimpleButton bt_Xoa;
        private DevExpress.XtraEditors.SimpleButton bt_Luu;
        private DevExpress.XtraEditors.SimpleButton bt_Sua;
        private ketquarenluyenDataSet ketquarenluyenDataSet;
        private System.Windows.Forms.BindingSource gvcnBindingSource;
        private ketquarenluyenDataSetTableAdapters.GvcnTableAdapter gvcnTableAdapter;
        private ketquarenluyenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource khoaHocBindingSource;
        private ketquarenluyenDataSetTableAdapters.KhoaHocTableAdapter khoaHocTableAdapter;
        private DevExpress.XtraEditors.TextEdit maKhoaTextEdit;
        private DevExpress.XtraEditors.TextEdit nienKhoaTextEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nienKhoaDataGridViewTextBoxColumn;
    }
}