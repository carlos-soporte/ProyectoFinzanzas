using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDeNegocios
{
    public class TablaMaestra
    {
        public DataTable ListarTablaMaestra()
        {
            var tabla = new CapaDeDatos.TablaMaestra();

            return tabla.ListarTablaMaestra();
        }

        public string ActualizarTablaMaestra(CapaDeDatos.TablaMaestra tabla)
        {
            return tabla.ActualizarTablaMaestra(tabla);
        }

        public string InsertarTablaMaestra(CapaDeDatos.TablaMaestra tabla)
        {
            return tabla.InsertarTablaMaestra(tabla);
        }

        public string EliminarTablaMaestra(int idMaestro)
        {
            var tabla = new CapaDeDatos.TablaMaestra();

            return tabla.EliminarTablaMaestra(idMaestro);
        }
    }
}
