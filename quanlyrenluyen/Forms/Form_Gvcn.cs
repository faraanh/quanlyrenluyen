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
    public partial class Form_Gvcn : DevExpress.XtraEditors.XtraForm
    {
        public Form_Gvcn()
        {
            InitializeComponent();
        }
        
        private int key = 0;

        private void lb_Matkhau_Click(object sender, EventArgs e)
        {

        }

        private void Form_Gvcn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ketquarenluyenDataSet.Gvcn' table. You can move, or remove it, as needed.
            this.gvcnTableAdapter.Fill(this.ketquarenluyenDataSet.Gvcn);
            Load_Data();
            bt_Luu.Enabled = false;
        }
        public void Load_Data()
        {
            DataConfig config = new DataConfig();
            dataGrv_Gvcn.DataSource = config.GetData("select * from Gvcn");
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
                Entity_Gvcn gv = new Entity_Gvcn();
                BLL b = new BLL();
                gv.MaGvcn1 = maGvcnTextEdit.Text.Trim();
                gv.MaTk1 = maTkTextEdit.Text.Trim();
                gv.TenGvcn1 = tenGvcnTextEdit.Text.Trim();
                //-------------------------------------------

                if (key == 1)
                {
                    if (b.CheckID("select * from Gvcn where MaGvcn='" + gv.MaGvcn1 + "'") > 0)
                        MessageBox.Show("Đã tồn tại Mã Gvcn này", "Lỗi");
                    else if (gv.MaGvcn1 == null)
                        MessageBox.Show("Mã Gvcn không được để trống", "Lỗi");
                    else
                        b.QueryIDU("insert into Gvcn values('" + gv.MaGvcn1 + "',N'" + gv.TenGvcn1 + "','" + gv.MaTk1 + "')");
                }
                else if (key == 2)
                {
                    if (b.CheckID("select * from Gvcn where MaGvcn='" + gv.MaGvcn1 + "'") == 0)
                        MessageBox.Show("Không tồn tại Mã Gvcn này", "Lỗi");
                    else
                        b.QueryIDU("update Gvcn set TenGvcn=N'" + gv.TenGvcn1 + "',MaTk='" + gv.MaTk1 + "' where MaGvcn='" + gv.MaGvcn1 + "'");
                }
                else if (key == 3)
                {
                    if (b.CheckID("select * from Gvcn where MaGvcn='" + gv.MaGvcn1 + "'") == 0)
                        MessageBox.Show("Không tồn tại Mã Gvcn này", "Lỗi");
                    else if (b.CheckID("select MaGvcn from Lop where MaGvcn='" + gv.MaGvcn1 + "'") > 0)
                        MessageBox.Show("Không xóa được Gvcn này \nĐể thực hiện cần xóa hết dữ liệu tham chiếu!\nDữ liệu tham chiếu được tìm thấy trong Cơ sở dữ liệu Lớp", "Lỗi");
                    else
                        b.QueryIDU("delete from Gvcn where MaGvcn='" + gv.MaGvcn1 + "'");
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
            this.gvcnBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ketquarenluyenDataSet);

        }

        private void dataGrv_Gvcn_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                maGvcnTextEdit.Text = dataGrv_Gvcn[0, dong].Value.ToString();
                tenGvcnTextEdit.Text = dataGrv_Gvcn[1, dong].Value.ToString();
                maTkTextEdit.Text = dataGrv_Gvcn[2, dong].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi");
            }
        
        }
    }
}