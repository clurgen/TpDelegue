using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvenementEx
{
    public partial class FLivre : Form
    {
        Livre unLivre;
        public FLivre(Livre unLivre)
        {
            InitializeComponent();
            this.unLivre = unLivre;

            this.tbPrix.Text = unLivre.PrixTTC.ToString();
            this.tbPrixTTC.Text = unLivre.PrixHt.ToString();
            this.tbTitre.Text = unLivre.ToString();

            //this.unLivre.changementPrix += new EventHandler Livre_ChangementPrix ;

            //btnModifier.Click += new EventHandler(this.btnModifier.Click);
        }
    }
}
