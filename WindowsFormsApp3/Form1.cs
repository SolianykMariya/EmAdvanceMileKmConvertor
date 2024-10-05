using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "miles to km";
            label2.Text = "Enter miles";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "km to miles";
            label2.Text = "Enter km";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double input = double.Parse(textBox2.Text);
            double output = 0;
            if (radioButton1.Checked)
            {
                output = input * 1.60934;
                textBox1.Text= output.ToString();
            }
            else if (radioButton2.Checked)
            {
                output = input / 1.60934;
                textBox1.Text = output.ToString();
            }
            else if (textBox1 == null)
            {
                MessageBox.Show("Error!\nYou have to enter a number");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
