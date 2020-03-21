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
            using (BD_CasaDeLaCiudadEntities bd = new BD_CasaDeLaCiudadEntities())
            {
                return bd.Persona
                  .OrderByDescending(x => x.idPersona)
                  .ToList();
            }
        }

        public Persona ObtenerPersonaPorId(int id)
        {
            using (BD_CasaDeLaCiudadEntities bd = new BD_CasaDeLaCiudadEntities())
            {
                return bd.Persona
                    .Where(x => x.idPersona == id)
                    .OrderByDescending(x => x.idPersona)
                    .First();
            }
        }

        public void GuardarPersona(Persona persona)
        {
            using (BD_CasaDeLaCiudadEntities bd = new BD_CasaDeLaCiudadEntities())
            {
                bd.Persona.Add(persona);
                bd.SaveChanges();
            }
        }



    }
}
