﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace Login
{
    public partial class frmLogin : Form
    {
    
        string cnxclinica = "Server=localhost; Port= 5432; Database=clinicas; User Id=postgres; Password=unicah;";
        public frmLogin()
        {
            InitializeComponent();
        }    
              
        private void Login_Load(object sender, EventArgs e)
        {
            //cuando carga login y cuando hace logout lo vuelve a los valores iniciales 
            Resources.Propiedades.nombre_ingreso = "";
            Resources.Propiedades.categoria = 0;
       
            if (txtIDmedico.Text == "")
            {
                btn_Aceptar.Enabled = false;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtIDmedico.Text == "")
            {
                btn_Aceptar.Enabled = false;
            }
            else
                btn_Aceptar.Enabled = true;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            bool block = Resources.Propiedades.flag;

            if (block == false)
            {
                evaluar();
            }
        }

        private void evaluar()
        {
            string password = txtPassword.Text;
            string idmedi = txtIDmedico.Text;
            string strerror = "";
            password = Resources.Propiedades.SHA512(password);
            if (txtIDmedico.Text != "" && txtPassword.Text != "")
            {
                string strSQL = "SELECT pass, nombrecompleto FROM administracion.medicos WHERE idmedico = '" + idmedi + "'";
                try
                {
                    NpgsqlConnection conexion = new NpgsqlConnection(cnxclinica);
                    //definimos la variable de comando donde le asignamos el string que contiene el select y la conexion
                    NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);
                    NpgsqlDataReader reader;
                    conexion.Open();
                    reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string dbpassw = reader.GetString(0);
                        string nombre = reader.GetString(1);
                       dbpassw = Resources.Propiedades.SHA512(dbpassw);

                        if (password == dbpassw)
                        {
                            MessageBox.Show("Bienvenido '" + nombre + "'");
                            Resources.Propiedades.nombre_ingreso = nombre;
                            categoria(idmedi);
                            this.Close();
                            Resources.Propiedades.flag = true;
                            Resources.Propiedades.ID_ingreso = idmedi;
                      


                        }
                        else
                        {
                            strerror = "Password Incorrecto";
                        }
                    }
                    else
                    {
                        strerror = "No existe ningun usuario con ese nombre";
                    }

                    conexion.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(strerror + err.ToString());
                }
            }
            else
            {
                strerror = "Ingrese los datos de usuario y contraseña";
            }

            if (strerror != "")
            {
                MessageBox.Show(strerror);
            }

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtIDmedico.Text = " ";
            txtPassword.Text = "";
            txtIDmedico.Focus();
        }

        private void categoria(string ID)
        {
            string strSQL = "SELECT tipomedico FROM administracion.tipomedico WHERE idmedico = '" + ID + "'";
            try
            {
                NpgsqlConnection conexion = new NpgsqlConnection(cnxclinica);
                NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);
                NpgsqlDataReader reader;
                conexion.Open();
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    Resources.Propiedades.categoria = reader.GetInt32(0);
                }
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }


        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Login.frmContraseña frmcontra = new Login.frmContraseña();
            frmcontra.Show();
        }     


        
    }
}