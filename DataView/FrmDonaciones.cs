using System;

using System.Windows.Forms;

namespace DataView
{
    public partial class FrmDonaciones : Form
    {
        public FrmDonaciones()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FrmPrincipal().Show();
        }
    }
}
