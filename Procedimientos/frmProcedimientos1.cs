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

        int statusform = 0; // Define el estado del formulario, 0 = primera vez, 1 = agregar, 2 = update, 3= eliminar

        string parametros = "Server=localhost;Port=5432;User Id=postgres;Password=unicah;Database=clinicas";

        string sqlNoSumiUso = "Select administracion.suministros.idsuministros, administracion.suministros.nombre FROM administracion.suministros WHERE idsuministros NOT IN(SELECT administracion.suministros.idsuministros FROM administracion.suministros INNER JOIN atencion.procedimientossuministros ON administracion.suministros.idsuministros = atencion.procedimientossuministros.idsuministros)";
        //string sqlcategorias = "SELECT categoriaid, nombrecat FROM atencion.categoriaprocedimiento";
        DataSet dsprocedimiento = new DataSet();

        DataTable tableproc;
        DataTable suministros;
        DataTable categorias;

        int selectedprocid = 1;

        int ultimo;
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
            cargarultimo();

            statusform = 2; //paso a modo edicion.


        }

        private void cargarultimo()
        {
            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();

                string strSQL = "SELECT MAX (procid) FROM atencion.procedimientos";

                NpgsqlCommand Comando = new NpgsqlCommand(strSQL, Cnx);
                NpgsqlDataReader reader = Comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ultimo = reader.GetInt32(0) + 1;

                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();



                Cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




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


            try
            {
                dsprocedimiento.Tables["procedimientos"].Clear();
            }
            catch { }



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

                if (statusform == 0)
                {
                    tbCantidad.DataBindings.Add("text", dsprocedimiento.Tables["procedimientos"], "procid");
                    tbNombre.DataBindings.Add("text", dsprocedimiento.Tables["procedimientos"], "nombre");
                    tbDescrip.DataBindings.Add("text", dsprocedimiento.Tables["procedimientos"], "descripcion");

                }
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

            try
            {
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
            // Operaciones:  1 =  insertar, 2  actuzliar, 3= eliminar
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
                        InsertCommand.Parameters.AddWithValue("@cant", Convert.ToInt32(tbCantidad.Text));

                        InsertCommand.ExecuteNonQuery();

                        break;

                    case 2:
                        string SQLUpdate = "UPDATE atencion.procedimientossuministros SET cantsuministro = @cant WHERE idsuministros = @idsum";

                        NpgsqlCommand UpdateCommand = new NpgsqlCommand(SQLUpdate);
                        UpdateCommand.Connection = Cnx;
                        UpdateCommand.Parameters.AddWithValue("@cant", Convert.ToInt32(tbCantidad.Text));
                        UpdateCommand.Parameters.AddWithValue("@idsum", Convert.ToInt32(cbSuministro.SelectedValue));
                        UpdateCommand.ExecuteNonQuery();
                        break;


                    case 3: // Eliminamos 


                        int seleccionado = Convert.ToInt32(dgSuministros.CurrentRow.Cells[0].Value);
                        string SQLDelete = "DELETE FROM atencion.procedimientossuministros WHERE idsuministros = @idsum";
                        NpgsqlCommand DeleteCommand = new NpgsqlCommand(SQLDelete);
                        DeleteCommand.Connection = Cnx;
                        DeleteCommand.Parameters.AddWithValue("@idsum", seleccionado);
                        DeleteCommand.ExecuteNonQuery();

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
            
        }

        private void dgSuministros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btplus_click(object sender, EventArgs e)
        {


            



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {



            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            



        }

        private void actualizarproced(int operacion)

        {
            // Operaciones:  1 =  insertar, 2=actualizar 3= eliminar
            // 

            int procselecionado = 0;
            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;


            if (dtgProcedimientos.CurrentRow != null)
            {
                procselecionado = Convert.ToInt32(dtgProcedimientos.CurrentRow.Cells[0].Value);
            }

            try
            {
                Cnx.Open();
                switch (operacion)
                {


                    case 1: //  Insertamos 
                        string SQLInsert = "INSERT INTO atencion.procedimientos (procid, nombre, descripcion, categoriaid) VALUES (@idproc, @nom, @descrip, @catid)";
                        NpgsqlCommand InsertCommand = new NpgsqlCommand(SQLInsert);
                        InsertCommand.Connection = Cnx;
                        InsertCommand.Parameters.AddWithValue("@idproc", ultimo);
                        InsertCommand.Parameters.AddWithValue("@nom", tbNombre.Text);
                        InsertCommand.Parameters.AddWithValue("@descrip", tbDescrip.Text);
                        InsertCommand.Parameters.AddWithValue("@catid", Convert.ToInt32(cmbcategoria.SelectedValue));

                        InsertCommand.ExecuteNonQuery();
                        break;

                    case 2:
                        string SQLUpdate = "UPDATE atencion.procedimientos SET nombre = @nom, descripcion = @descrip, categoriaid = @catid WHERE procid = @idproc";

                        NpgsqlCommand UpdateCommand = new NpgsqlCommand(SQLUpdate);
                        UpdateCommand.Connection = Cnx;
                        UpdateCommand.Parameters.AddWithValue("@nom", tbNombre.Text);
                        UpdateCommand.Parameters.AddWithValue("@descrip", tbDescrip.Text);
                        UpdateCommand.Parameters.AddWithValue("@catid", Convert.ToInt32(cmbcategoria.SelectedValue));
                        UpdateCommand.Parameters.AddWithValue("@idproc", procselecionado);
                        UpdateCommand.ExecuteNonQuery();
                        break;



                    case 3: // Update



                        string SQLDelete = "DELETE FROM atencion.procedimientos WHERE procid = @idproc";
                        NpgsqlCommand DeleteCommand = new NpgsqlCommand(SQLDelete);
                        DeleteCommand.Connection = Cnx;
                        DeleteCommand.Parameters.AddWithValue("@idproc", procselecionado);
                        DeleteCommand.ExecuteNonQuery();

                        break;


                }

                Cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error al actualizar los suministros.");
            }

            cargardatagrid();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void btPlus_Click_1(object sender, EventArgs e)
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

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            tbCantidad.Clear();
            tbDescrip.Clear();
            tbNombre.Clear();

            cmbcategoria.DataBindings.Clear();
            cbSuministro.DataBindings.Clear();

            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();

                string strSQL = "SELECT categoriaid, nombrecat FROM atencion.categoriaprocedimiento";
                NpgsqlDataAdapter Categorias = new NpgsqlDataAdapter(strSQL, Cnx);

                Categorias.Fill(dsprocedimiento, "categorias");

                cmbcategoria.DataSource = dsprocedimiento.Tables["categorias"];
                cmbcategoria.ValueMember = "categoriaid";
                cmbcategoria.DisplayMember = "nombrecat";


                Cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            statusform = 1; // cambiamos a agregar

            cbSuministro.Enabled = false;
            tbCantidad.Enabled = false;
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            cmbcategoria.DataBindings.Clear();
            actualizarproced(3);
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            switch (statusform)
            {
                case 1:
                    cmbcategoria.DataBindings.Clear();
                    actualizarproced(1);
                    cbSuministro.Enabled = true;
                    tbCantidad.Enabled = true;
                    btnGuardar.Enabled = true;



                    break;

                case 2:

                    cmbcategoria.DataBindings.Clear();
                    actualizarproced(2);
                    cbSuministro.Enabled = true;
                    tbCantidad.Enabled = true;
                    btnGuardar.Enabled = true;
                    break;

            }

            statusform = 2;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cmbcategoria.DataBindings.Clear();
            actualizarsum(2);
        }

        private void dtgProcedimientos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgProcedimientos.CurrentRow != null)
            {
                selectedprocid = Convert.ToInt32(dtgProcedimientos.CurrentRow.Cells[0].Value);
                cargarsuministros(selectedprocid);

            }
        }
    }
}
