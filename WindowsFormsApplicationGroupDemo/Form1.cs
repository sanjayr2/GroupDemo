using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationGroupDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void btnGetForm2_Click(object sender, EventArgs e)
        {
            Form F2 = new Form2();
            F2.Show();

        }

        private void btnGetForm3_Click(object sender, EventArgs e)
        {
            Form F3 = new Form3();
            F3.Show();
        }
    }
}
