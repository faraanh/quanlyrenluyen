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
    public partial class Form_Lop : DevExpress.XtraEditors.XtraForm
    {
        public Form_Lop()
        {
            InitializeComponent();
        }
        
        private int key = 0;

        private void Add_Item_cbbManganh()
        {
            BLL bll = new BLL();
            string va="";
            int i=0;
            do
            {
                va = bll.GetValues("select MaNganh from ChuyenNganh", 0, i);
                cbbManganh.Items.Add(va);
                i++;
            }
            while (va != null);
        }
        private void Add_Item_cbbMaKhoa()
        {
            BLL bll = new BLL();
            string va="";
            int i = 0;
            do
            {
                va = bll.GetValues("select MaKhoa from KhoaHoc", 0, i);
                cbbMakhoa.Items.Add(va);
                i++;
            }
            while (va != null);
        }
        private void Add_Item_cbbMaGvcn()
        {
            BLL bll = new BLL();
            string va="";
            int i = 0;
            do
            {
                va = bll.GetValues("select MaGvcn from Gvcn", 0, i);
                //cbbMagvcn.Items.Add(va);
                i++;
            }
            while (va != null);
        }

        private void Form_Gvcn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ketquarenluyenDataSet.KhoaHoc' table. You can move, or remove it, as needed.
            this.khoaHocTableAdapter.Fill(this.ketquarenluyenDataSet.KhoaHoc);
            // TODO: This line of code loads data into the 'ketquarenluyenDataSet.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.ketquarenluyenDataSet.Lop);
            Load_Data();
            bt_Luu.Enabled = false;
            Add_Item_cbbManganh();
            Add_Item_cbbMaKhoa();
            Add_Item_cbbMaGvcn();
        }
        public void Load_Data()
        {
            DataConfig config = new DataConfig();
            dataGrv_Lop.DataSource = config.GetData("select * from Lop");
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
                Entity_Lop lop= new Entity_Lop();
                BLL b = new BLL();
                lop.Malop = maLopTextEdit.Text.Trim();
                lop.Manganh = cbbManganh.Text.Trim();
                lop.Makhoa = cbbMakhoa.Text.Trim();
                lop.Magvcn = maGvcnTextEdit.Text.Trim();
                lop.Quanso = Convert.ToInt32(quanSoSpinEdit.Value);
                //-------------------------------------------

                if (key == 1)
                {
                    if (b.CheckID("select * from Lop where MaLop='" + lop.Malop + "'") > 0)
                        MessageBox.Show("Đã tồn tại Mã Lớp này", "Lỗi");
                    else if (lop.Manganh == null)
                        MessageBox.Show("Mã Ngành không được để trống", "Lỗi");
                    else if (lop.Makhoa == null)
                        MessageBox.Show("Mã Khóa học không được để trống", "Lỗi");
                    else if (lop.Magvcn == null)
                        MessageBox.Show("Mã gvcn không được để trống", "Lỗi");
                    else
                        b.QueryIDU("insert into Lop values('" + lop.Malop + "','" +lop.Manganh + "','" +lop.Makhoa + "','"+lop.Magvcn+"','"+lop.Quanso+"')");
                }
                else if (key == 2)
                {
                    if (b.CheckID("select * from Lop where MaLop='" + lop.Malop + "'") == 0)
                        MessageBox.Show("Không tồn tại Mã Lớp này", "Lỗi");
                    else if (lop.Manganh == null)
                        MessageBox.Show("Mã Ngành không được để trống", "Lỗi");
                    else if (lop.Makhoa == null)
                        MessageBox.Show("Mã Khóa học không được để trống", "Lỗi");
                    else if (lop.Magvcn == null)
                        MessageBox.Show("Mã gvcn không được để trống", "Lỗi");
                    else
                        b.QueryIDU("update Lop set MaNganh='" + lop.Manganh + "',MaKhoa='" + lop.Makhoa + "', MaGvcn='"+lop.Magvcn+"', QuanSo='"+lop.Quanso+"' where MaLop='" + lop.Malop + "'");
                }
                else if (key == 3)
                {
                    if (b.CheckID("select * from Lop where MaLop='" + lop.Malop + "'") == 0)
                        MessageBox.Show("Không tồn tại Mã Lớp này", "Lỗi");
                    else if (b.CheckID("select MaLop from HocVien") > 0)
                        MessageBox.Show("Không xóa được Lớp này \nĐể thực hiện cần xóa hết dữ liệu tham chiếu!\nDữ liệu tham chiếu được tìm thấy trong Cơ sở dữ liệu Học viên", "Lỗi");
                    else
                        b.QueryIDU("delete from Lop where MaLop='" + lop.Malop + "'");
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

        private void dataGrv_Lop_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                maLopTextEdit.Text = dataGrv_Lop[0, dong].Value.ToString();
                cbbManganh.Text = dataGrv_Lop[1, dong].Value.ToString();
                cbbMakhoa.Text = dataGrv_Lop[2, dong].Value.ToString();
                maGvcnTextEdit.Text = dataGrv_Lop[3, dong].Value.ToString();
                quanSoSpinEdit.Text = dataGrv_Lop[4, dong].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi");
            }
        
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}