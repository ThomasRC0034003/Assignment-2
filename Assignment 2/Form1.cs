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
                    // This code below is reading what is in the text box
                    double resistor1 = double.Parse(textBox1.Text);
                    double resistor2 = double.Parse(textBox2.Text);
                    double resistor3 = double.Parse(textBox4.Text);
                    double resistor4 = double.Parse(textBox5.Text);
                    double resistor5 = double.Parse(textBox6.Text);

                    // The code below is doing the calculation that has been inputted
                    double total = resistor1 + resistor2 + resistor3 + resistor4 + resistor5;
                    //This is what the calculation actually is
                    MessageBox.Show("Total_resistance = " + total.ToString("0.00") + "ohms");

                }
                catch
                {
                    //I did this so that the something appears rather than it just being blank
                    MessageBox.Show("Error in inputting values");
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Setting the values to zero before the if statements
            double resistor6 = 0.0;
            double resistor7 = 0.0;
            double resistor8 = 0.0;
            double resistor9 = 0.0;
            double resistor10 = 0.0;

            try
                // we used the try catch to prevent any mistakes
            {
                // we used the if statements if a zero was inputted into the code it wouldn't break
                if (textBox10.Text == "0")
                {
                    resistor6 = double.PositiveInfinity;   
                }
                else
                {
                    resistor6 = double.Parse(textBox10.Text);
                }

                if (textBox3.Text == "0")
                  {
                    resistor7 = double.PositiveInfinity;
                }
                else
                {
                    resistor7 = double.Parse(textBox3.Text);
                }

                if (textBox7.Text == "0")
                {
                    resistor8 = double.PositiveInfinity;
                }
                else
                {
                    resistor8 = double.Parse(textBox7.Text);
                }

                if (textBox8.Text == "0")
                {
                    resistor9 = double.PositiveInfinity;
                }
                else
                {
                    resistor9 = double.Parse(textBox8.Text);
                }

                if (textBox9.Text == "0")
                {
                    resistor10 = double.PositiveInfinity;
                }
                else
                {
                    resistor10 = double.Parse(textBox9.Text);
                }

          // This is the parallel series calculation
                double total_resistance = (1.0 / (1.0 / resistor6 + 1.0 / resistor7 + 1.0 / resistor8 + 1.0 / resistor9 + 1.0 / resistor10));
                MessageBox.Show("total resistance = " + total_resistance.ToString("0.00") + "ohms");
            }

            catch
            {
                MessageBox.Show("Error in inputting values");
            }

        }
    }
}
