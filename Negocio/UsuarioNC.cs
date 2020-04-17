using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Negocio
{
    public class UsuarioNC
    {
        private UsuarioRepositorio _userRep = new UsuarioRepositorio();

        public List<Usuario> obtenerTodosLosUsuarios()
        {
            return _userRep.obtenerTodosLosUsuarios(); ;
        }

        public Usuario ObtenerUsuarioPorId(int id)
        {
            return _userRep.ObtenerUsuarioPorId(id);
        }

        public void GuardarUsuario(Usuario usuario)
        {
            _userRep.GuardarUsuario(usuario);
        }

        public void EditarUsuario(Usuario usuario)
        {
            _userRep.EditarUsuario(usuario);
        }

        public void EliminarUsuario(Usuario usuario)
        {
            _userRep.EliminarUsuario(usuario);
        }

        public List<Perfil> ObtenerTodosLosPerfiles()
        {
            return _userRep.ObtenerTodosLosPerfiles();
        }

        public Usuario ComprobarLogin(string nombre, string clave)
        {
            return _userRep.ComprobarLogin(nombre, clave);
        }

        public List<Permiso> obtenerTodosLosPermisos(int idPefil)
        {
            return _userRep.obtenerTodosLosPermisos(idPefil);
        }

    }

}
