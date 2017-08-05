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
    public partial class frmSearch : Form
    {
        string cnx = "Server=localhost; Port= 5432; Database=clinica; User Id=postgres; Password=marathon1;";
        DataSet ds;
        public int statusForm = 0; //0 = Consultando; 1=Agregando; 2=Editando
        //string sqlPaciente = "SELECT idpaciente,paciente FROM pacientes.paciente WHERE idpaciente LIKE @filtro";
        string sqlPaciente = "SELECT idpaciente,cast(paciente as text) FROM pacientes.paciente";
        NpgsqlDataAdapter daPaciente;

        public frmSearch()
        {
            InitializeComponent();
            daPaciente = new NpgsqlDataAdapter(sqlPaciente, cnx);
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            Resources.Propiedades.pacienteenconsulta = "";
            ds = new DataSet();
            //Asignamos las columnas del Grid
            

            grdDetalle.AutoGenerateColumns = false;
            grdDetalle.Columns[0].DataPropertyName = "idpaciente";
            grdDetalle.Columns[1].DataPropertyName = "paciente";

            //Asignamos los parametros de busqueda en vacio para que cargue todos los usuarios
            daPaciente.SelectCommand.Parameters.AddWithValue("@filtro", "%%");
            //Llenamos el Dataset con los datos del Table Adapter
            daPaciente.Fill(ds, "paciente");

            //Asignar la fuente de datos al DataGrid con la table adapter creada anteriormente
            grdDetalle.DataSource = ds.Tables["paciente"];
            txtCuenta.DataBindings.Add("text",ds.Tables["paciente"],"idpaciente");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Resources.Propiedades.pacienteenconsulta = txtCuenta.Text;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            Resources.Propiedades.pacienteenconsulta = "";
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                string filtro = "%" + txtFiltro.Text + "%";
                daPaciente.SelectCommand.Parameters.Clear();
                daPaciente.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
                ds.Tables["paciente"].Clear();
                daPaciente.Fill(ds, "requisitos");
            }
        }
    }
}
