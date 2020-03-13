using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDeDatos
{
    public class Parametros
    {
        public int idParametro { get; set; }
        public string Concepto { get; set; }
        public string UnidadDeMedida { get; set; }
        public int idMaestro { get; set; }

        Conexion conexion = new Conexion();


        public DataTable ListarParametros()
        {
            return conexion.EjecutarStoredProcedureDeListado("SP_ListarParametro", new SqlParameter[0]);
        }

        public string InsertarParametro(Parametros parametro)
        {
            var parametros = new[]
            {
                new SqlParameter("@Concepto",parametro.Concepto),
                new SqlParameter("@UnidadDeMedida",parametro.UnidadDeMedida)
            };

            return conexion.EjecutarStoredProcedure("SP_InsertarParametro", parametros);
        }

        public string ActualizarParametro(Parametros parametro)
        {
            var parametros = new[]
            {
                new SqlParameter("@idParametro",parametro.idParametro),
                new SqlParameter("@Concepto",parametro.Concepto),
                new SqlParameter("@UnidadDeMedida",parametro.UnidadDeMedida)
            };

            return parametro.ActualizarParametro(parametro);
        }

        public string EliminarParametro(int idParametro)
        {
            var parametro = new Parametros();

            var parametros = new[]
            {
                new SqlParameter("@idParametro",idParametro)
            };

            return parametro.EliminarParametro(idParametro);
        }

    }
}
