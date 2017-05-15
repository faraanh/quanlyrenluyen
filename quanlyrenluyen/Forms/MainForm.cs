using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using quanlyrenluyen.DataAccess;
using quanlyrenluyen.Business;
using quanlyrenluyen.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Preview;
namespace quanlyrenluyen
{
    public partial class ssni : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public static string TaiKhoan = String.Empty;
        public ssni()
        {
            InitializeComponent();
        }

        public int i = 100;

        private void MainForm_Load(object sender, EventArgs e)
        {
            Page_quanlychung.Visible = false;
            Page_quanlylop.Visible = false;
            Page_thongke.Visible = false;
            bt_Dangxuat.Enabled = false;
        }

        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            string PhanQuyenadmin = "admin";
            string PhanQuyenguest = "user";
            string MatKhau = tb_MauKhau.Text.Trim();
            TaiKhoan = tb_MaTaiKhoan.Text.Trim();
            //SqlCommand cmd = new SqlCommand("select * from TaiKhoan where MaTk=@MaTk and MatKhau=@MatKhau and PhanQuyen='" + PhanQuyenadmin + "'");
            //cmd.Parameters.Add(new SqlParameter("@MaTk",TaiKhoan));
            //cmd.Parameters.Add(new SqlParameter("@MatKhau", MatKhau));
            //cmd.ExecuteNonQuery() == 1
            BLL bll = new BLL();
            // tien the phan quyen luon nhe?
            if (bll.CheckID("select * from TaiKhoan where MaTk='" + TaiKhoan + "' and MatKhau='" + MatKhau + "' and PhanQuyen='" + PhanQuyenadmin + "'") == 1)
            {
                MessageBox.Show("Đã đăng nhập với quyền Admin", "Đăng nhập thành công");
                Page_quanlychung.Visible = true;
                Page_quanlylop.Visible = true;
                Page_thongke.Visible = true;
                bt_Dangxuat.Enabled = true;
                bt_DangNhap.Enabled = false;
                tb_MaTaiKhoan.Text = "";
                tb_MauKhau.Text = "";
            }
            else if (bll.CheckID("select * from TaiKhoan where MaTk='" + TaiKhoan + "' and MatKhau='" + MatKhau + "' and PhanQuyen='"+PhanQuyenguest+"'") == 1)
            {
                MessageBox.Show("Đã đăng nhập với quyền User", "Đăng nhập thành công");
                // tiep tuc cac tuy chon o day
                Page_quanlychung.Visible = false;
                Page_quanlylop.Visible = true;
                Page_thongke.Visible = true;
                bt_Dangxuat.Enabled = true;
                bt_DangNhap.Enabled = false;
                tb_MaTaiKhoan.Text = "";
                tb_MauKhau.Text = "";
            }
            else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Đăng nhập thất bại");
        }

        private void bt_QuanlyTaikhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_Taikhoan qltk = new Form_Taikhoan();
            qltk.Show();
        }

        private void bt_HocVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm_Hocvien hv = new XtraForm_Hocvien();
            hv.Show();
        }

        private void bt_Dangxuat_Click(object sender, EventArgs e)
        {
            Page_quanlychung.Visible = false;
            Page_quanlylop.Visible = false;
            Page_thongke.Visible = false;
            bt_DangNhap.Enabled = true;
            tb_MaTaiKhoan.Text = "";
            tb_MauKhau.Text = "";
            TaiKhoan = String.Empty;
        }

        private void bt_Gvcn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_Gvcn gvcn = new Form_Gvcn();
            gvcn.Show();
        }

        private void bt_Khoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_Khoahoc Khoa = new Form_Khoahoc();
            Khoa.Show();
        }

        private void bt_ChuyenNganh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_ChuyenNganh cn = new Form_ChuyenNganh();
            cn.Show();
        }

        private void bt_Lop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_Lop lop = new Form_Lop();
            lop.Show();
        }

        private void bt_DiemCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_DiemCong dc = new Form_DiemCong();
            dc.Show();
        }

        private void tb_MauKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bt_DangNhap.PerformClick();
        }

        private void tb_MaTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tb_MauKhau.PerformLayout();
        }

        private void bt_DiemTru_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_DiemTru dt = new Form_DiemTru();
            dt.Show();
        }

        private void btThongtin_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_Thongtintacgia tttg = new Form_Thongtintacgia();
            tttg.Show();
        }

        private void bt_Diem_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm_Thang diem = new XtraForm_Thang();
            diem.Show();
        }

        private void bt_tk_Lop_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReportPrintTool printTool = new ReportPrintTool(new Thongkenamlop());
            printTool.Report.CreateDocument(false);
            printTool.PreviewForm.Load += new EventHandler(PreviewForm_Load);
            printTool.ShowPreviewDialog();
        }

        private void bt_tk_Hocvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReportPrintTool printTool = new ReportPrintTool(new ThongkeHocvien());
            printTool.Report.CreateDocument(false);
            printTool.PreviewForm.Load += new EventHandler(PreviewForm_Load);
            printTool.ShowPreviewDialog();
        }

        private void bt_Thanhtich_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReportPrintTool printTool = new ReportPrintTool(new ThongkeThanhtich());
            printTool.Report.CreateDocument(false);
            printTool.PreviewForm.Load += new EventHandler(PreviewForm_Load);
            printTool.ShowPreviewDialog();
            //ThongkeThanhtich tktt = new ThongkeThanhtich();
            //tktt.Show();
        }

        private void bt_Vipham_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReportPrintTool printTool = new ReportPrintTool(new ThongkeVipham());
            printTool.Report.CreateDocument(false);
            printTool.PreviewForm.Load += new EventHandler(PreviewForm_Load);
            printTool.ShowPreviewDialog();
        }
        void PreviewForm_Load(object sender, EventArgs e)
        {
            PrintPreviewFormEx frm = (PrintPreviewFormEx)sender;
            frm.PrintingSystem.ExecCommand(PrintingSystemCommand.Scale, new object[] { 0.7f });
        }

        private void bt_Phanmem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;

            startInfo.FileName = @"C:\Users\Administrator\Desktop\ChucNang.pdf";
            process.Start();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReportPrintTool printTool = new ReportPrintTool(new Thongkehockilop());
            printTool.Report.CreateDocument(false);
            printTool.PreviewForm.Load += new EventHandler(PreviewForm_Load);
            printTool.ShowPreviewDialog();
        }

    }
}