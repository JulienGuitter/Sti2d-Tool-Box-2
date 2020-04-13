using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STI2D_Tool_Box.filtre
{
    public partial class passeBas : UserControl
    {
        public passeBas()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            int fc = Decimal.ToInt32(FcValue.Value);
            float r1 = 10f;
            float c1 = 159155 / (r1*fc);

            C1Result.Text = "10 nF";
            R1Result.Text = c1.ToString() + " Ω";
        }
    }
}
