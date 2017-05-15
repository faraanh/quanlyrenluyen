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
            this.lb_chaychu = new DevExpress.XtraEditors.LabelControl();
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
            this.lb_chaychu.Location = new System.Drawing.Point(17, 67);
            this.lb_chaychu.Name = "lb_chaychu";
            this.lb_chaychu.Size = new System.Drawing.Size(406, 220);
            this.lb_chaychu.TabIndex = 10;
            this.lb_chaychu.Text = "Phần mềm quản lý kết quả rèn luyện học viên T36\r\n\r\n\r\nThành viên:\r\nĐoàn Đắc Ngọc A" +
    "nh\r\nVõ Tấn Hậu\r\nTrương Nhật Thành\r\n\r\nGiáo viên hướng dẫn:\r\nThS. Dương Phú Thuần";
            // 
            // Thongtintacgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 321);
            this.Controls.Add(this.lb_chaychu);
            this.Name = "Thongtintacgia";
            this.Text = "Thongtintacgia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lb_chaychu;
    }
}