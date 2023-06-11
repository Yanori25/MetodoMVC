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
    public partial class Ordenador : Form
    {

        
        public Ordenador()
        {
            InitializeComponent();
        }

        private void Ordenador_Load(object sender, EventArgs e)
        {
          
        }

        private void btnascendente_Click(object sender, EventArgs e)
        {

            int a =   Convert.ToInt32(txtvalor_A.Text);
            int b = Convert.ToInt32(txtvalor_B.Text);
            int c = Convert.ToInt32(txtvalor_C.Text);
            int d = Convert.ToInt32(txtvalor_D.Text);


            OrdenArray orden = new OrdenArray();
            MessageBox.Show( "orden ascendente: "+ orden.OrdenaArray(true, a, b, c, d).ToString());

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtvalor_A_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDESCENDENTE_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtvalor_A.Text);
            int b = Convert.ToInt32(txtvalor_B.Text);
            int c = Convert.ToInt32(txtvalor_C.Text);
            int d = Convert.ToInt32(txtvalor_D.Text);


            OrdenArray orden = new OrdenArray();
            MessageBox.Show("orden descendente: " + orden.OrdenaArray(false, a, b, c, d).ToString());


        }

        private void txtvalor_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtvalor_B_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtvalor_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtvalor_D_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
