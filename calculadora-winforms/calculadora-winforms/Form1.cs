using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_winforms
{
    public partial class Form1 : Form
    {

        Func<double, double, double> operation;
        double memory = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void add_char(string _char)
        {

            string new_text;
            new_text = textBox1.Text + _char;
            textBox1.Text = new_text;

        }

        //numero 0
        private void button11_Click(object sender, EventArgs e)
        {
            add_char("0");

        }

        //numero 1
        private void button1_Click(object sender, EventArgs e)
        {
            add_char("1");

        }

        //numero 2
        private void button13_Click(object sender, EventArgs e)
        {
            add_char("2");

        }

        //numero 3
        private void button14_Click(object sender, EventArgs e)
        {
            add_char("3");

        }

        //numero 4
        private void button4_Click(object sender, EventArgs e)
        {
            add_char("4");

        }

        //numero 5
        private void button5_Click(object sender, EventArgs e)
        {
            add_char("5");
        }

        //numero 6
        private void button6_Click(object sender, EventArgs e)
        {
            add_char("6");
        }

        //numero 7
        private void button8_Click(object sender, EventArgs e)
        {
            add_char("7");

        }

        //numero 8
        private void button7_Click(object sender, EventArgs e)
        {
            add_char("8");

        }

        //numero 9
        private void button9_Click(object sender, EventArgs e)
        {
            add_char("9");

        }


       

        


        //boton de igual
        private void button12_Click(object sender, EventArgs e)
        {
            double result = 0;
            string new_text = textBox1.Text;

            try
            {
                result = operation(memory, Convert.ToDouble(new_text));
            }
            catch(Exception err)
            {
                MessageBox.Show("Hubo un error en la operacion");

            }

            
            memory = result;
            textBox1.Text = memory.ToString();

        }

        //boton de +
        private void button16_Click(object sender, EventArgs e)
        {
            clearAndSave();
            operation = (x1, x2) => x1 + x2;

        }

        //boton de -
        private void button15_Click(object sender, EventArgs e)
        {
            clearAndSave();
            operation = (x1, x2) => x1 - x2;
        }

        //boton de X
        private void button10_Click(object sender, EventArgs e)
        {
            clearAndSave();
            operation = (x1, x2) => x1 * x2;

        }

        //boton de /
        private void button17_Click(object sender, EventArgs e)
        {
            clearAndSave();
            operation = (x1, x2) => x1 / x2;

        }


        //boton de sin
        private void button20_Click(object sender, EventArgs e)
        {
            double result = 0;

            result = Math.Sin((Convert.ToDouble(textBox1.Text) * Math.PI)/180);
            memory = result;
            textBox1.Text = result.ToString();

        }

        //boton de cos
        private void button3_Click(object sender, EventArgs e)
        {
            double result = 0;

            if (Convert.ToDouble(textBox1.Text) == 90)
            {
                result = 0;
                memory = result;
                textBox1.Text = result.ToString();
            }
            else
            {
                result = Math.Cos((Convert.ToDouble(textBox1.Text) * Math.PI) / 180);
                memory = result;
                textBox1.Text = result.ToString();
            }

            
        }

        //boton de tan
        private void button19_Click(object sender, EventArgs e)
        {
            double result = 0;

            

            if (Convert.ToDouble(textBox1.Text) != 90)
            {
                result = Math.Tan((Convert.ToDouble(textBox1.Text) * Math.PI) / 180);
                memory = result;
                textBox1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Error, operacion invalida");
            }
            

        }
        //boton de borrar
        private void button18_Click_2(object sender, EventArgs e)
        {
            textBox1.Clear();
            memory = 0;

        }

        private void clearAndSave()
        {
            memory = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                string new_value;
                new_value = textBox1.Text + ".";
                textBox1.Text = new_value;
            }
            
        }
    }
}
