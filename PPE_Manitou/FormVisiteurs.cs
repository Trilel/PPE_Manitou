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
    public partial class FormVisiteurs : Form
    {
        public FormVisiteurs()
        {
            InitializeComponent();
        }

        private void FormVisiterus_Load(object sender, EventArgs e)
        {

        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
            FormGestionDesComptesRendus f = new FormGestionDesComptesRendus();
            f.Show();
        }
    }
}
