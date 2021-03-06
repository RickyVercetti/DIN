﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(label1.Text, DragDropEffects.Copy);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(label2.Text, DragDropEffects.Copy);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(label3.Text, DragDropEffects.Copy);
        }
    }
}
