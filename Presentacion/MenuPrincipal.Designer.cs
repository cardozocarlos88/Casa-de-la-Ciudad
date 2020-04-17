namespace Presentacion
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnAlum = new System.Windows.Forms.Button();
            this.btnCurso = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnAsis = new System.Windows.Forms.Button();
            this.btnPest = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.acercaDeToolStripMenuItem.Text = "Ayuda";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.ayudaToolStripMenuItem.Text = "Acerca de ...";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackgroundImage = global::Presentacion.Properties.Resources.depositphotos_51489601_stock_photo_user_blue_icon;
            this.btnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuario.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuario.Location = new System.Drawing.Point(156, 144);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(121, 118);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "USUARIOS";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlum
            // 
            this.btnAlum.BackgroundImage = global::Presentacion.Properties.Resources.images__2_;
            this.btnAlum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlum.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlum.ForeColor = System.Drawing.Color.Black;
            this.btnAlum.Location = new System.Drawing.Point(355, 282);
            this.btnAlum.Name = "btnAlum";
            this.btnAlum.Size = new System.Drawing.Size(121, 118);
            this.btnAlum.TabIndex = 2;
            this.btnAlum.Text = "ALUMNOS";
            this.btnAlum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlum.UseVisualStyleBackColor = true;
            this.btnAlum.Click += new System.EventHandler(this.btnAlum_Click);
            // 
            // btnCurso
            // 
            this.btnCurso.BackgroundImage = global::Presentacion.Properties.Resources.descarga;
            this.btnCurso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCurso.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurso.ForeColor = System.Drawing.Color.Black;
            this.btnCurso.Location = new System.Drawing.Point(573, 144);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(121, 118);
            this.btnCurso.TabIndex = 3;
            this.btnCurso.Text = "CURSOS";
            this.btnCurso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCurso.UseVisualStyleBackColor = true;
            this.btnCurso.Click += new System.EventHandler(this.btnCurso_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackgroundImage = global::Presentacion.Properties.Resources.diseño_de_abstract_icon_symbol_del_hombre_negocios_empleado_oficina_usuario_1238841141;
            this.btnEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpleado.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmpleado.Location = new System.Drawing.Point(293, 144);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(121, 118);
            this.btnEmpleado.TabIndex = 4;
            this.btnEmpleado.Text = "EMPLEADOS";
            this.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAsis
            // 
            this.btnAsis.BackgroundImage = global::Presentacion.Properties.Resources.images__1_;
            this.btnAsis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsis.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsis.ForeColor = System.Drawing.Color.Black;
            this.btnAsis.Location = new System.Drawing.Point(497, 282);
            this.btnAsis.Name = "btnAsis";
            this.btnAsis.Size = new System.Drawing.Size(121, 118);
            this.btnAsis.TabIndex = 8;
            this.btnAsis.Text = "CONSULTAR ASISTENCIA";
            this.btnAsis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAsis.UseVisualStyleBackColor = true;
            this.btnAsis.Click += new System.EventHandler(this.btnAsis_Click);
            // 
            // btnPest
            // 
            this.btnPest.BackgroundImage = global::Presentacion.Properties.Resources.images;
            this.btnPest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPest.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPest.ForeColor = System.Drawing.Color.Black;
            this.btnPest.Location = new System.Drawing.Point(433, 144);
            this.btnPest.Name = "btnPest";
            this.btnPest.Size = new System.Drawing.Size(121, 118);
            this.btnPest.TabIndex = 6;
            this.btnPest.Text = "PLAN DE ESTUDIO";
            this.btnPest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPest.UseVisualStyleBackColor = true;
            this.btnPest.Click += new System.EventHandler(this.btnPest_Click);
            // 
            // btnIns
            // 
            this.btnIns.BackgroundImage = global::Presentacion.Properties.Resources.images1;
            this.btnIns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIns.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIns.ForeColor = System.Drawing.Color.Black;
            this.btnIns.Location = new System.Drawing.Point(214, 282);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(121, 118);
            this.btnIns.TabIndex = 5;
            this.btnIns.Text = "INSCRIPCIONES";
            this.btnIns.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(618, 41);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 16);
            this.lblUser.TabIndex = 9;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources._1573;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 539);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnAsis);
            this.Controls.Add(this.btnPest);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.btnCurso);
            this.Controls.Add(this.btnAlum);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Button btnAlum;
        private System.Windows.Forms.Button btnCurso;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnAsis;
        private System.Windows.Forms.Button btnPest;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnUsuario;
    }
}