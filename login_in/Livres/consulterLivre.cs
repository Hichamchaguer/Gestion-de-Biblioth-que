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
    public partial class consulterLivre : Form
    {

        SqlConnection cn = new SqlConnection("data source=DESKTOP-98JSGP2; initial catalog=projetliv;integrated security=True");
        SqlDataAdapter ad;
        DataTable dt;
        DataSet ds = new DataSet();
        public consulterLivre()
        {
            InitializeComponent();
        }
        
        
        private void consultertxt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="")
            {
                lblcheck.Text = "Le code n'éxiste pas !!";
                lblcheck.ForeColor = Color.Red;
                dataGridView1.DataSource = null;
                
            }
            else
            {
                if (lblcheck.Text=="Le code n'éxiste pas !!")
                {
                    lblcheck.Text = "";
                }
                
                string req = "select * from livre where code='" + textBox1.Text + "'";
                cn.Open();
                SqlCommand cmd = new SqlCommand(req, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr["titre"].ToString();
                    textBox3.Text = dr["auteur"].ToString();
                    textBox4.Text = dr["dateAchat"].ToString();
                    textBox5.Text = dr["prix"].ToString();
                }
                cn.Close();
                cn.Open();
                SqlDataAdapter adp = new SqlDataAdapter(req, cn);
                dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
            }
            
        }

        private void consulterLivre_Load(object sender, EventArgs e)
        {
            ad = new SqlDataAdapter("select * from livre", cn);
            ad.Fill(ds, "livre");
            dt = ds.Tables["livre"];
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            dataGridView1.DataSource = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        int i = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            
                textBox2.Text = dt.Rows[dt.Rows.Count - 1][1].ToString();
                textBox3.Text = dt.Rows[dt.Rows.Count - 1][2].ToString();
                textBox4.Text = dt.Rows[dt.Rows.Count - 1][3].ToString();
                textBox5.Text = dt.Rows[dt.Rows.Count - 1][4].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                textBox2.Text = dt.Rows[0][1].ToString();
                textBox3.Text = dt.Rows[0][2].ToString();
                textBox4.Text = dt.Rows[0][3].ToString();
                textBox5.Text = dt.Rows[0][4].ToString();
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            if (i < dt.Rows.Count-1)
            {
                i++;
                textBox2.Text = dt.Rows[i][1].ToString();
                textBox3.Text = dt.Rows[i][2].ToString();
                textBox4.Text = dt.Rows[i][3].ToString();
                textBox5.Text = dt.Rows[i][4].ToString();
            }
            else
            {
                MessageBox.Show("Fin d'enregistrement","Sauvegarde", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                textBox2.Text = dt.Rows[i][1].ToString();
                textBox3.Text = dt.Rows[i][2].ToString();
                textBox4.Text = dt.Rows[i][3].ToString();
                textBox5.Text = dt.Rows[i][4].ToString();
            }
            else
            {
                MessageBox.Show("D'ébut d'enregistrement","Sauvegarde",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
    }
}
