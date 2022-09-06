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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void acceuil_Load(object sender, EventArgs e)
        {
          
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterLivre a = new AjouterLivre();
            a.MdiParent = this;
            a.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerLivre s = new SupprimerLivre();
            s.MdiParent = this;
            s.Show();
        }

        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consulterLivre c = new consulterLivre();
            c.MdiParent = this;
            c.Show();
        }

        private void nouvelUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nvUtilisateur nv = new nvUtilisateur();
            nv.MdiParent = this;
            nv.Show();
        }

        private void supprimerUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spUtilisateur sp = new spUtilisateur();
            sp.MdiParent = this;
            sp.Show();

        }

        private void modifierUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listeDesUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LstUtilisateur lst = new LstUtilisateur();
            lst.MdiParent = this;
            lst.Show();
        }

        private void listeDesLivresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listeLivre l = new listeLivre();
            l.MdiParent = this;
            l.Show();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void livreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
