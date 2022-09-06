using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login_in
{
    public partial class nvUtilisateur : Form
    {
        SqlConnection cn = new SqlConnection();
        public nvUtilisateur()
        {
            InitializeComponent();
        }

        private void nvUtilisateur_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "data source=DESKTOP-98JSGP2; initial catalog=projetliv;integrated security=True";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" )
            {
                lblcheck.Text = "Tous les champs sont obligatoires !";
                lblcheck.ForeColor = Color.Red;
                
            }
            else
            {
                cn.Open();
                string req = "insert into users values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                SqlCommand cmd = new SqlCommand(req, cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("l'ajout bien affecter");
                cn.Close();
                textBox1.Clear();
                textBox2.Clear();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
