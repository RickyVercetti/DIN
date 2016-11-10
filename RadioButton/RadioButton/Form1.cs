using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                MessageBox.Show("Seguro que quiere destruir el mundo?","Si o No", MessageBoxButtons.YesNo);
            }
            if (radioButton2.Checked==true)
            {
                MessageBox.Show("Quieres acabar con el cambio climatico?","Ahora puedes Cancelar",MessageBoxButtons.YesNoCancel);
            }
        }
    }
}
