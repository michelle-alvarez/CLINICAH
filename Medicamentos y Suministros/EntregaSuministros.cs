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
namespace Medicamentos_y_Suministros
{
    public partial class EntregaSuministros : Form
    {


        string cnx = "Server=localhost; Port= 5432; Database=clinica; User Id=postgres; Password=Salmos665;";
        DataSet ds;
        public int statusForm = 0; //0 = Consultando; 1=Agregando; 2=Editando
        string sqlMedicamentos = "SELECT nombre,cantidad,reorden FROM administracion.suministros WHERE nombre LIKE @filtro ORDER BY nombre";
        NpgsqlDataAdapter damedicamentos;


        public EntregaSuministros()
        {
            InitializeComponent();
            damedicamentos = new NpgsqlDataAdapter(sqlMedicamentos, cnx);
        }

        private void EntregaSuministros_Load(object sender, EventArgs e)
        {
            ds = new DataSet();

            DGMedicamentos.AutoGenerateColumns = false;
            DGMedicamentos.Columns[0].DataPropertyName = "nombre";
            DGMedicamentos.Columns[1].DataPropertyName = "cantidad";
            DGMedicamentos.Columns[2].DataPropertyName = "reorden";

            damedicamentos.SelectCommand.Parameters.AddWithValue("@filtro", "%%");
            damedicamentos.Fill(ds, "medicamentos");

            DGMedicamentos.DataSource = ds.Tables["medicamentos"];

            txtsuministros.DataBindings.Add("text", ds.Tables["medicamentos"], "nombre");

            nmbcantidad.DataBindings.Add("text", ds.Tables["medicamentos"], "cantidad");
            nmbreorden.DataBindings.Add("text", ds.Tables["medicamentos"], "reorden");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dynamic filtro = "%" + txtBuscar.Text + "%";
            damedicamentos.SelectCommand.Parameters.Clear();
            damedicamentos.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string strSQL = "";

            strSQL = "UPDATE administracion.suministros SET  cantidad=@cantidad,  reorden = @reorden  WHERE nombre = @nombre";
            try
            {
                using (NpgsqlConnection conexion = new NpgsqlConnection(cnx))
                {
                    NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);

                    comando.Parameters.AddWithValue("@nombre", txtsuministros.Text);
                    comando.Parameters.AddWithValue("@reorden", Convert.ToDecimal(nmbreorden.Text));
                    comando.Parameters.AddWithValue("@cantidad", Convert.ToDecimal(nmbcantidad.Text));

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    dynamic filtro = "%" + txtBuscar.Text + "%";
                    damedicamentos.SelectCommand.Parameters.Clear();
                    damedicamentos.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
                    ds.Tables["medicamentos"].Clear();
                    damedicamentos.Fill(ds, "medicamentos");
                    conexion.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
