namespace quanlyrenluyen.Forms
{
    partial class Form_DiemTru
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
            System.Windows.Forms.Label maDiemTruLabel;
            System.Windows.Forms.Label tenDiemTruLabel;
            System.Windows.Forms.Label diemTruLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DiemTru));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.dataGrv_Diemtru = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bt_them = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.maDiemTruTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.diemTruBindingSource = new System.Windows.Forms.BindingSource();
            this.ketquarenluyenDataSet = new quanlyrenluyen.ketquarenluyenDataSet();
            this.tenDiemTruTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.diemTruTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.diemCongBindingSource = new System.Windows.Forms.BindingSource();
            this.gvcnBindingSource = new System.Windows.Forms.BindingSource();
            this.gvcnTableAdapter = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.GvcnTableAdapter();
            this.tableAdapterManager = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.TableAdapterManager();
            this.diemCongTableAdapter = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.DiemCongTableAdapter();
            this.diemTruTableAdapter = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.DiemTruTableAdapter();
            this.maDiemTruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDiemTruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maDiemTruLabel = new System.Windows.Forms.Label();
            tenDiemTruLabel = new System.Windows.Forms.Label();
            diemTruLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrv_Diemtru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maDiemTruTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemTruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenDiemTruTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemTruTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemCongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvcnBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maDiemTruLabel
            // 
            maDiemTruLabel.AutoSize = true;
            maDiemTruLabel.Location = new System.Drawing.Point(11, 41);
            maDiemTruLabel.Name = "maDiemTruLabel";
            maDiemTruLabel.Size = new System.Drawing.Size(68, 13);
            maDiemTruLabel.TabIndex = 0;
            maDiemTruLabel.Text = "Mã điểm trừ:";
            // 
            // tenDiemTruLabel
            // 
            tenDiemTruLabel.AutoSize = true;
            tenDiemTruLabel.Location = new System.Drawing.Point(11, 67);
            tenDiemTruLabel.Name = "tenDiemTruLabel";
            tenDiemTruLabel.Size = new System.Drawing.Size(72, 13);
            tenDiemTruLabel.TabIndex = 2;
            tenDiemTruLabel.Text = "Tên điểm trừ:";
            // 
            // diemTruLabel
            // 
            diemTruLabel.AutoSize = true;
            diemTruLabel.Location = new System.Drawing.Point(11, 93);
            diemTruLabel.Name = "diemTruLabel";
            diemTruLabel.Size = new System.Drawing.Size(53, 13);
            diemTruLabel.TabIndex = 4;
            diemTruLabel.Text = "Điểm trừ:";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            // 
            // dataGrv_Diemtru
            // 
            this.dataGrv_Diemtru.AllowUserToAddRows = false;
            this.dataGrv_Diemtru.AllowUserToDeleteRows = false;
            this.dataGrv_Diemtru.AutoGenerateColumns = false;
            this.dataGrv_Diemtru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrv_Diemtru.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDiemTruDataGridViewTextBoxColumn,
            this.tenDiemTruDataGridViewTextBoxColumn,
            this.diemTruDataGridViewTextBoxColumn});
            this.dataGrv_Diemtru.DataSource = this.diemTruBindingSource;
            this.dataGrv_Diemtru.Location = new System.Drawing.Point(264, 29);
            this.dataGrv_Diemtru.Name = "dataGrv_Diemtru";
            this.dataGrv_Diemtru.ReadOnly = true;
            this.dataGrv_Diemtru.Size = new System.Drawing.Size(326, 237);
            this.dataGrv_Diemtru.TabIndex = 0;
            this.dataGrv_Diemtru.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrv_Gvcn_CellEnter);
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
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Danh sách các điểm trừ:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(maDiemTruLabel);
            this.groupControl2.Controls.Add(this.maDiemTruTextEdit);
            this.groupControl2.Controls.Add(tenDiemTruLabel);
            this.groupControl2.Controls.Add(this.tenDiemTruTextEdit);
            this.groupControl2.Controls.Add(diemTruLabel);
            this.groupControl2.Controls.Add(this.diemTruTextEdit);
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(258, 135);
            this.groupControl2.TabIndex = 31;
            this.groupControl2.Text = "Thông tin";
            // 
            // maDiemTruTextEdit
            // 
            this.maDiemTruTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.diemTruBindingSource, "MaDiemTru", true));
            this.maDiemTruTextEdit.Location = new System.Drawing.Point(87, 38);
            this.maDiemTruTextEdit.Name = "maDiemTruTextEdit";
            this.maDiemTruTextEdit.Size = new System.Drawing.Size(166, 20);
            this.maDiemTruTextEdit.TabIndex = 1;
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
            // tenDiemTruTextEdit
            // 
            this.tenDiemTruTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.diemTruBindingSource, "TenDiemTru", true));
            this.tenDiemTruTextEdit.Location = new System.Drawing.Point(87, 64);
            this.tenDiemTruTextEdit.Name = "tenDiemTruTextEdit";
            this.tenDiemTruTextEdit.Size = new System.Drawing.Size(166, 20);
            this.tenDiemTruTextEdit.TabIndex = 3;
            // 
            // diemTruTextEdit
            // 
            this.diemTruTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.diemTruBindingSource, "DiemTru", true));
            this.diemTruTextEdit.Location = new System.Drawing.Point(87, 90);
            this.diemTruTextEdit.Name = "diemTruTextEdit";
            this.diemTruTextEdit.Size = new System.Drawing.Size(166, 20);
            this.diemTruTextEdit.TabIndex = 5;
            // 
            // diemCongBindingSource
            // 
            this.diemCongBindingSource.DataMember = "DiemCong";
            this.diemCongBindingSource.DataSource = this.ketquarenluyenDataSet;
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
            // diemTruTableAdapter
            // 
            this.diemTruTableAdapter.ClearBeforeFill = true;
            // 
            // maDiemTruDataGridViewTextBoxColumn
            // 
            this.maDiemTruDataGridViewTextBoxColumn.DataPropertyName = "MaDiemTru";
            this.maDiemTruDataGridViewTextBoxColumn.HeaderText = "Mã điểm trừ";
            this.maDiemTruDataGridViewTextBoxColumn.Name = "maDiemTruDataGridViewTextBoxColumn";
            this.maDiemTruDataGridViewTextBoxColumn.ReadOnly = true;
            this.maDiemTruDataGridViewTextBoxColumn.Width = 70;
            // 
            // tenDiemTruDataGridViewTextBoxColumn
            // 
            this.tenDiemTruDataGridViewTextBoxColumn.DataPropertyName = "TenDiemTru";
            this.tenDiemTruDataGridViewTextBoxColumn.HeaderText = "Tên điểm trừ";
            this.tenDiemTruDataGridViewTextBoxColumn.Name = "tenDiemTruDataGridViewTextBoxColumn";
            this.tenDiemTruDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenDiemTruDataGridViewTextBoxColumn.Width = 140;
            // 
            // diemTruDataGridViewTextBoxColumn
            // 
            this.diemTruDataGridViewTextBoxColumn.DataPropertyName = "DiemTru";
            this.diemTruDataGridViewTextBoxColumn.HeaderText = "Điểm trừ";
            this.diemTruDataGridViewTextBoxColumn.Name = "diemTruDataGridViewTextBoxColumn";
            this.diemTruDataGridViewTextBoxColumn.ReadOnly = true;
            this.diemTruDataGridViewTextBoxColumn.Width = 80;
            // 
            // Form_DiemTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 269);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dataGrv_Diemtru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_DiemTru";
            this.Text = "Quản lý điểm trừ";
            this.Load += new System.EventHandler(this.Form_Gvcn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrv_Diemtru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maDiemTruTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemTruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenDiemTruTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemTruTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemCongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvcnBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private System.Windows.Forms.DataGridView dataGrv_Diemtru;
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
        private System.Windows.Forms.BindingSource diemTruBindingSource;
        private ketquarenluyenDataSetTableAdapters.DiemTruTableAdapter diemTruTableAdapter;
        private DevExpress.XtraEditors.TextEdit maDiemTruTextEdit;
        private DevExpress.XtraEditors.TextEdit tenDiemTruTextEdit;
        private DevExpress.XtraEditors.TextEdit diemTruTextEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDiemTruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDiemTruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTruDataGridViewTextBoxColumn;
    }
}