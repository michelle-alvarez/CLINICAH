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

namespace Medicos
{
    public partial class frmMedicos : Form
    {
        string cnx = "";
        DataSet ds;
        public int statusForm = 0; //0 = Consultando; 1=Agregando; 2=Editando
        string sqlUsuarios = "SELECT *, CASE genero WHEN 1 THEN 'Masculino' WHEN 0 THEN 'Femenino' END as generotext  FROM seg.usuarios WHERE idusuario LIKE @filtro OR usuario LIKE @filtro ORDER BY idusuario";
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
            DGMedicos.Columns[1].DataPropertyName = "usuario";
            DGMedicos.Columns[2].DataPropertyName = "genero";
            DGMedicos.Columns[3].DataPropertyName = "campus";
            DGMedicos.Columns[4].DataPropertyName = "especialidad";
            DGMedicos.Columns[5].DataPropertyName = "celular";
            DGMedicos.Columns[6].DataPropertyName = "aniocarrera";
            DGMedicos.Columns[7].DataPropertyName = "estadocivil";
            DGMedicos.Columns[8].DataPropertyName = "trimestre";
            DGMedicos.Columns[10].DataPropertyName = "fechanac";
            DGMedicos.Columns[11].DataPropertyName = "email";
            DGMedicos.Columns[12].DataPropertyName = "direccion";
            DGMedicos.Columns[13].DataPropertyName = "pass";

            //Asignamos los parametros de busqueda en vacio para que cargue todos los usuarios
            damedicos.SelectCommand.Parameters.AddWithValue("@filtro", "%%");
            //Llenamos el Dataset con los datos del Table Adapter
            damedicos.Fill(ds, "usuarios");

            //Asignar la fuente de datos al DataGrid con la table adapter creada anteriormente
            DGMedicos.DataSource = ds.Tables["usuarios"];
            txtidentidad.DataBindings.Add("text", ds.Tables["usuarios"], "idusuario");
            txtnombre.DataBindings.Add("text", ds.Tables["usuarios"], "usuario");
            cmbgenero.DataBindings.Add("checked", ds.Tables["usuarios"], "genero");
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
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = DGMedicos.Rows[DGMedicos.CurrentCell.RowIndex];
            
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
            Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            DGMedicos.ReadOnly = true;
            DGMedicos.Enabled = false;
            btneditar.Text = "Guardar";
            btnagregar.Enabled = false;
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGMedicos.RowCount > 0)
            {
                dynamic strSQL = "DELETE FROM seg.usuarios WHERE idusuario = @idusuario";
                dynamic idusuario = DGMedicos.Rows[DGMedicos.CurrentRow.Index].Cells[0].Value;
                try
                {
                    using (NpgsqlConnection conexion = new NpgsqlConnection(cnx))
                    {
                        NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);
                        comando.Parameters.AddWithValue("@idusuario", idusuario);
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

        private void btneditar_Click(object sender, EventArgs e)
        {
            string strSQL = ""; ;
            txtpassword.Clear();
            txtconfirmacion.Clear();
            if (statusForm == 0)
            {
                activo(true);
                DGMedicos.ReadOnly = true;
                DGMedicos.Enabled = false;
                btnagregar.Enabled = false;
                btneditar.Text = "Guardar";
                statusForm = 2;
                txtnombre.Focus();
            }
            else
            {
                if (statusForm == 1)
                {
                    if (!string.IsNullOrEmpty(txtpassword.Text) & txtpassword.Text == txtconfirmacion.Text)
                    {
                        strSQL = "INSERT INTO seg.usuarios(idusuario, usuario, llave, passw, estado, genero, fechanac, email, celular, direccion, tiposangre) VALUES(@idusuario, @usuario, @llave, @passw, @estado, @genero, @fechanac, @email, @celular, @direccion, @tiposangre); ";
                        try
                        {
                            using (NpgsqlConnection conexion = new NpgsqlConnection(cnx))
                            {
                                NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);
                                DGMedicos.AutoGenerateColumns = false;
                                DGMedicos.Columns[0].DataPropertyName = "idmedico";
                                DGMedicos.Columns[1].DataPropertyName = "usuario";
                                DGMedicos.Columns[2].DataPropertyName = "genero";
                                DGMedicos.Columns[3].DataPropertyName = "campus";
                                DGMedicos.Columns[4].DataPropertyName = "especialidad";
                                DGMedicos.Columns[5].DataPropertyName = "celular";
                                DGMedicos.Columns[6].DataPropertyName = "aniocarrera";
                                DGMedicos.Columns[7].DataPropertyName = "estadocivil";
                                DGMedicos.Columns[8].DataPropertyName = "trimestre";
                                DGMedicos.Columns[10].DataPropertyName = "fechanac";
                                DGMedicos.Columns[11].DataPropertyName = "email";
                                DGMedicos.Columns[12].DataPropertyName = "direccion";
                                DGMedicos.Columns[13].DataPropertyName = "pass";
                                comando.Parameters.AddWithValue("@idmedico", txtidentidad.Text);
                                comando.Parameters.AddWithValue("@usuario", txtnombre.Text);
                                comando.Parameters.AddWithValue("@genero", cmbgenero.Text);
                                comando.Parameters.AddWithValue("@campus", cmbCampus.Text);
                                comando.Parameters.AddWithValue("@especialidad", cmbcarrera.Text);
                                comando.Parameters.AddWithValue("@celular", txtcelular.Text);
                                comando.Parameters.AddWithValue("@aniocarrera", cmbyear.Text);
                                comando.Parameters.AddWithValue("@estadocivil", cmbEstado.Text);
                                comando.Parameters.AddWithValue("@trimestre", cmbtrimestre.Text);
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
                                strSQL = "UPDATE seg.usuarios SET usuario = @usuario, estado = @estado, genero = @genero, fechanac = @fechanac, email = @email, celular = @celular, direccion = @direccion, tiposangre = @tiposangre WHERE idusuario = @idusuario";
                            }
                            else
                            {
                                strSQL = "UPDATE seg.usuarios SET usuario = @usuario, llave = @llave, passw = @passw, estado = @estado, genero = @genero, fechanac = @fechanac, email = @email, celular = @celular, direccion = @direccion, tiposangre = @tiposangre WHERE idusuario = @idusuario";
                            }
                            try
                            {
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
        }
    }
}
