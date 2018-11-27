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
            if (Modele.connection(txtIdentifiant.Text, txtPasswd.Text))
            {
                FormGestionDesComptesRendus f = new FormGestionDesComptesRendus();
                f.Show();
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
