using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;


namespace Datos
{
   public class CursosRepositorio
    {
        public List<Curso> obtenerTodosLosCursos()
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.Cursos
                    .Include("Empleado")
                    .Include("PlanDeEstudio")
                    .OrderByDescending(x => x.idCursos)
                    .ToList();
            }
        }

        public Curso ObtenerCursoPorId(int id)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.Cursos
                    .Include("Empleado")
                    .Include("PlanDeEstudio")
                    .Where(x => x.idCursos == id)
                    .First();
            }
        }

        public void GuardarCursos(Curso cursos)
        {
            cursos.CupoAct = 0;
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                bd.Cursos.Add(cursos);
                bd.SaveChanges();
            }
        }

        public void EditarCursos(Curso cursos)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                Curso cuEdit = bd.Cursos.FirstOrDefault(x => x.idCursos == cursos.idCursos);
                cuEdit.FechaIncial = cursos.FechaIncial;
                cuEdit.FechaFinal = cursos.FechaFinal;
                cuEdit.CupoMax = cursos.CupoMax;
                bd.SaveChanges();
            }
        }

        public void EliminarCursos(Curso cursos)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                Curso cuEdit = bd.Cursos.FirstOrDefault(x => x.idCursos == cursos.idCursos);
                bd.Cursos.Remove(cuEdit);
                bd.SaveChanges();
            }
        }

        public List<vw_CursosConInscripcion> ObtenerCursosConInscripcion()  // es para el combo del listado de inscrip
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.vw_CursosConInscripcion
                    .OrderByDescending(x => x.id)
                    .ToList();
            }
        }

        public List<Curso> ObtenerCursosConCuposYFechaHasta() // para el alta de inscrp
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.Cursos
                    .Include("PlanDeEstudio")
                    //.Where(
                       // x => DateTime.Now > x.FechaIncial 
                     //   && DateTime.Now < x.FechaFinal 
                     //   && x.CupoAct < x.CupoMax )
                    .OrderByDescending(x => x.idCursos)
                    .ToList();
            }

        }

        public List<vw_CursoPlanDeEstudio> ObtenerCursosConPlanDeEstudio()  // es para el combo del listado de inscrip
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.vw_CursoPlanDeEstudio
                    .OrderByDescending(x => x.id)
                    .ToList();
            }
        }

        public List<vw_ListadoAlumnosPorCurso> ObtenerAlumnosPorCurso(int idCurso)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.vw_ListadoAlumnosPorCurso
                    .Where(x => x.idCursos == idCurso)
                    .OrderByDescending(x => x.apeNom)
                    .ToList();
            }
        }
    }

}
