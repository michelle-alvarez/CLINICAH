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
using Resources;

namespace Medicos
{
    public partial class frmMedicos : Form
    {
        string cnx = "Server=localhost; Port= 5432; Database=clinica; User Id=postgres; Password=Salmos665;";
        DataSet ds;
        public int statusForm = 0; //0 = Consultando; 1=Agregando; 2=Editando
        string sqlUsuarios = "SELECT * FROM administracion.medicos WHERE idmedico LIKE @filtro OR nombrecompleto LIKE @filtro ORDER BY idmedico";
        NpgsqlDataAdapter damedicos;

        public frmMedicos()
        {
            InitializeComponent();
            damedicos = new NpgsqlDataAdapter(sqlUsuarios, cnx);
        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSmedicos.medicos' Puede moverla o quitarla según sea necesario.
            ds = new DataSet();

            //Asignamos las columnas del Grid
            DGMedicos.AutoGenerateColumns = false;
            DGMedicos.Columns[0].DataPropertyName = "idmedico";
            DGMedicos.Columns[1].DataPropertyName = "nombrecompleto";
            DGMedicos.Columns[2].DataPropertyName = "genero";
            DGMedicos.Columns[3].DataPropertyName = "campus";
            DGMedicos.Columns[4].DataPropertyName = "especialidad";
            DGMedicos.Columns[5].DataPropertyName = "celular";
            DGMedicos.Columns[6].DataPropertyName = "aniocarrera";
            DGMedicos.Columns[7].DataPropertyName = "estadocivil";
            DGMedicos.Columns[8].DataPropertyName = "trimestre";
            DGMedicos.Columns[9].DataPropertyName = "fechanac";
            DGMedicos.Columns[10].DataPropertyName = "email";
            DGMedicos.Columns[11].DataPropertyName = "direccion";
            DGMedicos.Columns[12].DataPropertyName = "pass";

            //Asignamos los parametros de busqueda en vacio para que cargue todos los usuarios
            damedicos.SelectCommand.Parameters.AddWithValue("@filtro", "%%");
            //Llenamos el Dataset con los datos del Table Adapter
            damedicos.Fill(ds, "usuarios");

            //Asignar la fuente de datos al DataGrid con la table adapter creada anteriormente
            DGMedicos.DataSource = ds.Tables["usuarios"];
            txtidentidad.DataBindings.Add("text", ds.Tables["usuarios"], "idmedico");
            txtnombre.DataBindings.Add("text", ds.Tables["usuarios"], "nombrecompleto");
            cmbgenero.DataBindings.Add("text", ds.Tables["usuarios"], "genero");
            cmbCampus.DataBindings.Add("text", ds.Tables["usuarios"], "campus");
            cmbcarrera.DataBindings.Add("text", ds.Tables["usuarios"], "especialidad");
            txtcelular.DataBindings.Add("text", ds.Tables["usuarios"], "celular");
            cmbyear.DataBindings.Add("text", ds.Tables["usuarios"], "aniocarrera");
            cmbEstado.DataBindings.Add("text", ds.Tables["usuarios"], "estadocivil");
            cmbtrimestre.DataBindings.Add("text", ds.Tables["usuarios"], "trimestre");
            dtpnacimiento.DataBindings.Add("text", ds.Tables["usuarios"], "fechanac");
            txtemail.DataBindings.Add("text", ds.Tables["usuarios"], "email");
            txtdireccion.DataBindings.Add("text", ds.Tables["usuarios"], "direccion");

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
            dtpnacimiento.Enabled = condicion;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            DGMedicos.ReadOnly = true;
            DGMedicos.Enabled = false;
            btneditar.Text = "Guardar";
            btnagregar.Enabled = false;
            btnDelete.Enabled = false;
            txtcelular.Clear();
            txtconfirmacion.Clear();
            txtdireccion.Clear();
            txtemail.Clear();
            txtidentidad.Clear();
            txtnombre.Clear();
            txtpassword.Clear();
            cmbCampus.SelectedItem = 1;
            cmbcarrera.SelectedItem = 1;
            cmbEstado.SelectedItem = 1;
            cmbgenero.SelectedItem = 1;
            cmbgenero.SelectedItem = 1;
            cmbtrimestre.SelectedItem = 1;
            cmbyear.SelectedItem = 1;
            dtpnacimiento.Value = DateTime.Now;
            statusForm = 1;
            txtidentidad.Focus();
            activo(true);
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dynamic filtro = "%" + txtbuscar.Text + "%";
                damedicos.SelectCommand.Parameters.Clear();
                damedicos.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
                ds.Tables["usuarios"].Clear();
                damedicos.Fill(ds, "usuarios");
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            string strSQL = "";
            if (statusForm == 0)
            {
                activo(true);
                DGMedicos.ReadOnly = true;
                DGMedicos.Enabled = false;
                btnagregar.Enabled = false;
                btnDelete.Enabled = false;
                btneditar.Text = "Guardar";
                statusForm = 2;
                txtnombre.Focus();
            }
            else
            {
                if (statusForm == 1)
                {
                    if ((txtpassword.Text != "") && (txtpassword.Text == txtconfirmacion.Text))
                    {
                        strSQL = "INSERT INTO administracion.medicos(idmedico, nombrecompleto, genero, campus, especialidad, celular, aniocarrera, estadocivil, trimestre, fechanac, email, direccion, pass) VALUES(@idmedico, @nombrecompleto, @genero, @campus, @especialidad, @celular, @aniocarrera, @estadocivil, @trimestre, @fechanac, @email, @direccion, @pass); ";
                        try
                        {
                            using (NpgsqlConnection conexion = new NpgsqlConnection(cnx))
                            {
                                NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);
                                comando.Parameters.AddWithValue("@idmedico", txtidentidad.Text);
                                comando.Parameters.AddWithValue("@nombrecompleto", txtnombre.Text);
                                comando.Parameters.AddWithValue("@genero", cmbgenero.Text);
                                comando.Parameters.AddWithValue("@campus", cmbCampus.Text);
                                comando.Parameters.AddWithValue("@especialidad", cmbcarrera.Text);
                                comando.Parameters.AddWithValue("@celular", Convert.ToDecimal(txtcelular.Text));
                                comando.Parameters.AddWithValue("@aniocarrera", Convert.ToDecimal(cmbyear.Text));
                                comando.Parameters.AddWithValue("@estadocivil", cmbEstado.Text);
                                comando.Parameters.AddWithValue("@trimestre", Convert.ToDecimal(cmbtrimestre.Text));
                                comando.Parameters.AddWithValue("@fechanac", dtpnacimiento.Value);
                                comando.Parameters.AddWithValue("@email", txtemail.Text);
                                comando.Parameters.AddWithValue("@direccion", txtdireccion.Text);
                                comando.Parameters.AddWithValue("@pass", txtpassword.Text);
                                conexion.Open();
                                comando.ExecuteNonQuery();
                                activo(false);
                                dynamic filtro = "%" + txtbuscar.Text + "%";
                                damedicos.SelectCommand.Parameters.Clear();
                                damedicos.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
                                ds.Tables["usuarios"].Clear();
                                damedicos.Fill(ds, "usuarios");
                                btnagregar.Enabled = true;
                                btnDelete.Enabled = true;
                                txtidentidad.ReadOnly = true;
                                btneditar.Text = "Editar";
                                DGMedicos.ReadOnly = false;
                                DGMedicos.Enabled = true;
                                statusForm = 0;
                                conexion.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseñas no coinciden");
                    }
                }
                else
                {
                    if (statusForm == 2)
                    {
                        if (txtpassword.Text == txtconfirmacion.Text)
                        {
                            if (txtpassword.Text == "")
                            {
                                strSQL = "UPDATE administracion.medicos SET nombrecompleto = @nombrecompleto, genero = @genero, campus = @campus, especialidad = @especialidad, celular = @celular, aniocarrera = @aniocarrera, estadocivil = @estadocivil, trimestre = @trimestre, fechanac = @fechanac, email = @email, direccion = @direccion   WHERE idmedico = @idmedico";
                            }
                            else
                            {
                                strSQL = "UPDATE administracion.medicos SET nombrecompleto = @nombrecompleto, genero = @genero, campus = @campus, especialidad = @especialidad, celular = @celular, aniocarrera = @aniocarrera, estadocivil = @estadocivil, trimestre = @trimestre, fechanac = @fechanac, email = @email, direccion = @direccion, pass = @pass   WHERE idmedico = @idmedico";
                            }
                            try
                            {
                                using (NpgsqlConnection conexion = new NpgsqlConnection(cnx))
                                {
                                    NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);
                                    comando.Parameters.AddWithValue("@idmedico", txtidentidad.Text);
                                    comando.Parameters.AddWithValue("@nombrecompleto", txtnombre.Text);
                                    comando.Parameters.AddWithValue("@genero", cmbgenero.Text);
                                    comando.Parameters.AddWithValue("@campus", cmbCampus.Text);
                                    comando.Parameters.AddWithValue("@especialidad", cmbcarrera.Text);
                                    comando.Parameters.AddWithValue("@celular", Convert.ToDecimal(txtcelular.Text));
                                    comando.Parameters.AddWithValue("@aniocarrera", Convert.ToDecimal(cmbyear.Text));
                                    comando.Parameters.AddWithValue("@estadocivil", cmbEstado.Text);
                                    comando.Parameters.AddWithValue("@trimestre", Convert.ToDecimal(cmbtrimestre.Text));
                                    comando.Parameters.AddWithValue("@fechanac", dtpnacimiento.Value);
                                    comando.Parameters.AddWithValue("@email", txtemail.Text);
                                    comando.Parameters.AddWithValue("@direccion", txtdireccion.Text);
                                    comando.Parameters.AddWithValue("@pass", txtpassword.Text);
                                    conexion.Open();
                                    comando.ExecuteNonQuery();
                                    activo(false);
                                    dynamic filtro = "%" + txtbuscar.Text + "%";
                                    damedicos.SelectCommand.Parameters.Clear();
                                    damedicos.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
                                    ds.Tables["usuarios"].Clear();
                                    damedicos.Fill(ds, "usuarios");
                                    btnagregar.Enabled = true;
                                    btnDelete.Enabled = true;
                                    txtidentidad.ReadOnly = true;
                                    btneditar.Text = "Editar";
                                    DGMedicos.ReadOnly = false;
                                    DGMedicos.Enabled = true;
                                    statusForm = 0;
                                    conexion.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseñas no coinciden");
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DGMedicos.RowCount > 0)
            {
                dynamic strSQL = "DELETE FROM administracion.medicos WHERE idmedico = @idmedico";
                dynamic idmedico = DGMedicos.Rows[DGMedicos.CurrentRow.Index].Cells[0].Value;
                try
                {
                    using (NpgsqlConnection conexion = new NpgsqlConnection(cnx))
                    {
                        NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);
                        comando.Parameters.AddWithValue("@idmedico", idmedico);
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        //Ejecucion de un Query de accion
                        DGMedicos.Rows.Remove(DGMedicos.CurrentRow);
                        conexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activo(false);
            btnagregar.Enabled = true;
            btneditar.Text = "Editar";
            btnDelete.Enabled = true;
            statusForm = 0;
        }
    }
}
