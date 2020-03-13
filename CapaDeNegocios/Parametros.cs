using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDeNegocios
{
    class Parametros
    {
        public DataTable ListarParametros()
        {
            var parametro = new CapaDeDatos.Parametros();

            return parametro.ListarParametros();
        }

        public string InsertarParametro(CapaDeDatos.Parametros parametro)
        {
            return parametro.InsertarParametro(parametro);
        }

        public string ActualizarParametro(CapaDeDatos.Parametros parametro)
        {
            return parametro.ActualizarParametro(parametro);
        }

        public string EliminarParametro(int idParametro)
        {
            var parametro = new CapaDeDatos.Parametros();

            return parametro.EliminarParametro(idParametro);
        }
    }
}
