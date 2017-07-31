using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicamentos_y_Suministros
{
    public partial class frmMedicamentos : Form
    {
        public frmMedicamentos()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //DateTime Marley = Convert.ToDateTime(dtpvencimiento.Value.ToShortDateString());
            tableAdapterManager._medicamentosTableAdapter.InsertQuery(txtmedicamento.Text, cantidad.Value, reorden.Value, dtpvencimiento.Text);
        }

        private void _medicamentosBindingSource1BindingNavigator1SaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._medicamentosBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSMantenimiento);

        }
    }
}
