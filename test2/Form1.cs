using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string theText = textBox1.Text;
            string end = textBox2.Text;
            double end1 =Convert.ToDouble(end) + Convert.ToDouble(theText); 
            textBox3.Text = Convert.ToString( end1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string theText = textBox1.Text;
            string end = textBox2.Text;
            double end1 = Convert.ToDouble(end) - Convert.ToDouble(theText);
            textBox3.Text = Convert.ToString(end1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string theText = textBox1.Text;
            string end = textBox2.Text;
            double end1 = Convert.ToDouble(end) * Convert.ToDouble(theText);
            textBox3.Text = Convert.ToString(end1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string theText = textBox1.Text;
            string end = textBox2.Text;
            double end1 = Convert.ToDouble(end) / Convert.ToDouble(theText);
            textBox3.Text = Convert.ToString(end1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string theText = textBox5.Text;
            string end = textBox6.Text;
            double end1 =2*( Convert.ToDouble(end) + Convert.ToDouble(theText));
            textBox3.Text = Convert.ToString(end1);
            double end2 = Convert.ToDouble(end) * Convert.ToDouble(theText);
            textBox8.Text = Convert.ToString(end2);

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string theText = textBox5.Text;
            string end = textBox6.Text;
            string c  =textBox4.Text;
            double half = 2 / (Convert.ToDouble(end) + Convert.ToDouble(theText)+Convert.ToDouble(c));
            double end2 = Math.Sqrt(( half*(half-Convert.ToDouble(end))*(half- Convert.ToDouble(theText))*(half- Convert.ToDouble(c))));
            textBox8.Text = Convert.ToString(end2);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
