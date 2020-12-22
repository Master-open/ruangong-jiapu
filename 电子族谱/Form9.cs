using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 电子族谱
{
    public partial class Form9 : Form
    {
        private string connStr;

        public Form9()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source = LAPTOP-S8DHMV61; Initial Catalog =FamilyTree; User ID = sa; Password = 123456";
            SqlConnection conn = new SqlConnection(connString);
            string sql;
             sql = @"UPDATE Members SET [Gen_id]='" + textBox1.Text + "',[Member_id]='" + textBox2.Text + "',[Member_name]='" + textBox3.Text + "',[Member_sex]='" + textBox4.Text + "',[Member_DOB]='" + textBox5.Text + "',[Member_mate]='" + textBox6.Text + "',[Member_BAdd]='" + textBox7.Text + "',[Member_parents]='" + textBox8.Text + "',[Member_children]='" + textBox9.Text + "'";
             sql += " WHERE [Member_id]='" + textBox2.Text + "'";







            conn.Open();
            
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(textBox2.Text + "成员修改成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新出错！" + ex.Message);
            }
            conn.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
