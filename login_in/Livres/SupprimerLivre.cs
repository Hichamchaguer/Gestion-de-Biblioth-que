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
    public partial class SupprimerLivre : Form
    {
        SqlConnection cn = new SqlConnection();
        public SupprimerLivre()
        {
            InitializeComponent();
        }
        int i = 0;
        private void SupprimerLivre_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "data source=DESKTOP-98JSGP2; initial catalog=projetliv;integrated security=True";

            string h = "select * from livre";
            cn.Open();
            SqlCommand cmd = new SqlCommand(h, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            i = 0;
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["code"]);
                t[i] = int.Parse(dr[0].ToString());
                i++;
            }
            cn.Close();

        }
        int[] t = new int[99];
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            string req = "select * from livre where code=" + t[comboBox1.SelectedIndex];
            SqlCommand cmd = new SqlCommand(req, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["titre"].ToString();
                textBox2.Text = dr["auteur"].ToString();
                textBox3.Text = dr["dateAchat"].ToString();
                textBox4.Text = dr["prix"].ToString();
            }
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text=="" || textBox3.Text==""|| textBox4.Text=="")
            {
                lblcheck.Text = "Tous les champs sont obligatoires";
                lblcheck.ForeColor = Color.Red;
            }
            else
            {
                DialogResult reponse = MessageBox.Show("Vous voullez bien supprimer", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult.Yes == reponse)
                {
                    cn.Open();
                    string req = "delete from livre where code=" + t[comboBox1.SelectedIndex];
                    SqlCommand cmd = new SqlCommand(req, cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
                else
                {
                    MessageBox.Show("Suppression est annulé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
