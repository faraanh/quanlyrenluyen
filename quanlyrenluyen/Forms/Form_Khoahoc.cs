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
    public partial class Form_Khoahoc : DevExpress.XtraEditors.XtraForm
    {
        public Form_Khoahoc()
        {
            InitializeComponent();
        }

        private int key = 0;

        private void Form_Khoahoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ketquarenluyenDataSet.KhoaHoc' table. You can move, or remove it, as needed.
            this.khoaHocTableAdapter.Fill(this.ketquarenluyenDataSet.KhoaHoc);
            Load_Data();
            bt_Luu.Enabled = false;
        }
        public void Load_Data()
        {
            DataConfig config = new DataConfig();
            dataGrv_Khoahoc.DataSource = config.GetData("select * from KhoaHoc");
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
                Entity_Khoahoc kh = new Entity_Khoahoc();
                BLL b = new BLL();
                kh.MaKhoa1 = maKhoaTextEdit.Text.Trim();
                kh.NienKhoa1 = nienKhoaTextEdit.Text.Trim();
                //-------------------------------------------

                if (key == 1)
                {
                    if (b.CheckID("select * from KhoaHoc where MaKhoa='" + kh.MaKhoa1 + "'") > 0)
                        MessageBox.Show("Đã tồn tại Mã Khóa học này", "Lỗi");
                    else if (kh.MaKhoa1 == null)
                        MessageBox.Show("Mã KhoaHoc không được để trống", "Lỗi");
                    else
                        b.QueryIDU("insert into KhoaHoc values('" + kh.MaKhoa1 + "','" + kh.NienKhoa1 + "')");
                }
                else if (key == 2)
                {
                    if (b.CheckID("select * from KhoaHoc where MaKhoa='" + kh.MaKhoa1 + "'") == 0)
                        MessageBox.Show("Không tồn tại Mã Khóa học này", "Lỗi");
                    else
                        b.QueryIDU("update KhoaHoc set NienKhoa='" + kh.NienKhoa1 + "'");
                }
                else if (key == 3)
                {
                    if (b.CheckID("select * from KhoaHoc where MaKhoa='" + kh.MaKhoa1 + "'") == 0)
                        MessageBox.Show("Không tồn tại Mã Khóa học này", "Lỗi");
                    else if (b.CheckID("select MaKhoa from Lop where MaKhoa='" + kh.MaKhoa1 + "'") > 0)
                        MessageBox.Show("Không xóa được Khóa học này \nĐể thực hiện cần xóa hết dữ liệu tham chiếu!\nDữ liệu tham chiếu được tìm thấy trong Cơ sở dữ liệu của Lớp", "Lỗi");
                    else
                        b.QueryIDU("delete from KhoaHoc where MaKhoa='" + kh.MaKhoa1 + "'");
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

        private void KhoaHocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoaHocBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ketquarenluyenDataSet);

        }

        private void dataGrv_Khoahoc_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                maKhoaTextEdit.Text = dataGrv_Khoahoc[0, dong].Value.ToString();
                nienKhoaTextEdit.Text = dataGrv_Khoahoc[1, dong].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi");
            }
        }
    }
}