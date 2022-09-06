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
    public partial class listeLivre : Form
    {
        SqlConnection cn =  new SqlConnection();
        public listeLivre()
        {
            InitializeComponent();
        }

        private void listeLivre_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "data source=DESKTOP-98JSGP2; initial catalog=projetliv;integrated security=True";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            cn.Open();
            string req = "select * from livre where dateAchat between '"+dateTimePicker1.Value+"' and '"+dateTimePicker2.Value+"'";
            SqlDataAdapter adp = new SqlDataAdapter(req, cn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
