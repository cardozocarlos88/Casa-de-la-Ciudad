using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Negocio
{
   public class InscripcionCN
    {
        private InscripcionRepositorio _inRep = new InscripcionRepositorio();

        public List<Inscripcion> obtenerTodasLasInsc()
        {
            return _inRep.obtenerTodasLasInsc();
        }

        public Inscripcion ObtenerInscPorId(int id)
        {
            return _inRep.ObtenerInscPorId(id);
        }

        public void GuardarInsc(Inscripcion inscripcion)
        {
            _inRep.GuardarInsc(inscripcion);
        }


        public void EliminarInsc(Inscripcion inscripcion)
        {
            _inRep.EliminarInsc(inscripcion);
        }

        public List<Inscripcion> ObtenerListadosDeInscipcionesPorCurso(int idCurso)
        {
            return _inRep.ObtenerListadosDeInscipcionesPorCurso(idCurso);
        }

    }
}
