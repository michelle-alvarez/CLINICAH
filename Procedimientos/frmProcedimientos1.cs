
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

namespace Procedimientos
{
    public partial class frmProcedimientos1 : Form
    {

        int statusform = 0; // Define el estado del formulario, 0 = visual, 1 = agregando, 2 = editando

        string parametros = "Server=localhost; Port= 5432; Database=clinicas; User Id=postgres; Password=unicah;";

        string sqlNoSumiUso = "Select administracion.suministros.idsuministros, administracion.suministros.nombre FROM administracion.suministros WHERE idsuministros NOT IN(SELECT administracion.suministros.idsuministros FROM administracion.suministros INNER JOIN atencion.procedimientossuministros ON administracion.suministros.idsuministros = atencion.procedimientossuministros.idsuministros)";
        string sqlcategorias = "SELECT categoriaid, nombrecat FROM atencion.categoriaprocedimiento";
        DataSet dsprocedimiento = new DataSet();
        DataTable tableproc;
        DataTable suministros;

        int selectedprocid = 1;
        NpgsqlDataAdapter TableAdap = new NpgsqlDataAdapter();


        public frmProcedimientos1()
        {
            InitializeComponent();
        }

        private void frmProcedimientos1_Load(object sender, EventArgs e)
        {
            cargardatagrid();
            cargarsuministros(1); // Carga la info del primer elemento

            // Cargar Suministros al combobox

            cargarcbSum();



         
        }

        private void cargarcbSum()
        {

            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();

                string strSQL = "SELECT idsuministros, nombre FROM administracion.suministros";
                NpgsqlDataAdapter TableAdap = new NpgsqlDataAdapter(strSQL, Cnx);

                TableAdap.Fill(dsprocedimiento, "listasuministro");

                cbSuministro.DataSource = dsprocedimiento.Tables["listasuministro"];
                cbSuministro.ValueMember = "idsuministros";
                cbSuministro.DisplayMember = "nombre";



                Cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }
        private void cargardatagrid()

