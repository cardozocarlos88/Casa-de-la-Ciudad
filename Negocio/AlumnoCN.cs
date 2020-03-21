using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Negocio
{
    public class AlumnoCN
    {
        private AlumnoRepositorio _aluRep = new AlumnoRepositorio();

        public List<Alumno> obtenerTodosLosAlumnos()
        {
            return _aluRep.obtenerTodosLosAlumnos();
        }

        public Alumno ObtenerAlumnoPorId(int id)
        {
            return _aluRep.ObtenerAlumnoPorId(id);
        }

        public void GuardarAlumno(Alumno alumno)
        {
            _aluRep.GuardarAlumno(alumno);
        }

        public void EditarAlumno(Alumno alumno)
        {
            _aluRep.EditarAlumno(alumno);
        }

        public void EliminarAlumno(Alumno alumno)
        {
            _aluRep.EliminarAlumno(alumno);
        }
    }
}
