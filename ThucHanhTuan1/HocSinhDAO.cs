using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanhTuan1
{
    internal class HocSinhDAO
    {

        SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.connStr);
        public HocSinhDAO() { } 
        public DataTable load()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT * FROM HocSinh");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);
                return dtSinhVien;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return new DataTable();
        }
        public void thucThi(string command, string type)
        {
            try
            {
                // Ket noi
                conn.Open();
                // string sqlStr = string.Format("INSERT INTO HocSinh(Ten , Diachi, Cmnd) VALUES ('{0}', '{1}', '{2}')", txtHovaten.Text, txtDiachi.Text, txtCmnd.Text);
                SqlCommand cmd = new SqlCommand(command, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show(type + " thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(type + " that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
