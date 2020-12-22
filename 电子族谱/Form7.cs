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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source = LAPTOP-S8DHMV61; Initial Catalog =FamilyTree; User ID = sa; Password = 123456";
            string sql = @"INSERT INTO Members(Gen_id,Member_id,Member_name,Member_sex,Member_DOB,Member_mate,Member_BAdd,Member_parents,Member_children) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("添加成功！");
            }
            catch (Exception msg)
            {
                MessageBox.Show("添加失败！\n出错原因：" + msg.Message);
            }
            conn.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 f2 = new Form8();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 f3 = new Form9();
            f3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void 族谱名_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connString = @"Data Source = LAPTOP-S8DHMV61; Initial Catalog =FamilyTree; User ID = sa; Password = 123456";
            string sql = @"SELECT [Members] FROM dict WHERE []='A' ORDER BY [key]";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Publishers");
            comboBox1.DataSource = ds.Tables["Publishers"];
            comboBox1.DisplayMember = ds.Tables["Publishers"].Columns[0].ToString();
            conn.Close();
        }
    }

    internal class comboBox1
    {
        public static DataTable DataSource { get; internal set; }
        public static string DisplayMember { get; internal set; }
    }
}
