namespace Presentacion
{
    partial class GestionCursos
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
            this.cbxEmp = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccion = new System.Windows.Forms.Button();
            this.cbxPlan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLegApll = new System.Windows.Forms.TextBox();
            this.txtCmax = new System.Windows.Forms.TextBox();
            this.txtInicial = new System.Windows.Forms.MaskedTextBox();
            this.txtFinal = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cbxEmp
            // 
            this.cbxEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmp.FormattingEnabled = true;
            this.cbxEmp.Location = new System.Drawing.Point(118, 61);
            this.cbxEmp.Name = "cbxEmp";
            this.cbxEmp.Size = new System.Drawing.Size(185, 21);
            this.cbxEmp.TabIndex = 77;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(215, 192);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(71, 30);
            this.btnEditar.TabIndex = 72;
            this.btnEditar.Text = "Salir";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Profesor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Fecha Inicial";
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(129, 192);
            this.btnAccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(71, 30);
            this.btnAccion.TabIndex = 68;
            this.btnAccion.Text = "Aceptar";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // cbxPlan
            // 
            this.cbxPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPlan.FormattingEnabled = true;
            this.cbxPlan.Location = new System.Drawing.Point(118, 29);
            this.cbxPlan.Name = "cbxPlan";
            this.cbxPlan.Size = new System.Drawing.Size(185, 21);
            this.cbxPlan.TabIndex = 79;
            this.cbxPlan.SelectedIndexChanged += new System.EventHandler(this.cbxPlan_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Plan de Estudio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Fecha Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 83;
            this.label5.Text = "Cupo";
            // 
            // txtLegApll
            // 
            this.txtLegApll.Location = new System.Drawing.Point(118, 61);
            this.txtLegApll.Margin = new System.Windows.Forms.Padding(2);
            this.txtLegApll.Name = "txtLegApll";
            this.txtLegApll.Size = new System.Drawing.Size(185, 20);
            this.txtLegApll.TabIndex = 84;
            this.txtLegApll.Visible = false;
            // 
            // txtCmax
            // 
            this.txtCmax.Location = new System.Drawing.Point(118, 155);
            this.txtCmax.Name = "txtCmax";
            this.txtCmax.Size = new System.Drawing.Size(185, 20);
            this.txtCmax.TabIndex = 86;
            this.txtCmax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCmax_KeyPress);
            // 
            // txtInicial
            // 
            this.txtInicial.Location = new System.Drawing.Point(118, 92);
            this.txtInicial.Mask = "00/00/0000";
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(185, 20);
            this.txtInicial.TabIndex = 87;
            this.txtInicial.ValidatingType = typeof(System.DateTime);
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(118, 123);
            this.txtFinal.Mask = "00/00/0000";
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(185, 20);
            this.txtFinal.TabIndex = 88;
            this.txtFinal.ValidatingType = typeof(System.DateTime);
            // 
            // GestionCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 250);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtInicial);
            this.Controls.Add(this.txtCmax);
            this.Controls.Add(this.txtLegApll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxPlan);
            this.Controls.Add(this.cbxEmp);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccion);
            this.Name = "GestionCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Cursos";
            this.Load += new System.EventHandler(this.GestionCursos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEmp;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.ComboBox cbxPlan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLegApll;
        private System.Windows.Forms.TextBox txtCmax;
        private System.Windows.Forms.MaskedTextBox txtInicial;
        private System.Windows.Forms.MaskedTextBox txtFinal;
    }
}