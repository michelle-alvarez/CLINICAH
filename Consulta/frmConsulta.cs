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
    public partial class txtVisita : Form
    {
        string cnx = "Server=localhost; Port= 5432; Database=clinicas; User Id=postgres; Password=malteada28;";
        DataSet ds;
        public int statusForm = 0; //0 = Consultando; 1=Agregando; 2=Editando
        string sqlMedicamentosCombo = "SELECT idmedicamentos,nombre FROM administracion.medicamentos ORDER BY idmedicamentos ASC ";
        string sqlMedicamentosCant = "SELECT idmedicamentos,nombre,cantidad FROM administracion.medicamentos ORDER BY idmedicamentos ASC ";
        string sqlPaciente = "SELECT * FROM administracion.medicamentos WHERE idmedicamentos LIKE @filtro OR nombre LIKE @filtro ORDER BY nombre";
        
        string sqlAlergias = "SELECT * FROM administracion.medicamentos WHERE idmedicamentos LIKE @filtro OR nombre LIKE @filtro ORDER BY nombre";
        string sqlPadecimientos = "SELECT * FROM administracion.medicamentos WHERE idmedicamentos LIKE @filtro OR nombre LIKE @filtro ORDER BY nombre";
        string sqlProcedimientos = "SELECT * FROM administracion.medicamentos WHERE idmedicamentos LIKE @filtro OR nombre LIKE @filtro ORDER BY nombre";

        NpgsqlDataAdapter damedicamentos;
        public txtVisita()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            ds = new DataSet();

            //Asignamos los parametros de busqueda en vacio para que cargue todos los usuarios

            damedicamentos.SelectCommand.Parameters.AddWithValue("@filtro", "%%");
            //Llenamos el Dataset con los datos del Table Adapter
            damedicamentos.Fill(ds, "paciente");

            txtCuenta.DataBindings.Add("text", ds.Tables["paciente"], "idpaciente");
            txtNombre.DataBindings.Add("text", ds.Tables["paciente"], "paciente");
            txtEdad.DataBindings.Add("text", ds.Tables["paciente"], "edad");
            txtAltura.DataBindings.Add("text", ds.Tables["paciente"], "altura");
            txtFenotipo.DataBindings.Add("text", ds.Tables["paciente"], "tiposangre");
            txtPeso.DataBindings.Add("text", ds.Tables["paciente"], "peso");

        }
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            frmSearch serch = new frmSearch();

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

        private void txtObservaciones_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

