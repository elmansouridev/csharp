using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionStock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=GestionStock1;Integrated Security=True");

        SqlCommand Command = new SqlCommand();
        SqlDataReader DataReader;

        private void button3_Click(object sender, EventArgs e)
        {
            

            Inscription f = new Inscription();
            f.Hide();
            f.ShowDialog();
        }

        private void bConnexion_Click(object sender, EventArgs e)
        {
            cn.Open();
            Command.Connection = cn;
            Command.CommandText = string.Format(@"select * 
                                                        from Inscription where MatriculeEmp= '{0}' and MotDePasseEmp='{1}' ",
                                                        textBox1.Text,
                                                        textBox2.Text);
            DataReader = Command.ExecuteReader();
            
            if (DataReader.HasRows)
            {
                GestionStock f = new GestionStock();
                f.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Les informations qui vous avez donnée n'est pas valides !!!", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataReader.Close();
            cn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MotPasseOublie f = new MotPasseOublie();
            f.Hide();
            f.ShowDialog();
        }

    }
}
