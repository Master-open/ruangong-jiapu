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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            string connStr = @"Data Source = LAPTOP-S8DHMV61; Initial Catalog =FamilyTree; User ID = sa; Password = 123456";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = @"SELECT * FROM Members";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter dds = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            dds.Fill(ds, "t");
            dataGridView1.DataSource = ds.Tables["t"];
            conn.Close();
        }
    }
}
