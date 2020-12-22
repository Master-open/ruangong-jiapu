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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source = LAPTOP-S8DHMV61; Initial Catalog =FamilyTree; User ID = sa; Password = 123456"; 
            string sql = @"DELETE FROM Genealogical WHERE Gen_id='" + textBox1.Text + "'";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(textBox1.Text + "删除成功");

            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库不存在该族谱" + ex.Message);
            }
            conn.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
