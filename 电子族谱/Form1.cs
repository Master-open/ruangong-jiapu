using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 电子族谱
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source = LAPTOP-S8DHMV61; Initial Catalog =FamilyTree; User ID = sa; Password = 123456";
            SqlConnection conn = new SqlConnection(connString);
            string sql = @"select count(*) from Users where User_name='" + textBox1.Text + "'and User_pawd='" + textBox2.Text + "'";
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            int num = (int)comm.ExecuteScalar();
            if (num > 0)
            {
                this.Visible = false;
                Form3 frm3 = new Form3();
                frm3.ShowDialog();
                conn.Close();
                //Log.DialogResult == DialogResult.OK;
            }
            else
            {
                MessageBox.Show("对不起，用户名和密码并不匹配！", "登陆失败");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
