using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Honesto_Carlos
{
    public partial class E4 : Form
    {
        int numAutos = 0;
        double totalIncen = 0;
        int cont = 1;
        public E4()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxAutos.Text != "")
            {
                numAutos = Convert.ToInt32(tbxAutos.Text);
                tbxComisiones.Text = (numAutos * 150).ToString();

                if (numAutos <= 0)
                {
                    tbxIncentivo.Text = "0";
                    tbxResultado.Text = (Convert.ToDouble(tbxSMensual.Text) + Convert.ToDouble(tbxComisiones.Text) + Convert.ToDouble(tbxIncentivo.Text)).ToString();
                    panel1.Enabled = false;
                    tbxResultado.Focus();
                }
                else
                {
                    panel2.Visible = true;
                    panel1.Enabled = false;
                    label3.Text = "Auto 1 de " + numAutos;
                    tbxValor.Focus();
                }
            }
        }
        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            double incen = (Convert.ToDouble(tbxValor.Text)) * .05;
            totalIncen += incen;
            if (cont == numAutos)
            {
                tbxIncentivo.Text = totalIncen.ToString();
                panel2.Enabled = false;
                tbxResultado.Text = (Convert.ToDouble(tbxSMensual.Text) + Convert.ToDouble(tbxComisiones.Text) + Convert.ToDouble(tbxIncentivo.Text)).ToString();
                tbxResultado.Focus();
            }
            else
            {
                cont += 1;
                label3.Text = "Auto " + cont + " de " + numAutos;
                tbxValor.Clear();
                tbxValor.Focus();
            }
        }
        private void numAutos_ValueChanged(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel2.Visible = false;
            tbxAutos.Clear();
            tbxValor.Clear();
            tbxComisiones.Clear();
            tbxIncentivo.Clear();
            tbxResultado.Clear();
            tbxAutos.Focus();
        }
    }
}
