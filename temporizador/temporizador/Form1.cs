using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temporizador
{
    public partial class Form1 : Form
    {
        double time;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time >= 100)
            {
                time = 0;
                label2.Text = "Temporizador: " + time.ToString();
            }
            else
            {
                label2.Text = "Temporizador: " + time.ToString();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(comboBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
                button1.Text = "Stop";
            }
            else
            {
                timer1.Stop();
                button1.Text = "Start";
            }
        }
    }
}
