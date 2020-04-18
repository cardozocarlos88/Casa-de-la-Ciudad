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
    public partial class MenuPrincipal : Form
    {

        private Usuario userSession = new Usuario();
        public Usuario UserSession { get => userSession; set => userSession = value; }


        private UsuarioNC _userCN = new UsuarioNC();

        public MenuPrincipal()
        {
            InitializeComponent();
            
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            habilitarBotones();
            CargarSesionUsuario();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            { 
                {
                    Application.Exit();
                }
            }
        }

        private void btnAlum_Click(object sender, EventArgs e)
        {
            Form ListAlu = new ListadoAlumnos();
            ListAlu.Show();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ListEmp = new ListadoEmpleado();
            ListEmp.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var aux = UserSession;
            ListadoUsuario lu = new ListadoUsuario();
            lu.Show(this);
        }

        private void habilitarBotones()
        {
            List<Permiso> permisosDeUsuario = _userCN.obtenerTodosLosPermisos(UserSession.Perfil_idPerfil);

            var a = (from c in permisosDeUsuario where c.Descripcion == "abmUsuario" select c).FirstOrDefault();
            if (a == null)
            {
                btnUsuario.Enabled = false;
            }

            var b = (from c in permisosDeUsuario where c.Descripcion == "abmEmpleado" select c).FirstOrDefault();
            if (b == null)
            {
                btnEmpleado.Enabled = false;
            }

            var d = (from c in permisosDeUsuario where c.Descripcion == "abmPlan" select c).FirstOrDefault();
            if (d == null)
            {
                btnPest.Enabled = false;
            }

            var e = (from c in permisosDeUsuario where c.Descripcion == "abmAlumno" select c).FirstOrDefault();
            if (e == null)
            {
                btnAlum.Enabled = false;
            }

            var f = (from c in permisosDeUsuario where c.Descripcion == "abmCurso" select c).FirstOrDefault();
            if (f == null)
            {
                btnCurso.Enabled = false;
            }

            var g = (from c in permisosDeUsuario where c.Descripcion == "abmInscripcion" select c).FirstOrDefault();
            if (g == null)
            {
                btnIns.Enabled = false;
            }

            var h = (from c in permisosDeUsuario where c.Descripcion == "repAsistencia" select c).FirstOrDefault();
            if (h == null)
            {
                btnAsis.Enabled = false;
            }

        }

        private void btnPest_Click(object sender, EventArgs e)
        {
            Form ListPla = new ListadoPlanDeEstudio();
            ListPla.Show();
            
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda ayu = new Ayuda();
            ayu.Show(this);
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            Form ListCu = new ListadoCursos();
            ListCu.Show();
       

        }

        private void btnAsis_Click(object sender, EventArgs e)
        {
            Reporte.ReporteAsistencia ListAsis = new Reporte.ReporteAsistencia();
            ListAsis.Show();
        

        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            ListadoInscripcion ListIns = new ListadoInscripcion();
            ListIns.UserSession = this.UserSession;
            ListIns.Show(this);
         
        }

        private void CargarSesionUsuario()
        {
            lblUser.Text = "Bienvenido "+UserSession.Empleado.Persona.Apellidos+" "+ UserSession.Empleado.Persona.Nombres;
            //inscirvion.usuario = UserSession;
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    
}
