using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenementEx
{
    public class ChangementPrixEventArgs : EventArgs
    {
        private decimal ancienPrix;
        private decimal nouveauPrix;
        private decimal nouveauPrixTTC;

        public decimal AncienPrix
        {
            get { return ancienPrix; }
        }

        public decimal NouveauPrix
        {
            get { return nouveauPrix; }
        }

        public ChangementPrixEventArgs (decimal ancienPrix, decimal nouveauPrix, decimal nouveauPrixTTC)
        {
            this.nouveauPrixTTC = nouveauPrixTTC;
            this.nouveauPrix = nouveauPrix;
            this.ancienPrix = ancienPrix;
        }
    }
}
