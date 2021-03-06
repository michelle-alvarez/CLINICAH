﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLINICAH
{
    public partial class mdiPrincipal : Form
    {
        Login.frmLogin frmlogin = new Login.frmLogin();
        Pacientes.FrmPacientes frmPacientes = new Pacientes.FrmPacientes();
        Medicos.frmMedicos frmMedico = new Medicos.frmMedicos();
        Procedimientos.frmProcedimientos frmProcedimientos = new Procedimientos.frmProcedimientos();
        Medicamentos_y_Suministros.frmMedicamentos frmSuministros = new Medicamentos_y_Suministros.frmMedicamentos();
        Consulta.btnCancelar frmConsulta = new Consulta.btnCancelar();
        public mdiPrincipal()
        {
            InitializeComponent();
        }
        private void MenuConsulta_Click(object sender, EventArgs e)
        {
            Consulta.btnCancelar consulta = new Consulta.btnCancelar();
            consulta.MdiParent = this;
            consulta.Show();
        }
        private void pacientes_Click(object sender, EventArgs e)
        {
            Pacientes.FrmPacientes pacientes = new Pacientes.FrmPacientes();
            pacientes.MdiParent = this;
            pacientes.Show();
        }

        private void medicos_Click(object sender, EventArgs e)
        {
            Medicos.frmMedicos medicos = new Medicos.frmMedicos();
            medicos.MdiParent = this;
            medicos.Show();
        }

        private void MenuProcedimientos_Click(object sender, EventArgs e)
        {
            Procedimientos.frmProcedimientos1 procedimientos = new Procedimientos.frmProcedimientos1();
            procedimientos.MdiParent = this;
            procedimientos.Show();
        }

        private void MenuSuministros_Click(object sender, EventArgs e)
        {
            
        }

        private void mdiPrincipal_Load(object sender, EventArgs e)
        {
            //lo puse aqui para cuando haga logout
            cargar();

        }
        private void bt_logout_Click(object sender, EventArgs e)
        {
            MenuMedicos.Enabled = true;
            MenuPacientes.Enabled = true;
            MenuProcedimientos.Enabled = true;
            lb_nom.Text = "";
            Resources.Propiedades.nombre_ingreso = "";
            Resources.Propiedades.categoria = 0;
            Resources.Propiedades.flag = false;
            cargar();
        }
        private void cargar()
        {
            Login.frmLogin frmlogin = new Login.frmLogin();

            while (!Resources.Propiedades.flag)
            {
                frmlogin.ShowDialog();
            }

            string nombre_medico = Resources.Propiedades.nombre_ingreso;
            int categoria_medico = Resources.Propiedades.categoria;

            lb_nom.Text = nombre_medico;
            switch (categoria_medico)
            {
                case 1:
                    MenuMedicos.Enabled = false;
                    MenuPacientes.Enabled = false;
                    MenuProcedimientos.Enabled = false;
                    mst.Enabled = false;
                    break;
                case 2:
                    MenuConsulta.Enabled = false;
                    MenuMedicos.Enabled = false;
                    MenuPacientes.Enabled = false;
                    mst.Enabled = false;
                    break;
                case 3:
                    
                    break;
                case 4:
                    //super usuario inicial
                    break;
                default:
                    //Application.Exit();
                    break;

            }
        }


        private void suministrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicamentos_y_Suministros.frmSuministros suministros = new Medicamentos_y_Suministros.frmSuministros();
            suministros.MdiParent = this;
            suministros.Show();
        }

        private void medicamentosYSuministrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicamentos_y_Suministros.frmMedicamentos medicamentos = new Medicamentos_y_Suministros.frmMedicamentos();
            medicamentos.MdiParent = this;
            medicamentos.Show();
        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicos.frmMedicos medicos = new Medicos.frmMedicos();
            medicos.MdiParent = this;
            medicos.Show();
        }

        private void pacientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pacientes.FrmPacientes pacientes = new Pacientes.FrmPacientes();
            pacientes.MdiParent = this;
            pacientes.Show();
        }

        private void medicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Medicos.frmReporteMedicos reporte = new Medicos.frmReporteMedicos();
            reporte.MdiParent = this;
            reporte.Show();
        }

        private void medicosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Medicos.frmPrivilegios privilegios = new Medicos.frmPrivilegios();
            privilegios.MdiParent = this;
            privilegios.Show();
        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicamentos_y_Suministros.EntregaMantenimiento entradaMed = new Medicamentos_y_Suministros.EntregaMantenimiento();
            entradaMed.MdiParent = this;
            entradaMed.Show();
        }

        private void suministrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Medicamentos_y_Suministros.EntregaSuministros entradaSum = new Medicamentos_y_Suministros.EntregaSuministros();
            entradaSum.MdiParent = this;
            entradaSum.Show();
        }
    }
}
