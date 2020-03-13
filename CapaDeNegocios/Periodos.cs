using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDeNegocios
{
     public class Periodos
    {
        public DataTable ListarPeriodos()
        {
            var periodo = new CapaDeDatos.Periodos();

            return periodo.ListarPeriodos();
        }

        public string InsertarPeriodo(CapaDeDatos.Periodos periodo)
        {
            return periodo.InsertarPeriodo(periodo);
        }

        public string ActualizarPeriodo(CapaDeDatos.Periodos periodo)
        {
            return periodo.ActualizarPeriodo(periodo);
        }

        public string EliminarPeriodo(int idPeriodo)
        {
            var periodo = new CapaDeDatos.Periodos();
            return periodo.EliminarPeriodo(idPeriodo);
        }
    }
}
