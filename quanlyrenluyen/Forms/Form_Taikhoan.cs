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
using System.Data.SqlClient;
using quanlyrenluyen.Entity;
using quanlyrenluyen.Business;

namespace quanlyrenluyen.Forms
{
    public partial class Form_Taikhoan : DevExpress.XtraEditors.XtraForm
    {
        public Form_Taikhoan()
        {
            InitializeComponent();
        }

        private int key = 0;

        private void lb_Matkhau_Click(object sender, EventArgs e)
        {

        }

        private void Form_Taikhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ketquarenluyenDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.ketquarenluyenDataSet.TaiKhoan);
            Load_Data();
            bt_Luu.Enabled = false;
        }
        public void Load_Data()
        {
            DataConfig config = new DataConfig();
            dataGrv_Taikhoan.DataSource = config.GetData("select * from TaiKhoan");
        }

        private void dataGrv_Taikhoan_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                tb_Mataikhoan.Text = dataGrv_Taikhoan[0, dong].Value.ToString();
                tb_Matkhau.Text = dataGrv_Taikhoan[1, dong].Value.ToString();
                tb_Phanquyen.Text = dataGrv_Taikhoan[2, dong].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi");
            }
        }

        private void bt_them_Click_1(object sender, EventArgs e)
        {
            key = 1;
            bt_Luu.Enabled = true;
        }

        private void bt_Sua_Click_1(object sender, EventArgs e)
        {
            key = 2;
            bt_Luu.Enabled = true;
        }

        private void bt_Xoa_Click_1(object sender, EventArgs e)
        {
            key = 3;
            bt_Luu.Enabled = true;
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                Entity_Taikhoan Tkhoan = new Entity_Taikhoan();
                BLL b = new BLL();
                Tkhoan.MaTk1 = tb_Mataikhoan.Text.Trim();
                Tkhoan.Matkhau1 = tb_Matkhau.Text.Trim();
                Tkhoan.Phanquyen1 = tb_Phanquyen.Text.Trim();
                //-------------------------------------------

                if (key == 1)
                {
                    if (b.CheckID("select * from TaiKhoan where MaTk='" + Tkhoan.MaTk1 + "'") > 0)
                        MessageBox.Show("Đã tồn tại Mã tài khoản này", "Lỗi");
                    else if (Tkhoan.MaTk1 == null)
                        MessageBox.Show("Mã tài khoản không được để trống", "Lỗi");
                    else if (Tkhoan.Phanquyen1 == null)
                        MessageBox.Show("Phân quyền không được để trống", "Lỗi");
                    else if (Tkhoan.Matkhau1 == null)
                        MessageBox.Show("Mật khẩu không được để trống", "Lỗi");
                    else
                        b.QueryIDU("insert into TaiKhoan values('" + Tkhoan.MaTk1 + "','" + Tkhoan.Matkhau1 + "','" + Tkhoan.Phanquyen1 + "')");
                }
                else if (key == 2)
                {
                    if (b.CheckID("select * from TaiKhoan where MaTk='" + Tkhoan.MaTk1 + "'") == 0)
                        MessageBox.Show("Không tồn tại Mã tài khoản này", "Lỗi");
                    else if (Tkhoan.Phanquyen1 == null)
                        MessageBox.Show("Phân quyền không được để trống", "Lỗi");
                    else if (Tkhoan.Matkhau1 == null)
                        MessageBox.Show("Mật khẩu không được để trống", "Lỗi");
                    else
                        b.QueryIDU("update TaiKhoan set MatKhau='" + Tkhoan.Matkhau1 + "',PhanQuyen='" + Tkhoan.Phanquyen1 + "' where MaTk='" + Tkhoan.MaTk1 + "'");
                }
                else if (key == 3)
                {
                    if (b.CheckID("select * from TaiKhoan where MaTk='" + Tkhoan.MaTk1 + "'") == 0)
                        MessageBox.Show("Không tồn tại Mã tài khoản này", "Lỗi");
                    else if (b.CheckID("select MaTk from Gvcn where MaTk='" + Tkhoan.MaTk1 + "'") > 0)
                        MessageBox.Show("Không xóa được Tài khoản này \nĐể thực hiện cần xóa hết dữ liệu tham chiếu!\nDữ liệu tham chiếu được tìm thấy trong Cơ sở dữ liệu của Gvcn", "Lỗi");
                    else
                        b.QueryIDU("delete from TaiKhoan where MaTk='" + Tkhoan.MaTk1 + "'");
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

        private void Form_Taikhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}