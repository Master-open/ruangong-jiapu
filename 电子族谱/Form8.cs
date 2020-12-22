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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source = LAPTOP-S8DHMV61; Initial Catalog =FamilyTree; User ID = sa; Password = 123456";
            string sql = @"DELETE FROM Members WHERE Member_id='" + textBox2.Text + "'";

            
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(textBox2.Text + "成员删除成功");

            }
            catch (Exception ex)
            {
                MessageBox.Show("没有该成员!" + ex.Message);
            }
            conn.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
