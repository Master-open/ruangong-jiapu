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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            

        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UNO uno = new 电子族谱.UNO();
            uno.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.ShowDialog();
        }
    }
}
