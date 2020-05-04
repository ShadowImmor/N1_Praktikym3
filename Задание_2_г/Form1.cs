using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Задание_2_г
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            A.Maximum = decimal.MaxValue;
            A.Minimum = decimal.MinValue;
            B.Maximum = decimal.MaxValue;
            B.Minimum = decimal.MinValue;
            H.Maximum = decimal.MaxValue;
        }
        private void A_ValueChanged(object sender, EventArgs e)
        {
            B.Minimum = A.Value;
        }

        private void Rashbutton_Click(object sender, EventArgs e)
        {
            Ot.Clear();
            for (double i = (double)A.Value, n=0; i <= (double)B.Value; i += (double)H.Value, n++)
            {
                Ot.Text += ("f( " + Math.Round(i, 2) + " )= " + Math.Round(f(i), 4) + ";   ");
                if (n % 5 == 0 & n > 0)
                    Ot.Text += "\n";
            }
        }
        private double f(double x)
        {
            double y;
            if (Math.Abs(x) < (Math.PI / 2)) y = Math.Sin(x);
            else if (Math.Abs(x) <= Math.PI) y = Math.Cos(x);
            else y = 0;
            return y;
        }
    }
}
