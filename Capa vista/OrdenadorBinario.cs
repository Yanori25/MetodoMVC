using Capas_controladora_y_vista.Capa_Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capas_controladora_y_vista.Capa_vista
{
    public partial class OrdenadorBinario : Form
    {
        public OrdenadorBinario()
        {
            InitializeComponent();
        }

        private void OrdenadorBinario_Load(object sender, EventArgs e)
        {

        }

        private void txtconvertit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconvertit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(txtconvertit.Text);
            ConvertirBinario conver = new ConvertirBinario( );
            //conver.conversionbinario(valor);
            MessageBox.Show(conver.conversionbinario(valor));



        }
    }
}
