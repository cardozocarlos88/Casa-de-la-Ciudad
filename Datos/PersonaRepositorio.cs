using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;


namespace Datos
{
    public class PersonaRepositorio
    {
        public List<Persona> obtenerTodosLasPersonas()
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.Personas
                  .OrderByDescending(x => x.idPersona)
                  .ToList();
            }
        }

        public Persona ObtenerPersonaPorId(int id)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.Personas
                    .Where(x => x.idPersona == id)
                    .OrderByDescending(x => x.idPersona)
                    .First();
            }
        }

        public void GuardarPersona(Persona persona)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                bd.Personas.Add(persona);
                bd.SaveChanges();
            }
        }

        public void EditarPersona(Persona persona)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                Persona perEdit = bd.Personas.FirstOrDefault(x => x.idPersona == persona.idPersona);
                perEdit.Nombres = persona.Nombres;
                perEdit.Apellidos = persona.Apellidos;
                perEdit.Dni = persona.Dni;
                perEdit.Direccion = persona.Direccion;
                perEdit.FechNac = persona.FechNac;
                perEdit.Telefono = persona.Telefono;
                perEdit.Correo = persona.Correo;
                bd.SaveChanges();
            }
        }

        public void EliminarPersona(Persona persona)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                Persona perEli = bd.Personas.FirstOrDefault(x => x.idPersona == persona.idPersona);
                //bd.Personas.Remove(perEli);
                bd.SaveChanges();
            }
        }


    }
}
