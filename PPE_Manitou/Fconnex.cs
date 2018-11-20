using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_Manitou
{
    public partial class Fconnex : Form
    {
        public Fconnex()
        {
            InitializeComponent();
        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string id = txtIdentifiant.Text;
            string mdp = txtPasswd.Text;
            cbotest.ValueMember = "identifiant";
            cbotest2.ValueMember = "password";
            bsVisiteur.DataSource = Modele.listeVisiteur();
            cbotest.DataSource = bsVisiteur;
            cbotest2.DataSource = bsVisiteur;
            bool connecte = Modele.connection(id, mdp);
            if(connecte)
            {
                Application.Exit();
            }else
            {
                txtPasswd.Clear();
                lblError.Visible = true;
            }
        }

        private void Fconnex_Load(object sender, EventArgs e)
        {

        }
    }
}
