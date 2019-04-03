using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenementEx
{
    public delegate void ChangementPrixPrototype(object o, ChangementPrixEventArgs e);
    class Livre
    {
        private string titre;
        private decimal prixHt;
        private decimal tauxTva;
        public ChangementPrixPrototype changementPrix;

        public Livre (string titre, decimal prix, decimal tauxTva)
        {
            this.titre = titre;
            this.prixHt = prixHt;
            this.tauxTva = tauxTva;
        }

        public void HausseAnnuelle()
        {
            prixHt = prixHt * (decimal)1.1;
        }

        public decimal PrixTTC
        {
            get { return (1 + this.tauxTva / 100) * this.prixHt; }
        }

        public override string ToString()
        {
            return this.titre;
        }

        public decimal PrixHt
        {
            set
            {
                decimal ancienPrix = this.prixHt;
                prixHt = value;
                OnChangementPrix(ancienPrix, value, this.PrixTTC);
            }
            get { return prixHt; }
        }

        public void OnChangementPrix(decimal ancienPrix, decimal nouveauPrix, decimal nouveauPrixTTC)
        {
            if(changementPrix != null)
            {
                changementPrix(this, new ChangementPrixEventArgs(ancienPrix, nouveauPrix, nouveauPrixTTC));
            }
        }
    }
}
