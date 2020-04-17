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
    public partial class ListadoEmpleado : Form
    {
        private EmpleadoCN _empCn = new EmpleadoCN();
        public ListadoEmpleado()
        {
            InitializeComponent();
            ConfigurarDataGrid();
            CargarDataGrid();
        }

        private void ConfigurarDataGrid()
        {
            dataGridEmpleado.Rows.Clear();
            dataGridEmpleado.ColumnCount = 12;
            dataGridEmpleado.Columns[0].Name = "Id";
            dataGridEmpleado.Columns[0].ReadOnly = true;
            dataGridEmpleado.Columns[0].Visible = false;
            dataGridEmpleado.Columns[1].Name = "Legajo";
            dataGridEmpleado.Columns[1].ReadOnly = true;
            dataGridEmpleado.Columns[2].Name = "Id-Persona";
            dataGridEmpleado.Columns[2].ReadOnly = true;
            dataGridEmpleado.Columns[2].Visible = false;
            dataGridEmpleado.Columns[3].Name = "Apellidos";
            dataGridEmpleado.Columns[3].ReadOnly = true;
            dataGridEmpleado.Columns[4].Name = "Nombres";
            dataGridEmpleado.Columns[4].ReadOnly = true;
            dataGridEmpleado.Columns[5].Name = "Dni";
            dataGridEmpleado.Columns[5].ReadOnly = true;
            dataGridEmpleado.Columns[6].Name = "Nacimiento";
            dataGridEmpleado.Columns[6].ReadOnly = true;
            dataGridEmpleado.Columns[7].Name = "Direccion";
            dataGridEmpleado.Columns[7].ReadOnly = true;
            dataGridEmpleado.Columns[8].Name = "Telefono";
            dataGridEmpleado.Columns[8].ReadOnly = true;
            dataGridEmpleado.Columns[9].Name = "Correo";
            dataGridEmpleado.Columns[9].ReadOnly = true;
            dataGridEmpleado.Columns[10].Name = "Id-Cargo";
            dataGridEmpleado.Columns[10].ReadOnly = true;
            dataGridEmpleado.Columns[10].Visible = false;
            dataGridEmpleado.Columns[11].Name = "Cargo";
            dataGridEmpleado.Columns[11].ReadOnly = true;
        }


        public void CargarDataGrid()
        {
            int renglon = 0;
            dataGridEmpleado.Rows.Clear();
            foreach (Empleado emp in _empCn.obtenerTodosLosEmpleados())
            {
                renglon = dataGridEmpleado.Rows.Add();
                dataGridEmpleado.Rows[renglon].Cells["Id"].Value = emp.idEmpleado;
                dataGridEmpleado.Rows[renglon].Cells["Legajo"].Value = emp.Legajo;
                dataGridEmpleado.Rows[renglon].Cells["Id-Persona"].Value = emp.Persona_idPersona;
                dataGridEmpleado.Rows[renglon].Cells["Apellidos"].Value = emp.Persona.Apellidos;
                dataGridEmpleado.Rows[renglon].Cells["Nombres"].Value = emp.Persona.Nombres;
                dataGridEmpleado.Rows[renglon].Cells["Dni"].Value = emp.Persona.Dni;
                dataGridEmpleado.Rows[renglon].Cells["Nacimiento"].Value = emp.Persona.FechNac;
                dataGridEmpleado.Rows[renglon].Cells["Direccion"].Value = emp.Persona.Direccion;
                dataGridEmpleado.Rows[renglon].Cells["Telefono"].Value = emp.Persona.Telefono;
                dataGridEmpleado.Rows[renglon].Cells["Correo"].Value = emp.Persona.Correo;
                dataGridEmpleado.Rows[renglon].Cells["Id-Cargo"].Value = emp.Cargo.idCargo;
                dataGridEmpleado.Rows[renglon].Cells["Cargo"].Value = emp.Cargo.Descripcion;
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GestionEmpleado ge = new GestionEmpleado();
            ge.TipoGestion = "alta";
            ge.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            GestionEmpleado ge = new GestionEmpleado();
            ge.EmpleadoFrm.idEmpleado = (int)dataGridEmpleado.CurrentRow.Cells["Id"].Value;
            ge.TipoGestion = "modi";
            ge.Show(this);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            GestionEmpleado ge = new GestionEmpleado();
            ge.EmpleadoFrm.idEmpleado = (int)dataGridEmpleado.CurrentRow.Cells["Id"].Value;
            ge.TipoGestion = "baja";
            ge.Show();
        }

        private void ListadoEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void dataGridEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
