using MDI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class Form1 : Form
    {
        private int num = 0;

        public void setNum(int n)
        {
            num = n;
        }

        public String getNum()
        {
            return num.ToString();
        }

        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.setNum(num);
            form2.Text = form2.getNum();
            form2.Show();
            num++;
        }
    }
}
