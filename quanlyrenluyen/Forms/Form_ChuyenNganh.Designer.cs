namespace quanlyrenluyen.Forms
{
    partial class Form_ChuyenNganh
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
            System.Windows.Forms.Label maNganhLabel;
            System.Windows.Forms.Label tenChuyenNganhLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChuyenNganh));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.dataGrv_ChuyenNganh = new System.Windows.Forms.DataGridView();
            this.maNganhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenChuyenNganhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuyenNganhBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.maNganhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenChuyenNganhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.chuyenNganhTableAdapter = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.ChuyenNganhTableAdapter();
            maNganhLabel = new System.Windows.Forms.Label();
            tenChuyenNganhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrv_ChuyenNganh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenNganhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvcnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maNganhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenChuyenNganhTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maNganhLabel
            // 
            maNganhLabel.AutoSize = true;
            maNganhLabel.Location = new System.Drawing.Point(12, 32);
            maNganhLabel.Name = "maNganhLabel";
            maNganhLabel.Size = new System.Drawing.Size(96, 13);
            maNganhLabel.TabIndex = 0;
            maNganhLabel.Text = "Mã chuyên ngành:";
            // 
            // tenChuyenNganhLabel
            // 
            tenChuyenNganhLabel.AutoSize = true;
            tenChuyenNganhLabel.Location = new System.Drawing.Point(12, 58);
            tenChuyenNganhLabel.Name = "tenChuyenNganhLabel";
            tenChuyenNganhLabel.Size = new System.Drawing.Size(100, 13);
            tenChuyenNganhLabel.TabIndex = 2;
            tenChuyenNganhLabel.Text = "Tên chuyên ngành:";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            // 
            // dataGrv_ChuyenNganh
            // 
            this.dataGrv_ChuyenNganh.AllowUserToAddRows = false;
            this.dataGrv_ChuyenNganh.AllowUserToDeleteRows = false;
            this.dataGrv_ChuyenNganh.AutoGenerateColumns = false;
            this.dataGrv_ChuyenNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrv_ChuyenNganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNganhDataGridViewTextBoxColumn,
            this.tenChuyenNganhDataGridViewTextBoxColumn});
            this.dataGrv_ChuyenNganh.DataSource = this.chuyenNganhBindingSource;
            this.dataGrv_ChuyenNganh.Location = new System.Drawing.Point(258, 23);
            this.dataGrv_ChuyenNganh.Name = "dataGrv_ChuyenNganh";
            this.dataGrv_ChuyenNganh.ReadOnly = true;
            this.dataGrv_ChuyenNganh.Size = new System.Drawing.Size(241, 190);
            this.dataGrv_ChuyenNganh.TabIndex = 0;
            this.dataGrv_ChuyenNganh.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrv_ChuyenNganh_CellEnter);
            // 
            // maNganhDataGridViewTextBoxColumn
            // 
            this.maNganhDataGridViewTextBoxColumn.DataPropertyName = "MaNganh";
            this.maNganhDataGridViewTextBoxColumn.HeaderText = "Mã ngành";
            this.maNganhDataGridViewTextBoxColumn.Name = "maNganhDataGridViewTextBoxColumn";
            this.maNganhDataGridViewTextBoxColumn.ReadOnly = true;
            this.maNganhDataGridViewTextBoxColumn.Width = 80;
            // 
            // tenChuyenNganhDataGridViewTextBoxColumn
            // 
            this.tenChuyenNganhDataGridViewTextBoxColumn.DataPropertyName = "TenChuyenNganh";
            this.tenChuyenNganhDataGridViewTextBoxColumn.HeaderText = "Tên chuyên ngành";
            this.tenChuyenNganhDataGridViewTextBoxColumn.Name = "tenChuyenNganhDataGridViewTextBoxColumn";
            this.tenChuyenNganhDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenChuyenNganhDataGridViewTextBoxColumn.Width = 130;
            // 
            // chuyenNganhBindingSource
            // 
            this.chuyenNganhBindingSource.DataMember = "ChuyenNganh";
            this.chuyenNganhBindingSource.DataSource = this.ketquarenluyenDataSet;
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
            this.groupControl1.Location = new System.Drawing.Point(0, 89);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(252, 124);
            this.groupControl1.TabIndex = 23;
            this.groupControl1.Text = "Công cụ";
            // 
            // bt_them
            // 
            this.bt_them.Image = ((System.Drawing.Image)(resources.GetObject("bt_them.Image")));
            this.bt_them.Location = new System.Drawing.Point(38, 30);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(74, 40);
            this.bt_them.TabIndex = 5;
            this.bt_them.Text = "Thêm";
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click_1);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("bt_Xoa.Image")));
            this.bt_Xoa.Location = new System.Drawing.Point(38, 76);
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
            this.bt_Luu.Location = new System.Drawing.Point(136, 76);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(75, 39);
            this.bt_Luu.TabIndex = 7;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Image = ((System.Drawing.Image)(resources.GetObject("bt_Sua.Image")));
            this.bt_Sua.Location = new System.Drawing.Point(136, 30);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(75, 40);
            this.bt_Sua.TabIndex = 6;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Danh sách chuyên ngành:";
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
            this.groupControl2.Controls.Add(maNganhLabel);
            this.groupControl2.Controls.Add(this.maNganhTextEdit);
            this.groupControl2.Controls.Add(tenChuyenNganhLabel);
            this.groupControl2.Controls.Add(this.tenChuyenNganhTextEdit);
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(252, 86);
            this.groupControl2.TabIndex = 31;
            this.groupControl2.Text = "Thông tin";
            // 
            // maNganhTextEdit
            // 
            this.maNganhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.chuyenNganhBindingSource, "MaNganh", true));
            this.maNganhTextEdit.Location = new System.Drawing.Point(121, 29);
            this.maNganhTextEdit.Name = "maNganhTextEdit";
            this.maNganhTextEdit.Size = new System.Drawing.Size(126, 20);
            this.maNganhTextEdit.TabIndex = 1;
            // 
            // tenChuyenNganhTextEdit
            // 
            this.tenChuyenNganhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.chuyenNganhBindingSource, "TenChuyenNganh", true));
            this.tenChuyenNganhTextEdit.Location = new System.Drawing.Point(121, 55);
            this.tenChuyenNganhTextEdit.Name = "tenChuyenNganhTextEdit";
            this.tenChuyenNganhTextEdit.Size = new System.Drawing.Size(126, 20);
            this.tenChuyenNganhTextEdit.TabIndex = 3;
            // 
            // chuyenNganhTableAdapter
            // 
            this.chuyenNganhTableAdapter.ClearBeforeFill = true;
            // 
            // Form_ChuyenNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 215);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dataGrv_ChuyenNganh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_ChuyenNganh";
            this.Text = "Quản lý chuyên ngành";

            this.Load += new System.EventHandler(this.Form_ChuyenNganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrv_ChuyenNganh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenNganhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvcnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maNganhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenChuyenNganhTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private System.Windows.Forms.DataGridView dataGrv_ChuyenNganh;
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
        private System.Windows.Forms.BindingSource chuyenNganhBindingSource;
        private ketquarenluyenDataSetTableAdapters.ChuyenNganhTableAdapter chuyenNganhTableAdapter;
        private DevExpress.XtraEditors.TextEdit maNganhTextEdit;
        private DevExpress.XtraEditors.TextEdit tenChuyenNganhTextEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNganhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenChuyenNganhDataGridViewTextBoxColumn;
    }
}