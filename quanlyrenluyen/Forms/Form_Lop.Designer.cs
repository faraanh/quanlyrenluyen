namespace quanlyrenluyen.Forms
{
    partial class Form_Lop
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
            System.Windows.Forms.Label maLopLabel;
            System.Windows.Forms.Label maNganhLabel;
            System.Windows.Forms.Label maKhoaLabel;
            System.Windows.Forms.Label maGvcnLabel;
            System.Windows.Forms.Label quanSoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Lop));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.dataGrv_Lop = new System.Windows.Forms.DataGridView();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNganhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGvcnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketquarenluyenDataSet = new quanlyrenluyen.ketquarenluyenDataSet();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bt_them = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gvcnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvcnTableAdapter = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.GvcnTableAdapter();
            this.tableAdapterManager = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.TableAdapterManager();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cbbMakhoa = new System.Windows.Forms.ComboBox();
            this.khoaHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbManganh = new System.Windows.Forms.ComboBox();
            this.maLopTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maGvcnTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.quanSoSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.lopTableAdapter = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.LopTableAdapter();
            this.khoaHocTableAdapter = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.KhoaHocTableAdapter();
            this.gvcnBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gvcnBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gvcnBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            maLopLabel = new System.Windows.Forms.Label();
            maNganhLabel = new System.Windows.Forms.Label();
            maKhoaLabel = new System.Windows.Forms.Label();
            maGvcnLabel = new System.Windows.Forms.Label();
            quanSoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrv_Lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvcnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoaHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maLopTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maGvcnTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanSoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvcnBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvcnBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvcnBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // maLopLabel
            // 
            maLopLabel.AutoSize = true;
            maLopLabel.Location = new System.Drawing.Point(12, 35);
            maLopLabel.Name = "maLopLabel";
            maLopLabel.Size = new System.Drawing.Size(42, 13);
            maLopLabel.TabIndex = 0;
            maLopLabel.Text = "Mã lớp:";
            // 
            // maNganhLabel
            // 
            maNganhLabel.AutoSize = true;
            maNganhLabel.Location = new System.Drawing.Point(12, 61);
            maNganhLabel.Name = "maNganhLabel";
            maNganhLabel.Size = new System.Drawing.Size(58, 13);
            maNganhLabel.TabIndex = 2;
            maNganhLabel.Text = "Mã ngành:";
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Location = new System.Drawing.Point(192, 35);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(71, 13);
            maKhoaLabel.TabIndex = 4;
            maKhoaLabel.Text = "Mã khóa học:";
            // 
            // maGvcnLabel
            // 
            maGvcnLabel.AutoSize = true;
            maGvcnLabel.Location = new System.Drawing.Point(192, 61);
            maGvcnLabel.Name = "maGvcnLabel";
            maGvcnLabel.Size = new System.Drawing.Size(52, 13);
            maGvcnLabel.TabIndex = 6;
            maGvcnLabel.Text = "Mã Gvcn:";
            // 
            // quanSoLabel
            // 
            quanSoLabel.AutoSize = true;
            quanSoLabel.Location = new System.Drawing.Point(192, 87);
            quanSoLabel.Name = "quanSoLabel";
            quanSoLabel.Size = new System.Drawing.Size(51, 13);
            quanSoLabel.TabIndex = 8;
            quanSoLabel.Text = "Quân số:";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            // 
            // dataGrv_Lop
            // 
            this.dataGrv_Lop.AllowUserToAddRows = false;
            this.dataGrv_Lop.AllowUserToDeleteRows = false;
            this.dataGrv_Lop.AutoGenerateColumns = false;
            this.dataGrv_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrv_Lop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLopDataGridViewTextBoxColumn,
            this.maNganhDataGridViewTextBoxColumn,
            this.maKhoaDataGridViewTextBoxColumn,
            this.maGvcnDataGridViewTextBoxColumn,
            this.quanSoDataGridViewTextBoxColumn});
            this.dataGrv_Lop.DataSource = this.lopBindingSource;
            this.dataGrv_Lop.Location = new System.Drawing.Point(0, 158);
            this.dataGrv_Lop.Name = "dataGrv_Lop";
            this.dataGrv_Lop.ReadOnly = true;
            this.dataGrv_Lop.Size = new System.Drawing.Size(555, 153);
            this.dataGrv_Lop.TabIndex = 0;
            this.dataGrv_Lop.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrv_Lop_CellEnter);
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "Mã Lớp";
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            this.maLopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maNganhDataGridViewTextBoxColumn
            // 
            this.maNganhDataGridViewTextBoxColumn.DataPropertyName = "MaNganh";
            this.maNganhDataGridViewTextBoxColumn.HeaderText = "Mã Ngành";
            this.maNganhDataGridViewTextBoxColumn.Name = "maNganhDataGridViewTextBoxColumn";
            this.maNganhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maKhoaDataGridViewTextBoxColumn
            // 
            this.maKhoaDataGridViewTextBoxColumn.DataPropertyName = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn.HeaderText = "Mã khóa học";
            this.maKhoaDataGridViewTextBoxColumn.Name = "maKhoaDataGridViewTextBoxColumn";
            this.maKhoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maGvcnDataGridViewTextBoxColumn
            // 
            this.maGvcnDataGridViewTextBoxColumn.DataPropertyName = "MaGvcn";
            this.maGvcnDataGridViewTextBoxColumn.HeaderText = "Mã Gvcn";
            this.maGvcnDataGridViewTextBoxColumn.Name = "maGvcnDataGridViewTextBoxColumn";
            this.maGvcnDataGridViewTextBoxColumn.ReadOnly = true;
            this.maGvcnDataGridViewTextBoxColumn.Width = 110;
            // 
            // quanSoDataGridViewTextBoxColumn
            // 
            this.quanSoDataGridViewTextBoxColumn.DataPropertyName = "QuanSo";
            this.quanSoDataGridViewTextBoxColumn.HeaderText = "Quân số";
            this.quanSoDataGridViewTextBoxColumn.Name = "quanSoDataGridViewTextBoxColumn";
            this.quanSoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.ketquarenluyenDataSet;
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
            this.groupControl1.Location = new System.Drawing.Point(389, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(165, 130);
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
            this.label1.Location = new System.Drawing.Point(6, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Danh sách các lớp:";
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
            this.groupControl2.Controls.Add(this.cbbMakhoa);
            this.groupControl2.Controls.Add(this.cbbManganh);
            this.groupControl2.Controls.Add(maLopLabel);
            this.groupControl2.Controls.Add(this.maLopTextEdit);
            this.groupControl2.Controls.Add(maNganhLabel);
            this.groupControl2.Controls.Add(maKhoaLabel);
            this.groupControl2.Controls.Add(maGvcnLabel);
            this.groupControl2.Controls.Add(this.maGvcnTextEdit);
            this.groupControl2.Controls.Add(quanSoLabel);
            this.groupControl2.Controls.Add(this.quanSoSpinEdit);
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(384, 130);
            this.groupControl2.TabIndex = 31;
            this.groupControl2.Text = "Thông tin";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // cbbMakhoa
            // 
            this.cbbMakhoa.DataSource = this.khoaHocBindingSource;
            this.cbbMakhoa.DisplayMember = "MaKhoa";
            this.cbbMakhoa.FormattingEnabled = true;
            this.cbbMakhoa.Location = new System.Drawing.Point(265, 32);
            this.cbbMakhoa.Name = "cbbMakhoa";
            this.cbbMakhoa.Size = new System.Drawing.Size(100, 21);
            this.cbbMakhoa.TabIndex = 44;
            this.cbbMakhoa.ValueMember = "MaKhoa";
            // 
            // khoaHocBindingSource
            // 
            this.khoaHocBindingSource.DataMember = "KhoaHoc";
            this.khoaHocBindingSource.DataSource = this.ketquarenluyenDataSet;
            // 
            // cbbManganh
            // 
            this.cbbManganh.FormattingEnabled = true;
            this.cbbManganh.Location = new System.Drawing.Point(77, 58);
            this.cbbManganh.Name = "cbbManganh";
            this.cbbManganh.Size = new System.Drawing.Size(100, 21);
            this.cbbManganh.TabIndex = 43;
            // 
            // maLopTextEdit
            // 
            this.maLopTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lopBindingSource, "MaLop", true));
            this.maLopTextEdit.Location = new System.Drawing.Point(77, 32);
            this.maLopTextEdit.Name = "maLopTextEdit";
            this.maLopTextEdit.Size = new System.Drawing.Size(100, 20);
            this.maLopTextEdit.TabIndex = 1;
            // 
            // maGvcnTextEdit
            // 
            this.maGvcnTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lopBindingSource, "MaGvcn", true));
            this.maGvcnTextEdit.Location = new System.Drawing.Point(265, 58);
            this.maGvcnTextEdit.Name = "maGvcnTextEdit";
            this.maGvcnTextEdit.Size = new System.Drawing.Size(100, 20);
            this.maGvcnTextEdit.TabIndex = 7;
            // 
            // quanSoSpinEdit
            // 
            this.quanSoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lopBindingSource, "QuanSo", true));
            this.quanSoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.quanSoSpinEdit.Location = new System.Drawing.Point(265, 84);
            this.quanSoSpinEdit.Name = "quanSoSpinEdit";
            this.quanSoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.quanSoSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.quanSoSpinEdit.TabIndex = 9;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // khoaHocTableAdapter
            // 
            this.khoaHocTableAdapter.ClearBeforeFill = true;
            // 
            // gvcnBindingSource1
            // 
            this.gvcnBindingSource1.DataMember = "Gvcn";
            this.gvcnBindingSource1.DataSource = this.ketquarenluyenDataSet;
            // 
            // gvcnBindingSource2
            // 
            this.gvcnBindingSource2.DataMember = "Gvcn";
            this.gvcnBindingSource2.DataSource = this.ketquarenluyenDataSet;
            // 
            // gvcnBindingSource3
            // 
            this.gvcnBindingSource3.DataMember = "Gvcn";
            this.gvcnBindingSource3.DataSource = this.ketquarenluyenDataSet;
            // 
            // Form_Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 313);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dataGrv_Lop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Lop";
            this.Text = "Quản lý lớp";
            this.Load += new System.EventHandler(this.Form_Gvcn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrv_Lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvcnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoaHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maLopTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maGvcnTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanSoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvcnBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvcnBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvcnBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private System.Windows.Forms.DataGridView dataGrv_Lop;
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
        private System.Windows.Forms.BindingSource lopBindingSource;
        private ketquarenluyenDataSetTableAdapters.LopTableAdapter lopTableAdapter;
        private DevExpress.XtraEditors.TextEdit maLopTextEdit;
        private DevExpress.XtraEditors.TextEdit maGvcnTextEdit;
        private DevExpress.XtraEditors.SpinEdit quanSoSpinEdit;
        private System.Windows.Forms.ComboBox cbbManganh;
        private System.Windows.Forms.ComboBox cbbMakhoa;
        private System.Windows.Forms.BindingSource khoaHocBindingSource;
        private ketquarenluyenDataSetTableAdapters.KhoaHocTableAdapter khoaHocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNganhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGvcnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gvcnBindingSource2;
        private System.Windows.Forms.BindingSource gvcnBindingSource1;
        private System.Windows.Forms.BindingSource gvcnBindingSource3;
    }
}