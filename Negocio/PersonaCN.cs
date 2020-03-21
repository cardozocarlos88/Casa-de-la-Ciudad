using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Negocio
{
    public class PersonaCN
    {
        private PersonaRepositorio _per = new PersonaRepositorio();

        public List<Persona> obtenerTodosLasPersonas()
        {
            return _per.obtenerTodosLasPersonas();
        }

        public Persona ObtenerPersonaPorId(int id)
        {
            return _per.ObtenerPersonaPorId(id);
        }

        public void GuardarPersona(Persona persona)
        {
            _per.GuardarPersona(persona);
        }
    }
}
