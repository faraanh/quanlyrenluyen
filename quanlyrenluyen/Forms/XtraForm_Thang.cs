using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using quanlyrenluyen.DataAccess;
using quanlyrenluyen.Business;
using quanlyrenluyen.Entity;


namespace quanlyrenluyen.Forms
{
    public partial class XtraForm_Thang : DevExpress.XtraEditors.XtraForm
    {
        private int key = 0;
        public static string MaGvcn = String.Empty;
        public XtraForm_Thang()
        {
            InitializeComponent();
        }

        private void XtraForm_Thang_Load(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            for (int i = 1; i < 20; i++)
            {
                System.Threading.Thread.Sleep(100);
            }
            // TODO: This line of code loads data into the 'ketquarenluyenDataSet2.renluyen' table. You can move, or remove it, as needed.
            this.renluyenTableAdapter.Fill(this.ketquarenluyenDataSet2.renluyen);
            // TODO: This line of code loads data into the 'ketquarenluyenDataSet1.View_1' table. You can move, or remove it, as needed.
            this.view_1TableAdapter.Fill(this.ketquarenluyenDataSet1.View_1);
            // TODO: This line of code loads data into the 'ketquarenluyenDataSet.DiemCong' table. You can move, or remove it, as needed.
            this.diemCongTableAdapter.Fill(this.ketquarenluyenDataSet.DiemCong);
            // TODO: This line of code loads data into the 'ketquarenluyenDataSet.DiemTru' table. You can move, or remove it, as needed.
            this.diemTruTableAdapter.Fill(this.ketquarenluyenDataSet.DiemTru);
            Load_Data();
            splashScreenManager1.CloseWaitForm();
        }
        public void Load_Data()
        {
            try
            {
                DataConfig config = new DataConfig();
                BLL b = new BLL();
                if (ssni.TaiKhoan != "TKLdao")
                {
                    MaGvcn = b.GetValues("select MaGvcn from Gvcn where MaTk='" + ssni.TaiKhoan + "'", 0, 0);
                    dataGridView1.DataSource = config.GetData("SELECT dbo.HocVien.HoTen AS [Họ tên], dbo.Diem.ThangNam AS [Ngày ghi nhận], dbo.DiemCong.TenDiemCong AS [Thành tích], dbo.DiemTru.TenDiemTru AS [Vi phạm]FROM  dbo.HocVien INNER JOIN dbo.Lop ON dbo.HocVien.MaLop = dbo.Lop.MaLop RIGHT OUTER JOIN dbo.Diem INNER JOIN dbo.DiemCong ON dbo.Diem.MaDiemCong = dbo.DiemCong.MaDiemCong LEFT OUTER JOIN dbo.DiemTru ON dbo.Diem.MaDiemTru = dbo.DiemTru.MaDiemTru ON dbo.HocVien.MaHv = dbo.Diem.MaHv WHERE  (dbo.Lop.MaGvcn = '"+MaGvcn+"')");
                }
                else
                dataGridView1.DataSource = config.GetData("SELECT dbo.HocVien.HoTen AS [Họ tên], dbo.Diem.ThangNam AS [Ngày ghi nhận], dbo.DiemCong.TenDiemCong AS [Thành tích], dbo.DiemTru.TenDiemTru AS [Vi phạm] FROM dbo.Diem INNER JOIN dbo.DiemCong ON dbo.Diem.MaDiemCong = dbo.DiemCong.MaDiemCong LEFT OUTER JOIN  dbo.DiemTru ON dbo.Diem.MaDiemTru = dbo.DiemTru.MaDiemTru LEFT OUTER JOIN  dbo.HocVien ON dbo.Diem.MaHv = dbo.HocVien.MaHv ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi");
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            maHvTextEdit.Text = dataGridView1[0, dong].Value.ToString();
            dateTimePicker1.Text = dataGridView1[1, dong].Value.ToString();
            cbbDiemcong.Text = dataGridView1[2, dong].Value.ToString();
            cbbDiemtru.Text = dataGridView1[3, dong].Value.ToString();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_Luu_Click_1(object sender, EventArgs e)
        {
            try
            {
                Entity_Diem dm = new Entity_Diem();
                BLL b = new BLL();
                if (b.CheckID("select MaHv from HocVien where HoTen like N'" + maHvTextEdit.Text.Trim() + "'") > 0)
                    dm.Mahv = b.GetValues("select MaHv from HocVien where HoTen like N'" + maHvTextEdit.Text.Trim() + "'", 0, 0);
                dm.Thangnam = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                if (b.CheckID("select MaDiemCong from DiemCong where TenDiemCong like N'" + cbbDiemcong.Text.Trim() + "'") > 0)
                    dm.Madiemcong = b.GetValues("select MaDiemCong from DiemCong where TenDiemCong like N'" + cbbDiemcong.Text.Trim() + "'", 0, 0);
                if (b.CheckID("select MaDiemTru from DiemTru where TenDiemTru like N'" + cbbDiemtru.Text.Trim() + "'") > 0)
                    dm.Madiemtru = b.GetValues("select MaDiemTru from DiemTru where TenDiemTru like N'" + cbbDiemtru.Text.Trim() + "'", 0, 0);
                //-------------------------------------------

                if (key == 1)
                {
                    if (b.CheckID("select * from Diem where MaHv='" + dm.Mahv + "' and ThangNam='" + dm.Thangnam + "'") > 0)
                        MessageBox.Show("Đã tồn tại Mã học viên trong tháng ", "Lỗi");
                    else if (dm.Mahv == null)
                        MessageBox.Show("Mã học viên không được để trống", "Lỗi");
                    else if (dm.Thangnam == null)
                        MessageBox.Show("Thời gian không được để trống", "Lỗi");
                    else
                    {
                        b.QueryIDU("insert into Diem (MaHv, ThangNam, MaDiemCong, MaDiemTru) values('" + dm.Mahv + "','" + dm.Thangnam + "','kkkk','kkkk')");
                        if (dm.Madiemcong != null)
                            b.QueryIDU("update Diem set MaDiemCong='" + dm.Madiemcong + "' where MaHv='" + dm.Mahv + "' and  ThangNam='" + dm.Thangnam + "'");
                        if (dm.Madiemtru != null)
                            b.QueryIDU("update Diem set MaDiemTru='" + dm.Madiemtru + "' where MaHv='" + dm.Mahv + "' and  ThangNam='" + dm.Thangnam + "'");
                    }

                }
                else if (key == 2)
                {
                    if (b.CheckID("select * from Diem where MaHv='" + dm.Mahv + "' and ThangNam='" + dm.Thangnam + "'") == 0)
                        MessageBox.Show("Không tồn tại Mã học viên trong tháng để cập nhật", "Lỗi");
                    else if (dm.Mahv == null)
                        MessageBox.Show("Mã học viên không được để trống", "Lỗi");
                    else if (dm.Thangnam == null)
                        MessageBox.Show("Thời gian không được để trống", "Lỗi");
                    else
                    {
                        if (dm.Madiemcong != null)
                            b.QueryIDU("update Diem set MaDiemCong='" + dm.Madiemcong + "' where MaHv='" + dm.Mahv + "' and  ThangNam='" + dm.Thangnam + "'");
                        if (dm.Madiemtru != null)
                            b.QueryIDU("update Diem set MaDiemTru='" + dm.Madiemtru + "' where MaHv='" + dm.Mahv + "' and  ThangNam='" + dm.Thangnam + "'");
                    }
                }
                else if (key == 3)
                {
                    if (b.CheckID("select * from Diem where MaHv='" + dm.Mahv + "' and ThangNam='" + dm.Thangnam + "'") == 0)
                        MessageBox.Show("Không tồn tại Mã học viên trong tháng để xóa", "Lỗi");
                    else if (dm.Mahv == null)
                        MessageBox.Show("Mã học viên không được để trống", "Lỗi");
                    else if (dm.Thangnam == null)
                        MessageBox.Show("Thời gian không được để trống", "Lỗi");
                    else
                    {
                        b.QueryIDU("delete from Diem  where MaHv='" + dm.Mahv + "' and ThangNam='" + dm.Thangnam + "'");
                    }
                }
                //-----------------------------------------------
                key = 0;
                bt_Luu.Enabled = false;
                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi");
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            key = 1;
            bt_Luu.Enabled = true;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            key = 2;
            bt_Luu.Enabled = true;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            key = 3;
            bt_Luu.Enabled = true;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string dk = txtTimKiem.Text.Trim();
            BLL b = new BLL();
            DataConfig config = new DataConfig();
            if (this.txtTimKiem.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm");
            else if (cbbTimkiem.Text == "Học viên")
            {
                string MaHv = b.GetValues("select MaHv from Hocvien Where HoTen like N'%" + dk + "%'",0,0);
                string strsql = "SELECT dbo.HocVien.HoTen AS [Họ tên], dbo.Diem.ThangNam AS [Ngày ghi nhận], dbo.DiemCong.TenDiemCong AS [Thành tích], dbo.DiemTru.TenDiemTru AS [Vi phạm] FROM dbo.Diem INNER JOIN dbo.DiemCong ON dbo.Diem.MaDiemCong = dbo.DiemCong.MaDiemCong LEFT OUTER JOIN  dbo.DiemTru ON dbo.Diem.MaDiemTru = dbo.DiemTru.MaDiemTru LEFT OUTER JOIN  dbo.HocVien ON dbo.Diem.MaHv = dbo.HocVien.MaHv where Hocvien.MaHv = '" + MaHv + "'";
                dataGridView1.DataSource = config.GetData(strsql);
            }
            else if (cbbTimkiem.Text == "Tháng")
            {
                
                string strsql = "SELECT dbo.HocVien.HoTen AS [Họ tên], dbo.Diem.ThangNam AS [Ngày ghi nhận], dbo.DiemCong.TenDiemCong AS [Thành tích], dbo.DiemTru.TenDiemTru AS [Vi phạm] FROM dbo.Diem INNER JOIN dbo.DiemCong ON dbo.Diem.MaDiemCong = dbo.DiemCong.MaDiemCong LEFT OUTER JOIN  dbo.DiemTru ON dbo.Diem.MaDiemTru = dbo.DiemTru.MaDiemTru LEFT OUTER JOIN  dbo.HocVien ON dbo.Diem.MaHv = dbo.HocVien.MaHv where month(ThangNam) like '" + txtTimKiem.Text + "'";
                dataGridView1.DataSource = config.GetData(strsql);
            }
            else if (cbbTimkiem.Text == "Năm")
            {
                string strsql = "SELECT dbo.HocVien.HoTen AS [Họ tên], dbo.Diem.ThangNam AS [Ngày ghi nhận], dbo.DiemCong.TenDiemCong AS [Thành tích], dbo.DiemTru.TenDiemTru AS [Vi phạm] FROM dbo.Diem INNER JOIN dbo.DiemCong ON dbo.Diem.MaDiemCong = dbo.DiemCong.MaDiemCong LEFT OUTER JOIN  dbo.DiemTru ON dbo.Diem.MaDiemTru = dbo.DiemTru.MaDiemTru LEFT OUTER JOIN  dbo.HocVien ON dbo.Diem.MaHv = dbo.HocVien.MaHv where year(ThangNam) like '" + txtTimKiem.Text + "'";
                dataGridView1.DataSource = config.GetData(strsql);
            }
            else
            {
                MessageBox.Show("Chưa nhập tiêu chí tìm kiếm", "Thông báo");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            btTimkiem.Enabled = true;
        }
      
    }
}