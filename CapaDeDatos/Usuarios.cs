using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class Usuarios
    {
        public int idUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }


        Conexion conexion = new Conexion();
        public DataTable ListarUsuarios()
        {
            return conexion.EjecutarStoredProcedureDeListado("SP_ListarUsuario",new SqlParameter[0]);
        }

        public string InsertarUsuario(Usuarios usuario)
        {
            var parametros = new[]
            {
                new SqlParameter("@Usuario",usuario.Usuario),
                new SqlParameter("@Contraseña",usuario.Contraseña)
            };

            return conexion.EjecutarStoredProcedure("SP_InsertarUsuario", parametros);
        }

        public string ActualizarUsuario(Usuarios usuario)
        {
            var parametros = new[]
            {
                new SqlParameter("@idUsuario",usuario.idUsuario),
                new SqlParameter("@Usuario",usuario.Usuario),
                new SqlParameter("@Contraseña",usuario.Contraseña)
            };

            return conexion.EjecutarStoredProcedure("SP_ActualizarUsuario", parametros);
        }

        public string EliminarUsuario(int idUsuario)
        {
            var parametros = new[]
            {
                new SqlParameter("@idUsuario",idUsuario)
            };

            return conexion.EjecutarStoredProcedure("SP_EliminarUsuario", parametros);
        }

    }
}
