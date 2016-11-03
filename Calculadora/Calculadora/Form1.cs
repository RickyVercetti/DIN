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
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Button(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            BOX.Text += boton.Text;
        }
        public void BorrarTexto(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            //BOX.Text(0);
        }
    }
}
