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
    public partial class conversions : UserControl
    {
        public conversions()
        {
            InitializeComponent();
        }               
        int A = 10;
        int B = 11;
        int C = 12;
        int D = 13;
        int E = 14;
        int F = 15;
        private string decimalbinaire(int Decimal) //décimal vers binaire
        {
           string binaire = "";                   
            while (Decimal > 0)   
            {
                int _ = Decimal;
                Decimal = Decimal / 2;
                _ = _ % 2;
                if (_ == 0)
                {
                    binaire = "0" + binaire;
                }
                else
                {
                    binaire = "1" + binaire;
                }
                _ = Decimal;               
            }
            return binaire;
        }
        private string decimalhexa(int Décimal) //décimal vers hexa
        {            
           string hexa = "";
            while (Décimal > 0)       
            {
                int m = Décimal;
                Décimal = Décimal / 16;
                m = m % 16;
                if (m == 1)
                {
                    hexa = "1" + hexa;
                }
                if (m == 2)
                {
                    hexa = "2" + hexa;
                }
                if (m == 3)
                {
                    hexa = "3" + hexa;
                }
                if (m == 4)
                {
                    hexa = "4" + hexa;
                }
                if (m == 5)
                {
                    hexa = "5" + hexa;
                }
                if (m == 6)
                {
                    hexa = "6" + hexa;
                }
                if (m == 7)
                {
                    hexa = "7" + hexa;
                }
                if (m == 8)
                {
                    hexa = "8" + hexa;
                }
                if (m == 9)
                {
                    hexa = "9" + hexa;
                }
                if (m == A)
                {
                    hexa = "A" + hexa;
                }
                if (m == B)
                {
                    hexa = "B" + hexa;
                }
                if (m == C)
                {
                    hexa = "C" + hexa;
                }
                if (m == D)
                {
                    hexa = "D" + hexa;
                }
                if (m == E)
                {
                    hexa = "E" + hexa;
                }
                if (m == F)
                {
                    hexa = "F" + hexa;
                }
                if (m == 0)
                {
                    hexa = "0" + hexa;
                }
                m = Décimal;
            }
            return hexa;
        }
        private int binairedecimal(string binaire1) //binaire vers décimal
        {           
            int h = 1;
            int result = 0;
            for (int i = binaire1.Length; i > 0; i--)
            {
                if (int.Parse(binaire1.Substring(i - 1, 1)) == 1)
                {
                    result += h;
                }
                h *= 2;
            }
            return result;
        }
        private string hexadecimal(string Hexa) //hexa vers décimal
        {
            string car = "abcdef";
            double result2 = 0;
            int k = 0;
            for (int i = Hexa.Length; i > 0; i--)
            {
                if (car.Contains(Hexa.Substring(i - 1, 1)))
                {
                    result2 += (10 + car.IndexOf(Hexa.Substring(i - 1, 1))) * Math.Pow(16, k);
                }
                else
                {
                    int h = int.Parse(Hexa.Substring(i - 1, 1));
                    if (0 <= h && h <= 9)
                    {
                        result2 += h * Math.Pow(16, k);
                    }
                }
                k++;
            }
            return result2.ToString();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }                                                  
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "" | e.KeyChar.ToString() == "1" || e.KeyChar.ToString().ToLower() == "0")
            {
                e.Handled = false;               
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "" | e.KeyChar.ToString() == "1" || e.KeyChar.ToString() == "2" || e.KeyChar.ToString() == "3" || e.KeyChar.ToString() == "4" || e.KeyChar.ToString() == "5" || e.KeyChar.ToString() == "6" || e.KeyChar.ToString() == "7" || e.KeyChar.ToString() == "8" || e.KeyChar.ToString() == "9" || e.KeyChar.ToString() == "a" || e.KeyChar.ToString() == "b" || e.KeyChar.ToString() == "c" || e.KeyChar.ToString() == "d" || e.KeyChar.ToString() == "e" || e.KeyChar.ToString() == "f" || e.KeyChar.ToString().ToLower() == "0")
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Length>0)
            { 
                textBox2.Text = decimalbinaire(int.Parse(textBox1.Text));
                 textBox3.Text = decimalhexa(int.Parse(textBox1.Text));
        }
    }
        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox2.Text.Length > 0)
            { 
                textBox1.Text = binairedecimal(textBox2.Text).ToString();
                textBox3.Text = decimalhexa(int.Parse(textBox1.Text));
            }
        }
        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox3.Text.Length > 0)
            { 
                textBox1.Text = hexadecimal(textBox3.Text).ToString();
                textBox2.Text = decimalbinaire(int.Parse(textBox1.Text));
        }
    }
    }
}