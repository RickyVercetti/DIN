using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool power = false;
        private int contador = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (power==false)
            {
                button1.Text = "Stop";
                power = true;
                timer1.Start();

            }
            else
            {
                button1.Text = "Start";
                power = false;
                timer1.Stop();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            int horas = contador / 3600;
            int minutos = (contador / 60) % 60;
            int segundos = contador % 60;
            String strHoras = (horas < 10) ? $"0{horas.ToString()}" : horas.ToString();
            String strMinutos = (minutos < 10) ? $"0{minutos.ToString()}" : minutos.ToString();
            String strSegundos = (segundos < 10) ? $"0{segundos.ToString()}" : segundos.ToString();
            label1.Text = $"{strHoras}:{strMinutos}:{strSegundos}";

            //label1.Text = contador.ToString();

            
        }
    }
}
