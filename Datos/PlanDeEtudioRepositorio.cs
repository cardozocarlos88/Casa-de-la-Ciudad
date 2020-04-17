using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class PlanDeEtudioRepositorio
    {

        public List<PlanDeEstudio> obtenerTodosLosPlanes()
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.PlanDeEstudios
                  .OrderByDescending(x => x.idPlanDeEstudio)
                  .Where(y => y.Activo == "S")
                  .ToList();
            }
        }

        public PlanDeEstudio ObtenerPlanPorId(int id)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                return bd.PlanDeEstudios
                    .Where(x => x.idPlanDeEstudio == id)
                    .OrderByDescending(x => x.idPlanDeEstudio)
                    .First();
            }
        }

        public void GuardarPlan(PlanDeEstudio planDeEstudio)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                planDeEstudio.Activo = "S";
                bd.PlanDeEstudios.Add(planDeEstudio);
                bd.SaveChanges();
            }
        }

        public void EditarPlan(PlanDeEstudio planDeEstudio)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                PlanDeEstudio plaEdit = bd.PlanDeEstudios.FirstOrDefault(x => x.idPlanDeEstudio == planDeEstudio.idPlanDeEstudio);
                plaEdit.Nombre = planDeEstudio.Nombre;
                plaEdit.RandoEdad = planDeEstudio.RandoEdad;
                plaEdit.Activo = planDeEstudio.Activo;
                bd.SaveChanges();
            }
        }

        public void EliminarPlan(PlanDeEstudio planDeEstudio)
        {
            using (BD_CasaDeLaCiudad bd = new BD_CasaDeLaCiudad())
            {
                PlanDeEstudio plaEdit = bd.PlanDeEstudios.FirstOrDefault(x => x.idPlanDeEstudio == planDeEstudio.idPlanDeEstudio);
                plaEdit.Activo = "N";
                bd.SaveChanges();
            }
        }


    }
}
