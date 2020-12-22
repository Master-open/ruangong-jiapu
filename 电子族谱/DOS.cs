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
    public partial class DOS : Form
    {
        internal static string id;
        internal static string id2;
        internal static string name;

        public DOS()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox0.Text = id;
            textBox1.Text = id2;
            textBox2.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source = LAPTOP-S8DHMV61; Initial Catalog =FamilyTree; User ID = sa; Password = 123456";
            string sql = string.Format("select * from Members where Member_id ={0}",id2);
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader myReader = cmd.ExecuteReader();
            myReader.Read();
            textBox3.Text = Convert.ToString(myReader["Member_sex"]);
            textBox4.Text = Convert.ToString(myReader["Member_DOB"]);
            textBox5.Text = Convert.ToString(myReader["Member_mate"]);
            textBox6.Text = Convert.ToString(myReader["Member_BAdd"]);
            textBox7.Text = Convert.ToString(myReader["Member_parents"]);
            textBox8.Text = Convert.ToString(myReader["Member_children"]);
            conn.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
