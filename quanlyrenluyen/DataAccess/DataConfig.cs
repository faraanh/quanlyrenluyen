using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace quanlyrenluyen.DataAccess
{
    class DataConfig
    {
        public string strcon = @"Data Source=Administrator;Initial Catalog=ketquarenluyen;Integrated Security=True";
        public SqlConnection con;

        public DataConfig()
        {
            try
            {
                connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi");
            }

        }

        public void connect()
        {
            con = new SqlConnection(strcon);
        }

        public DataTable GetData(string strsql)
        {
            DataTable result = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlDataAdapter da = new SqlDataAdapter(strsql, con);
                da.Fill(result);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi");
            }
            return result;
        }

        public int exenonequery(string strsql)
        {
            int result = 0;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strsql;
            result = cmd.ExecuteNonQuery();
            return result;
        }

    }
}
