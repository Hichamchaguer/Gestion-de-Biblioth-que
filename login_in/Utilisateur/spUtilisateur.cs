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
    public partial class spUtilisateur : Form
    {
        SqlConnection cn = new SqlConnection();
        public spUtilisateur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            string req = "delete from users where logine ='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(req, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("bien supprimer");
            textBox1.Clear();
               
        }
        
        private void spUtilisateur_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "data source=DESKTOP-98JSGP2; initial catalog=projetliv;integrated security=True";
           
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
