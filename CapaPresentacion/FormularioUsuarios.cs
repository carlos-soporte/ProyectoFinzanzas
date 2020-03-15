using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaPresentacion.Properties;

namespace CapaPresentacion
{
    public partial class FormularioUsuarios : Form
    {
        public int idUsuario;
        public FormularioUsuarios()
        {
            InitializeComponent();
        }

        private void FormularioUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new CapaDeNegocios.Usuarios().ListarUsuarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="" || txtContraseña.Text=="")
            {
                MessageBox.Show("Existen campos sin diligenciar.", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var UsuarioInsertar = new CapaDeDatos.Usuarios()
                {
                    Usuario = txtUsuario.Text,
                    Contraseña = txtContraseña.Text
                };

                var mensaje = new CapaDeNegocios.Usuarios().InsertarUsuario(UsuarioInsertar);

                MessageBox.Show(mensaje, "Usuario Insertado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUsuario.Text = "";
                txtContraseña.Text = "";
                dataGridView1.DataSource = new CapaDeNegocios.Usuarios().ListarUsuarios();
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexion o de formato, valide los campos", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtContraseña.Text == "")
            {
                MessageBox.Show("Existen campos sin diligenciar.", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var UsuarioInsertar = new CapaDeDatos.Usuarios()
                {
                    idUsuario=idUsuario,
                    Usuario = txtUsuario.Text,
                    Contraseña = txtContraseña.Text
                };

                var mensaje = new CapaDeNegocios.Usuarios().ActualizarUsuario(UsuarioInsertar);

                MessageBox.Show(mensaje, "Usuario Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUsuario.Text = "";
                txtContraseña.Text = "";
                dataGridView1.DataSource = new CapaDeNegocios.Usuarios().ListarUsuarios();
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexion o de formato, valide los campos", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idUsuario = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            txtUsuario.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtContraseña.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var mensaje = new CapaDeNegocios.Usuarios().EliminarUsuario(idUsuario);

                MessageBox.Show(mensaje, "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUsuario.Text = "";
                txtContraseña.Text = "";
                dataGridView1.DataSource = new CapaDeNegocios.Usuarios().ListarUsuarios();


            }
            catch (Exception)
            {

                MessageBox.Show("Error de conexion o de formato, valide los campos", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
