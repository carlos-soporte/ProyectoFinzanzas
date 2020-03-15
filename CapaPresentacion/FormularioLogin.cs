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
            

            var DataTable = new CapaDeNegocios.Usuarios().ListarUsuarios();

            for(int i = 0; i < DataTable.Rows.Count; i++)
            {
                for(int j = 0; j < DataTable.Columns.Count; j++)
                {
                    if(txtUsuario.Text==DataTable.Rows[i][1].ToString() && txtContraseña.Text == DataTable.Rows[i][2].ToString())
                    {
                        MessageBox.Show("Datos correctos, bienvenid@ al sistema.", "¡Bienvenid@!", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                        this.Hide();
                        new FormularioMenu().Show();
                        break;
                    }
                }
            }


            MessageBox.Show("Datos incorrectos, intentelo de nuevo.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
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
