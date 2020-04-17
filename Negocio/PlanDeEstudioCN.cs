using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Negocio
{
    public class PlanDeEstudioCN
    {

        private PlanDeEtudioRepositorio _plaRep = new PlanDeEtudioRepositorio();

        public List<PlanDeEstudio> obtenerTodosLosPlanes()
        {
            return _plaRep.obtenerTodosLosPlanes(); ;
        }

        public PlanDeEstudio ObtenerPlanPorId(int id)
        {
            return _plaRep.ObtenerPlanPorId(id);
        }

        public void GuardarPlan(PlanDeEstudio planDeEstudio)
        {
            _plaRep.GuardarPlan(planDeEstudio);
        }

        public void EditarPlan(PlanDeEstudio planDeEstudio)
        {
            _plaRep.EditarPlan(planDeEstudio);
        }

        public void EliminarPlan(PlanDeEstudio planDeEstudio)
        {
            _plaRep.EliminarPlan(planDeEstudio);
        }

    }
}
