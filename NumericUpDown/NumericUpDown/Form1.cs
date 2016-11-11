using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            calcularIntereses();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            calcularIntereses();
        }

        private void calcularIntereses()
        {
            double dinero = Convert.ToInt32(textBox1.Text);
            int anyo = (int) numericUpDown1.Value;
            double intereses = (double) numericUpDown2.Value;
            string[] array = new string[anyo];

            if (!(textBox1.Size.Equals("") && numericUpDown1.Equals(0) && numericUpDown2.Equals(0)))
            {
                
                for (int i=0;i<anyo;i++)
                {
                    double cuota = dinero * ((intereses * Math.Pow(1 + intereses, anyo)) / Math.Pow(1 + intereses, anyo) - 1);
                    array[i] = cuota.ToString();
                    dinero = dinero - cuota;
                }
            }
            textBox2.Lines = array;
        }
    }
}
