using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
  
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    double resistor1 = double.Parse(textBox1.Text);
                    double resistor2 = double.Parse(textBox2.Text);
                    double resistor3 = double.Parse(textBox4.Text);
                    double resistor4 = double.Parse(textBox5.Text);
                    double resistor5 = double.Parse(textBox6.Text);

                    double total = resistor1 + resistor2 + resistor3 + resistor4 + resistor5;
                    MessageBox.Show("Total_resistance = " + total.ToString("0.00") + "ohms");

                }
                catch
                {
                    MessageBox.Show("error in inputting values");
                }
            }
        }
    }
}
