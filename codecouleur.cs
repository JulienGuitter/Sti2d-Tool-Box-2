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
    public partial class codecouleur : UserControl
    {
        public codecouleur()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox5.Visible = false;
            }
            else
            {
                pictureBox5.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (comboBox1.SelectedIndex == 0)
            {

                if (textBox1.Text.Length == 0)
                {
                    pictureBox2.BackColor = Color.White;
                    pictureBox3.BackColor = Color.White;
                    pictureBox4.BackColor = Color.White;


                }
                else if (textBox1.Text.Length == 1)
                {
                    pictureBox2.BackColor = Color.Black;
                    pictureBox3.BackColor = Color.Brown;
                    pictureBox4.BackColor = Color.Black;

                }
                else if (textBox1.Text.Length > 1)
                {
                    int barre1 = Int32.Parse(textBox1.Text.Substring(0, 1));
                    int barre2 = Int32.Parse(textBox1.Text.Substring(1, 1));
                    int barre3 = 0;
                    if (textBox1.Text.Length > 2)
                    {

                        barre3 = textBox1.Text.Length - 2;

                    }
                    pictureBox2.BackColor = Couleur(barre1);
                    pictureBox3.BackColor = Couleur(barre2);
                    pictureBox4.BackColor = Couleur(barre3);
                }

            }
            else
            {
                if (textBox1.Text.Length == 0)
                {
                    pictureBox2.BackColor = Color.White;
                    pictureBox3.BackColor = Color.White;
                    pictureBox4.BackColor = Color.White;


                }
                else if (textBox1.Text.Length == 1)
                {
                    pictureBox2.BackColor = Color.Black;
                    pictureBox3.BackColor = Color.Brown;
                    pictureBox4.BackColor = Color.Black;

                }
                else if (textBox1.Text.Length > 1)
                {
                    int barre1 = Int32.Parse(textBox1.Text.Substring(0, 1));
                    int barre2 = Int32.Parse(textBox1.Text.Substring(1, 1));
                    int barre3 = 0;
                    if (textBox1.Text.Length > 2)
                    {
                        barre3 = Int32.Parse(textBox1.Text.Substring(2, 1));
                    }
                    int barre4 = 0;
                    if (textBox1.Text.Length > 3)
                    {

                        barre4 = textBox1.Text.Length - 3;

                    }
                    pictureBox2.BackColor = Couleur(barre1);
                    pictureBox3.BackColor = Couleur(barre2);
                    pictureBox4.BackColor = Couleur(barre3);
                    pictureBox5.BackColor = Couleur(barre4);
                }


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar)) || (textBox1.Text.Length > 10 && !char.IsControl(e.KeyChar) && comboBox1.SelectedIndex == 0) || (textBox1.Text.Length > 11 && !char.IsControl(e.KeyChar) && comboBox1.SelectedIndex == 1))
            {
                e.Handled = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private Color Couleur(int chiffre)
        {
            Color h = Color.Black;

            if (chiffre == 1)
            {
                h = Color.Brown;
            }
            else if (chiffre == 2)
            {
                h = Color.Red;
            }
            else if (chiffre == 3)
            {
                h = Color.Orange;
            }
            else if (chiffre == 4)
            {
                h = Color.Yellow;
            }
            else if (chiffre == 5)
            {
                h = Color.Green;
            }
            else if (chiffre == 6)
            {
                h = Color.Blue;
            }
            else if (chiffre == 7)
            {
                h = Color.Violet;
            }
            else if (chiffre == 8)
            {

                h = Color.Gray;
            }
            else if (chiffre == 9)
            {
                h = Color.White;
            }

            return h;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                pictureBox6.BackColor = Color.Brown;

            }
            else if (comboBox2.SelectedIndex == 1)
            {
                pictureBox6.BackColor = Color.Red;

            }
            else if (comboBox2.SelectedIndex == 2)
            {
                pictureBox6.BackColor = Color.Green;

            }
            else
                 if (comboBox2.SelectedIndex == 3)
            {
                pictureBox6.BackColor = Color.Blue;

            }
            else if (comboBox2.SelectedIndex == 4)
            {
                pictureBox6.BackColor = Color.Violet;

            }
            else if (comboBox2.SelectedIndex == 5)
            {
                pictureBox6.BackColor = Color.Gray;

            }
            else if (comboBox2.SelectedIndex == 6)
            {
                pictureBox6.BackColor = Color.Gold;

            }
            else if (comboBox2.SelectedIndex == 7)
            {
                pictureBox6.BackColor = Color.Silver;

            }


        }
    }
}
