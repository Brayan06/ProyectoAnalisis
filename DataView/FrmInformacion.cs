using AcroPDFLib;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace DataView
{
    public partial class FrmInformacion : Form
    {
        public OpenFileDialog examinar = new OpenFileDialog();
        public static string NAME;
        public FrmInformacion()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FrmPrincipal().Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string args = "Data Source=localhost;Initial Catalog=SoftColitas;Integrated Security=True";
            string ruta = "";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = args;

            try
            {
                examinar.Filter = "Archivo PDF|*.pdf";
                DialogResult res = examinar.ShowDialog();
                if (res == DialogResult.OK)
                    ruta = examinar.FileName;
                axAcroPDF.src = examinar.FileName;
                FileStream stream = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(stream);
                FileInfo fi = new FileInfo(ruta);
                byte[] binData = new byte[stream.Length];
                stream.Read(binData, 0, Convert.ToInt32(stream.Length));
            }
            catch
            {
                MessageBox.Show("Error al cargar archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Dispose();
            new FrmEnvioCorreo().Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                examinar.Filter = "Archivo PDF|*.pdf";
                DialogResult res = examinar.ShowDialog();
                if (res == DialogResult.OK) ;
                axAcroPDF.src = examinar.FileName;
                txtNombreArch.Text = examinar.FileName;
                NAME = examinar.FileName;
            }
            catch
            {
                MessageBox.Show("Error al cargar archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
