using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Reporte
{
    public class ReporteListadoAlumnos
    {
        private string legajo;
        private string dni;
        private string apellidoNombre;

        public string Legajo { get => legajo; set => legajo = value; }
        public string Dni { get => dni; set => dni = value; }
        public string ApellidoNombre { get => apellidoNombre; set => apellidoNombre = value; }

        public ReporteListadoAlumnos()
        {

        }
    }
}
