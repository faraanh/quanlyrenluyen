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
using quanlyrenluyen.Entity;
using quanlyrenluyen.Business;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace quanlyrenluyen.Forms
{
    public partial class XtraForm_Hocvien : DevExpress.XtraEditors.XtraForm
    {
        public static string MaGvcn = String.Empty;
        private int key = 0;
        public XtraForm_Hocvien()
        {
            InitializeComponent();
        }

        private void XtraForm_Hocvien_Load(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            for (int i = 1; i < 20; i++)
            {
                System.Threading.Thread.Sleep(100);
            }
            // TODO: This line of code loads data into the 'ketquarenluyenDataSet.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.ketquarenluyenDataSet.Lop);
            // TODO: This line of code loads data into the 'ketquarenluyenDataSet.HocVien' table. You can move, or remove it, as needed.
            this.hocVienTableAdapter.Fill(this.ketquarenluyenDataSet.HocVien);
            Load_Data();
            splashScreenManager1.CloseWaitForm();
            txtImage.Text = null;
        }

        public void Load_Data()
        {
            try
            {
                DataConfig config = new DataConfig();
                BLL b = new BLL();
                if (ssni.TaiKhoan!="TKLdao")
                {
                    MaGvcn = b.GetValues("select MaGvcn from Gvcn where MaTk='" + ssni.TaiKhoan + "'", 0, 0);
                    dataGridView1.DataSource = config.GetData("SELECT * FROM HocVien INNER JOIN Lop ON HocVien.MaLop = Lop.MaLop WHERE Lop.MaGvcn = '"+MaGvcn+"'");
                }
                else
                dataGridView1.DataSource = config.GetData("select * from HocVien");
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

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                Entity_HocVien hv = new Entity_HocVien();
                BLL b = new BLL();
                hv.MaHv1 = tbMahocvien.Text.Trim();
                hv.HoTen1 = tbHoten.Text.Trim();
                hv.QueQuan1 = tbQuequan.Text.Trim();
                hv.MaLop1 = cbbMalop.Text.Trim();
             
                hv.NgaySinh1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                if (rdbNam.Checked == true) hv.GioiTinh1 = true; else hv.GioiTinh1 = false;
             
                //-------------------------------------------

                if (key == 1)
                {
                    if (b.CheckID("select * from HocVien where MaHv='" + hv.MaHv1 + "'") > 0)
                        MessageBox.Show("Đã tồn tại Mã học viên này ", "Lỗi");
                    else if (hv.MaHv1 == null)
                        MessageBox.Show("Mã học viên không được để trống", "Lỗi");
                    else if (hv.MaLop1 == null)
                        MessageBox.Show("Mã lớp không được để trống", "Lỗi");
                    else if (hv.HoTen1 == null)
                        MessageBox.Show("Họ tên học viên không được để trống", "Lỗi");
                    else
                    {
                        if (ssni.TaiKhoan!="TKLdao")
                        {
                            if (b.GetValues("select MaGvcn from Lop where MaLop='" + cbbMalop.Text.Trim() + "'", 0, 0) != MaGvcn)
                            {
                                MessageBox.Show("Đồng chí không chủ nhiệm lớp này", "Lỗi");
                                cbbMalop.Text = hv.MaLop1;
                            }
                            else
                                b.QueryIDU("insert into HocVien (MaHv, MaLop, HoTen, GioiTinh, NgaySinh, QueQuan) values('" + hv.MaHv1 + "','" + hv.MaLop1 + "',N'" + hv.HoTen1 + "','" + hv.GioiTinh1 + "','" + hv.NgaySinh1 + "',N'" + hv.QueQuan1 + "')");
                        }
                        else
                        b.QueryIDU("insert into HocVien (MaHv, MaLop, HoTen, GioiTinh, NgaySinh, QueQuan) values('" + hv.MaHv1 + "','" + hv.MaLop1 + "',N'"+hv.HoTen1+"','"+hv.GioiTinh1+"','"+hv.NgaySinh1+"',N'"+hv.QueQuan1+"')");
                        if (txtImage.Text.Trim() != "") saveImage();
                    }
                }
                else if (key == 2)
                {
                    if (b.CheckID("select * from HocVien where MaHv='" + hv.MaHv1 + "'") == 0)
                        MessageBox.Show("Chưa tồn tại Mã học viên này ", "Lỗi");
                    else if (hv.MaHv1 == null)
                        MessageBox.Show("Mã học viên không được để trống", "Lỗi");
                    else if (hv.MaLop1 == null)
                        MessageBox.Show("Mã lớp không được để trống", "Lỗi");
                    else if (hv.HoTen1 == null)
                        MessageBox.Show("Họ tên học viên không được để trống", "Lỗi");
                    else
                    {
                        if (ssni.TaiKhoan != "TKLdao")
                        {
                            if (b.GetValues("select MaGvcn from Lop where MaLop='" + cbbMalop.Text.Trim() + "'", 0, 0) != MaGvcn)
                            {
                                MessageBox.Show("Đồng chí không chủ nhiệm lớp này", "Lỗi");
                                cbbMalop.Text = hv.MaLop1;
                            }
                            else
                                b.QueryIDU("update HocVien set  MaLop='" + hv.MaLop1 + "', HoTen=N'" + hv.HoTen1 + "', GioiTinh='" + hv.GioiTinh1 + "', NgaySinh='" + hv.NgaySinh1 + "', QueQuan=N'" + hv.QueQuan1 + "' where MaHv='" + hv.MaHv1 + "'");
                        }
                        else
                        b.QueryIDU("update HocVien set  MaLop='" + hv.MaLop1 + "', HoTen=N'" + hv.HoTen1 + "', GioiTinh='" + hv.GioiTinh1 + "', NgaySinh='" + hv.NgaySinh1+"', QueQuan=N'" + hv.QueQuan1 + "' where MaHv='" + hv.MaHv1+ "'");
                        if (txtImage.Text.Trim() != "") saveImage();
                    }
                }
                else if (key == 3)
                {
                    if (b.CheckID("select * from HocVien where MaHv='" + hv.MaHv1 + "'") == 0)
                        MessageBox.Show("Chưa tồn tại Mã học viên này ", "Lỗi");
                    else if (b.CheckID("select MaHv from Diem where  MaHv='" + hv.MaHv1 + "'") > 0)
                        MessageBox.Show("Không xóa được Học viên này \nĐể thực hiện cần xóa hết dữ liệu tham chiếu!\nDữ liệu tham chiếu được tìm thấy trong Cơ sở dữ liệu Theo dõi rèn luyện", "Lỗi");
                    else
                    {
                        b.QueryIDU("delete from HocVien where  MaHv='" + hv.MaHv1+ "'");
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                tbMahocvien.Text = dataGridView1[0, dong].Value.ToString();
                cbbMalop.Text = dataGridView1[1, dong].Value.ToString();
                tbHoten.Text = dataGridView1[2, dong].Value.ToString();
                if (dataGridView1[3, dong].Value.ToString() == "True")
                    rdbNam.Checked = true;
                else rdbNu.Checked = true;
                dateTimePicker1.Text = dataGridView1[4, dong].Value.ToString();
                tbQuequan.Text = dataGridView1[5, dong].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[6].Value != DBNull.Value)
                {

                    pictureBox1.Image = ByteArrayToImage((byte[]) dataGridView1[6, dong].Value);
                }
                else
                    pictureBox1.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi");
            }
            
            
        }
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }
        private void btChonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDlg = new OpenFileDialog();
            openfileDlg.Filter = openfileDlg.Filter="JPG files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            openfileDlg.FilterIndex = 1;
            openfileDlg.RestoreDirectory = true;
            if (openfileDlg.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = openfileDlg.FileName;
                txtImage.Text = openfileDlg.FileName;
            }
        }


        private void btTimkiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string dk = txtTimKiem.Text.Trim();
            DataConfig config = new DataConfig();
            if (this.txtTimKiem.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm");
            else if (cbbTimkiem.Text == "Mã học viên")
            {
                string strsql = "select * from HocVien where MaHv like N'%" + dk+ "%'";
                dataGridView1.DataSource = config.GetData(strsql);
            }
            else if (cbbTimkiem.Text == "Lớp")
            {
                string strsql = "select * from HocVien where MaLop like N'%" + dk + "%'";
                dataGridView1.DataSource = config.GetData(strsql);
            }
            else if (cbbTimkiem.Text == "Tên")
            {
                string strsql = "select * from HocVien where HoTen like N'%" + dk + "%'";
                dataGridView1.DataSource = config.GetData(strsql);
            }
            else
            {
                Load_Data();
            }
        }

        private byte[] convertImageToBytes()
        {
            FileStream fs;
            fs = new FileStream(txtImage.Text, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
        private void saveImage()
        {
            try
            {
                string strcon = @"Data Source=Administrator;Initial Catalog=ketquarenluyen;Integrated Security=True";
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                string strsql = "update Hocvien set Image=@Image where MaHv='"+tbMahocvien.Text.Trim()+"'";
                SqlCommand com = new SqlCommand(strsql, con);
                com.Parameters.AddWithValue("@Image", convertImageToBytes());
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi");
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cbbTimkiem.Text != null)
                btTimkiem.Enabled = true;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void cbbMalop_TextChanged(object sender, EventArgs e)
        {
            
        }  
    }
}