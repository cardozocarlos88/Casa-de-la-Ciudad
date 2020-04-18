using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Negocio
{
    public class CursosCN
    {
        private CursosRepositorio _cuRep = new CursosRepositorio();

        public List<Curso> obtenerTodosLosCursos()
        {
            return _cuRep.obtenerTodosLosCursos(); ;
        }

        public Curso ObtenerCursoPorId(int id)
        {
            return _cuRep.ObtenerCursoPorId(id);
        }

        public void GuardarCursos(Curso curso)
        {
            _cuRep.GuardarCursos(curso);
        }

        public void EditarCursos(Curso curso)
        {
            _cuRep.EditarCursos(curso);
        }

        public void EliminarCursos(Curso curso)
        {
            _cuRep.EliminarCursos(curso);
        }

        public List<vw_CursosConInscripcion> ObtenerCursosConInscripcion()
        {
            return _cuRep.ObtenerCursosConInscripcion();
        }

        public List<vw_CursoPlanDeEstudio> ObtenerCursosConPlanDeEstudio()
        {
            return _cuRep.ObtenerCursosConPlanDeEstudio();
        }


        public List<Curso> ObtenerCursosConCuposYFechaHasta()
        {
            return _cuRep.ObtenerCursosConCuposYFechaHasta();
        }

        public List<vw_ListadoAlumnosPorCurso> ObtenerAlumnosPorCurso(int idCurso)
        {
            return _cuRep.ObtenerAlumnosPorCurso(idCurso);
        }


    }
}
