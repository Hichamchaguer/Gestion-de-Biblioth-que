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
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection();
        int i = 0;
        SqlDataReader dr;
        //DataSet ds = new DataSet();

        private void log_Load(object sender, EventArgs e)
        {
             cn.ConnectionString = "data source=DESKTOP-98JSGP2; initial catalog=projetliv;integrated security=True";
            this.Width = 670;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string x = "NONE";
            cn.Open();
            string req = "select * from users where logine = '" + textBox1.Text + "' and motdepasse = '" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(req, cn);
             dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (textBox1.Text.Equals(dr[0].ToString()) && textBox2.Text.Equals(dr[1].ToString()))
                    
                {
                    i = 1;
                    if (dr[2].ToString() == "admin")
                        x = "admin";
                    else
                        x = "utilisateur";
                        
                }
                break;
            }
            if (i == 1 && x == "admin")
            {
                
                this.Hide();
                Admin a = new Admin();
                a.ShowDialog();
            }
            else if (i == 1 && x == "utilisateur")
            {
                cn.Close();
                this.Hide();
                Utilisateur u = new Utilisateur();
                u.ShowDialog();
            }
            else
            {
                lbl.Text = "login or password incorect";
                lbl.ForeColor = Color.GreenYellow;
                
            }
            

            cn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool etat = false;
            string x = "NONE";
            cn.Open();
            string req = "select * from users where logine = '" + textBox1.Text+ "'";
            SqlCommand cmd = new SqlCommand(req, cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
                if (textBox1.Text.Equals(dr[0].ToString()))
                {
                    etat = true;
                    if (dr[2].ToString() == "admin")
                        x = "admin";
                    else
                        x = "utilisateur";
                }
            if (etat == true && x == "admin")
            {
                roleLbl.Text = "ADMIN";
                roleLbl.ForeColor = Color.Blue;
            }
            else if (etat == true && x == "utilisateur")
            {
                roleLbl.Text = "UTILISATEUR";
                roleLbl.ForeColor = Color.GreenYellow;
            }
            else
            {
                roleLbl.Text = "";
            }
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void roleLbl_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            this.Width = 1100;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            lbl1.Text = "";
            this.Width = 670;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                lbl1.Text = "Tous les champs sont obligatoires !";
                lbl1.ForeColor = Color.GreenYellow;

            }
            else
            {
                cn.Open();
                string req = "insert into users values ('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                SqlCommand cmd = new SqlCommand(req, cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("l'ajout bien affecter");
                cn.Close();
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
