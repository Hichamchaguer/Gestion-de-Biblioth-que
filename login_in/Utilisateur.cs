using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_in
{
    public partial class Utilisateur : Form
    {
        public Utilisateur()
        {
            InitializeComponent();
        }

        private void Utilisateur_Load(object sender, EventArgs e)
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

        private void livreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerLivre l = new SupprimerLivre();
            l.MdiParent = this;
            l.Show();
        }

        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consulterLivre c = new consulterLivre();
            c.MdiParent = this;
            c.Show();
        }

        private void listesDesLivresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listeLivre l = new listeLivre();
            l.MdiParent = this;
            l.Show();
        }

        private void modiferToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
