using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private int num1 = 0, num2 = 0;
        private bool introducir;
        private char operacion;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Button(object sender, EventArgs e)
        {
            if (BOX.TextLength<=10)
            {
                Button boton = (Button)sender;
                BOX.Text += boton.Text;
            }
        }
        public void BorrarTexto(object sender, EventArgs e)
        {
            BOX.Text = "0";
            num1 = 0;
            num2 = 0;
        }
        public void Operaciones(Object sender, EventArgs e)
        {

        }
    }
}
