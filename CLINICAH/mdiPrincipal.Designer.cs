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
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.medicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosYSuministrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suministrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.privilegiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsr = new System.Windows.Forms.ToolStrip();
            this.MenuConsulta = new System.Windows.Forms.ToolStripButton();
            this.MenuPacientes = new System.Windows.Forms.ToolStripButton();
            this.MenuMedicos = new System.Windows.Forms.ToolStripButton();
            this.MenuProcedimientos = new System.Windows.Forms.ToolStripButton();
            this.lb_nom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_logout = new System.Windows.Forms.Button();
            this.mst.SuspendLayout();
            this.tlsr.SuspendLayout();
            this.SuspendLayout();
            // 
            // mst
            // 
            this.mst.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mst.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametrosToolStripMenuItem,
            this.clínicaToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.privilegiosToolStripMenuItem});
            this.mst.Location = new System.Drawing.Point(0, 0);
            this.mst.Name = "mst";
            this.mst.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mst.Size = new System.Drawing.Size(1897, 28);
            this.mst.TabIndex = 1;
            this.mst.Text = "menuStrip1";
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.parametrosToolStripMenuItem.Text = "&Parámetros";
            // 
            // clínicaToolStripMenuItem
            // 
            this.clínicaToolStripMenuItem.Name = "clínicaToolStripMenuItem";
            this.clínicaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.clínicaToolStripMenuItem.Text = "&Clínica";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.pacientesToolStripMenuItem.Text = "P&acientes";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem1,
            this.medicosToolStripMenuItem,
            this.medicamentosYSuministrosToolStripMenuItem,
            this.suministrosToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.mantenimientoToolStripMenuItem.Text = "&Mantenimiento ";
            // 
            // pacientesToolStripMenuItem1
            // 
            this.pacientesToolStripMenuItem1.Name = "pacientesToolStripMenuItem1";
            this.pacientesToolStripMenuItem1.Size = new System.Drawing.Size(182, 26);
            this.pacientesToolStripMenuItem1.Text = "Pacientes";
            this.pacientesToolStripMenuItem1.Click += new System.EventHandler(this.pacientesToolStripMenuItem1_Click);
            // 
            // medicosToolStripMenuItem
            // 
            this.medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            this.medicosToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.medicosToolStripMenuItem.Text = "Medicos";
            this.medicosToolStripMenuItem.Click += new System.EventHandler(this.medicosToolStripMenuItem_Click);
            // 
            // medicamentosYSuministrosToolStripMenuItem
            // 
            this.medicamentosYSuministrosToolStripMenuItem.Name = "medicamentosYSuministrosToolStripMenuItem";
            this.medicamentosYSuministrosToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.medicamentosYSuministrosToolStripMenuItem.Text = "Medicamentos";
            this.medicamentosYSuministrosToolStripMenuItem.Click += new System.EventHandler(this.medicamentosYSuministrosToolStripMenuItem_Click);
            // 
            // suministrosToolStripMenuItem
            // 
            this.suministrosToolStripMenuItem.Name = "suministrosToolStripMenuItem";
            this.suministrosToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.suministrosToolStripMenuItem.Text = "Suministros";
            this.suministrosToolStripMenuItem.Click += new System.EventHandler(this.suministrosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicosToolStripMenuItem1});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // medicosToolStripMenuItem1
            // 
            this.medicosToolStripMenuItem1.Name = "medicosToolStripMenuItem1";
            this.medicosToolStripMenuItem1.Size = new System.Drawing.Size(140, 26);
            this.medicosToolStripMenuItem1.Text = "Medicos";
            this.medicosToolStripMenuItem1.Click += new System.EventHandler(this.medicosToolStripMenuItem1_Click);
            // 
            // privilegiosToolStripMenuItem
            // 
            this.privilegiosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicosToolStripMenuItem2});
            this.privilegiosToolStripMenuItem.Name = "privilegiosToolStripMenuItem";
            this.privilegiosToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.privilegiosToolStripMenuItem.Text = "Privilegios";
            // 
            // medicosToolStripMenuItem2
            // 
            this.medicosToolStripMenuItem2.Name = "medicosToolStripMenuItem2";
            this.medicosToolStripMenuItem2.Size = new System.Drawing.Size(140, 26);
            this.medicosToolStripMenuItem2.Text = "Medicos";
            this.medicosToolStripMenuItem2.Click += new System.EventHandler(this.medicosToolStripMenuItem2_Click);
            // 
            // tlsr
            // 
            this.tlsr.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.tlsr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuConsulta,
            this.MenuPacientes,
            this.MenuMedicos,
            this.MenuProcedimientos});
            this.tlsr.Location = new System.Drawing.Point(0, 28);
            this.tlsr.Name = "tlsr";
            this.tlsr.Size = new System.Drawing.Size(1897, 55);
            this.tlsr.TabIndex = 2;
            this.tlsr.Text = "tlst";
            // 
            // MenuConsulta
            // 
            this.MenuConsulta.Image = global::CLINICAH.Properties.Resources.consultas;
            this.MenuConsulta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuConsulta.Name = "MenuConsulta";
            this.MenuConsulta.Size = new System.Drawing.Size(118, 52);
            this.MenuConsulta.Text = "Consulta";
            this.MenuConsulta.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.MenuConsulta.Click += new System.EventHandler(this.MenuConsulta_Click);
            // 
            // MenuPacientes
            // 
            this.MenuPacientes.Image = global::CLINICAH.Properties.Resources.users1;
            this.MenuPacientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuPacientes.Name = "MenuPacientes";
            this.MenuPacientes.Size = new System.Drawing.Size(122, 52);
            this.MenuPacientes.Text = "Pacientes";
            this.MenuPacientes.Click += new System.EventHandler(this.pacientes_Click);
            // 
            // MenuMedicos
            // 
            this.MenuMedicos.Image = global::CLINICAH.Properties.Resources.doctor;
            this.MenuMedicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuMedicos.Name = "MenuMedicos";
            this.MenuMedicos.Size = new System.Drawing.Size(117, 52);
            this.MenuMedicos.Text = "Médicos";
            this.MenuMedicos.Click += new System.EventHandler(this.medicos_Click);
            // 
            // MenuProcedimientos
            // 
            this.MenuProcedimientos.Image = global::CLINICAH.Properties.Resources.inyeccion;
            this.MenuProcedimientos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuProcedimientos.Name = "MenuProcedimientos";
            this.MenuProcedimientos.Size = new System.Drawing.Size(164, 52);
            this.MenuProcedimientos.Text = "Procedimientos";
            this.MenuProcedimientos.Click += new System.EventHandler(this.MenuProcedimientos_Click);
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nom.Location = new System.Drawing.Point(1436, 30);
            this.lb_nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(20, 22);
            this.lb_nom.TabIndex = 7;
            this.lb_nom.Text = "#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1323, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Conectado:";
            // 
            // bt_logout
            // 
            this.bt_logout.Location = new System.Drawing.Point(1739, 25);
            this.bt_logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(117, 28);
            this.bt_logout.TabIndex = 10;
            this.bt_logout.Text = "Cerrar Sesión";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // mdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1897, 497);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.lb_nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tlsr);
            this.Controls.Add(this.mst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mst;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ToolStripButton MenuProcedimientos;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem medicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentosYSuministrosToolStripMenuItem;
        private System.Windows.Forms.Label lb_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem suministrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem privilegiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicosToolStripMenuItem2;
        private System.Windows.Forms.Button bt_logout;
    }
}