using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class Periodos
    {
        public int idPeriodo { get; set; }
        public int NumeroAño { get; set; }
        public int Año { get; set; }
        public Double Valor { get; set; }
        public int idParametro { get; set; }

        public DataTable ListarPeriodos()
        {
            var conexion = new Conexion();

            return conexion.EjecutarStoredProcedureDeListado("SP_listarPeriodo", new SqlParameter[0]);
        }

        public string InsertarPeriodo(Periodos periodo)
        {
            var conexion = new Conexion();
            var parametros = new[]
           {
                new SqlParameter("@NumeroAño",periodo.NumeroAño),
                new SqlParameter("@Año",periodo.Año),
                new SqlParameter("@Valor",periodo.Valor),
                new SqlParameter("@idParametro",periodo.idParametro),
            };

            return conexion.EjecutarStoredProcedure("SP_InsertarPeriodo", parametros);

        }

        public string ActualizarPeriodo(Periodos periodo)
        {
            var conexion = new Conexion();

            var parametros = new[]
            {
                new SqlParameter("@idPeriodo",periodo.idPeriodo),
                new SqlParameter("@NumeroAño",periodo.NumeroAño),
                new SqlParameter("@Año",periodo.Año),
                new SqlParameter("@Valor",periodo.Valor)
            };

            return conexion.EjecutarStoredProcedure("SP_ActualizarPeriodo", parametros);
        }

        public string EliminarPeriodo(int idPeriodo)
        {
            var conexion = new Conexion();

            var parametros = new[]
            {
                new SqlParameter("@idPeriodo", idPeriodo),
            };

            return conexion.EjecutarStoredProcedure("SP_EliminarPeriodo", parametros);
        }
    }
}
