using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class InscripcionRepositorio
    {
        public List<Inscripcion> obtenerTodasLasInsc()
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.Inscripcions
                    .Include("Alumno")
                    .Include("Curso")
                    .Include("Usuario")
                    .OrderByDescending(x => x.idInscripcion)
                    .ToList();
            }
        }
        public Inscripcion ObtenerInscPorId(int id)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.Inscripcions
                    .Include("Curso")
                    .Include("Alumno")
                    .Include("Usuario")
                    .Where(x => x.idInscripcion == id)
                    .First();
            }
        }

        public void GuardarInsc(Inscripcion inscripcion)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {

                bd.Inscripcions.Add(inscripcion);
                bd.SaveChanges();
            }
        }


        public void EliminarInsc(Inscripcion inscripcion)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                Inscripcion inEdit = bd.Inscripcions.FirstOrDefault(x => x.idInscripcion == inscripcion.idInscripcion);
                bd.Inscripcions.Remove(inEdit);
                bd.SaveChanges();
            }
        }

        public List<Inscripcion> ObtenerListadosDeInscipcionesPorCurso(int idCurso)// consultar asitencia
            {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.Inscripcions
                    .Include("Alumno")
                    .Where(x => x.Curso_idCursos == idCurso)
                    .ToList();
            }

        }

    }
}
