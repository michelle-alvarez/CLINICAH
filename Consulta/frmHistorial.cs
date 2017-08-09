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

        string sqlConsulta = "SELECT pacientes.consulta.idconsulta, pacientes.paciente.nombre, pacientes.consulta.presion, pacientes.consulta.motivovisita as motivo_visita, administracion.medicos.nombrecompleto as medico, atencion.procedimientos.nombre AS procedimiento, pacientes.consulta.fecha, administracion.campus.campus, pacientes.consulta.observacion FROM pacientes.consulta INNER JOIN pacientes.paciente ON pacientes.consulta.idpaciente = pacientes.paciente.idpaciente INNER JOIN administracion.medicos ON pacientes.consulta.idmedico = administracion.medicos.idmedico INNER JOIN atencion.procedimientos ON pacientes.consulta.procid = atencion.procedimientos.procid INNER JOIN administracion.campus ON pacientes.consulta.idcampus = administracion.campus.idcampus WHERE pacientes.consulta.idpaciente LIKE @filtro";
        string sqlPaciente = "SELECT idpaciente, paciente.nombre,(current_date- fechanac)/365 as edad, altura, peso, tiposangre, carreras.nombre as carrera FROM pacientes.paciente inner join administracion.carreras on administracion.carreras.idcarrera = pacientes.paciente.idcarrera where idpaciente LIKE @filtro";
        string sqlAlergias = "select paciente.idpaciente, ala.nombre as alergia from pacientes.paciente inner join pacientes.alergias on paciente.idpaciente = alergias.idpaciente inner join administracion.lista_alergias as ala on alergias.idalergia = ala.idalergia where paciente.idpaciente LIKE  @filtro";
        string sqlPadecimientos = "select paciente.idpaciente, sscm.nombre as padecimiento from pacientes.paciente inner join pacientes.padecimientos on paciente.idpaciente = padecimientos.idpaciente inner join administracion.lista_padecimientos as sscm on sscm.idpadecimiento = padecimientos.idpadecimiento where paciente.idpaciente LIKE @filtro";

        NpgsqlDataAdapter daConsulta;
        NpgsqlDataAdapter daPacientes;
        NpgsqlDataAdapter daAlergias;
        NpgsqlDataAdapter daPadecimientos;

        public frmHistorial()
        {
            InitializeComponent();
            daConsulta = new NpgsqlDataAdapter(sqlConsulta, cnx);
            daAlergias = new NpgsqlDataAdapter(sqlAlergias, cnx);
            daPacientes = new NpgsqlDataAdapter(sqlPaciente, cnx);
            daPadecimientos = new NpgsqlDataAdapter(sqlPadecimientos, cnx);

            //Asignamos las columnas del Grid
            GrdDetalle.AutoGenerateColumns = false;
            GrdDetalle.Columns[0].DataPropertyName = "idconsulta";
            GrdDetalle.Columns[1].DataPropertyName = "fecha";
            GrdDetalle.Columns[2].DataPropertyName = "nombre";
            GrdDetalle.Columns[3].DataPropertyName = "campus";
            GrdDetalle.Columns[4].DataPropertyName = "medico";
            GrdDetalle.Columns[5].DataPropertyName = "procedimiento";
            GrdDetalle.Columns[6].DataPropertyName = "observacion";

        }

        private void pac()
        {
            string consultado = Resources.Propiedades.pacienteenconsulta;
            try
            {
                //Asignamos los parametros de busqueda en vacio para que cargue todos los usuarios
                daPacientes.SelectCommand.Parameters.AddWithValue("@filtro", consultado);
                //Llenamos el Dataset con los datos del Table Adapter
                daPacientes.Fill(ds, "pacientes");
                txtAltura.DataBindings.Add("text", ds.Tables["pacientes"], "altura");
                txtEdad.DataBindings.Add("text", ds.Tables["pacientes"], "edad");
                txtFenotipo.DataBindings.Add("text", ds.Tables["pacientes"], "tiposangre");
                txtPeso.DataBindings.Add("text", ds.Tables["pacientes"], "peso");
                txtCarrera.DataBindings.Add("text", ds.Tables["pacientes"], "carrera");
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show(e.Message);
            }
            ////////////////////////////////////Alergias///////////////////////////////////////
            try
            {
                daAlergias.SelectCommand.Parameters.AddWithValue("@filtro", consultado);
                daAlergias.Fill(ds, "lista_alergias");
                lbxAlergias.DataSource = ds.Tables["lista_alergias"];
                lbxAlergias.ValueMember = "alergia";
                lbxAlergias.DisplayMember = "alergia";
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show(e.Message);
            }
            ////////////////////////////////////Patologias///////////////////////////////////////
            try
            {
                daPadecimientos.SelectCommand.Parameters.AddWithValue("@filtro", consultado);
                daPadecimientos.Fill(ds, "patologias");
                lbxPato.DataSource = ds.Tables["patologias"];
                lbxPato.DisplayMember = "padecimiento";
                lbxPato.ValueMember = "padecimiento";
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void grid()
        {
            string consultado = Resources.Propiedades.pacienteenconsulta;
            //Asignamos los parametros de busqueda en vacio para que cargue todos los usuarios
            daConsulta.SelectCommand.Parameters.AddWithValue("@filtro", consultado);
            //Llenamos el Dataset con los datos del Table Adapter
            daConsulta.Fill(ds, "consulta");
            //Asignar la fuente de datos al DataGrid con la table adapter creada anteriormente
            GrdDetalle.DataSource = ds.Tables["consulta"];
            txtObservacion.DataBindings.Add("text", ds.Tables["consulta"], "observacion");
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            string consultado = Resources.Propiedades.pacienteenconsulta;
            grid();
            pac();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
