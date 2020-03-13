using System;
using System.Data;

namespace CapaDeNegocios
{
    public class Areas
    {
        /// <summary>
        /// Lista uno o màs registros.  
        /// </summary>
        /// <returns>Retorna un DataTable recpetivo de acuerdo al SP ejecutado</returns>
        public DataTable ListarAreas()
        {
            var area = new CapaDeDatos.Areas();

            return area.ListarAreas();
        }

        /// <summary>
        /// Inserta un nuevo registro en un conjunto de datos.  
        /// </summary>
        /// <returns>Retorna un String recpetivo de acuerdo al SP ejecutado</returns>
        public string InsertarArea(CapaDeDatos.Areas area)
        {
            return area.InsertarArea(area);
        }


        /// <summary>
        /// Actualiza un registro de un conjunto de datos.  
        /// </summary>
        /// <returns>Retorna un String recpetivo de acuerdo al SP ejecutado</returns>
        public string ActualizarArea(CapaDeDatos.Areas area)
        {
            return area.ActualizarArea(area);
        }

        /// <summary>
        /// Elimina un registro de un conjunto de datos.  
        /// </summary>
        /// <returns>Retorna un String recpetivo de acuerdo al SP ejecutado</returns>
        public string EliminarArea(int idArea)
        {
            var area = new CapaDeDatos.Areas();

            return area.EliminarArea(idArea);
        }
       
    }
}
