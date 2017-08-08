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
    public partial class frmHistorial : Form
    {
        string cnx = "Server=localhost; Port= 5432; Database=clinicas; User Id=postgres; Password=unicah;";
        DataSet ds;

        string sqlConsulta = "SELECT * FROM administracion.medicamentos WHERE idmedicamentos LIKE @filtro OR nombre LIKE @filtro ORDER BY nombre";
        string sqlPaciente = "SELECT idpaciente, paciente,(current_date- fechanac)/365 as edad, altura, peso, tiposangre FROM pacientes.paciente where idpaciente LIKE @paciente";
        string sqlAlergias = "select idalergia, alergias.idpaciente, paciente FROM pacientes.alergias inner join pacientes.consulta on alergias.idpaciente = consulta.idpaciente inner join pacientes.paciente on consulta.idpaciente = paciente.idpaciente";

        NpgsqlDataAdapter daConsulta;
        NpgsqlDataAdapter daPacientes;
        NpgsqlDataAdapter daAlergias;
        public frmHistorial()
        {
            InitializeComponent();
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            ds = new DataSet();

            //Llenamos el Dataset con los datos del Table Adapter
            daConsulta.Fill(ds, "consulta");
            daPacientes.Fill(ds, "paciente");
            daAlergias.Fill(ds, "alergias");

            //Asignamos las columnas del Grid
            GrdDetalle.AutoGenerateColumns = false;
            GrdDetalle.Columns[0].DataPropertyName = "idconsulta";
            GrdDetalle.Columns[1].DataPropertyName = "idpaciente";
            GrdDetalle.Columns[2].DataPropertyName = "idmedico";
            GrdDetalle.Columns[3].DataPropertyName = "procid";
            GrdDetalle.Columns[4].DataPropertyName = "fecha";
            GrdDetalle.Columns[5].DataPropertyName = "observacion";
            GrdDetalle.Columns[6].DataPropertyName = "idcampus";

            //Asignar la fuente de datos al DataGrid con la table adapter creada anteriormente
            GrdDetalle.DataSource = ds.Tables["consulta"];
            txtAltura.DataBindings.Add("text", ds.Tables["paciente"], "altura");
            txtEdad.DataBindings.Add("text", ds.Tables["paciente"], "edad");
            txtFenotipo.DataBindings.Add("text", ds.Tables["paciente"], "tiposangre");
            txtPeso.DataBindings.Add("text", ds.Tables["paciente"], "peso");
            txtObservacion.DataBindings.Add("text", ds.Tables["consulta"], "observacion");
        }

        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                string filtro = "%" + txtCuenta.Text + "%";
                daConsulta.SelectCommand.Parameters.Clear();
                daConsulta.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
                ds.Tables["consulta"].Clear();
                daConsulta.Fill(ds, "consulta");
                ds.Tables["paciente"].Clear();
            }
        }
    }
}