        {

            dtgProcedimientos.AutoGenerateColumns = false;
            dtgProcedimientos.Columns[0].DataPropertyName = "procid";
            dtgProcedimientos.Columns[1].DataPropertyName = "nombre";
            dtgProcedimientos.Columns[2].DataPropertyName = "descripcion";
            dtgProcedimientos.Columns[3].DataPropertyName = "nombrecat";


            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();
                //MessageBox.Show("-BIENVENIDO-");

                string strSQL = "SELECT procid, atencion.procedimientos.nombre, atencion.procedimientos.descripcion, atencion.categoriaprocedimiento.nombrecat FROM atencion.categoriaprocedimiento INNER JOIN atencion.procedimientos ON atencion.procedimientos.categoriaid = atencion.categoriaprocedimiento.categoriaid";
                NpgsqlDataAdapter TableAdap = new NpgsqlDataAdapter(strSQL, Cnx);
  
                NpgsqlDataAdapter daNoProceSumi = new NpgsqlDataAdapter(sqlNoSumiUso, Cnx);
                //NpgsqlDataAdapter categorias = new NpgsqlDataAdapter(sqlcategorias, Cnx);


                TableAdap.Fill(dsprocedimiento, "procedimientos");


                //dacategorias.Fill(dsprocedimiento, "categorias");

                dtgProcedimientos.DataSource = dsprocedimiento.Tables["procedimientos"];

             
                tbCantidad.DataBindings.Add("text", dsprocedimiento.Tables["procedimientos"], "procid");
                tbNombre.DataBindings.Add("text", dsprocedimiento.Tables["procedimientos"], "nombre");
                tbDescrip.DataBindings.Add("text", dsprocedimiento.Tables["procedimientos"], "descripcion");
                cmbcategoria.DataBindings.Add("text", dsprocedimiento.Tables["procedimientos"], "nombrecat");


                Cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

       private void cargarsuministros(int fila)

        {
           
            dgSuministros.AutoGenerateColumns = false;
            dgSuministros.Columns[0].DataPropertyName = "idsuministros";
            dgSuministros.Columns[1].DataPropertyName = "nombre";
            dgSuministros.Columns[2].DataPropertyName = "cantsuministro";


            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;

            try {
                dsprocedimiento.Tables["Suministros"].Clear();
            }
                catch { }



            try
            {
                Cnx.Open();
                //MessageBox.Show("-BIENVENIDO-");

                string sqlSuministrosActuales = "SELECT administracion.suministros.idsuministros, administracion.suministros.nombre, atencion.procedimientossuministros.cantsuministro FROM administracion.suministros INNER JOIN atencion.procedimientossuministros ON administracion.suministros.idsuministros = atencion.procedimientossuministros.idsuministros WHERE procid = @id";
                NpgsqlCommand Comando = new NpgsqlCommand(sqlSuministrosActuales);
                Comando.Connection = Cnx;
                int ID;


                Comando.Parameters.AddWithValue("@id", fila);



                //NpgsqlDataAdapter TableAdap = new NpgsqlDataAdapter();
                //TableAdap.SelectCommand = Comando;
                NpgsqlDataAdapter TableSum = new NpgsqlDataAdapter();
                TableSum.SelectCommand = Comando;




                //dacategorias.Fill(dsprocedimiento, "categorias");
                //NpgsqlDataAdapter TableSum = new NpgsqlDataAdapter(sqlSuministrosActuales,Cnx);
                TableSum.Fill(dsprocedimiento, "suministros");
                

                dgSuministros.DataSource = dsprocedimiento.Tables["suministros"];


                    Cnx.Close();
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error al cargar los suministros.");
            }

            
        }

        private void actualizarsum(int operacion)

        {
            // Operaciones:  1 =  insertar, 2= eliminar, 3= actualizar
            // 


            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;

            int sumselecionado = 0;
            if (dgSuministros.CurrentRow != null)
            {
                sumselecionado = Convert.ToInt32(dgSuministros.CurrentRow.Cells[0].Value);
            }

            try
            {
                Cnx.Open();
                            switch (operacion)
                        {

                            case 1: //  Insertamos 
                                string SQLInsert = "INSERT INTO atencion.procedimientossuministros (procid, idsuministros, cantsuministro) VALUES (@idproc, @idsum, @cant)";
                                NpgsqlCommand InsertCommand = new NpgsqlCommand(SQLInsert);
                                InsertCommand.Connection = Cnx;
                                InsertCommand.Parameters.AddWithValue("@idproc", selectedprocid);
                                InsertCommand.Parameters.AddWithValue("@idsum", Convert.ToInt32(cbSuministro.SelectedValue));
                                InsertCommand.Parameters.AddWithValue("@idsum", Convert.ToInt32(tbCantidad));

                        InsertCommand.ExecuteNonQuery();
                        break;
                    case 2: // Eliminamos 

                  

                        string SQLDelete = "DELETE FROM atencion.procedimientossuministros WHERE idsuministros = @idsum";
                        NpgsqlCommand DeleteCommand = new NpgsqlCommand(SQLDelete);
                        DeleteCommand.Connection = Cnx;
                        DeleteCommand.Parameters.AddWithValue("@idsum", sumselecionado);
                        DeleteCommand.ExecuteNonQuery();

                        break;

                    case 3:
                        string SQLUpdate = "UPDATE atencion.procedimientossuministros SET cantsuministro = @cant WHERE idsuministros = @idsum";

                        NpgsqlCommand UpdateCommand = new NpgsqlCommand(SQLUpdate);
                        UpdateCommand.Connection = Cnx;
                        UpdateCommand.Parameters.AddWithValue("@cant", Convert.ToInt32(tbCantidad.Text));
                        UpdateCommand.Parameters.AddWithValue("@idsum", Convert.ToInt32(cbSuministro.SelectedValue));
                        UpdateCommand.ExecuteNonQuery();
                        break;

                        }

                Cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error al actualizar los suministros.");
            }

            cargarsuministros(selectedprocid);
        }




        private void dtgProcedimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgProcedimientos.CurrentRow != null)
            {
                selectedprocid = Convert.ToInt32(dtgProcedimientos.CurrentRow.Cells[0].Value);
                cargarsuministros(selectedprocid);
             
            }
        }

        private void dgSuministros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btplus_click(object sender, EventArgs e)
        {
                   
        {
            int x;

            bool nuevo = true;


            foreach (DataGridViewRow fila in dgSuministros.Rows)
            {
                if (Convert.ToInt32(fila.Cells[0].Value) == Convert.ToInt32(cbSuministro.SelectedValue))
                {
                        // Si ya existe entonces solo actualizo
                        actualizarsum(3);
                            // Operaciones:  1 =  insertar, 2= eliminar, 3= actualizar
 



                            nuevo = false;
                    break;
                }

            }
            if (nuevo == true)
            {

                    if (dtgProcedimientos.CurrentRow != null)
                    {
                        // Si no existe, entonces lo creo
                        actualizarsum(1);
                        // Operaciones:  1 =  insertar, 2= eliminar, 3= actualizar


                        //dgSuministros.Rows.Add(cbSuministro.SelectedValue, cbSuministro.SelectedText, );
                    }


                }


        }
    }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
       //     dsprocedimiento.Tables["suministros"].Rows.Add(FilaNueva);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 0;
            int seleccionado = Convert.ToInt32(cbSuministro.SelectedValue);

            foreach (DataGridViewRow fila in dgSuministros.Rows)
            {
                if (Convert.ToInt32(fila.Cells[0].Value) == seleccionado)
                {
                    if (Convert.ToInt32(fila.Cells[2].Value) > 1 && Convert.ToInt32(fila.Cells[2].Value) < seleccionado)
                    {
                        x = Convert.ToInt32(fila.Cells[2].Value) - seleccionado;
                        fila.Cells[2].Value = x;
                        break;
                    }
                    else
                    {
                        dgSuministros.Rows.RemoveAt(fila.Index);
                        break;
                    }
                }
            }
        }
    }
}
