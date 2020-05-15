using System;
using System.Linq;
using System.Windows.Forms;

namespace DataView
{
    public partial class FrmExpedienteMedico : Form
    {
        
        public FrmExpedienteMedico()
        {
            InitializeComponent();
            LlenarFecha();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FrmPrincipal().Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (BuscarAnimal() == true)
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                MessageBox.Show("El animal no se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool BuscarAnimal()
        {
            /**var animal = db.tbAnimal.FirstOrDefault(a => a.CodigoAnimal == txtCodigoAnimal.Text);
            if (animal != null)
            {
                return true;
            }*/
            return false;
        }
        public void LlenarFecha()
        {
            string dateString = DateTime.Now.ToString("dd/MM/yyyy");
            txtFecha.Text = dateString;
        }
    }
}
