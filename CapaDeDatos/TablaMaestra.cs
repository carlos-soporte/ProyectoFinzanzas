using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class TablaMaestra
    {
        public int idMaestro { get; set; }
        public string Nombre { get; set; }
        public double Valor { get; set; }
        public double VidaUtil { get; set; }
        public DateTime FechaInicial { get; set; }
        public double Periodos { get; set; }
        public char UnidadDeTiempo { get; set; }
        public DateTime FechaFinal { get; set; }
        public int Nit { get; set; }
        public string Proveedor { get; set; }
        public int Cedula { get; set; }
        public string Responsable { get; set; }
        public int idArea { get; set; }

        public DataTable ListarTablaMaestra()
        {
            var conexion = new Conexion();

            return conexion.EjecutarStoredProcedureDeListado("SP_ListarTablaMaestra", new SqlParameter[0]);

        }

        public string InsertarTablaMaestra(TablaMaestra tabla)
        {
            var conexion = new Conexion();

            var parametros = new[]
            {
                new SqlParameter("@Nombre",tabla.Nombre),
                new SqlParameter("@Valor",tabla.Valor),
                new SqlParameter("@VidaUtil",tabla.VidaUtil),
                new SqlParameter("@FechaInicial",tabla.FechaInicial),
                new SqlParameter("@Periodos",tabla.Periodos),
                new SqlParameter("@UnidadDeTiempo",tabla.UnidadDeTiempo),
                new SqlParameter("@FechaFinal",tabla.FechaFinal),
                new SqlParameter("@Nit",tabla.Nit),
                new SqlParameter("@Proveedor",tabla.Proveedor),
                new SqlParameter("@Cedula",tabla.Cedula),
                new SqlParameter("@Responsable",tabla.Responsable),
                new SqlParameter("@idArea",tabla.idArea)
            };

            return conexion.EjecutarStoredProcedure("SP_InsertarTablaMaestra", parametros);
        }

        public string ActualizarTablaMaestra(TablaMaestra tabla)
        {
            var conexion = new Conexion();

            var parametros = new[]
            {
                new SqlParameter("@idMaestro",tabla.idMaestro),
                new SqlParameter("@Nombre",tabla.Nombre),
                new SqlParameter("@Valor",tabla.Valor),
                new SqlParameter("@VidaUtil",tabla.VidaUtil),
                new SqlParameter("@FechaInicial",tabla.FechaInicial),
                new SqlParameter("@Periodos",tabla.Periodos),
                new SqlParameter("@UnidadDeTiempo",tabla.UnidadDeTiempo),
                new SqlParameter("@FechaFinal",tabla.FechaFinal),
                new SqlParameter("@Nit",tabla.Nit),
                new SqlParameter("@Proveedor",tabla.Proveedor),
                new SqlParameter("@Cedula",tabla.Cedula),
                new SqlParameter("@Responsable",tabla.Responsable),
                new SqlParameter("@idArea",tabla.idArea)
            };

            return conexion.EjecutarStoredProcedure("SP_ActualizarTablaMaestra", parametros);
        }

        public string EliminarTablaMaestra(int idMaestro)
        {
            var conexion = new Conexion();

            var parametros = new[]
            {
                new SqlParameter("idMaestro",idMaestro)
            };

            return conexion.EjecutarStoredProcedure("SP_EliminarTablaMaestra", parametros);
        }

    }
}
