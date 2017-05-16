namespace quanlyrenluyen.Forms
{
    partial class Form_Thongtintacgia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Thongtintacgia));
            this.lb_chaychu = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_chaychu
            // 
            this.lb_chaychu.AllowHtmlString = true;
            this.lb_chaychu.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_chaychu.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_chaychu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lb_chaychu.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lb_chaychu.LineVisible = true;
            this.lb_chaychu.Location = new System.Drawing.Point(17, 12);
            this.lb_chaychu.Name = "lb_chaychu";
            this.lb_chaychu.Size = new System.Drawing.Size(406, 220);
            this.lb_chaychu.TabIndex = 10;
            this.lb_chaychu.Text = "Phần mềm quản lý kết quả rèn luyện học viên T36\r\n\r\n\r\nThành viên:\r\nĐoàn Đắc Ngọc A" +
    "nh\r\nVõ Tấn Hậu\r\nTrương Nhật Thành\r\n\r\nGiáo viên hướng dẫn:\r\nThS. Dương Phú Thuần";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::quanlyrenluyen.Properties.Resources.Picture3;
            this.pictureBox2.Location = new System.Drawing.Point(202, 251);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(221, 174);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::quanlyrenluyen.Properties.Resources.Picture2;
            this.pictureBox1.Location = new System.Drawing.Point(17, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Thongtintacgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 434);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_chaychu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Thongtintacgia";
            this.Text = "Thông tin tác giả";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lb_chaychu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}