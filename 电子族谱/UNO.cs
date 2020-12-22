using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 电子族谱
{
    public partial class UNO : Form
    {
        public UNO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DOS form2 = new DOS();
            DOS.id = textBox1.Text;
            DOS.id2 = textBox2.Text;
            DOS.name = textBox3.Text;
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
