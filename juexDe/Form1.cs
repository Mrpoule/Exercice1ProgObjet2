using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juexDe
{
    public partial class Form1 : Form
    {
        private readonly Controleur controleur;
        public Form1()
        {
            InitializeComponent();
            controleur = new Controleur();
            
        }

        private void btn_brasser_Click(object sender, EventArgs e)
        {
            
            List<string> resultats = controleur.BrasserLesDes();
            

            lbl_deCourant.Text = "De courant: "+resultats[0];
            lbl_valeurObtenue.Text = "Valeur obtenue: " + resultats[1];
            lbl_totalPoints.Text = "Total points: " + resultats[2];
        }
    }
}
