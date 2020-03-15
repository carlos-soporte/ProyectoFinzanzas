using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDeNegocios
{
    public class Usuarios
    {

        public DataTable ListarUsuarios()
        {
            var usuario = new CapaDeDatos.Usuarios();

            return usuario.ListarUsuarios();
        }

        public string InsertarUsuario(CapaDeDatos.Usuarios usuario)
        {
            return usuario.InsertarUsuario(usuario);
        }

        public string ActualizarUsuario(CapaDeDatos.Usuarios usuario)
        {
            return usuario.ActualizarUsuario(usuario);
        }

        public string EliminarUsuario(int idUsuario)
        {
            var usuario = new CapaDeDatos.Usuarios();

            return usuario.EliminarUsuario(idUsuario);
        }
    }
}
