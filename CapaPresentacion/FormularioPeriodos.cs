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
    public partial class FormularioPeriodos : Form
    {

        public int idParametro,idPeriodo;
        public FormularioPeriodos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNumeroAño.Text=="" || txtAño.Text=="" || txtValor.Text=="" || txtidParametro.Text=="")
            {
                MessageBox.Show("Existen campos sin diligenciar.", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var PeriodoInsertar = new CapaDeDatos.Periodos()
                {
                    NumeroAño = Convert.ToInt32(txtNumeroAño.Text),
                    Año = Convert.ToInt32(txtAño.Text),
                    Valor = Convert.ToDouble(txtValor.Text),
                    idParametro= Convert.ToInt32(txtidParametro.Text)
                };

                var mensaje = new CapaDeNegocios.Periodos().InsertarPeriodo(PeriodoInsertar);

                MessageBox.Show(mensaje, "Periodo Insertado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNumeroAño.Text = "";
                txtAño.Text = "";
                txtValor.Text = "";
                txtidParametro.Text = "";
                dataGridView1.DataSource = new CapaDeNegocios.Periodos().ListarPeriodos();
            }
            catch (Exception)
            {

                MessageBox.Show("Error de conexion o de formato, valide los campos", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNumeroAño.Text == "" || txtAño.Text == "" || txtValor.Text == "")
            {
                MessageBox.Show("Existen campos sin diligenciar.", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var PeriodoActualizar = new CapaDeDatos.Periodos()
                {
                    idPeriodo=idPeriodo,
                    NumeroAño = Convert.ToInt32(txtNumeroAño.Text),
                    Año = Convert.ToInt32(txtAño.Text),
                    Valor = Convert.ToDouble(txtValor.Text)
                };

                var mensaje = new CapaDeNegocios.Periodos().ActualizarPeriodo(PeriodoActualizar);

                MessageBox.Show(mensaje, "Periodo Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNumeroAño.Text = "";
                txtAño.Text = "";
                txtValor.Text = "";
                txtidParametro.Text = "";
                dataGridView1.DataSource = new CapaDeNegocios.Periodos().ListarPeriodos();
            }
            catch (Exception)
            {

                MessageBox.Show("Error de conexion o de formato, valide los campos", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                
                var mensaje = new CapaDeNegocios.Periodos().EliminarPeriodo(idPeriodo);

                MessageBox.Show(mensaje, "Periodo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNumeroAño.Text = "";
                txtAño.Text = "";
                txtValor.Text = "";
                txtidParametro.Text = "";
                dataGridView1.DataSource = new CapaDeNegocios.Periodos().ListarPeriodos();
            }
            catch (Exception)
            {

                MessageBox.Show("Error de conexion o de formato, valide los campos", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idPeriodo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            txtNumeroAño.Text=dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAño.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtValor.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            idParametro= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
        }

        private void FormularioPeriodos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new CapaDeNegocios.Periodos().ListarPeriodos();
        }
    }
}
