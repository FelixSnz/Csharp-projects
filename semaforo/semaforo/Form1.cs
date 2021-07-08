using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semaforo
{
    public partial class Form1 : Form
    {
        double time;
        bool preventivo;


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            preventivo = !preventivo;
            time = 0;
        }

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;

            if (!preventivo)
            {
                if (time >= 30)
                {
                    time = 0;
                }

                if (time > 0 && time < 10)
                {
                    button1.BackColor = Color.Green;
                    button2.BackColor = Color.Black;
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.Black;
                    button5.BackColor = Color.Black;
                    button6.BackColor = Color.Red;



                }
                else if (time >= 10 && time <= 15)
                {
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.Yellow;
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.Black;
                    button5.BackColor = Color.Black;
                    button6.BackColor = Color.Red;

                }
                else if (time > 15 && time <= 25)
                {
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.Black;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Green;
                    button5.BackColor = Color.Black;
                    button6.BackColor = Color.Black;

                }
                else if (time > 25 && time <= 30)
                {
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.Black;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Black;
                    button5.BackColor = Color.Yellow;
                    button6.BackColor = Color.Black;

                }

            }
            else
            {
                if (time % 2 == 0)
                {
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.Yellow;
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.Black;
                    button5.BackColor = Color.Yellow;
                    button6.BackColor = Color.Black;

                }
                else
                {
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.Black;
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.Black;
                    button5.BackColor = Color.Black;
                    button6.BackColor = Color.Black;
                }
            }

            

        }


    }
}
