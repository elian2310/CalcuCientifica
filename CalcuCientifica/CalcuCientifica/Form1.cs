using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.matheval;

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

        private void Plot2d(String funcion)
        {
            double[] x = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            DataTable dt = new DataTable();
            foreach(double num in x)
            {
                int a = 0;
            }
        }
        private void Plot3d(String funcion)
        {

        }

        private double Potencia(double bas, double pot)
        {
            double res = Math.Pow(bas, pot);
            return res;
        }

        private double Raiz(double bas, double ind)
        {
            double res = Math.Pow(bas, 1 / ind);
            return res;
        }

        private double Suma(double n1, double n2)
        {
            return (n1 + n2);
        }
        private double Resta(double n1, double n2)
        {
            return (n1 - n2);
        }
        private double Mult(double n1, double n2)
        {
            return (n1 * n2);
        }
        private double Div(double n1, double n2)
        {
            return (n1 / n2);
        }
        private double Log(double num, double nbase)
        {
            return (Math.Log(num, nbase));
        }
        private double Seno(double num)
        {
            return (Math.Sin(num));
        }
        private double Coseno(double num)
        {
            return (Math.Cos(num));
        }
        private double Tangente(double num)
        {
            return (Math.Tan(num));
        }
        private decimal Derivar(String funcion, decimal num)
        {
            decimal h = Convert.ToDecimal(Math.Pow(10, -5));
            decimal val1;
            decimal val2;
            Expression expr = new Expression();
            expr.SetFomular(funcion);
            expr.Bind("x", num + h);
            val1 = expr.Eval<decimal>();
            expr.Bind("x", num);
            val2 = expr.Eval<decimal>();
            decimal res = (val1 - val2) / h;
            return res;
        }
        private double Integrar(String funcion, double limSup, double limInf)
        {
            double val;
            Expression expr = new Expression();
            expr.SetFomular(funcion);
            int nTriangulos = 1000;
            double delta_x = (limSup - limInf) / nTriangulos;
            double sumAc = 0;
            for(int i = 1;i < nTriangulos + 1; i++)
            {
                expr.Bind("x", limInf + (i - 1) * delta_x);
                val = expr.Eval<double>();
                sumAc += (double)val * delta_x;
            }
            return sumAc;
        }
        private bool VerifTb()
        {
            bool res = false;
            if (double.TryParse(tb1.Text, out _) && double.TryParse(tb2.Text,out _))
            {
                res = true;
            }
            return res;
        }
        private bool VerifTb1()
        {
            bool res = false;
            if (double.TryParse(tb1.Text, out _))
            {
                res = true;
            }
            return res;
        }
        private bool VerifTbInt()
        {
            bool res = false;
            if (double.TryParse(tb2.Text, out _) && double.TryParse(tb3.Text, out _))
            {
                res = true;
            }
            return res;
        }
        private bool VerifTbDer()
        {
            bool res = false;
            if (decimal.TryParse(tb2.Text, out _))
            {
                res = true;
            }
            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String res = "";
            if (VerifTb())
            {
                res = Suma(Convert.ToDouble(tb1.Text), Convert.ToDouble(tb2.Text)).ToString();
            }
            else
            {
                res = "Syntax error";
            }
            tbRes.Text = res;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            String res = "";
            if (VerifTb())
            {
                res = Resta(Convert.ToDouble(tb1.Text), Convert.ToDouble(tb2.Text)).ToString();
            }
            else
            {
                res = "Syntax error";
            }
            tbRes.Text = res;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            String res = "";
            if (VerifTb())
            {
                res = Mult(Convert.ToDouble(tb1.Text), Convert.ToDouble(tb2.Text)).ToString();
            }
            else
            {
                res = "Syntax error";
            }
            tbRes.Text = res;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            String res = "";
            if (VerifTb())
            {
                if(Convert.ToDouble(tb2.Text) == 0)
                {
                    res = "Math Error";
                }
                else
                {
                    res = Div(Convert.ToDouble(tb1.Text), Convert.ToDouble(tb2.Text)).ToString();
                }
            }
            else
            {
                res = "Syntax error";
            }
            tbRes.Text = res;
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            String res = "";
            if (VerifTb1())
            {
                res = Seno(Convert.ToDouble(tb1.Text)).ToString();
            }
            else
            {
                res = "Syntax error";
            }
            tbRes.Text = res;
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            String res = "";
            if (VerifTb1())
            {
                res = Coseno(Convert.ToDouble(tb1.Text)).ToString();
            }
            else
            {
                res = "Syntax error";
            }
            tbRes.Text = res;
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            String res = "";
            if (VerifTb1())
            {
                if (Convert.ToDouble(tb1.Text) == (Math.PI / 2))
                {
                    res = "Math Error";
                }
                else
                {
                    res = Tangente(Convert.ToDouble(tb1.Text)).ToString();
                }
                
            }
            else
            {
                res = "Syntax error";
            }
            tbRes.Text = res;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            String res = "";
            if (VerifTb())
            {
                if (Convert.ToDouble(tb1.Text) <= 0)
                {
                    res = "Math Error";
                }
                else
                {
                    res = Log(Convert.ToDouble(tb1.Text), Convert.ToDouble(tb2.Text)).ToString();
                }
            }
            else
            {
                res = "Syntax error";
            }
            tbRes.Text = res;
        }

        private void btnPot_Click(object sender, EventArgs e)
        {
            String res = "";
            if (VerifTb())
            {
                if (Convert.ToDouble(tb2.Text) == 0)
                {
                    res = "Math Error";
                }
                else
                {
                    res = Potencia(Convert.ToDouble(tb1.Text), Convert.ToDouble(tb2.Text)).ToString();
                }
            }
            else
            {
                res = "Syntax error";
            }
            tbRes.Text = res;
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            String res = "";
            if (VerifTb())
            {
                if (Convert.ToDouble(tb2.Text) == 0)
                {
                    res = "Math Error";
                }
                else
                {
                    res = Raiz(Convert.ToDouble(tb1.Text), Convert.ToDouble(tb2.Text)).ToString();
                }
            }
            else
            {
                res = "Syntax error";
            }
            tbRes.Text = res;
        }

        private void btnDer_Click(object sender, EventArgs e)
        {
            String res = "";
            if (VerifTbDer())
            {
                res = Derivar(tb1.Text, Convert.ToDecimal(tb2.Text)).ToString();
            }
            else
            {
                res = "Syntax Error";
            }
            tbRes.Text = res;
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            String res = "";
            if (VerifTbInt())
            {
                res = Integrar(tb1.Text, Convert.ToDouble(tb2.Text), Convert.ToDouble(tb3.Text)).ToString();
            }
            else
            {
                res = "Syntax Error";
            }
            tbRes.Text = res;
        }
    }
}
