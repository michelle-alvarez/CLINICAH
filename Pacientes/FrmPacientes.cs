using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Npgsql;
using NpgsqlTypes;


namespace Pacientes
{
    public partial class FrmPacientes : Form
    {
        public FrmPacientes()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            carreras();
            botones_iniciales();
        }

        public void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            busqueda();
        }

        //Cadena de Conexion.
        string parametros = "User Id=postgres;Password=hola;Host=localhost;Database=clinica";

        private void busqueda()
        {
            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();
                //MessageBox.Show("-BIENVENIDO-");
                string x;
                if(txtbusqueda.Text == "")
                {
                    x = "XXXXXXXXXX";
                }
                else
                {
                    x = txtbusqueda.Text.ToString();
                }
                string strSQL = "SELECT nombre,idpaciente FROM pacientes.paciente WHERE nombre LIKE '" + x + "%' OR nombre LIKE '% " + x + "%' OR idpaciente = '"+x+"' ";
                NpgsqlCommand Comando = new NpgsqlCommand(strSQL, Cnx);
                NpgsqlDataReader Reg;
                Reg = Comando.ExecuteReader();
                //MessageBox.Show(strSQL);
                datagridx.Rows.Clear();
                while (Reg.Read())
                {
                    string nombre2 = Reg.GetString(0);
                    string identidad = Reg["idpaciente"].ToString();
                    datagridx.Rows.Add(identidad,nombre2);
                }
                //MessageBox.Show(strSQL);
                Cnx.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            busqueda();
        }

        private void datagridx_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            busqueda_botones();
            string codigo = "";
            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();
                //MessageBox.Show("-BIENVENIDO-");
               // DataGridViewRow row = this.datagridx.Rows[e.RowIndex];
                string persona = datagridx.SelectedCells[0].Value.ToString();
                string strSQL = "SELECT idpaciente, carreras.nombre as carrera, tiposangre, telefono, email, peso, altura, etnia, genero, paciente.nombre as persona, fechanac, categorias.nombre as tipo,telefonoemer,observacion FROM pacientes.paciente INNER JOIN administracion.carreras ON paciente.idcarrera = carreras.idcarrera INNER JOIN administracion.categorias ON paciente.idtipo = categorias.idtipo WHERE paciente.nombre ='" + datagridx.SelectedCells[0].Value.ToString() +"' OR idpaciente = '"+ datagridx.SelectedCells[0].Value.ToString() + "'";
                NpgsqlCommand Comando = new NpgsqlCommand(strSQL, Cnx);
                NpgsqlDataReader Reg;
                //MessageBox.Show(strSQL);
                datagrida.Rows.Clear();
                datagridp.Rows.Clear();
                Reg = Comando.ExecuteReader();
                while (Reg.Read())
                {   
                    codigo = Reg["idpaciente"].ToString();
                    txtcodigo.Text = Reg["idpaciente"].ToString();
                    txtnombre.Text = Reg["persona"].ToString();
                    combocarrera.Text = Reg["carrera"].ToString();
                    dtfechanac.Text = Reg["fechanac"].ToString();
                    combosangre.Text = Reg["tiposangre"].ToString();
                    txtpeso.Text = Reg["peso"].ToString();
                    txtaltura.Text = Reg["altura"].ToString();
                    txttelefono.Text = Reg["telefono"].ToString();
                    txtemail.Text = Reg["email"].ToString();
                    comboetnia.Text = Reg["etnia"].ToString();
                    combotipo.Text = Reg["tipo"].ToString();
                    txtemergencia.Text = Reg["telefonoemer"].ToString();
                    rtxtobservacion.Text = Reg["observacion"].ToString();
                    
                    if(Reg["genero"].ToString() == "M")
                    {
                        rdbmasculino.Checked = true;
                    }
                    else
                    {
                        rdbfemenino.Checked = true;
                    }
                }
                Cnx.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            combocarrera.Enabled = false;
            alergias(codigo);
            padecimientos(codigo);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void activarbotones()
        {
            //textboxs
            txtcodigo.ReadOnly = false;
            txtnombre.ReadOnly = false;
            txtemail.ReadOnly = false;
            txtpeso.ReadOnly = false;
            txtaltura.ReadOnly = false;
            txttelefono.ReadOnly = false;
            txtemergencia.ReadOnly = false;
            rtxtobservacion.ReadOnly = false;
            //combo
            combotipo.Enabled = true;
            combocarrera.Enabled = true;
            comboap.Enabled = true;
            comboetnia.Enabled = true;
            combosangre.Enabled = true;
            //date
            dtfechanac.Enabled = true;
            //botones
            btnagregar.Enabled = true;
            btneliminar.Enabled = true;
            //radiob
            rdbfemenino.Enabled = true;
            rdbmasculino.Enabled = true;
            rbalergia.Enabled = true;
            rbpadecimiento.Enabled = true;
            cargarcarreras();
            combosangre.SelectedIndex = 0;
            comboetnia.SelectedIndex = 0;
            combotipo.SelectedIndex = 0;
            rbalergia.Checked = true;
            rdbmasculino.Checked = true;
            datagrida.Rows.Clear();
            datagridp.Rows.Clear();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            modo_cancelar();
            botones_iniciales();
        }

        private void rbalergia_CheckedChanged(object sender, EventArgs e)
        {
            comboap.Items.Clear();
            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();
                string items = "SELECT nombre FROM administracion.lista_alergias";
                NpgsqlCommand cmditems = new NpgsqlCommand(items, Cnx);
                NpgsqlDataReader Reg;
                Reg = cmditems.ExecuteReader();
                while (Reg.Read())
                {
                    comboap.Items.Add(Reg["nombre"].ToString());
                }
                Cnx.Close();
                comboap.SelectedIndex = 0;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void rbpadecimiento_CheckedChanged(object sender, EventArgs e)
        {
            comboap.Items.Clear();
            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();
                string items = "SELECT nombre FROM administracion.lista_padecimientos";
                NpgsqlCommand cmditems = new NpgsqlCommand(items, Cnx);
                NpgsqlDataReader Reg;
                Reg = cmditems.ExecuteReader();
                while (Reg.Read())
                {
                    comboap.Items.Add(Reg["nombre"].ToString());
                }
                Cnx.Close();
                comboap.SelectedIndex = 0;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
    }

        private void cargarcarreras()
        {
            combocarrera.Items.Clear();
            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();
                string items = "SELECT nombre FROM administracion.carreras WHERE nombre != 'Ninguna'";
                NpgsqlCommand cmditems = new NpgsqlCommand(items, Cnx);
                NpgsqlDataReader Reg;
                Reg = cmditems.ExecuteReader();
                while (Reg.Read())
                {
                    combocarrera.Items.Add(Reg["nombre"].ToString());
                }
                Cnx.Close();
                combocarrera.SelectedIndex = 0;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void combotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combotipo.Text == "Visitante")
            {
                combocarrera.Text = "Ninguna";
                combocarrera.Enabled = false;
            }
            else
            {
                combocarrera.Enabled = true;
                //combocarrera.SelectedIndex = 0;
                combocarrera.Text = combocarrera.Items[0].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nuevo();
            modo_nuevo();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            DialogResult RS = MessageBox.Show("¿Esta seguro que desea registrar al nuevo paciente?", "Registro" , MessageBoxButtons.YesNo);
            if(RS == DialogResult.Yes)
            {
                registro_nuevo();
                modo_cancelar();
                botones_iniciales();
            }
           
        }

        private void registro_nuevo()
        {
            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();
                string SELECT = "VALUES('" + txtcodigo.Text.ToString() + "','" + idcarrera() + "','" + combosangre.Text + "'," + txttelefono.Text + ",'" + txtemail.Text + "', "+txtpeso.Text+"  ," + txtaltura.Text + ",'" + comboetnia.Text + "','" + genero + "','" + txtnombre.Text + "','" + dtfechanac.Text + "','" + idtipo() + "', "+txtemergencia.Text+",'"+rtxtobservacion.Text+"')";
                string strSQL = "INSERT INTO pacientes.paciente(idpaciente, idcarrera, tiposangre, telefono, email, peso, altura, etnia, genero, nombre, fechanac, idtipo, telefonoemer, observacion) "+ SELECT +"";
                NpgsqlCommand cmdregistro = new NpgsqlCommand(strSQL, Cnx);
                cmdregistro.ExecuteNonQuery();
                for (int x = 0; x < datagrida.Rows.Count; x++)
                {
                    string sel2 = "SELECT '" + txtcodigo.Text + "', idalergia FROM administracion.lista_alergias WHERE nombre = '" + datagrida.Rows[x].Cells[0].Value.ToString() + "' ";
                    string insert2 = "INSERT INTO pacientes.alergias(idpaciente, idalergia)  " + sel2 + " ";
                    NpgsqlCommand cmdpad2 = new NpgsqlCommand(insert2, Cnx);
                    cmdpad2.ExecuteNonQuery();
                }
                for (int x = 0;x<datagridp.Rows.Count;x++)
                {
                    string sel = "SELECT '" + txtcodigo.Text + "' , idpadecimiento FROM administracion.lista_padecimientos WHERE nombre = '" + datagridp.Rows[x].Cells[0].Value.ToString()+"'";
                    string insert = "INSERT INTO pacientes.padecimientos(idpaciente, idpadecimiento)  " + sel+" ";
                    NpgsqlCommand cmdpad3 = new NpgsqlCommand(insert, Cnx);
                    cmdpad3.ExecuteNonQuery();
                }
                Cnx.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public string idcarrera()
        {
            string ab = "";
            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();
                
                string items = "SELECT idcarrera FROM administracion.carreras WHERE nombre = '" + combocarrera.Text+"'";
                NpgsqlCommand cmditems = new NpgsqlCommand(items, Cnx);
                NpgsqlDataReader Reg;
                Reg = cmditems.ExecuteReader();
                while (Reg.Read())
                {
                    ab = Reg["idcarrera"].ToString();
                }
                Cnx.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            return ab;
        }

        public string idtipo()
        {
            string cd = "";
            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();

                string items = "SELECT idtipo FROM administracion.categorias WHERE nombre = '" + combotipo.Text + "'";
                NpgsqlCommand cmditems = new NpgsqlCommand(items, Cnx);
                NpgsqlDataReader Reg;
                Reg = cmditems.ExecuteReader();
                while (Reg.Read())
                {
                    cd = Reg["idtipo"].ToString();
                }
                Cnx.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            return cd;
        }

        string genero = "";

        public void rdbmasculino_CheckedChanged(object sender, EventArgs e)
        {
            genero = "M";
        }

        public void rdbfemenino_CheckedChanged(object sender, EventArgs e)
        {
            genero = "F";
        }

        string nombre_edit = "";
        private void button2_Click(object sender, EventArgs e)
        {
            if(txtnombre.ReadOnly == true && txtnombre.Text != "")
            {
                //txtbusqueda.Text = "";
                edicion();
                modo_edicion();
                nombre_edit = txtnombre.Text;
            }
        }

        private void FrmPacientes_Click(object sender, EventArgs e)
        {

        }

        private void modo_edicion()
        {
            //textboxs
            txtcodigo.ReadOnly = false;
            txtnombre.ReadOnly = false;
            txtemail.ReadOnly = false;
            txtpeso.ReadOnly = false;
            txtaltura.ReadOnly = false;
            txttelefono.ReadOnly = false;
            txtemergencia.ReadOnly = false;
            rtxtobservacion.ReadOnly = false;
            //combo
            combotipo.Enabled = true;
            if (combotipo.Text != "Visitante")
            {
                combocarrera.Enabled = true;
            }
            comboap.Enabled = true;
            comboetnia.Enabled = true;
            combosangre.Enabled = true;
            //date
            dtfechanac.Enabled = true;
            //botones
            btnagregar.Enabled = true;
            btneliminar.Enabled = true;
            //radiob
            rdbfemenino.Enabled = true;
            rdbmasculino.Enabled = true;
            rbalergia.Enabled = true;
            rbpadecimiento.Enabled = true;
            txtbusqueda.ReadOnly = true;
            rbalergia.Checked = true;
            txtcodigo.ReadOnly = true; 
        }

        private void modo_cancelar()
        {
            //textboxs
            txtcodigo.Text = "";
            txtcodigo.ReadOnly = true;
            txtnombre.Text = "";
            txtnombre.ReadOnly = true;
            txtemail.Text = "";
            txtemail.ReadOnly = true;
            txtpeso.Text = "";
            txtpeso.ReadOnly = true;
            txtaltura.Text = "";
            txtaltura.ReadOnly = true;
            txttelefono.Text = "";
            txttelefono.ReadOnly = true;
            txtemergencia.Text = "";
            txtemergencia.ReadOnly = true;
            rtxtobservacion.ReadOnly = true;
            rtxtobservacion.Text = "";
            //combo
            combotipo.Text = "";
            combotipo.Enabled = false;
            combocarrera.Text = "";
            combocarrera.Enabled = false;
            comboap.Text = "";
            comboap.Enabled = false;
            comboetnia.Text = "";
            comboetnia.Enabled = false;
            combosangre.Text = "";
            combosangre.Enabled = false;
            //date
            dtfechanac.Text = "";
            dtfechanac.Enabled = false;
            //botones
            btnagregar.Enabled = false;
            btneliminar.Enabled = false;
            //radiob
            rdbfemenino.Checked = false;
            rdbmasculino.Checked = false;
            rdbfemenino.Enabled = false;
            rdbmasculino.Enabled = false;
            rbalergia.Checked = false;
            rbpadecimiento.Checked = false;
            rbalergia.Enabled = false;
            rbpadecimiento.Enabled = false;
            datagrida.Rows.Clear();
            datagridp.Rows.Clear();
            datagridx.Rows.Clear();
            txtbusqueda.ReadOnly = false;
            txtbusqueda.Text = "";
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if(comboap.Text != "")
            {
                if(rbalergia.Checked == true)
                {
                    bool flag = false;
                    for (int x = 0; x < datagrida.Rows.Count; x++)
                    {
                        if (datagrida.Rows[x].Cells[0].Value.ToString() == comboap.Text)
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        datagrida.Rows.Add(comboap.Text);
                    }
                }
                else
                {
                    if(rbpadecimiento.Checked == true)
                    {
                        bool flag = false;
                        for (int x = 0; x < datagridp.Rows.Count; x++)
                        {
                            if (datagridp.Rows[x].Cells[0].Value.ToString() == comboap.Text)
                            {
                                flag = true;
                            }
                        }
                        if (flag == false)
                        {
                            datagridp.Rows.Add(comboap.Text);
                        }
                    }
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if(x == 1)
            {
                if(datagrida.Rows.Count > 0)
                {
                    //int f = 0;
                    for(int z = 0;z<datagrida.Rows.Count;z++)
                    {
                        if (datagrida.Rows[z].Cells[0].Value.ToString() == ale_pad)
                        {
                            datagrida.Rows.RemoveAt(z);
                        }
                    }

                }

            }
            else
            {
                if(x == 2)
                {
                    if (datagridp.Rows.Count > 0)
                    {
                        for (int z = 0; z < datagridp.Rows.Count; z++)
                        {
                            if (datagridp.Rows[z].Cells[0].Value.ToString() == ale_pad)
                            {
                                datagridp.Rows.RemoveAt(z);
                            }
                        }

                    }
                }
            }
        }

        string ale_pad = ""; //0 -> Estado Inicial, 1 -> Alergia seleccionado, 2 -> Padecimiento seleccionado.
        int x = 0;
        private void datagrida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ale_pad = datagrida.SelectedCells[0].Value.ToString();
            x = 1;
        }

        private void datagridp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ale_pad = datagridp.SelectedCells[0].Value.ToString();
            x = 2;
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void carreras()
        {
            combocarrera.Items.Clear();
            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();
                string items = "SELECT nombre FROM administracion.carreras";
                NpgsqlCommand cmditems = new NpgsqlCommand(items, Cnx);
                NpgsqlDataReader Reg;
                Reg = cmditems.ExecuteReader();
                while (Reg.Read())
                {
                    combocarrera.Items.Add(Reg["nombre"].ToString());
                    combocarrera.Text = "";
                }
                Cnx.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void modo_nuevo()
        {
            //textboxs
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtemail.Text = "";
            txtpeso.Text = "";
            txtaltura.Text = "";
            txttelefono.Text = "";
            rtxtobservacion.Text = "";
            //combo
            combotipo.Text = "";
            combocarrera.Text = "";
            comboap.Text = "";
            comboetnia.Text = "";
            combosangre.Text = "";
            //date
            dtfechanac.Text = "";
            //botones
            btnagregar.Enabled = true;
            btneliminar.Enabled = true;
            //radiob
            rdbfemenino.Checked = false;
            rdbmasculino.Checked = false;
            rbalergia.Checked = false;
            rbpadecimiento.Checked = false;
            txtbusqueda.ReadOnly = true;
            datagrida.Rows.Clear();
            datagridp.Rows.Clear();
            txtbusqueda.ReadOnly = true;
            activarbotones();
            txtbusqueda.Text = "";
            txtemergencia.Text = "";
            combotipo.Text = combotipo.Items[0].ToString();
            comboap.Text = comboap.Items[0].ToString();
            comboetnia.Text = comboetnia.Items[0].ToString();
            combocarrera.Text = combocarrera.Items[0].ToString();
            combosangre.Text = combosangre.Items[0].ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            modo_cancelar();
        }

        private void guardar_cambios()
        {
            NpgsqlConnection Cnx = new NpgsqlConnection();
            string set = "";
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();
                set = "SET idpaciente='"+txtcodigo.Text+"', idcarrera='"+idcarrera()+"', tiposangre='"+combosangre.Text+"', telefono="+txttelefono.Text+", email='"+txtemail.Text+"', peso="+txtpeso.Text+", altura="+txtaltura.Text+", etnia='"+comboetnia.Text+"', genero='"+genero+"', nombre='"+txtnombre.Text+"', fechanac='"+dtfechanac.Text+"', idtipo='"+idtipo()+"', observacion = '"+rtxtobservacion.Text+"', telefonoemer = "+txtemergencia.Text+" WHERE nombre = '"+nombre_edit+"'; ";
                string strSQL = "UPDATE pacientes.paciente "+set+"";
                //MessageBox.Show(strSQL);
                NpgsqlCommand cmditems = new NpgsqlCommand(strSQL, Cnx);
                cmditems.ExecuteNonQuery();
                
                actualizar_alergias_padecimientos();
                Cnx.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(set);
                MessageBox.Show(Ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult RS = MessageBox.Show("¿Esta seguro que desea confirmar los cambios?", "Editar", MessageBoxButtons.YesNo);
            if (RS == DialogResult.Yes)
            {
                guardar_cambios();
                modo_cancelar();
                botones_iniciales();
            }
        }

        private void actualizar_alergias_padecimientos()
        {
            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();
                string strSQL = "DELETE FROM pacientes.alergias WHERE idpaciente = '" + txtcodigo.Text + "'";
                NpgsqlCommand Eliminar = new NpgsqlCommand(strSQL, Cnx);
                Eliminar.ExecuteNonQuery();
                string strSQL2 = "DELETE FROM pacientes.padecimientos WHERE idpaciente = '" + txtcodigo.Text + "'";
                NpgsqlCommand Eliminar2 = new NpgsqlCommand(strSQL2, Cnx);
                Eliminar2.ExecuteNonQuery();
                for (int x = 0; x < datagrida.Rows.Count; x++)
                {
                    string sel2 = "SELECT '" + txtcodigo.Text + "', idalergia FROM administracion.lista_alergias WHERE nombre = '" + datagrida.Rows[x].Cells[0].Value.ToString() + "' ";
                    string insert2 = "INSERT INTO pacientes.alergias(idpaciente, idalergia)  " + sel2 + " ";
                    NpgsqlCommand cmdpad2 = new NpgsqlCommand(insert2, Cnx);
                    cmdpad2.ExecuteNonQuery();
                }
                for (int x = 0; x < datagridp.Rows.Count; x++)
                {
                    string sel = "SELECT '" + txtcodigo.Text + "' , idpadecimiento FROM administracion.lista_padecimientos WHERE nombre = '" + datagridp.Rows[x].Cells[0].Value.ToString() + "'";
                    string insert = "INSERT INTO pacientes.padecimientos(idpaciente, idpadecimiento)  " + sel + " ";
                    NpgsqlCommand cmdpad3 = new NpgsqlCommand(insert, Cnx);
                    cmdpad3.ExecuteNonQuery();
                }

            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();
                //Alergias
                string strSQL2 = "DELETE FROM pacientes.alergias WHERE idpaciente = '" + txtcodigo.Text + "'";
                NpgsqlCommand cmditems2 = new NpgsqlCommand(strSQL2, Cnx);
                cmditems2.ExecuteNonQuery();
                //Padecimientos
                string strSQL3 = "DELETE FROM pacientes.padecimientos WHERE idpaciente = '" + txtcodigo.Text + "'";
                NpgsqlCommand cmditems3 = new NpgsqlCommand(strSQL3, Cnx);
                cmditems3.ExecuteNonQuery();
                //Pacientes
                string strSQL = "DELETE FROM pacientes.paciente WHERE idpaciente = '" + txtcodigo.Text + "'";
                NpgsqlCommand cmditems = new NpgsqlCommand(strSQL, Cnx);
                cmditems.ExecuteNonQuery();
                Cnx.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            modo_cancelar();
            botones_iniciales();
        }

        private void botones_iniciales()
        {
            btn_nuevo.Visible = true;
            btn_salir.Visible = true;
            btn_registrar.Visible = false;
            btn_cancelar2.Visible = false;
            bteliminar.Visible = false;
            btn_editar.Visible = false;
            btn_cambios.Visible = false;
        }

        private void nuevo()
        {
            btn_nuevo.Visible = false;
            btn_salir.Visible = false;
            btn_registrar.Visible = true;
            btn_cancelar2.Visible = true;
            bteliminar.Visible = false;
            btn_editar.Visible = false;
            btn_cambios.Visible = false;
        }

        private void busqueda_botones()
        {
            btn_nuevo.Visible = true;
            btn_salir.Visible = false;
            btn_registrar.Visible = false;
            btn_cancelar2.Visible = true;
            bteliminar.Visible = false;
            btn_editar.Visible = true;
            btn_cambios.Visible = false;
        }

        private void edicion()
        {
            btn_nuevo.Visible = false;
            btn_salir.Visible = false;
            btn_registrar.Visible = false;
            btn_cancelar2.Visible = true;
            bteliminar.Visible = true;
            btn_editar.Visible = false;
            btn_cambios.Visible = true;
        }

        private void combotipo_Leave(object sender, EventArgs e)
        {
            bool correcto = false;
            for(int x=0;x<combotipo.Items.Count;x++)
            {
                if(combotipo.Text == combotipo.Items[x].ToString())
                {
                    correcto = true;
                }
            }
            if(correcto == false)
            {
                MessageBox.Show("La opcion elegida no es valida, seleccione una de las disponibles en la lista","Error");
                combotipo.Select();
            }
        }

        private void combosangre_Leave(object sender, EventArgs e)
        {
            bool correcto = false;
            for (int x = 0; x < combosangre.Items.Count; x++)
            {
                if (combosangre.Text == combosangre.Items[x].ToString())
                {
                    correcto = true;
                }
            }
            if (correcto == false)
            {
                MessageBox.Show("La opcion elegida no es valida, seleccione una de las disponibles en la lista","Error");
                combosangre.Select();
            }
        }

        private void combocarrera_Leave(object sender, EventArgs e)
        {
            bool correcto = false;
            for (int x = 0; x < combocarrera.Items.Count; x++)
            {
                if (combocarrera.Text == combocarrera.Items[x].ToString())
                {
                    correcto = true;
                }
            }
            if (correcto == false)
            {
                MessageBox.Show("La opcion elegida no es valida, seleccione una de las disponibles en la lista", "Error");
                combocarrera.Select();
            }
        }

        private void comboap_Leave(object sender, EventArgs e)
        {
            bool correcto = false;
            for (int x = 0; x < comboap.Items.Count; x++)
            {
                if (comboap.Text == comboap.Items[x].ToString())
                {
                    correcto = true;
                }
            }
            if (correcto == false)
            {
                MessageBox.Show("La opcion elegida no es valida, seleccione una de las disponibles en la lista", "Error");
                comboap.Select();
            }
        }

        private void comboetnia_Leave(object sender, EventArgs e)
        {
            bool correcto = false;
            for (int x = 0; x < comboetnia.Items.Count; x++)
            {
                if (comboetnia.Text == comboetnia.Items[x].ToString())
                {
                    correcto = true;
                }
            }
            if (correcto == false)
            {
                MessageBox.Show("La opcion elegida no es valida, seleccione una de las disponibles en la lista", "Error");
                comboetnia.Select();
            }
        }

        private void alergias(string codigo)
        {
            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();                                                                                                                                       //Aqui
                string strSQL2 = "SELECT lista_alergias.nombre as name FROM administracion.lista_alergias INNER JOIN pacientes.alergias ON alergias.idalergia = lista_alergias.idalergia WHERE alergias.idpaciente = '" + codigo + "' AND alergias.idalergia = lista_alergias.idalergia GROUP BY lista_alergias.nombre";
                NpgsqlDataReader Reg2;
                NpgsqlCommand Comando2 = new NpgsqlCommand(strSQL2, Cnx);
                Reg2 = Comando2.ExecuteReader();
                while (Reg2.Read())
                {
                    string tmp = Reg2["name"].ToString();
                    datagrida.Rows.Add(tmp);
                }
                Cnx.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void padecimientos(string codigo)
        {
            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();
                string strSQL3 = "SELECT lista_padecimientos.nombre as name FROM administracion.lista_padecimientos INNER JOIN pacientes.padecimientos ON lista_padecimientos.idpadecimiento = padecimientos.idpadecimiento WHERE padecimientos.idpaciente = '" + codigo + "' AND padecimientos.idpadecimiento = lista_padecimientos.idpadecimiento";
                NpgsqlDataReader Reg3;
                NpgsqlCommand Comando3 = new NpgsqlCommand(strSQL3, Cnx);
                Reg3 = Comando3.ExecuteReader();
                while (Reg3.Read())
                {
                    string tmp = Reg3["name"].ToString();
                    datagridp.Rows.Add(tmp);
                }
                Cnx.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

    }
}
