using System;

using System.Data;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class FormularioLogin : Form
    {
        public FormularioLogin()
        {
            InitializeComponent();
        }

        // Se utiliza para permitir mover el formulario a través de la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        // Se utiliza para permitir mover el formulario a través de la pantalla
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr handler, int wmsg, int wparam, int lparam);

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            //var parametros = new[]
            //{
            //    new SqlParameter()
            //}
            //new CapaDeDatos.Conexion().EjecutarStoredProcedureDeListado()
        }

        private void FormularioLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconPictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
