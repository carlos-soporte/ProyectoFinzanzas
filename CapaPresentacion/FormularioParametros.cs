using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormularioParametros : Form
    {

        public int idParametro;
        public FormularioParametros()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtConcepto.Text=="" || txtUnidadDeMedida.Text=="" || txtUnidadDeMedida.Text=="" || txtidMaestro.Text == "")
            {
                MessageBox.Show("Existen campos sin diligenciar.", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var ParametroInsertar = new CapaDeDatos.Parametros()
                {
                    Concepto = txtConcepto.Text,
                    UnidadDeMedida = txtUnidadDeMedida.Text,
                    idMaestro = Convert.ToInt32(txtidMaestro.Text)

                };

                var mensaje = new CapaDeNegocios.Parametros().InsertarParametro(ParametroInsertar);

                MessageBox.Show(mensaje, "Paràmetro Insertado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtConcepto.Text = "";
                txtUnidadDeMedida.Text = "";
                txtidMaestro.Text = "";
                dataGridView1.DataSource = new CapaDeNegocios.Parametros().ListarParametros();
            }
            catch (Exception)
            {

                MessageBox.Show("Error de conexion o de formato, valide los campos", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtConcepto.Text == "" || txtUnidadDeMedida.Text == "" )
            {
                MessageBox.Show("Existen campos sin diligenciar.", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var ParametroActualizar = new CapaDeDatos.Parametros()
                {
                    idParametro = idParametro,
                    Concepto = txtConcepto.Text,
                    UnidadDeMedida = txtUnidadDeMedida.Text
                };

                var mensaje = new CapaDeNegocios.Parametros().ActualizarParametro(ParametroActualizar);

                MessageBox.Show(mensaje, "Paràmetro Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtConcepto.Text = "";
                txtUnidadDeMedida.Text = "";
                txtidMaestro.Text = "";
                dataGridView1.DataSource = new CapaDeNegocios.Parametros().ListarParametros();
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexion o de formato, valide los campos", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idParametro = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                txtConcepto.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtUnidadDeMedida.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                

            }
            catch (Exception)
            {

               
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idParametro <= 0)
            {
                MessageBox.Show("Seleccione una fila por favor", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var mensaje = new CapaDeNegocios.Parametros().EliminarParametro(idParametro);

                MessageBox.Show(mensaje, "Paràmetro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtConcepto.Text = "";
                txtUnidadDeMedida.Text = "";
                txtidMaestro.Text = "";
                dataGridView1.DataSource = new CapaDeNegocios.Parametros().ListarParametros();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FormularioParametros_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = new CapaDeNegocios.Parametros().ListarParametros();
        }
    }
}
