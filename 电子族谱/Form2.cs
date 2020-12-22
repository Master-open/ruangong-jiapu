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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text==textBox3.Text)
                {
                string connString = @"Data Source = LAPTOP-S8DHMV61; Initial Catalog =FamilyTree; User ID = sa; Password = 123456";
                string sql = @"INSERT INTO Users(User_name,User_pawd) VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("注册成功！");
                }
                catch (Exception msg)
                {
                    MessageBox.Show("注册失败！\n出错原因：" + msg.Message);
                }
                conn.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("请确保两次密码输入一致");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
