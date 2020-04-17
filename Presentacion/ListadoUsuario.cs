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
    public partial class ListadoUsuario : Form
    {

        private UsuarioNC _userCn = new UsuarioNC();
        private PersonaCN _perCn = new PersonaCN();

        public ListadoUsuario()
        {
            InitializeComponent();
            ConfigurarDataGrid();
            CargarDataGrid();
        }
        private void ConfigurarDataGrid()
        {
            dataGridPlan.Rows.Clear();
            dataGridPlan.ColumnCount = 9;
            dataGridPlan.Columns[0].Name = "Id";
            dataGridPlan.Columns[0].ReadOnly = true;
            dataGridPlan.Columns[0].Visible = true;
            dataGridPlan.Columns[1].Name = "Usuario";
            dataGridPlan.Columns[1].ReadOnly = true;
            dataGridPlan.Columns[2].Name = "Clave";
            dataGridPlan.Columns[2].ReadOnly = true;
            
            dataGridPlan.Columns[3].Name = "Id-Empleado";
            dataGridPlan.Columns[3].ReadOnly = true;
            dataGridPlan.Columns[3].Visible = false;


            dataGridPlan.Columns[4].Name = "Legajo";
            dataGridPlan.Columns[4].ReadOnly = true;

            dataGridPlan.Columns[5].Name = "Apellidos";
            dataGridPlan.Columns[5].ReadOnly = true;
            dataGridPlan.Columns[6].Name = "Nombres";
            dataGridPlan.Columns[6].ReadOnly = true;

            dataGridPlan.Columns[7].Name = "Id-Perfil";
            dataGridPlan.Columns[7].ReadOnly = true;
            dataGridPlan.Columns[7].Visible = false;
            dataGridPlan.Columns[8].Name = "Perfil";
            dataGridPlan.Columns[8].ReadOnly = true;
        }


        public void CargarDataGrid()
        {
            int renglon = 0;
            dataGridPlan.Rows.Clear();
            foreach (Usuario user in _userCn.obtenerTodosLosUsuarios())
            {
                user.Empleado.Persona = _perCn.ObtenerPersonaPorId(user.Empleado.Persona_idPersona);
                renglon = dataGridPlan.Rows.Add();
                dataGridPlan.Rows[renglon].Cells["Id"].Value = user.idUsuario;
                dataGridPlan.Rows[renglon].Cells["Usuario"].Value = user.Nombre;
                //dataGridUsuario.Rows[renglon].Cells["Clave"].Value = user.Clave;
                dataGridPlan.Rows[renglon].Cells["Clave"].Value = "*******";
                dataGridPlan.Rows[renglon].Cells["Id-Empleado"].Value = user.Empleado_idEmpleado;


                dataGridPlan.Rows[renglon].Cells["Legajo"].Value = user.Empleado.Legajo;
                dataGridPlan.Rows[renglon].Cells["Apellidos"].Value = user.Empleado.Persona.Apellidos;
                dataGridPlan.Rows[renglon].Cells["Nombres"].Value = user.Empleado.Persona.Nombres;

                dataGridPlan.Rows[renglon].Cells["Id-Perfil"].Value = user.Perfil.idPerfil;
                dataGridPlan.Rows[renglon].Cells["Perfil"].Value = user.Perfil.Descripcion;
              

            }
        }



        private void ListadoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            GestionUsuario gu = new GestionUsuario();
            gu.TipoGestion = "alta";
            gu.Show();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            GestionUsuario gu = new GestionUsuario();
            gu.UsuarioFrm.idUsuario = (int)dataGridPlan.CurrentRow.Cells["Id"].Value;
            gu.TipoGestion = "modi";
            gu.Show(this);
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            GestionUsuario gu = new GestionUsuario();
            gu.UsuarioFrm.idUsuario = (int)dataGridPlan.CurrentRow.Cells["Id"].Value;
            gu.TipoGestion = "baja";
            gu.Show();
        }

        private void dataGridPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
