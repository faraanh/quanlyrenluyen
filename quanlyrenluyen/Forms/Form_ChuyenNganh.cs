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
    public partial class Form_ChuyenNganh : DevExpress.XtraEditors.XtraForm
    {
        public Form_ChuyenNganh()
        {
            InitializeComponent();
        }
        
        private int key = 0;

        private void Form_ChuyenNganh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ketquarenluyenDataSet.ChuyenNganh' table. You can move, or remove it, as needed.
            this.chuyenNganhTableAdapter.Fill(this.ketquarenluyenDataSet.ChuyenNganh);
            Load_Data();
            bt_Luu.Enabled = false;
        }
        public void Load_Data()
        {
            DataConfig config = new DataConfig();
            dataGrv_ChuyenNganh.DataSource = config.GetData("select * from ChuyenNganh");
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
                Entity_ChuyenNganh cn = new Entity_ChuyenNganh();
                BLL b = new BLL();
                cn.Manganh1 = maNganhTextEdit.Text.Trim();
                cn.Tencn1 = tenChuyenNganhTextEdit.Text.Trim();
                //-------------------------------------------

                if (key == 1)
                {
                    if (b.CheckID("select * from ChuyenNganh where MaNganh='" + cn.Manganh1 + "'") > 0)
                        MessageBox.Show("Đã tồn tại Mã Chuyên ngành này", "Lỗi");
                    else if (cn.Manganh1 == null)
                        MessageBox.Show("Mã ngành không được để trống", "Lỗi");
                    else
                        b.QueryIDU("insert into ChuyenNganh values('" + cn.Manganh1 + "',N'" + cn.Tencn1 + "')");
                }
                else if (key == 2)
                {
                    if (b.CheckID("select * from ChuyenNganh where MaNganh='" + cn.Manganh1 + "'") == 0)
                        MessageBox.Show("Không tồn tại Mã ngành này", "Lỗi");
                    else
                        b.QueryIDU("update ChuyenNganh set TenChuyenNganh=N'" + cn.Tencn1 + "' where MaNganh='" + cn.Manganh1 + "'");
                }
                else if (key == 3)
                {
                    if (b.CheckID("select * from ChuyenNganh where MaNganh='" + cn.Manganh1 + "'") == 0)
                        MessageBox.Show("Không tồn tại Mã Chuyên ngành này", "Lỗi");
                    else
                        b.QueryIDU("delete from cncn where Macncn='" + cn.Manganh1 + "'");
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

        private void cncnBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chuyenNganhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ketquarenluyenDataSet);

        }

        private void dataGrv_ChuyenNganh_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                maNganhTextEdit.Text = dataGrv_ChuyenNganh[0, dong].Value.ToString();
                tenChuyenNganhTextEdit.Text = dataGrv_ChuyenNganh[1, dong].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi");
            }
        
        }
    }
}