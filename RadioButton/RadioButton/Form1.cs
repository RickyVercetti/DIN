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
            DialogResult dr = DialogResult.None;
            if (radioButton1.Checked)
            {
               dr = MessageBox.Show("Seguro que quiere destruir el mundo?","Si o No", MessageBoxButtons.YesNo);
            }
            else if (radioButton2.Checked)
            {
               dr = MessageBox.Show("Quieres acabar con el cambio climatico?","Ahora puedes Cancelar",MessageBoxButtons.YesNoCancel);
            }
            else if (radioButton3.Checked)
            {
               dr = MessageBox.Show("Tu voto a fallado, ¿Quieres reintentarlo?", "¿Reintentar?", MessageBoxButtons.RetryCancel);
            }
            textBox1.Text = dr.ToString();
        }
    }
}
