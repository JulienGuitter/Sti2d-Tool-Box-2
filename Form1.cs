using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STI2D_Tool_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //definie les parametre du menu déroulan du filtre
            filtreSlidePanel.Enabled = false;
            filtreSlidePanel.Height = 0;
        }

        private void activate()
        {
            codeCouleurButton.Enabled = true;
            conversionsButton.Enabled = true;
            resistanceButton.Enabled = true;
            passeBandeButton.Enabled = true;
            passeHautButton.Enabled = true;
            passeBasButton.Enabled = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool mouseDown;
        private Point lastLocation;
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {

            mouseDown = true;
            lastLocation = e.Location;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void conversionsButton_Click(object sender, EventArgs e)
        {
            content.Controls.Clear();
            content.Controls.Add(new conversions());
            activate();
            conversionsButton.Enabled = false;
            closeSlideMenu();
        }

        private void resistanceButton_Click(object sender, EventArgs e)
        {
            content.Controls.Clear();
            content.Controls.Add(new resistances());
            activate();
            resistanceButton.Enabled = false;
            closeSlideMenu();
        }

        private void codeCouleurButton_Click(object sender, EventArgs e)
        {
            content.Controls.Clear();
            content.Controls.Add(new codecouleur());
            activate();
            codeCouleurButton.Enabled = false;
            closeSlideMenu();
        }

        // partie filtre
        bool sliderOpen = false;
        private void filtreButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (!sliderOpen)
            {
                filtreSlidePanel.Enabled = true;
            }
        }

        private void closeSlideMenu()
        {
            if (sliderOpen)
            {
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sliderOpen)
            {
                if (filtreSlidePanel.Height <= 0)
                {
                    timer1.Enabled = false;
                    filtreSlidePanel.Enabled = false;
                    sliderOpen = false;
                }
                else
                {
                    filtreSlidePanel.Height -= 10;
                }
            }
            else
            {
                if (filtreSlidePanel.Height >= 110)
                {
                    timer1.Enabled = false;
                    sliderOpen = true;
                }
                else
                {
                    filtreSlidePanel.Height += 10;
                }
            }
        }

        private void passeBasButton_Click(object sender, EventArgs e)
        {
            content.Controls.Clear();
            content.Controls.Add(new filtre.passeBas());
            activate();
            passeBasButton.Enabled = false;
        }

        private void passeHautButton_Click(object sender, EventArgs e)
        {
            content.Controls.Clear();
            content.Controls.Add(new filtre.passeHaut());
            activate();
            passeHautButton.Enabled = false;
        }

        private void passeBandeButton_Click(object sender, EventArgs e)
        {
            content.Controls.Clear();
            content.Controls.Add(new filtre.passeBande());
            activate();
            passeBandeButton.Enabled = false;
        }

        //fin partie filtre

        private void changeColor(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                button.BackColor = Color.FromArgb(255, 12, 94, 138);
            }
            else
            {
                button.BackColor = Color.FromArgb(255, 255, 255, 255);
            }
        }

        private void filtreColorChange(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                button.BackColor = Color.FromArgb(255, 18, 113, 163);
            }
            else
            {
                button.BackColor = Color.FromArgb(255, 255, 255, 255);
            }
        }
    }
}
