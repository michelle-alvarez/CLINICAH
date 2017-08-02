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
    public partial class frmSuministros : Form
    {
        string cnx;
        DataSet ds;
        public int statusForm = 0; //0 = Consultando; 1=Agregando; 2=Editando
        string sqlMedicamentos = "SELECT * FROM administracion.suministros WHERE idmedicamentos LIKE @filtro OR nombre LIKE @filtro ORDER BY nombre";
        NpgsqlDataAdapter damedicamentos;
        public frmSuministros(string cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //tableAdapterManager.suministrosTableAdapter.InsertQuery(txtSuministro.Text, cantidad.Value, reorden.Value, dtpVencimiento.Value);
        }

    }
}
