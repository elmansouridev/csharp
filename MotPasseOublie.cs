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
    public partial class MotPasseOublie : Form
    {
        public MotPasseOublie()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=GestionStock1;Integrated Security=True");
        BindingSource bs = new BindingSource();
        SqlCommand Command = new SqlCommand();
        SqlDataReader DataReader;
        public bool confirm = false;
        private void bConfirmer_Click(object sender, EventArgs e)
        {
            cn.Open();
            Command.Connection = cn;
            Command.CommandText = string.Format(@"select * from Employe where MatriculeEmp='{0}' and NomEmp='{1}' and Prenom='{2}' and NomDep='{3}'"
                                                , textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            DataReader = Command.ExecuteReader();
            if (DataReader.Read())
            {
                DataReader.Close();
                MessageBox.Show("Bien Confirmé");
            }
            else
            {
                MessageBox.Show("Les Informations sont Incorrect","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            confirm = true;
            cn.Close();
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            
            
            if (confirm==true)
            {
                cn.Open();
                Command.Connection = cn;
                Command.CommandText = string.Format("update Inscription set MotDePasseEmp='{0}' where MatriculeEmp='{1}'"
                    , textBox5.Text, textBox1.Text);
                DataReader = Command.ExecuteReader();
                DataReader.Close();
                MessageBox.Show("Mot de passe initialisé");
                confirm = false;
                cn.Close();
            }
            else
            {
                MessageBox.Show("Confirmez les Informations avant Enregistrer","Echec",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

 




    }
}
