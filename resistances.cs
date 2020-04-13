using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STI2D_Tool_Box
{
    public partial class resistances : UserControl
    {

        string serie_string;
        int n;
        int m;
        int d;
        string d_string;
        double r;
        string r_string;
        double racine;

        




        public resistances()
        {
            InitializeComponent();
        }

        private void resistances_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonV_Click(object sender, EventArgs e)
        {

            serie_string = comboBox1.SelectedItem.ToString();
            d_string = comboBox2.SelectedItem.ToString();
            n = Convert.ToInt32(serie_string);
            m = Convert.ToInt32(textBox1.Text);
            d = Convert.ToInt32(d_string);

            racine = Math.Sqrt(10 * m);
            r = (n*racine)/d;
            r_string = r.ToString();

            textBox2.Text = r_string;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != "")
            {
                textBox4.Text = Math.Round(Math.Log(Math.Pow(Convert.ToInt32(textBox3.Text), Convert.ToInt32(comboBox3.SelectedItem.ToString())))).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox3.Text = "";
          
        }
    }
}
