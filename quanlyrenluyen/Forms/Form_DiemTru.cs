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
    public partial class Form_DiemTru : DevExpress.XtraEditors.XtraForm
    {
        public Form_DiemTru()
        {
            InitializeComponent();
        }
        
        private int key = 0;

        private void lb_Matkhau_Click(object sender, EventArgs e)
        {

        }

        private void Form_Gvcn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ketquarenluyenDataSet.DiemTru' table. You can move, or remove it, as needed.
            this.diemTruTableAdapter.Fill(this.ketquarenluyenDataSet.DiemTru);
            Load_Data();
            bt_Luu.Enabled = false;
        }
        public void Load_Data()
        {
            DataConfig config = new DataConfig();
            dataGrv_Diemtru.DataSource = config.GetData("select * from DiemTru");
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
                Entity_DiemTru dc = new Entity_DiemTru();
                BLL b = new BLL();
                dc.Madiem = maDiemTruTextEdit.Text.Trim();
                dc.Tendiem = tenDiemTruTextEdit.Text.Trim();
                //-------------------------------------------

                if (key == 1)
                {
                    if (b.CheckID("select * from DiemTru where MaDiemTru='" + dc.Madiem + "'") > 0)
                        MessageBox.Show("Đã tồn tại Mã điểm cộng này", "Lỗi");
                    else if (dc.Madiem == null)
                        MessageBox.Show("Mã điểm cộng không được để trống", "Lỗi");
                    else
                        b.QueryIDU("insert into DiemTru values('" + dc.Madiem + "',N'" + dc.Tendiem + "','" + diemTruTextEdit.Text + "')");
                }
                else if (key == 2)
                {
                    if (b.CheckID("select * from DiemTru where MaDiemTru='" + dc.Madiem + "'") == 0)
                        MessageBox.Show("Không tồn tại Mã điểm cộng này", "Lỗi");
                    else
                        b.QueryIDU("update DiemTru set TenDiemTru=N'" + dc.Tendiem + "',DiemTru='" + diemTruTextEdit.Text + "' where MaDiemTru='" + dc.Madiem + "'");
                }
                else if (key == 3)
                {
                    if (b.CheckID("select * from DiemTru where MaDiemTru='" + dc.Madiem + "'") == 0)
                        MessageBox.Show("Không tồn tại Mã điểm cộng này", "Lỗi");
                    else
                        b.QueryIDU("delete from DiemTru where MaDiemTru='" + dc.Madiem + "'");
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
            this.diemTruBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ketquarenluyenDataSet);
        }

        private void dataGrv_Gvcn_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                maDiemTruTextEdit.Text = dataGrv_Diemtru[0, dong].Value.ToString();
                tenDiemTruTextEdit.Text = dataGrv_Diemtru[1, dong].Value.ToString();
                diemTruTextEdit.Text = dataGrv_Diemtru[2, dong].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi");
            }
        
        }
    }
}