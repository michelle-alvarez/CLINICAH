using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicos
{
    public partial class frmMedicos : Form
    {
        public frmMedicos()
        {
            InitializeComponent();
        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSmedicos.medicos' Puede moverla o quitarla según sea necesario.
            this.medicosTableAdapter.Fill(this.dSmedicos.medicos);
            activo(false);
        }

        private void activo(bool condicion)
        {
            txtcelular.Enabled = condicion;
            txtconfirmacion.Enabled = condicion;
            txtdireccion.Enabled = condicion;
            txtemail.Enabled = condicion;
            txtidentidad.Enabled = condicion;
            txtnombre.Enabled = condicion;
            txtpassword.Enabled = condicion;
            cmbCampus.Enabled = condicion;
            cmbcarrera.Enabled = condicion;
            cmbEstado.Enabled = condicion;
            cmbgenero.Enabled = condicion;
            cmbgenero.Enabled = condicion;
            cmbtrimestre.Enabled = condicion;
            cmbyear.Enabled = condicion;
            cmbturno.Enabled = condicion;
            dtpnacimiento.Enabled = condicion;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            
            txtidentidad.Text = row.Cells[2].Value.ToString();
            txtnombre.Text = row.Cells[1].Value.ToString();
            txtemail.Text = row.Cells[7].Value.ToString();
            txtdireccion.Text = row.Cells[8].Value.ToString();
            txtcelular.Text = row.Cells[9].Value.ToString();
            cmbCampus.Text = row.Cells[4].Value.ToString();
            cmbcarrera.Text = row.Cells[6].Value.ToString();
            cmbEstado.Text = row.Cells[5].Value.ToString();
            cmbgenero.Text = (Convert.ToBoolean(row.Cells[3].Value)) ? "Masculino" : "Femenino" ;
            cmbtrimestre.Text = row.Cells[0].Value.ToString();
            cmbyear.Text = row.Cells[10].Value.ToString();
            dtpnacimiento.Text = row.Cells[4].Value.ToString();

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            btneditar.Text = "Guardar";
            btnagregar.Enabled = false;

        }
    }
}
