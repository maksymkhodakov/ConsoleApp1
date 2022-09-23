using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string Value { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You entered " + Value);
        }

        private void Form1_Load(object sender, EventArgs e) {}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Value = textBox1.Text;
        }
    }
}
