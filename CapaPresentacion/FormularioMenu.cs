using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace CapaPresentacion
{
    public partial class FormularioMenu : MaterialForm
    {
        public FormularioMenu()
        {
            InitializeComponent();
        }

        private void FormularioMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            btnListarArea.Enabled = true;
            btnInsertarArea.Enabled = true;
            btnActualizarArea.Enabled = true;
            btnEliminarArea.Enabled = true;

            btnListarUsuario.Enabled = true;
            btnInsertarUsuario.Enabled = true;
            btnActualizarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;

            btnListarParametro.Enabled = true;
            btnInsertarParametro.Enabled = true;
            btnActualizarParametro.Enabled = true;
            btnEliminarParametro.Enabled = true;

            btnListarPeriodo.Enabled = true;
            btnInsertarPeriodo.Enabled = true;
            btnActualizarPeriodo.Enabled = true;
            btnEliminarPeriodo.Enabled = true;

            btnListarTabla.Enabled = false;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = true;


            var FormularioTablaMaestra = new FormularioTablaMaestra();
            if (PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                PanelVisualizador.Controls.Clear();
            }
            FormularioTablaMaestra.TopLevel = false;
            FormularioTablaMaestra.Dock = DockStyle.Fill;
            FormularioTablaMaestra.FormBorderStyle = FormBorderStyle.None;
            PanelVisualizador.Controls.Add(FormularioTablaMaestra);
            FormularioTablaMaestra.Show();

            FormularioTablaMaestra.btnActualizar.Enabled = false;
            FormularioTablaMaestra.btnGuardar.Enabled = false;
            FormularioTablaMaestra.btnEliminar.Enabled = false;

            FormularioTablaMaestra.btnActualizar.Visible = false;
            FormularioTablaMaestra.btnGuardar.Visible = false;
            FormularioTablaMaestra.btnEliminar.Visible = false;

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            btnListarArea.Enabled = true;
            btnInsertarArea.Enabled = true;
            btnActualizarArea.Enabled = true;
            btnEliminarArea.Enabled = true;

            btnListarUsuario.Enabled = true;
            btnInsertarUsuario.Enabled = true;
            btnActualizarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;

            btnListarParametro.Enabled = true;
            btnInsertarParametro.Enabled = true;
            btnActualizarParametro.Enabled = true;
            btnEliminarParametro.Enabled = true;

            btnListarPeriodo.Enabled = true;
            btnInsertarPeriodo.Enabled = true;
            btnActualizarPeriodo.Enabled = true;
            btnEliminarPeriodo.Enabled = true;

            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = false;
            btnEliminarTabla.Enabled = true;

            var FormularioTablaMaestra = new FormularioTablaMaestra();
            if (PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                PanelVisualizador.Controls.Clear();
            }
            FormularioTablaMaestra.TopLevel = false;
            FormularioTablaMaestra.Dock = DockStyle.Fill;
            FormularioTablaMaestra.FormBorderStyle = FormBorderStyle.None;
            PanelVisualizador.Controls.Add(FormularioTablaMaestra);
            FormularioTablaMaestra.Show();
            FormularioTablaMaestra.btnActualizar.Enabled = false;
            FormularioTablaMaestra.btnEliminar.Enabled = false;

            FormularioTablaMaestra.btnActualizar.Visible = false;
            FormularioTablaMaestra.btnEliminar.Visible = false;
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            btnListarArea.Enabled = true;
            btnInsertarArea.Enabled = true;
            btnActualizarArea.Enabled = true;
            btnEliminarArea.Enabled = true;

            btnListarUsuario.Enabled = true;
            btnInsertarUsuario.Enabled = true;
            btnActualizarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;

            btnListarParametro.Enabled = true;
            btnInsertarParametro.Enabled = true;
            btnActualizarParametro.Enabled = true;
            btnEliminarParametro.Enabled = true;

            btnListarPeriodo.Enabled = true;
            btnInsertarPeriodo.Enabled = true;
            btnActualizarPeriodo.Enabled = true;
            btnEliminarPeriodo.Enabled = true;

            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = false;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = true;

            var FormularioTablaMaestra = new FormularioTablaMaestra();
            if (PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                PanelVisualizador.Controls.Clear();
            }
            FormularioTablaMaestra.TopLevel = false;
            FormularioTablaMaestra.Dock = DockStyle.Fill;
            FormularioTablaMaestra.FormBorderStyle = FormBorderStyle.None;
            PanelVisualizador.Controls.Add(FormularioTablaMaestra);
            FormularioTablaMaestra.Show();

            FormularioTablaMaestra.btnEliminar.Enabled = false;
            FormularioTablaMaestra.btnGuardar.Enabled = false;

            FormularioTablaMaestra.btnEliminar.Visible = false;
            FormularioTablaMaestra.btnGuardar.Visible = false;

            
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            btnListarArea.Enabled = true;
            btnInsertarArea.Enabled = true;
            btnActualizarArea.Enabled = true;
            btnEliminarArea.Enabled = true;

            btnListarUsuario.Enabled = true;
            btnInsertarUsuario.Enabled = true;
            btnActualizarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;

            btnListarParametro.Enabled = true;
            btnInsertarParametro.Enabled = true;
            btnActualizarParametro.Enabled = true;
            btnEliminarParametro.Enabled = true;

            btnListarPeriodo.Enabled = true;
            btnInsertarPeriodo.Enabled = true;
            btnActualizarPeriodo.Enabled = true;
            btnEliminarPeriodo.Enabled = true;

            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = false;

            var FormularioTablaMaestra = new FormularioTablaMaestra();
            if (PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                PanelVisualizador.Controls.Clear();
            }
            FormularioTablaMaestra.TopLevel = false;
            FormularioTablaMaestra.Dock = DockStyle.Fill;
            FormularioTablaMaestra.FormBorderStyle = FormBorderStyle.None;
            PanelVisualizador.Controls.Add(FormularioTablaMaestra);
            FormularioTablaMaestra.Show();

            FormularioTablaMaestra.btnActualizar.Enabled = false;
            FormularioTablaMaestra.btnGuardar.Enabled = false;

            FormularioTablaMaestra.btnActualizar.Visible = false;
            FormularioTablaMaestra.btnGuardar.Visible = false;

        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = true;

            btnListarUsuario.Enabled = true;
            btnInsertarUsuario.Enabled = true;
            btnActualizarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;

            btnListarArea.Enabled = false;
            btnInsertarArea.Enabled = true;
            btnActualizarArea.Enabled = true;
            btnEliminarArea.Enabled = true;

            btnListarParametro.Enabled = true;
            btnInsertarParametro.Enabled = true;
            btnActualizarParametro.Enabled = true;
            btnEliminarParametro.Enabled = true;

            btnListarPeriodo.Enabled = true;
            btnInsertarPeriodo.Enabled = true;
            btnActualizarPeriodo.Enabled = true;
            btnEliminarPeriodo.Enabled = true;

            var formularioAreas = new FormularioAreas();
            if (PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                PanelVisualizador.Controls.Clear();
            }
            formularioAreas.TopLevel = false;
            formularioAreas.Dock = DockStyle.Fill;
            formularioAreas.FormBorderStyle = FormBorderStyle.None;
            PanelVisualizador.Controls.Add(formularioAreas);
            formularioAreas.Show();
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = true;

            btnListarArea.Enabled = true;
            btnInsertarArea.Enabled = false;
            btnActualizarArea.Enabled = true;
            btnEliminarArea.Enabled = true;

            btnListarUsuario.Enabled = true;
            btnInsertarUsuario.Enabled = true;
            btnActualizarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;

            btnListarParametro.Enabled = true;
            btnInsertarParametro.Enabled = true;
            btnActualizarParametro.Enabled = true;
            btnEliminarParametro.Enabled = true;

            btnListarPeriodo.Enabled = true;
            btnInsertarPeriodo.Enabled = true;
            btnActualizarPeriodo.Enabled = true;
            btnEliminarPeriodo.Enabled = true;

            var formularioAreas = new FormularioAreas();
            if (PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                PanelVisualizador.Controls.Clear();
            }
            formularioAreas.TopLevel = false;
            formularioAreas.Dock = DockStyle.Fill;
            formularioAreas.FormBorderStyle = FormBorderStyle.None;
            PanelVisualizador.Controls.Add(formularioAreas);
            formularioAreas.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = true;

            btnListarUsuario.Enabled = true;
            btnInsertarUsuario.Enabled = true;
            btnActualizarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;

            btnListarArea.Enabled = true;
            btnInsertarArea.Enabled = true;
            btnActualizarArea.Enabled = false;
            btnEliminarArea.Enabled = true;

            btnListarParametro.Enabled = true;
            btnInsertarParametro.Enabled = true;
            btnActualizarParametro.Enabled = true;
            btnEliminarParametro.Enabled = true;

            btnListarPeriodo.Enabled = true;
            btnInsertarPeriodo.Enabled = true;
            btnActualizarPeriodo.Enabled = true;
            btnEliminarPeriodo.Enabled = true;

            var formularioAreas = new FormularioAreas();
            if (PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                PanelVisualizador.Controls.Clear();
            }
            formularioAreas.TopLevel = false;
            formularioAreas.Dock = DockStyle.Fill;
            formularioAreas.FormBorderStyle = FormBorderStyle.None;
            PanelVisualizador.Controls.Add(formularioAreas);
            formularioAreas.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = true;

            btnListarUsuario.Enabled = true;
            btnInsertarUsuario.Enabled = true;
            btnActualizarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;

            btnListarArea.Enabled = true;
            btnInsertarArea.Enabled = true;
            btnActualizarArea.Enabled = true;
            btnEliminarArea.Enabled = false;

            btnListarParametro.Enabled = true;
            btnInsertarParametro.Enabled = true;
            btnActualizarParametro.Enabled = true;
            btnEliminarParametro.Enabled = true;

            btnListarPeriodo.Enabled = true;
            btnInsertarPeriodo.Enabled = true;
            btnActualizarPeriodo.Enabled = true;
            btnEliminarPeriodo.Enabled = true;

            var formularioAreas = new FormularioAreas();
            if (PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                PanelVisualizador.Controls.Clear();
            }
            formularioAreas.TopLevel = false;
            formularioAreas.Dock = DockStyle.Fill;
            formularioAreas.FormBorderStyle = FormBorderStyle.None;
            PanelVisualizador.Controls.Add(formularioAreas);
            formularioAreas.Show();
        }

        private void iconButton17_Click(object sender, EventArgs e)
        {
            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = true;

            btnListarArea.Enabled = true;
            btnInsertarArea.Enabled = true;
            btnActualizarArea.Enabled = true;
            btnEliminarArea.Enabled = true;

            btnListarUsuario.Enabled = false;
            btnInsertarUsuario.Enabled = true;
            btnActualizarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;

            btnListarParametro.Enabled = true;
            btnInsertarParametro.Enabled = true;
            btnActualizarParametro.Enabled = true;
            btnEliminarParametro.Enabled = true;

            btnListarPeriodo.Enabled = true;
            btnInsertarPeriodo.Enabled = true;
            btnActualizarPeriodo.Enabled = true;
            btnEliminarPeriodo.Enabled = true;

            var FormularioUsuarios = new FormularioUsuarios();
            if (PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                PanelVisualizador.Controls.Clear();
            }
            FormularioUsuarios.TopLevel = false;
            FormularioUsuarios.Dock = DockStyle.Fill;
            FormularioUsuarios.FormBorderStyle = FormBorderStyle.None;
            PanelVisualizador.Controls.Add(FormularioUsuarios);
            FormularioUsuarios.Show();
            
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = true;

            btnListarArea.Enabled = true;
            btnInsertarArea.Enabled = true;
            btnActualizarArea.Enabled = true;
            btnEliminarArea.Enabled = true;

            btnListarUsuario.Enabled = true;
            btnInsertarUsuario.Enabled = false;
            btnActualizarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;

            btnListarParametro.Enabled = true;
            btnInsertarParametro.Enabled = true;
            btnActualizarParametro.Enabled = true;
            btnEliminarParametro.Enabled = true;

            btnListarPeriodo.Enabled = true;
            btnInsertarPeriodo.Enabled = true;
            btnActualizarPeriodo.Enabled = true;
            btnEliminarPeriodo.Enabled = true;

            var FormularioUsuarios = new FormularioUsuarios();
            if (PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                PanelVisualizador.Controls.Clear();
            }
            FormularioUsuarios.TopLevel = false;
            FormularioUsuarios.Dock = DockStyle.Fill;
            FormularioUsuarios.FormBorderStyle = FormBorderStyle.None;
            PanelVisualizador.Controls.Add(FormularioUsuarios);
            FormularioUsuarios.Show();
        }

        private void iconButton15_Click(object sender, EventArgs e)
        {
            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = true;

            btnListarArea.Enabled = true;
            btnInsertarArea.Enabled = true;
            btnActualizarArea.Enabled = true;
            btnEliminarArea.Enabled = true;

            btnListarUsuario.Enabled = true;
            btnInsertarUsuario.Enabled = true;
            btnActualizarUsuario.Enabled = false;
            btnEliminarUsuario.Enabled = true;

            btnListarParametro.Enabled = true;
            btnInsertarParametro.Enabled = true;
            btnActualizarParametro.Enabled = true;
            btnEliminarParametro.Enabled = true;

            btnListarPeriodo.Enabled = true;
            btnInsertarPeriodo.Enabled = true;
            btnActualizarPeriodo.Enabled = true;
            btnEliminarPeriodo.Enabled = true;

            var FormularioUsuarios = new FormularioUsuarios();
            if (PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                PanelVisualizador.Controls.Clear();
            }
            FormularioUsuarios.TopLevel = false;
            FormularioUsuarios.Dock = DockStyle.Fill;
            FormularioUsuarios.FormBorderStyle = FormBorderStyle.None;
            PanelVisualizador.Controls.Add(FormularioUsuarios);
            FormularioUsuarios.Show();
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = true;

            btnListarArea.Enabled = true;
            btnInsertarArea.Enabled = true;
            btnActualizarArea.Enabled = true;
            btnEliminarArea.Enabled = true;

            btnListarUsuario.Enabled = true;
            btnInsertarUsuario.Enabled = true;
            btnActualizarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = false;

            btnListarParametro.Enabled = true;
            btnInsertarParametro.Enabled = true;
            btnActualizarParametro.Enabled = true;
            btnEliminarParametro.Enabled = true;

            btnListarPeriodo.Enabled = true;
            btnInsertarPeriodo.Enabled = true;
            btnActualizarPeriodo.Enabled = true;
            btnEliminarPeriodo.Enabled = true;

            var FormularioUsuarios = new FormularioUsuarios();
            if (PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                PanelVisualizador.Controls.Clear();
            }
            FormularioUsuarios.TopLevel = false;
            FormularioUsuarios.Dock = DockStyle.Fill;
            FormularioUsuarios.FormBorderStyle = FormBorderStyle.None;
            PanelVisualizador.Controls.Add(FormularioUsuarios);
            FormularioUsuarios.Show();
        }

        private void btnListarParametro_Click(object sender, EventArgs e)
        {
            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = true;

            btnListarArea.Enabled = true;
            btnInsertarArea.Enabled = true;
            btnActualizarArea.Enabled = true;
            btnEliminarArea.Enabled = true;

            btnListarUsuario.Enabled = true;
            btnInsertarUsuario.Enabled = true;
            btnActualizarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;

            btnListarParametro.Enabled = false;
            btnInsertarParametro.Enabled = true;
            btnActualizarParametro.Enabled = true;
            btnEliminarParametro.Enabled = true;

            btnListarPeriodo.Enabled = true;
            btnInsertarPeriodo.Enabled = true;
            btnActualizarPeriodo.Enabled = true;
            btnEliminarPeriodo.Enabled = true;

            var FormularioParametros = new FormularioParametros();
            if (PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                PanelVisualizador.Controls.Clear();
            }
            FormularioParametros.TopLevel = false;
            FormularioParametros.Dock = DockStyle.Fill;
            FormularioParametros.FormBorderStyle = FormBorderStyle.None;
            PanelVisualizador.Controls.Add(FormularioParametros);
            FormularioParametros.Show();


        }

        private void btnInsertarParametro_Click(object sender, EventArgs e)
        {
            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = true;

            btnListarArea.Enabled = true;
            btnInsertarArea.Enabled = true;
            btnActualizarArea.Enabled = true;
            btnEliminarArea.Enabled = true;

            btnListarUsuario.Enabled = true;
            btnInsertarUsuario.Enabled = true;
            btnActualizarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;

            btnListarParametro.Enabled = true;
            btnInsertarParametro.Enabled = false;
            btnActualizarParametro.Enabled = true;
            btnEliminarParametro.Enabled = true;

            btnListarPeriodo.Enabled = true;
            btnInsertarPeriodo.Enabled = true;
            btnActualizarPeriodo.Enabled = true;
            btnEliminarPeriodo.Enabled = true;

            var FormularioParametros = new FormularioParametros();
            if (PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                PanelVisualizador.Controls.Clear();
            }
            FormularioParametros.TopLevel = false;
            FormularioParametros.Dock = DockStyle.Fill;
            FormularioParametros.FormBorderStyle = FormBorderStyle.None;
            PanelVisualizador.Controls.Add(FormularioParametros);
            FormularioParametros.Show();
        }

        private void btnActualizarParametro_Click(object sender, EventArgs e)
        {
            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = true;

            btnListarArea.Enabled = true;
            btnInsertarArea.Enabled = true;
            btnActualizarArea.Enabled = true;
            btnEliminarArea.Enabled = true;

            btnListarUsuario.Enabled = true;
            btnInsertarUsuario.Enabled = true;
            btnActualizarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;

            btnListarParametro.Enabled = true;
            btnInsertarParametro.Enabled = true;
            btnActualizarParametro.Enabled = false;
            btnEliminarParametro.Enabled = true;

            btnListarPeriodo.Enabled = true;
            btnInsertarPeriodo.Enabled = true;
            btnActualizarPeriodo.Enabled = true;
            btnEliminarPeriodo.Enabled = true;

            var FormularioParametros = new FormularioParametros();
            if (PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                PanelVisualizador.Controls.Clear();
            }
            FormularioParametros.TopLevel = false;
            FormularioParametros.Dock = DockStyle.Fill;
            FormularioParametros.FormBorderStyle = FormBorderStyle.None;
            PanelVisualizador.Controls.Add(FormularioParametros);
            FormularioParametros.Show();
        }

        private void btnEliminarParametro_Click(object sender, EventArgs e)
        {
            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = true;

            btnListarArea.Enabled = true;
            btnInsertarArea.Enabled = true;
            btnActualizarArea.Enabled = true;
            btnEliminarArea.Enabled = true;

            btnListarUsuario.Enabled = true;
            btnInsertarUsuario.Enabled = true;
            btnActualizarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;

            btnListarParametro.Enabled = true;
            btnInsertarParametro.Enabled = true;
            btnActualizarParametro.Enabled = true;
            btnEliminarParametro.Enabled = false;

            btnListarPeriodo.Enabled = true;
            btnInsertarPeriodo.Enabled = true;
            btnActualizarPeriodo.Enabled = true;
            btnEliminarPeriodo.Enabled = true;

            var FormularioParametros = new FormularioParametros();
            if (PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                PanelVisualizador.Controls.Clear();
            }
            FormularioParametros.TopLevel = false;
            FormularioParametros.Dock = DockStyle.Fill;
            FormularioParametros.FormBorderStyle = FormBorderStyle.None;
            PanelVisualizador.Controls.Add(FormularioParametros);
            FormularioParametros.Show();
        }

        private void btnListarPeriodo_Click(object sender, EventArgs e)
        {
            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = true;

            btnListarArea.Enabled = true;
            btnInsertarArea.Enabled = true;
            btnActualizarArea.Enabled = true;
            btnEliminarArea.Enabled = true;

            btnListarUsuario.Enabled = true;
            btnInsertarUsuario.Enabled = true;
            btnActualizarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;

            btnListarParametro.Enabled = true;
            btnInsertarParametro.Enabled = true;
            btnActualizarParametro.Enabled = true;
            btnEliminarParametro.Enabled = true;

            btnListarPeriodo.Enabled = false;
            btnInsertarPeriodo.Enabled = true;
            btnActualizarPeriodo.Enabled = true;
            btnEliminarPeriodo.Enabled = true;

            var FormularioPeriodos = new FormularioPeriodos();
            if (PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                PanelVisualizador.Controls.Clear();
            }
            FormularioPeriodos.TopLevel = false;
            FormularioPeriodos.Dock = DockStyle.Fill;
            FormularioPeriodos.FormBorderStyle = FormBorderStyle.None;
            PanelVisualizador.Controls.Add(FormularioPeriodos);
            FormularioPeriodos.Show();
        }

        private void btnInsertarPeriodo_Click(object sender, EventArgs e)
        {
            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = true;

            btnListarArea.Enabled = true;
            btnInsertarArea.Enabled = true;
            btnActualizarArea.Enabled = true;
            btnEliminarArea.Enabled = true;

            btnListarUsuario.Enabled = true;
            btnInsertarUsuario.Enabled = true;
            btnActualizarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;

            btnListarParametro.Enabled = true;
            btnInsertarParametro.Enabled = true;
            btnActualizarParametro.Enabled = true;
            btnEliminarParametro.Enabled = true;

            btnListarPeriodo.Enabled = true;
            btnInsertarPeriodo.Enabled = false;
            btnActualizarPeriodo.Enabled = true;
            btnEliminarPeriodo.Enabled = true;

            var FormularioPeriodos = new FormularioPeriodos();
            if (PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                PanelVisualizador.Controls.Clear();
            }
            FormularioPeriodos.TopLevel = false;
            FormularioPeriodos.Dock = DockStyle.Fill;
            FormularioPeriodos.FormBorderStyle = FormBorderStyle.None;
            PanelVisualizador.Controls.Add(FormularioPeriodos);
            FormularioPeriodos.Show();
        }

        private void btnActualizarPeriodo_Click(object sender, EventArgs e)
        {
            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = true;

            btnListarArea.Enabled = true;
            btnInsertarArea.Enabled = true;
            btnActualizarArea.Enabled = true;
            btnEliminarArea.Enabled = true;

            btnListarUsuario.Enabled = true;
            btnInsertarUsuario.Enabled = true;
            btnActualizarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;

            btnListarParametro.Enabled = true;
            btnInsertarParametro.Enabled = true;
            btnActualizarParametro.Enabled = true;
            btnEliminarParametro.Enabled = true;

            btnListarPeriodo.Enabled = true;
            btnInsertarPeriodo.Enabled = true;
            btnActualizarPeriodo.Enabled = false;
            btnEliminarPeriodo.Enabled = true;

            var FormularioPeriodos = new FormularioPeriodos();
            if (PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                PanelVisualizador.Controls.Clear();
            }
            FormularioPeriodos.TopLevel = false;
            FormularioPeriodos.Dock = DockStyle.Fill;
            FormularioPeriodos.FormBorderStyle = FormBorderStyle.None;
            PanelVisualizador.Controls.Add(FormularioPeriodos);
            FormularioPeriodos.Show();
        }

        private void btnEliminarPeriodo_Click(object sender, EventArgs e)
        {
            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = true;

            btnListarArea.Enabled = true;
            btnInsertarArea.Enabled = true;
            btnActualizarArea.Enabled = true;
            btnEliminarArea.Enabled = true;

            btnListarUsuario.Enabled = true;
            btnInsertarUsuario.Enabled = true;
            btnActualizarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;

            btnListarParametro.Enabled = true;
            btnInsertarParametro.Enabled = true;
            btnActualizarParametro.Enabled = true;
            btnEliminarParametro.Enabled = true;

            btnListarPeriodo.Enabled = true;
            btnInsertarPeriodo.Enabled = true;
            btnActualizarPeriodo.Enabled = true;
            btnEliminarPeriodo.Enabled = false;

            var FormularioPeriodos = new FormularioPeriodos();
            if (PanelVisualizador.Controls.Count >= default(int))
            {
                //PanelVisualizador.Controls.RemoveAt(default(int));
                PanelVisualizador.Controls.Clear();
            }
            FormularioPeriodos.TopLevel = false;
            FormularioPeriodos.Dock = DockStyle.Fill;
            FormularioPeriodos.FormBorderStyle = FormBorderStyle.None;
            PanelVisualizador.Controls.Add(FormularioPeriodos);
            FormularioPeriodos.Show();
        }
    }
}
