using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class Areas
    {
        public int idArea { get; set; }
        public string Nombre { get; set; }
        public string Departamento { get; set; }

        public DataTable ListarAreas()
        {
            var conexion = new Conexion();
            return conexion.EjecutarStoredProcedureDeListado("SP_ListarArea", new SqlParameter[0]);
        }


        public string InsertarArea(Areas area)
        {
            var conexion = new Conexion();
            var parametros = new[]
            {
                new SqlParameter("@Nombre",area.Nombre),
                new SqlParameter("@Departamento", area.Departamento)
            };

            return conexion.EjecutarStoredProcedure("SP_InsertarArea", parametros);
        }

        public string ActualizarArea(Areas area)
        {
            var conexion = new Conexion();
            var parametros = new[]
            {
                new SqlParameter("idArea",area.idArea),
                new SqlParameter("@Nombre",area.Nombre),
                new SqlParameter("@Departamento", area.Departamento)
            };

            return conexion.EjecutarStoredProcedure("SP_ActualizarArea", parametros);
        }

        public string EliminarArea(int idArea)
        {
            var conexion = new Conexion();
            var parametros = new[]
            {
                new SqlParameter("@idArea",idArea)
            };

            return conexion.EjecutarStoredProcedure("SP_EliminarArea", parametros);
        }




    }
}
