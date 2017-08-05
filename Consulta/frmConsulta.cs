using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Consulta
{
    public partial class frmConsulta : Form
    {
        string cnx = "Server=localhost; Port= 5432; Database=clinica; User Id=postgres; Password=marathon1;";
        DataSet ds;
        public int statusForm = 0; //0 = Consultando; 1=Agregando; 2=Editando
        string sqlMedicamentosCombo = "SELECT idmedicamentos,nombre FROM administracion.medicamentos ORDER BY idmedicamentos ASC ";
        string sqlMedicamentosCant = "SELECT idmedicamentos,nombre,cantidad FROM administracion.medicamentos ORDER BY idmedicamentos ASC ";
        string sqlPaciente = "SELECT * FROM administracion.medicamentos WHERE idmedicamentos LIKE @filtro OR nombre LIKE @filtro ORDER BY nombre";
        
        string sqlAlergias = "SELECT * FROM administracion.medicamentos WHERE idmedicamentos LIKE @filtro OR nombre LIKE @filtro ORDER BY nombre";
        string sqlPadecimientos = "SELECT * FROM administracion.medicamentos WHERE idmedicamentos LIKE @filtro OR nombre LIKE @filtro ORDER BY nombre";
        string sqlProcedimientos = "SELECT * FROM administracion.medicamentos WHERE idmedicamentos LIKE @filtro OR nombre LIKE @filtro ORDER BY nombre";




        NpgsqlDataAdapter damedicamentos;
        public frmConsulta()
        {
            InitializeComponent();
           
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            Consulta.frmSearch serch = new Consulta.frmSearch();

            serch.ShowDialog();
            txtCuenta.Text = Resources.Propiedades.pacienteenconsulta;
            if (txtCuenta.Text != "")
            {
                activar(true);
            }


        }

        private void activar(bool condicion)
        {
            //txtmedicamento.Enabled = condicion;
            //txtDonado.Enabled = condicion;
            //txttipo.Enabled = condicion;
            //cmbCampus.Enabled = condicion;
            //cmbreorden.Enabled = condicion;
            //dtpvencimiento.Enabled = condicion;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        // Draw the new button. 
       
    }
}

