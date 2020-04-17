using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class EmpleadoRepositorio
    {
        public List<Empleado> obtenerTodosLosEmpleados()
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.Empleadoes
                    .Include("Persona")  // esto es como un inner join "=="
                    .Include("Cargo")
                    .Where(x=>x.Activo=="S") 
                    .OrderByDescending(x => x.idEmpleado)
                    .ToList();
            }
        }

        public Empleado ObtenerEmpleadoPorId(int id)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.Empleadoes
                    .Include("Persona")
                    .Include("Cargo")
                    .Where(x => x.idEmpleado == id)
                    .First();
            }
        }

        public void GuardarEmpleado(Empleado empleado)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                empleado.Activo = "S";
                bd.Empleadoes.Add(empleado);
                bd.SaveChanges();
            }
        }

        public void EditarEmpleado(Empleado empleado)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                Empleado empEdit = bd.Empleadoes.FirstOrDefault(x => x.idEmpleado == empleado.idEmpleado);
                empEdit.Legajo = empleado.Legajo;
                empEdit.Cargo_idCargo = empleado.Cargo_idCargo;
                empEdit.Activo = empleado.Activo;
                bd.SaveChanges();
            }
        }

        public void EliminarEmpleado(Empleado empleado)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                Empleado empEdit = bd.Empleadoes.FirstOrDefault(x => x.idEmpleado == empleado.idEmpleado);

                empEdit.Activo = "N";
                //bd.Empleadoes.Remove(empEdit);
                bd.SaveChanges();
            }
        }

        public List<Cargo> ObtenerTodosLosCargos()
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.Cargoes
                    .OrderByDescending(x => x.Descripcion)
                    .ToList();
            }
        }


        public List<vw_EmpleadosSinUsuario> ObtenerEmpleadosSinUsuario()
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.vw_EmpleadosSinUsuario
                    .OrderByDescending(x => x.id)
                    .ToList();
            }
        }

        public List<vw_EmpleadoProfesor> ObtenerEmpleadosProfesor()
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.vw_EmpleadoProfesor
                    .OrderByDescending(x => x.id)
                    .ToList();
            }
        }

    }
}
