using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Botones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool fStatus;

        public bool Status
        {
            set { Status = !Status; }
            get { return fStatus; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fStatus == true)
            {
                textBox1.Text = Status.ToString();
                button1.Text = "Apagar";
                cambiaEstado();
            }
            else
            {
                textBox1.Text = Status.ToString();
                button1.Text = "Encender";
                cambiaEstado();
            }
        }
        protected void cambiaEstado()
        {
            if (fStatus == true)
            {
                fStatus = false;
            }
            else
            {
                fStatus = true;
            }
        }
    }
}
