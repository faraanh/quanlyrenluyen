namespace quanlyrenluyen.Forms
{
    partial class Form_Gvcn
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
            System.Windows.Forms.Label maGvcnLabel;
            System.Windows.Forms.Label tenGvcnLabel;
            System.Windows.Forms.Label maTkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Gvcn));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.dataGrv_Gvcn = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bt_them = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ketquarenluyenDataSet = new quanlyrenluyen.ketquarenluyenDataSet();
            this.gvcnBindingSource = new System.Windows.Forms.BindingSource();
            this.gvcnTableAdapter = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.GvcnTableAdapter();
            this.tableAdapterManager = new quanlyrenluyen.ketquarenluyenDataSetTableAdapters.TableAdapterManager();
            this.maGvcnTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenGvcnTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maTkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.maGvcnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGvcnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maGvcnLabel = new System.Windows.Forms.Label();
            tenGvcnLabel = new System.Windows.Forms.Label();
            maTkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrv_Gvcn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvcnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maGvcnTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenGvcnTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maTkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // maGvcnLabel
            // 
            maGvcnLabel.AutoSize = true;
            maGvcnLabel.Location = new System.Drawing.Point(12, 39);
            maGvcnLabel.Name = "maGvcnLabel";
            maGvcnLabel.Size = new System.Drawing.Size(52, 13);
            maGvcnLabel.TabIndex = 25;
            maGvcnLabel.Text = "Mã Gvcn:";
            // 
            // tenGvcnLabel
            // 
            tenGvcnLabel.AutoSize = true;
            tenGvcnLabel.Location = new System.Drawing.Point(12, 65);
            tenGvcnLabel.Name = "tenGvcnLabel";
            tenGvcnLabel.Size = new System.Drawing.Size(56, 13);
            tenGvcnLabel.TabIndex = 27;
            tenGvcnLabel.Text = "Tên Gvcn:";
            // 
            // maTkLabel
            // 
            maTkLabel.AutoSize = true;
            maTkLabel.Location = new System.Drawing.Point(12, 91);
            maTkLabel.Name = "maTkLabel";
            maTkLabel.Size = new System.Drawing.Size(72, 13);
            maTkLabel.TabIndex = 29;
            maTkLabel.Text = "Mã tài khoản:";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            // 
            // dataGrv_Gvcn
            // 
            this.dataGrv_Gvcn.AllowUserToAddRows = false;
            this.dataGrv_Gvcn.AllowUserToDeleteRows = false;
            this.dataGrv_Gvcn.AutoGenerateColumns = false;
            this.dataGrv_Gvcn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrv_Gvcn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGvcnDataGridViewTextBoxColumn,
            this.tenGvcnDataGridViewTextBoxColumn,
            this.maTkDataGridViewTextBoxColumn});
            this.dataGrv_Gvcn.DataSource = this.gvcnBindingSource;
            this.dataGrv_Gvcn.Location = new System.Drawing.Point(0, 166);
            this.dataGrv_Gvcn.Name = "dataGrv_Gvcn";
            this.dataGrv_Gvcn.ReadOnly = true;
            this.dataGrv_Gvcn.Size = new System.Drawing.Size(372, 153);
            this.dataGrv_Gvcn.TabIndex = 0;
            this.dataGrv_Gvcn.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrv_Gvcn_CellEnter);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.bt_them);
            this.groupControl1.Controls.Add(this.bt_Xoa);
            this.groupControl1.Controls.Add(this.bt_Luu);
            this.groupControl1.Controls.Add(this.bt_Sua);
            this.groupControl1.Location = new System.Drawing.Point(206, 0);
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
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Danh sách giáo viên:";
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
            // maGvcnTextEdit
            // 
            this.maGvcnTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gvcnBindingSource, "MaGvcn", true));
            this.maGvcnTextEdit.Location = new System.Drawing.Point(86, 36);
            this.maGvcnTextEdit.Name = "maGvcnTextEdit";
            this.maGvcnTextEdit.Size = new System.Drawing.Size(100, 20);
            this.maGvcnTextEdit.TabIndex = 26;
            // 
            // tenGvcnTextEdit
            // 
            this.tenGvcnTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gvcnBindingSource, "TenGvcn", true));
            this.tenGvcnTextEdit.Location = new System.Drawing.Point(86, 62);
            this.tenGvcnTextEdit.Name = "tenGvcnTextEdit";
            this.tenGvcnTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tenGvcnTextEdit.TabIndex = 28;
            // 
            // maTkTextEdit
            // 
            this.maTkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gvcnBindingSource, "MaTk", true));
            this.maTkTextEdit.Location = new System.Drawing.Point(86, 88);
            this.maTkTextEdit.Name = "maTkTextEdit";
            this.maTkTextEdit.Size = new System.Drawing.Size(100, 20);
            this.maTkTextEdit.TabIndex = 30;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(maGvcnLabel);
            this.groupControl2.Controls.Add(this.maTkTextEdit);
            this.groupControl2.Controls.Add(this.maGvcnTextEdit);
            this.groupControl2.Controls.Add(maTkLabel);
            this.groupControl2.Controls.Add(tenGvcnLabel);
            this.groupControl2.Controls.Add(this.tenGvcnTextEdit);
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(200, 130);
            this.groupControl2.TabIndex = 31;
            this.groupControl2.Text = "Thông tin";
            // 
            // maGvcnDataGridViewTextBoxColumn
            // 
            this.maGvcnDataGridViewTextBoxColumn.DataPropertyName = "MaGvcn";
            this.maGvcnDataGridViewTextBoxColumn.HeaderText = "Mã Gvcn";
            this.maGvcnDataGridViewTextBoxColumn.Name = "maGvcnDataGridViewTextBoxColumn";
            this.maGvcnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenGvcnDataGridViewTextBoxColumn
            // 
            this.tenGvcnDataGridViewTextBoxColumn.DataPropertyName = "TenGvcn";
            this.tenGvcnDataGridViewTextBoxColumn.HeaderText = "Tên Gvcn";
            this.tenGvcnDataGridViewTextBoxColumn.Name = "tenGvcnDataGridViewTextBoxColumn";
            this.tenGvcnDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenGvcnDataGridViewTextBoxColumn.Width = 130;
            // 
            // maTkDataGridViewTextBoxColumn
            // 
            this.maTkDataGridViewTextBoxColumn.DataPropertyName = "MaTk";
            this.maTkDataGridViewTextBoxColumn.HeaderText = "Mã tài khoản";
            this.maTkDataGridViewTextBoxColumn.Name = "maTkDataGridViewTextBoxColumn";
            this.maTkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form_Gvcn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 319);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dataGrv_Gvcn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Gvcn";
            this.Text = "Quản lý giáo viên chủ nhiệm";
            this.Load += new System.EventHandler(this.Form_Gvcn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrv_Gvcn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ketquarenluyenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvcnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maGvcnTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenGvcnTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maTkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private System.Windows.Forms.DataGridView dataGrv_Gvcn;
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
        private DevExpress.XtraEditors.TextEdit maGvcnTextEdit;
        private DevExpress.XtraEditors.TextEdit tenGvcnTextEdit;
        private DevExpress.XtraEditors.TextEdit maTkTextEdit;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGvcnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGvcnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTkDataGridViewTextBoxColumn;
    }
}