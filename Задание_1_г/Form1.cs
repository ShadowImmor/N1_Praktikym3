using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Задание_1_г
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            X.Maximum = decimal.MaxValue;
            X.Minimum = decimal.MinValue;
            Y.Maximum = decimal.MaxValue;
            Y.Minimum = decimal.MinValue;
            Z.Maximum = decimal.MaxValue;
            Z.Minimum = decimal.MinValue;
            V.Maximum = decimal.MaxValue;
            V.Minimum = decimal.MinValue;
        }
        private void XandYandZandV_ValueChanged(object sender, EventArgs e)
        {
            Ot.Text = (min(min((double)X.Value, (double)Y.Value), min((double)Z.Value, (double)V.Value))).ToString();
        }
        private double min(double a, double b)
        {
            return (a < b) ? a : b;
        }
    }
}
