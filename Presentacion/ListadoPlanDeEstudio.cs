using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace Presentacion
{
    public partial class ListadoPlanDeEstudio : Form
    {

        private PlanDeEstudioCN _planCn = new PlanDeEstudioCN();

        public ListadoPlanDeEstudio()
        {
            InitializeComponent();
            ConfigurarDataGrid();
            CargarDataGrid();
        }

        private void ConfigurarDataGrid()
        {
            dataGridPlan.Rows.Clear();
            dataGridPlan.ColumnCount = 3;
            dataGridPlan.Columns[0].Name = "Id";
            dataGridPlan.Columns[0].ReadOnly = true;
            dataGridPlan.Columns[0].Visible = false;
            dataGridPlan.Columns[1].Name = "Plan de Estudio";
            dataGridPlan.Columns[1].ReadOnly = true;
            dataGridPlan.Columns[2].Name = "Rango de Edad";
            dataGridPlan.Columns[2].ReadOnly = true;     
        }

        public void CargarDataGrid()
        {
            int renglon = 0;
            dataGridPlan.Rows.Clear();
            foreach (PlanDeEstudio plan in _planCn.obtenerTodosLosPlanes())
            {
                renglon = dataGridPlan.Rows.Add();
                dataGridPlan.Rows[renglon].Cells["Id"].Value = plan.idPlanDeEstudio;
                dataGridPlan.Rows[renglon].Cells["Plan de Estudio"].Value = plan.Nombre;
                dataGridPlan.Rows[renglon].Cells["Rango de Edad"].Value = plan.RandoEdad;

            }
        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        private void ListadoPlanDeEstudio_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GestionPlanDeEstudio pl = new GestionPlanDeEstudio();
            pl.TipoGestion = "alta";
            pl.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            GestionPlanDeEstudio pl = new GestionPlanDeEstudio();
            pl.PlanDeEstudioFrm.idPlanDeEstudio = (int)dataGridPlan.CurrentRow.Cells["Id"].Value;
            pl.TipoGestion = "modi";
            pl.Show(this);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            GestionPlanDeEstudio pl = new GestionPlanDeEstudio();
            pl.PlanDeEstudioFrm.idPlanDeEstudio = (int)dataGridPlan.CurrentRow.Cells["Id"].Value;
            pl.TipoGestion = "baja";
            pl.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
