using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class UsuarioRepositorio
    {
        public List<Usuario> obtenerTodosLosUsuarios()
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.Usuarios
                    .Include("Empleado")
                    .Include("Perfil")
                    .OrderByDescending(x => x.idUsuario)
                    .Where( y => y.Activo == "S")
                    .ToList();
            }
        }

        public Usuario ObtenerUsuarioPorId(int id)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.Usuarios
                    .Include("Empleado")
                    .Include("Perfil")
                    .Where(x => x.idUsuario == id)
                    .First();
            }
        }

        public void GuardarUsuario(Usuario usuario)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                usuario.Activo = "S";
                bd.Usuarios.Add(usuario);
                bd.SaveChanges();
            }
        }

        public void EditarUsuario(Usuario usuario)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                Usuario userEdit = bd.Usuarios.FirstOrDefault(x => x.idUsuario == usuario.idUsuario);
                userEdit.Clave = usuario.Clave;
                usuario.Activo = usuario.Activo;
                userEdit.Perfil_idPerfil = usuario.Perfil_idPerfil;
                bd.SaveChanges();
            }
        }

        public void EliminarUsuario(Usuario usuario)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                  Usuario userEdit = bd.Usuarios.FirstOrDefault(x => x.idUsuario == usuario.idUsuario);
                  userEdit.Activo = "N";
                  bd.SaveChanges();
            }
        }

        public List<Perfil> ObtenerTodosLosPerfiles()
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.Perfils
                    .OrderByDescending(x => x.Descripcion)
                    .ToList();
            }
        }

        public Usuario ComprobarLogin(string nombre, string clave)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.Usuarios
                    .Include("Empleado")
                    .Include("Perfil")
                    .Where(x=> x.Nombre == nombre && x.Clave == clave && x.Activo == "S")
                    .FirstOrDefault();
            }

        }

        public List<Permiso> obtenerTodosLosPermisos(int idPerfil)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.Permisos
                .Where(x=> x.Perfil_idPerfil == idPerfil)
                .ToList();

            }
        }


    }
}
