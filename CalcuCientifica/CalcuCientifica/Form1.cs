using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcuCientifica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public double Potencia(double bas, double pot)
        {
            double res = Math.Pow(bas, pot);
            return res;
        }

        public double Raiz(double bas, double ind)
        {
            double res = Math.Pow(bas, 1 / ind);
            return res;
        }
    }
}
