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
        Medicamentos_y_Suministros.frmMedicamentosSuministros frmSuministros = new Medicamentos_y_Suministros.frmMedicamentosSuministros();
        Consulta.frmConsulta frmConsulta = new Consulta.frmConsulta();
        public mdiPrincipal()
        {
            InitializeComponent();
        }
        private void MenuConsulta_Click(object sender, EventArgs e)
        {
            frmConsulta.MdiParent = this;
            frmConsulta.Show();
        }
        private void pacientes_Click(object sender, EventArgs e)
        {
            frmPacientes.MdiParent = this;
            frmPacientes.Show();
        }

        private void medicos_Click(object sender, EventArgs e)
        {
            frmMedico.MdiParent = this;
            frmMedico.Show();
        }

        private void MenuProcedimientos_Click(object sender, EventArgs e)
        {
            frmProcedimientos.MdiParent = this;
            frmProcedimientos.Show();
        }

        private void MenuSuministros_Click(object sender, EventArgs e)
        {
            frmSuministros.MdiParent = this;
            frmSuministros.Show();
        }

        private void mdiPrincipal_Load(object sender, EventArgs e)
        {
            tlsr.Enabled = false;
            frmlogin.MdiParent = this;
            frmlogin.Show();
        }
    }
}
