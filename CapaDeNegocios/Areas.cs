using System;
using System.Data;

namespace CapaDeNegocios
{
    public class Areas
    {
        public DataTable ListarAreas()
        {
            var area = new CapaDeDatos.Areas();

            return area.ListarAreas();
        }

        public string InsertarArea(CapaDeDatos.Areas area)
        {
            return area.InsertarArea(area);
        }

        public string ActualizarArea(CapaDeDatos.Areas area)
        {
            return area.ActualizarArea(area);
        }

        public string EliminarArea(int idArea)
        {
            var area = new CapaDeDatos.Areas();

            return area.EliminarArea(idArea);
        }
       
    }
}
