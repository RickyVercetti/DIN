using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String myConex = "Server=localhost;Database=clientes;Uid=root;Pwd=1234;";
            MySqlConnection conex = new MySqlConnection(myConex);

            MySqlCommand cmd;
            conex.Open();

            cmd = conex.CreateCommand();
            cmd.CommandText = "INSERT into cliente (id,name) VALUES('"+textID.Text+"','"+textName.Text+"')";
            //cmd.Connection = conex;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Introducido correctamente!");
        }
    }
}
