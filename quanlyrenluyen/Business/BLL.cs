using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanlyrenluyen.DataAccess;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace quanlyrenluyen.Business
{
    class BLL
    {
        public void QueryIDU(string strsql)
        {
            DataConfig config = new DataConfig();
            try
            {
                config.exenonequery(strsql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi");
            }
        }

        public int CheckID(string strsql)
        {
            DataConfig config = new DataConfig();
            DataTable table = new DataTable();
            table = config.GetData(strsql);
            return table.Rows.Count;
        }

        public string GetValues(string strsql, int col, int row)
        {
            string result = "";
            DataConfig config = new DataConfig();
            DataTable dt = config.GetData(strsql);
            if (dt != null) { 
                DataRow dtr = dt.Rows[row];
                if (dtr!=null) 
                    result = dtr[col].ToString();
            }
            return result;
        }
    }
}
