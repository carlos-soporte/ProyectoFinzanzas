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
            
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
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
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
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
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
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
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
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
