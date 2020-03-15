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
    public partial class FormularioAreas : Form
    {
        public int idArea;
        public FormularioAreas()
        {
            InitializeComponent();
        }

        private void FormularioAreas_Load(object sender, EventArgs e)
        {
            var AreaNegocio = new CapaDeNegocios.Areas();
            dataGridView1.DataSource = AreaNegocio.ListarAreas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text=="" || txtDepartamento.Text == "")
            {
                MessageBox.Show("Existen campos sin diligenciar.", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var AreaNegocio = new CapaDeNegocios.Areas();

                var AreaInsertar = new CapaDeDatos.Areas()
                {
                    Nombre = txtNombre.Text,
                    Departamento = txtDepartamento.Text
                };

                var mensaje = AreaNegocio.InsertarArea(AreaInsertar);

                MessageBox.Show(mensaje, "Area Insertada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombre.Text = "";
                txtDepartamento.Text = "";
                dataGridView1.DataSource = AreaNegocio.ListarAreas();
            }
            catch (Exception)
            {

                MessageBox.Show("Error de conexion o de formato, valide los campos","¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDepartamento.Text == "")
            {
                MessageBox.Show("Existen campos sin diligenciar.", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var AreaNegocio = new CapaDeNegocios.Areas();

                var AreaActualizar = new CapaDeDatos.Areas()
                {
                    idArea = idArea,
                    Nombre = txtNombre.Text,
                    Departamento = txtDepartamento.Text
                };

                var mensaje = AreaNegocio.ActualizarArea(AreaActualizar);

                MessageBox.Show(mensaje, "Area Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombre.Text = "";
                txtDepartamento.Text = "";
                dataGridView1.DataSource = AreaNegocio.ListarAreas();


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
                idArea = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDepartamento.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception)
            {

              
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idArea <= 0)
            {
                MessageBox.Show("Seleccione una fila por favor", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var mensaje=new CapaDeNegocios.Areas().EliminarArea(idArea);

                MessageBox.Show(mensaje, "Area Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombre.Text = "";
                txtDepartamento.Text = "";
                dataGridView1.DataSource = new CapaDeNegocios.Areas().ListarAreas();

            }
            catch (Exception)
            {

                MessageBox.Show("Error de conexion o de formato, valide los campos", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
