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
        public FormularioAreas()
        {
            InitializeComponent();
        }

        private void FormularioAreas_Load(object sender, EventArgs e)
        {
            var AreaNegocio = new CapaDeNegocios.Areas();
            dataGridView1.DataSource = AreaNegocio.ListarAreas();
        }
    }
}
