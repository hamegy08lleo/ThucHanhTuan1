using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ThucHanhTuan1
{
    public partial class Form1 : Form
    {

        SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.connStr);
        HocSinhDAO hocSinhDao = new HocSinhDAO(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("DELETE FROM HocSinh WHERE Cmnd = '{0}'", txtCmnd.Text);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("xoa thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("xoa that bai" + ex);
            }
            finally
            {
                conn.Close();
                load(sender, e);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string command = string.Format("INSERT INTO HocSinh(Ten , Diachi, Cmnd) VALUES('{0}', '{1}', '{2}')", txtHovaten.Text, txtDiachi.Text, txtCmnd.Text);
            hocSinhDao.thucThi(command, "INSERT");
            load(sender, e); 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("UPDATE HocSinh SET Ten = '{0}', DiaChi =\r\n'{1}' WHERE Cmnd = {2}", txtHovaten.Text, txtDiachi.Text, txtCmnd.Text);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("sua thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("sua that bai" + ex);
            }
            finally
            {
                conn.Close();
                load(sender, e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hocSinhDao.load(); /// gvHsinh = name cua data gridview

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtb1_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}
