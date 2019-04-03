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
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLivre fl = new FLivre();
            fl.Show();
            FHistorique fh = new FHistorique();
            fh.Show();

        }
    }
}
