using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract2_Descuentos___Programado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal venta;
            decimal porcentaje;
            decimal descuento;
            decimal ventaFinal;

            if (string.IsNullOrWhiteSpace(txtValorVenta.Text))
            {
                MessageBox.Show("Debe ingresar el valor de la venta.");
                return;
            }

            if (!decimal.TryParse(txtValorVenta.Text, out venta))
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
                return;
            }

            if (venta >= 500)
            {
                porcentaje = 30;
            }
            else if (venta > 300 && venta <= 499)
            {
                porcentaje = 20;
            }
            else if (venta > 100 && venta <= 299)
            {
                porcentaje = 10;
            }
            else
            {
                porcentaje = 0;
            }

            descuento = venta * porcentaje / 100;

            ventaFinal = venta - descuento;


            MessageBox.Show(
                  "Valor de la venta: $" + venta.ToString("0.00") +
                  "\nPorcentaje de descuento: " + porcentaje + "%" +
                  "\nDescuento aplicado: $" + descuento.ToString("0.00") +
                  "\nVenta final: $" + ventaFinal.ToString("0.00"),
                  "Resultado",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValorVenta.Text = "";
            txtDescuentoDolar.Text = "";
            txtDescuentoPorcentual.Text = "";
            txtVentaFinal.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrará la ventana");
            this.Close();
    }
    }
}
