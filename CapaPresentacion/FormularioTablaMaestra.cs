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
    public partial class FormularioTablaMaestra : Form
    {
        public int idTablaMaestra;
        public FormularioTablaMaestra()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var tablaNegocio = new CapaDeNegocios.TablaMaestra();

            if(txtNombre.Text=="" || txtValor.Text=="" || txtVidaUtil.Text=="" || txtPeriodos.Text == "" || txtUnidadDeTiempo.Text=="")
            {
                MessageBox.Show("Existen campos sin diligenciar.", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNit.Text=="" || txtProveedor.Text=="" || txtCedula.Text=="" || txtResponsable.Text=="" || txtIdArea.Text=="")
            {
                MessageBox.Show("Existen campos sin diligenciar.", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                var TablaInsertar = new CapaDeDatos.TablaMaestra()
                {
                    Nombre = txtNombre.Text,
                    Valor = Convert.ToDouble(txtValor.Text),
                    VidaUtil = Convert.ToDouble(txtVidaUtil.Text),
                    FechaInicial = dateFechaInicial.Value,
                    Periodos = Convert.ToDouble(txtPeriodos.Text),
                    UnidadDeTiempo = txtUnidadDeTiempo.Text[0],
                    FechaFinal = dateFechaFinal.Value,
                    Nit = Convert.ToInt32(txtNit.Text),
                    Proveedor = txtProveedor.Text,
                    Cedula = Convert.ToInt32(txtCedula.Text),
                    Responsable = txtResponsable.Text,
                    idArea = Convert.ToInt32(txtIdArea.Text)
                };

                var mensaje = tablaNegocio.InsertarTablaMaestra(TablaInsertar);

                MessageBox.Show(mensaje, "Datos insertados correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = tablaNegocio.ListarTablaMaestra();
            }
            catch (Exception)
            {

                MessageBox.Show("Formato de datos incorrectos","Atenciòn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            

        }

        private void FormularioTablaMaestra_Load(object sender, EventArgs e)
        {
            var tabla = new CapaDeNegocios.TablaMaestra();
            dataGridView1.DataSource = tabla.ListarTablaMaestra();

            dataGridView1.Columns[0].HeaderText = "idTabla Maestra";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Valor";
            dataGridView1.Columns[3].HeaderText = "Vida Util";
            dataGridView1.Columns[4].HeaderText = "Fecha Inicial";
            dataGridView1.Columns[5].HeaderText = "Periodos";
            dataGridView1.Columns[6].HeaderText = "Unidad de Tiempo";
            dataGridView1.Columns[7].HeaderText = "Fecha Final";
            dataGridView1.Columns[8].HeaderText = "Nit";
            dataGridView1.Columns[9].HeaderText = "Proveedor";
            dataGridView1.Columns[10].HeaderText = "Cedula";
            dataGridView1.Columns[11].HeaderText = "Proveedor";
            dataGridView1.Columns[12].HeaderText = "id Area";
        }

        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var tablaNegocio = new CapaDeNegocios.TablaMaestra();

            if (txtNombre.Text == "" || txtValor.Text == "" || txtVidaUtil.Text == "" || txtPeriodos.Text == "" || txtUnidadDeTiempo.Text == "")
            {
                MessageBox.Show("Existen campos sin diligenciar.", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNit.Text == "" || txtProveedor.Text == "" || txtCedula.Text == "" || txtResponsable.Text == "" || txtIdArea.Text == "")
            {
                MessageBox.Show("Existen campos sin diligenciar.", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (idTablaMaestra <= 0)
            {
                MessageBox.Show("Ninguna fila seleccionada.", "Atenciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var TablaInsertar = new CapaDeDatos.TablaMaestra()
                {
                    idMaestro = idTablaMaestra,
                    Nombre = txtNombre.Text,
                    Valor = Convert.ToDouble(txtValor.Text),
                    VidaUtil = Convert.ToDouble(txtVidaUtil.Text),
                    FechaInicial = dateFechaInicial.Value,
                    Periodos = Convert.ToDouble(txtPeriodos.Text),
                    UnidadDeTiempo = txtUnidadDeTiempo.Text[0],
                    FechaFinal = dateFechaFinal.Value,
                    Nit = Convert.ToInt32(txtNit.Text),
                    Proveedor = txtProveedor.Text,
                    Cedula = Convert.ToInt32(txtCedula.Text),
                    Responsable = txtResponsable.Text,
                    idArea = Convert.ToInt32(txtIdArea.Text)
                };

                var mensaje = tablaNegocio.ActualizarTablaMaestra(TablaInsertar);

                MessageBox.Show(mensaje, "Datos Actualizados correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = tablaNegocio.ListarTablaMaestra();
            }
            catch (Exception)
            {

                MessageBox.Show("Formato de datos incorrectos", "Atenciòn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idTablaMaestra <=0)
            {
                MessageBox.Show("Ninguna fila seleccionada.", "Atenciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                var CapaNegocio = new CapaDeNegocios.TablaMaestra();

                var mensaje = CapaNegocio.EliminarTablaMaestra(idTablaMaestra);

                MessageBox.Show(mensaje, "Datos Eliminados correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = CapaNegocio.ListarTablaMaestra();
            }
            catch (Exception)
            {

                MessageBox.Show("Problemas de conexiòn con el servidor","Atenciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                idTablaMaestra = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtValor.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtVidaUtil.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateFechaInicial.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                txtPeriodos.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtUnidadDeTiempo.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                dateFechaFinal.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
                txtNit.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtProveedor.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtCedula.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtResponsable.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtIdArea.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            }
            catch (Exception)
            {

            }
            
        }

        private void btnVerParametros_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioMenu.ActiveForm.Hide();

            var formulariomenu = new FormularioMenu();
            formulariomenu.Show();

            var formularioParametros = new FormularioParametros();
            if (formulariomenu.PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                formulariomenu.Controls.Clear();
            }
            formularioParametros.TopLevel = false;
            formularioParametros.Dock = DockStyle.Fill;
            formularioParametros.FormBorderStyle = FormBorderStyle.None;
            formulariomenu.Controls.Add(formularioParametros);
            formularioParametros.Show();

        }
    }
}
