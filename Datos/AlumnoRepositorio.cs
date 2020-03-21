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
            using (BD_CasaDeLaCiudadEntities bd = new BD_CasaDeLaCiudadEntities())
            {
                return bd.Alumno
                    .Include("Persona")
                    .Where(x => x.Activo == "S")
                    .OrderByDescending(x => x.idAlumno)
                    .ToList();
            }
        }

        public Alumno ObtenerAlumnoPorId(int id)
        {
            using (BD_CasaDeLaCiudadEntities bd = new BD_CasaDeLaCiudadEntities())
            {
                return bd.Alumno
                    .Include("Persona")
                    .Where(x => x.idAlumno == id)
                    .OrderByDescending(x => x.idAlumno)
                    .First();
            }
        }

        public void GuardarAlumno(Alumno alumno)
        {
            using (BD_CasaDeLaCiudadEntities bd = new BD_CasaDeLaCiudadEntities())
            {
                bd.Alumno.Add(alumno);
                bd.SaveChanges();
            }
        }

        public void EditarAlumno(Alumno alumno)
        {
            using (BD_CasaDeLaCiudadEntities bd = new BD_CasaDeLaCiudadEntities())
            {
                Alumno aluEdit = bd.Alumno.FirstOrDefault(x => x.idAlumno == alumno.idAlumno);
                aluEdit.Legajo = alumno.Legajo;
                aluEdit.Activo = alumno.Activo;
                bd.SaveChanges();
            }
        }

        public void EliminarAlumno(Alumno alumno)
        {
            using (BD_CasaDeLaCiudadEntities bd = new BD_CasaDeLaCiudadEntities())
            {
                Alumno aluEdit = bd.Alumno.FirstOrDefault(x => x.idAlumno == alumno.idAlumno);
                aluEdit.Activo = "N";
                bd.SaveChanges();
            }
        }
    }
}
