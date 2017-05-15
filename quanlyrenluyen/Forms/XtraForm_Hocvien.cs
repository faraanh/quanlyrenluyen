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
            // TODO: This line of code loads data into the 'ketquarenluyenDataSet.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.ketquarenluyenDataSet.Lop);
            // TODO: This line of code loads data into the 'ketquarenluyenDataSet.HocVien' table. You can move, or remove it, as needed.
            this.hocVienTableAdapter.Fill(this.ketquarenluyenDataSet.HocVien);
            Load_Data();
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
                        //if (txtImage.Text.Trim() != null) saveImage();
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
                        //if (txtImage.Text.Trim() != null) saveImage();
                    }
                }
                else if (key == 3)
                {
                    if (b.CheckID("select * from HocVien where MaHv='" + hv.MaHv1 + "'") == 0)
                        MessageBox.Show("Chưa tồn tại Mã học viên này ", "Lỗi");
                    else
                    {
                        b.QueryIDU("delete from HocVien where  MaLop='" + hv.MaLop1 + "'");
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
                Image newImage = ByteArrayToImage((byte[])dataGridView1.CurrentRow.Cells[6].Value);
                pictureBox1.Image = newImage;
            }
            else
                pictureBox1.Image = null;
                
        }
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            //MemoryStream ms = new MemoryStream(byteArrayIn);
            //Image returnimage = System.Drawing.Image.FromStream(ms);
            using (var ms = new System.IO.MemoryStream(byteArrayIn))
            {
                ms.Position = 0;
                using (var img = System.Drawing.Image.FromStream(ms, true))
                {
                    return img;
                }
            }
            //return returnimage;
        }
        private void btChonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdOpenFile = new OpenFileDialog();
            ofdOpenFile.Filter = "JPG|*.jpg|PNG|*.png|GIF|*.gif|All Files (*.*)|*.*";
            if (ofdOpenFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofdOpenFile.FileName;
                txtImage.Text = ofdOpenFile.FileName;
                ofdOpenFile.Dispose();
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

        private byte[] Image2Byte(string Fullfilename)
        {
            FileStream fs;
            BinaryReader br;
            byte[] imgbyte;

            if (!File.Exists(Fullfilename)) { return null; }
            fs = new FileStream(Fullfilename, FileMode.Open);
            br = new BinaryReader(fs);
            imgbyte = new byte[fs.Length];
            imgbyte = br.ReadBytes(Convert.ToInt32((fs.Length)));
            br.Close(); fs.Close(); return imgbyte;
        }
        private void saveImage()
        {
            string strcon = @"Data Source=Administrator;Initial Catalog=ketquarenluyen;Integrated Security=True";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            byte[] image = Image2Byte(txtImage.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"update HocVien set Image=@imagedata where MaHv=@idx";
            cmd.Parameters.Add("@idx", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add("@imagedata", SqlDbType.Image, int.MaxValue);
            cmd.Parameters["@idx"].Value = tbMahocvien.Text.Trim();
            cmd.Parameters["@imagedata"].Value = image;
            cmd.ExecuteNonQuery();
            //da.InsertCommand = new SqlCommand("INSERT INTO Anh(ID,hinh) VALUES ('1',@image)", con);
            //da.InsertCommand.ExecuteNonQuery();
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