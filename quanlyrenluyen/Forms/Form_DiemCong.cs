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
    public partial class Form_DiemCong : DevExpress.XtraEditors.XtraForm
    {
        public Form_DiemCong()
        {
            InitializeComponent();
        }
        
        private int key = 0;

        private void lb_Matkhau_Click(object sender, EventArgs e)
        {

        }

        private void Form_Gvcn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ketquarenluyenDataSet.DiemCong' table. You can move, or remove it, as needed.
            this.diemCongTableAdapter.Fill(this.ketquarenluyenDataSet.DiemCong);
            Load_Data();
            bt_Luu.Enabled = false;
        }
        public void Load_Data()
        {
            DataConfig config = new DataConfig();
            dataGrv_Diemcong.DataSource = config.GetData("select * from DiemCong");
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
                Entity_DiemCong dc = new Entity_DiemCong();
                BLL b = new BLL();
                dc.Madiem = maDiemCongTextEdit.Text.Trim();
                dc.Tendiem = tenDiemCongTextEdit.Text.Trim();
                dc.Diem =(float) Convert.ToDouble( tb_diemcong.Text.Trim());
                dc.Diem /= 10;

                //-------------------------------------------

                if (key == 1)
                {
                    if (b.CheckID("select * from DiemCong where MaDiemCong='" + dc.Madiem + "'") > 0)
                        MessageBox.Show("Đã tồn tại Mã điểm cộng này", "Lỗi");
                    else if (dc.Madiem == null)
                        MessageBox.Show("Mã điểm cộng không được để trống", "Lỗi");
                    else
                        b.QueryIDU("insert into DiemCong values('" + dc.Madiem + "',N'" + dc.Tendiem + "','" + tb_diemcong.Text + "')");
                }
                else if (key == 2)
                {
                    if (b.CheckID("select * from DiemCong where MaDiemCong='" + dc.Madiem + "'") == 0)
                        MessageBox.Show("Không tồn tại Mã điểm cộng này", "Lỗi");
                    else
                        b.QueryIDU("update DiemCong set TenDiemCong=N'" + dc.Tendiem + "',DiemCong='" + tb_diemcong.Text + "' where MaDiemCong='" + dc.Madiem + "'");
                }
                else if (key == 3)
                {
                    if (b.CheckID("select * from DiemCong where MaDiemCong='" + dc.Madiem + "'") == 0)
                        MessageBox.Show("Không tồn tại Mã điểm cộng này", "Lỗi");
                    else if (b.CheckID("select MaDiemCong from Diem where MaDiemCong='" + dc.Madiem + "'") > 0)
                        MessageBox.Show("Không xóa được Mã điểm cộng này \nĐể thực hiện cần xóa hết dữ liệu tham chiếu!\nDữ liệu tham chiếu được tìm thấy trong Cơ sở dữ liệu Theo dõi rèn luyện", "Lỗi");
                    else
                        b.QueryIDU("delete from DiemCong where MaDiemCong='" + dc.Madiem + "'");
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

        private void gvcnBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.diemCongBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ketquarenluyenDataSet);
        }

        private void dataGrv_Gvcn_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                maDiemCongTextEdit.Text = dataGrv_Diemcong[0, dong].Value.ToString();
                tenDiemCongTextEdit.Text = dataGrv_Diemcong[1, dong].Value.ToString();
                tb_diemcong.Text = dataGrv_Diemcong[2, dong].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi");
            }
        
        }
    }
}