using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
            cmd.CommandText = "Select * from cliente where id =" + TBClient.Text;
            //cmd.Connection = conex;
            MySqlDataReader data = cmd.ExecuteReader();
            if (data.HasRows)
            {
                while (data.Read())
                {
                    String name = data.GetString(1);
                    LBLName.Text = name;
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBLNameCheckBox.Text = comboBox1.SelectedItem.
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String myConex = "Server=localhost;Database=clientes;Uid=root;Pwd=1234;";
            MySqlConnection conex = new MySqlConnection(myConex);

            MySqlCommand cmd;
            conex.Open();

            cmd = conex.CreateCommand();
            cmd.CommandText = "Select * from cliente";

            MySqlDataReader data = cmd.ExecuteReader();
            if (data.HasRows)
            {
                while (data.Read())
                {
                    comboBox1.Items.Add(data.GetInt32(0));
                    LBLNameCheckBox.Text = data.GetString(1);
                }
            }
        }
    }
}
