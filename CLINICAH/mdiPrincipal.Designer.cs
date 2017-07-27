namespace CLINICAH
{
    partial class mdiPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mst = new System.Windows.Forms.MenuStrip();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clínicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsr = new System.Windows.Forms.ToolStrip();
            this.MenuConsulta = new System.Windows.Forms.ToolStripButton();
            this.MenuPacientes = new System.Windows.Forms.ToolStripButton();
            this.MenuMedicos = new System.Windows.Forms.ToolStripButton();
            this.MenuProcedimientos = new System.Windows.Forms.ToolStripButton();
            this.MenuSuministros = new System.Windows.Forms.ToolStripButton();
            this.mst.SuspendLayout();
            this.tlsr.SuspendLayout();
            this.SuspendLayout();
            // 
            // mst
            // 
            this.mst.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametrosToolStripMenuItem,
            this.clínicaToolStripMenuItem,
            this.pacientesToolStripMenuItem});
            this.mst.Location = new System.Drawing.Point(0, 0);
            this.mst.Name = "mst";
            this.mst.Size = new System.Drawing.Size(866, 24);
            this.mst.TabIndex = 1;
            this.mst.Text = "menuStrip1";
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.parametrosToolStripMenuItem.Text = "&Parámetros";
            // 
            // clínicaToolStripMenuItem
            // 
            this.clínicaToolStripMenuItem.Name = "clínicaToolStripMenuItem";
            this.clínicaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clínicaToolStripMenuItem.Text = "&Clínica";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "P&acientes";
            // 
            // tlsr
            // 
            this.tlsr.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.tlsr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuConsulta,
            this.MenuPacientes,
            this.MenuMedicos,
            this.MenuProcedimientos,
            this.MenuSuministros});
            this.tlsr.Location = new System.Drawing.Point(0, 24);
            this.tlsr.Name = "tlsr";
            this.tlsr.Size = new System.Drawing.Size(866, 55);
            this.tlsr.TabIndex = 2;
            this.tlsr.Text = "tlst";
            // 
            // MenuConsulta
            // 
            this.MenuConsulta.Image = global::CLINICAH.Properties.Resources.consultas;
            this.MenuConsulta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuConsulta.Name = "MenuConsulta";
            this.MenuConsulta.Size = new System.Drawing.Size(106, 52);
            this.MenuConsulta.Text = "Consulta";
            this.MenuConsulta.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.MenuConsulta.Click += new System.EventHandler(this.MenuConsulta_Click);
            // 
            // MenuPacientes
            // 
            this.MenuPacientes.Image = global::CLINICAH.Properties.Resources.users1;
            this.MenuPacientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuPacientes.Name = "MenuPacientes";
            this.MenuPacientes.Size = new System.Drawing.Size(109, 52);
            this.MenuPacientes.Text = "Pacientes";
            this.MenuPacientes.Click += new System.EventHandler(this.pacientes_Click);
            // 
            // MenuMedicos
            // 
            this.MenuMedicos.Image = global::CLINICAH.Properties.Resources.doctor;
            this.MenuMedicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuMedicos.Name = "MenuMedicos";
            this.MenuMedicos.Size = new System.Drawing.Size(104, 52);
            this.MenuMedicos.Text = "Médicos";
            this.MenuMedicos.Click += new System.EventHandler(this.medicos_Click);
            // 
            // MenuProcedimientos
            // 
            this.MenuProcedimientos.Image = global::CLINICAH.Properties.Resources.inyeccion;
            this.MenuProcedimientos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuProcedimientos.Name = "MenuProcedimientos";
            this.MenuProcedimientos.Size = new System.Drawing.Size(142, 52);
            this.MenuProcedimientos.Text = "Procedimientos";
            this.MenuProcedimientos.Click += new System.EventHandler(this.MenuProcedimientos_Click);
            // 
            // MenuSuministros
            // 
            this.MenuSuministros.Image = global::CLINICAH.Properties.Resources.medicina;
            this.MenuSuministros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuSuministros.Name = "MenuSuministros";
            this.MenuSuministros.Size = new System.Drawing.Size(212, 52);
            this.MenuSuministros.Text = "Medicamentos y Suministros";
            this.MenuSuministros.Click += new System.EventHandler(this.MenuSuministros_Click);
            // 
            // mdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 400);
            this.Controls.Add(this.tlsr);
            this.Controls.Add(this.mst);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mst;
            this.Name = "mdiPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mdiPrincipal_Load);
            this.mst.ResumeLayout(false);
            this.mst.PerformLayout();
            this.tlsr.ResumeLayout(false);
            this.tlsr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mst;
        private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clínicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tlsr;
        private System.Windows.Forms.ToolStripButton MenuPacientes;
        private System.Windows.Forms.ToolStripButton MenuMedicos;
        private System.Windows.Forms.ToolStripButton MenuConsulta;
        private System.Windows.Forms.ToolStripButton MenuSuministros;
        private System.Windows.Forms.ToolStripButton MenuProcedimientos;
    }
}