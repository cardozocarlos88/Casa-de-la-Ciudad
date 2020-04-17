using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Negocio
{
   public class EmpleadoCN
    {

        private EmpleadoRepositorio _empRep = new EmpleadoRepositorio();

        public List<Empleado> obtenerTodosLosEmpleados()
        {
            return _empRep.obtenerTodosLosEmpleados(); ;
        }

        public Empleado ObtenerEmpleadoPorId(int id)
        {
            return _empRep.ObtenerEmpleadoPorId(id);
        }

        public void GuardarEmpleado(Empleado empleado)
        {
            _empRep.GuardarEmpleado(empleado);
        }

        public void EditarEmpleado(Empleado empleado)
        {
            _empRep.EditarEmpleado(empleado);
        }

        public void EliminarEmpleado(Empleado empleado)
        {
            _empRep.EliminarEmpleado(empleado);
        }

        public List<Cargo> ObtenerTodosLosCargos()
        {
            return _empRep.ObtenerTodosLosCargos();
        }

        public List<vw_EmpleadosSinUsuario> ObtenerEmpleadosSinUsuario()
        {
            return _empRep.ObtenerEmpleadosSinUsuario();
        }

        public List<vw_EmpleadoProfesor> ObtenerEmpleadosProfesor()
        {
            return _empRep.ObtenerEmpleadosProfesor();
        }
    }
}
