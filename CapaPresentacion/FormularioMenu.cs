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

            btnListarTabla.Enabled = false;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = true;


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

            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = false;
            btnEliminarTabla.Enabled = true;
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

            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = false;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = true;
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

            btnListarTabla.Enabled = true;
            btnActualizarTabla.Enabled = true;
            btnInsertarTabla.Enabled = true;
            btnEliminarTabla.Enabled = false;
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
    }
}
