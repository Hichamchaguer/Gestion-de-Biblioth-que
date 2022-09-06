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
    public partial class LstUtilisateur : Form
    {
        SqlConnection cn = new SqlConnection();
        public LstUtilisateur()
        {
            InitializeComponent();
        }

        private void LstUtilisateur_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "data source=DESKTOP-98JSGP2; initial catalog=projetliv;integrated security=True";

            cn.Open();
            string req = "select * from users";
            SqlDataAdapter adp  = new SqlDataAdapter(req, cn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
    }
}
