using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class AlumnoRepositorio
    {
        public List<Alumno> obtenerTodosLosAlumnos()
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.Alumnoes
                    .Include("Persona")  // esto es como un inner join "=="
                    //.Where(x => x.Activo == "S") 
                    .OrderByDescending(x => x.idAlumno)
                    .ToList();
            }
        }

        public Alumno ObtenerAlumnoPorId(int id)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.Alumnoes
                    .Include("Persona")
                    .Where(x => x.idAlumno == id)
                    .First();
            }
        }

        public void GuardarAlumno(Alumno alumno)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                //alumno.Activo = "S";
                bd.Alumnoes.Add(alumno);
                bd.SaveChanges();
            }
        }

        public void EditarAlumno(Alumno alumno)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                Alumno aluEdit = bd.Alumnoes.FirstOrDefault(x => x.idAlumno == alumno.idAlumno);
                aluEdit.Legajo = alumno.Legajo;
                bd.SaveChanges();
            }
        }

        public void EliminarAlumno(Alumno alumno)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                Alumno aluEdit = bd.Alumnoes.FirstOrDefault(x => x.idAlumno == alumno.idAlumno);
                
                bd.Alumnoes.Remove(aluEdit); 
                bd.SaveChanges();
            }
        }
    }
}
