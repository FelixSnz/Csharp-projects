using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversion_temperaturas
{
    public partial class Form1 : Form
    {
        Func<double, double> operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            operation = inputScale => (inputScale *9) / 5 + 32;
            label1.Text = "°C";
            label3.Text = "°F";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conversion = listBox1.Text;

            switch (conversion)
            {
                case "°C a °F":
                    operation = inputScale => (inputScale * 9) / 5 + 32;
                    label1.Text = "°c";
                    label3.Text = "°F";
                    break;
                case "°C a °K":
                    operation = inputScale => inputScale + 273.15;
                    label1.Text = "°C";
                    label3.Text = "°K";
                    break;
                case "°F a °C":
                    operation = inputScale => ((inputScale - 32) * 5)/9;
                    label1.Text = "°F";
                    label3.Text = "°C";
                    break;
                case "°F a °K":
                    operation = inputScale => ((inputScale - 32) * 5 )/ 9 + 273.15;
                    label1.Text = "°F";
                    label3.Text = "°K";
                    break;
                default:
                    break;

            }

            label2.Text = operation(Convert.ToDouble(numericUpDown1.Value)).ToString("0.00");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = operation(Convert.ToDouble(numericUpDown1.Value)).ToString("0.00");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult option;

            option = MessageBox.Show("Desea salir del programa?", "Salir?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (option == DialogResult.OK)
            {
                this.Close();
            }
        }

    }
}
