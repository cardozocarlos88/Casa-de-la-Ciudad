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
using Microsoft.Reporting.WinForms;

namespace Presentacion.Reporte
{
    public partial class ReporteAsistencia : Form
    {
        private CursosCN _cuCN = new CursosCN();
        private PersonaCN _peCN = new PersonaCN();
        public ReporteAsistencia()
        {
            InitializeComponent();
        }

        private void ReporteAsistencia_Load(object sender, EventArgs e)
        {
            txtFecha.Text = Convert.ToString(DateTime.Now);
            CargarComboBoxCursos();

            //this.reportViewer1.RefreshReport();
        }

        private void CargarComboBoxCursos()
        {
            cbxCursos.SelectedValue = "id";
            cbxCursos.DisplayMember = "detalle";
            List<vw_CursosConInscripcion> lista = new List<vw_CursosConInscripcion>();
            lista = _cuCN.ObtenerCursosConInscripcion();
            lista.Add(new vw_CursosConInscripcion() { id = 0, detalle = "- seleccione el curso-" });
            cbxCursos.DataSource = lista.OrderBy(x => x.id).ToList();
        }

        private void CbxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCurso = ((vw_CursosConInscripcion)cbxCursos.SelectedItem).id;
            if (idCurso != 0)
            {
                Curso cursoReporte = new Curso();
                cursoReporte = _cuCN.ObtenerCursoPorId(idCurso);
                cursoReporte.Empleado.Persona = _peCN.ObtenerPersonaPorId(cursoReporte.Empleado.Persona_idPersona);
                List<vw_ListadoAlumnosPorCurso> lista = new List<vw_ListadoAlumnosPorCurso>();
                lista = _cuCN.ObtenerAlumnosPorCurso(idCurso);



                ReportDataSource rds = new ReportDataSource("DataSet2", lista);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reporte.InformeAsistencia.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                ReportParameter[] parameters = new ReportParameter[4];
                parameters[0] = new ReportParameter("repAsis_Curso", cursoReporte.PlanDeEstudio.Nombre);
                parameters[1] = new ReportParameter("repAsis_Profesor", cursoReporte.Empleado.Persona.Apellidos + "," + cursoReporte.Empleado.Persona.Nombres);
                parameters[2] = new ReportParameter("repAsis_Desde", Convert.ToString(cursoReporte.FechaIncial));
                parameters[3] = new ReportParameter("repAsis_Hasta", Convert.ToString(cursoReporte.FechaFinal));
                this.reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }
            

            /*
            DataTable tabla = new DataTable();
            DataColumn col = new DataColumn("d1");
            col.DataType = System.Type.GetType("System.String");
            tabla.Columns.Add(col);
            col = new DataColumn("d2");
            col.DataType = System.Type.GetType("System.String");
            tabla.Columns.Add(col);
            col = new DataColumn("d3");
            col.DataType = System.Type.GetType("System.String");
            tabla.Columns.Add(col);

            foreach(var item in lista)
            {
                DataRow linea = tabla.NewRow();
                linea["d1"] = item.Legajo.ToString();
                linea["d2"] = item.Dni.ToString();
                linea["d3"] = item.apeNom.ToString();
                tabla.Rows.Add(linea);
            }
            DataSet1 dtsAlumnos = new DataSet1();
            dtsAlumnos.Tables.RemoveAt(0);    //Eliminamos la tabla que crea por defecto
            dtsAlumnos.Tables.Add(tabla);     //Añadimos la tabla que acabamos de crear

            dtsEjemploBindingSource.DataSource = dtsAlumnos;
            dtsEjemploBindingSource.DataMember = "Table1";
            */
        }
    }
}
