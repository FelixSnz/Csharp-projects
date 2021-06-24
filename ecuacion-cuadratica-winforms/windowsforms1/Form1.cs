using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsforms1
{
    public partial class Form1 : Form
    {

        double coefa, coefb, coefc;
        double x1, x2;

        public Form1()
        {
            InitializeComponent();
        }

        private static (double, double) GetSqrts(double a1, double b1, double c1)//subrutina para obtener raices de ecuaciond e segundo grado
        {
            double x_1, x_2;
            double sqrt = (Math.Sqrt(Math.Pow(b1, 2) - 4 * a1 * c1));//se obtiene la raiz de la formula
            if (sqrt >= 0)
            {
                //se obtienen ambas raices en caso de la raiz interior ser mayor o igual a 0
                x_1 = (-(b1 - sqrt) / (2 * a1));
                x_2 = (-(b1 + sqrt) / (2 * a1));
            }
            else
            {
                //se muestra mensaje de las raices son complejas
                MessageBox.Show("las raices son complejas");
                x_1 = 0;
                x_2 = 0;
            }
            return (x_1, x_2);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            coefa = Convert.ToDouble(numericUpDown1.Value);
            try_to_resolve();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            coefb = Convert.ToDouble(numericUpDown2.Value);
            try_to_resolve();

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            coefc = Convert.ToDouble(numericUpDown3.Value);
            try_to_resolve();

        }

        private void try_to_resolve()
        {
            if (coefa != null && coefb != null && coefc != null)
            {
                (x1, x2) = GetSqrts(coefa, coefb, coefc);
                label7.Text = "X1: " + x1.ToString();
                label8.Text = "X2: " + x2.ToString();

            }
        }
    }
}
