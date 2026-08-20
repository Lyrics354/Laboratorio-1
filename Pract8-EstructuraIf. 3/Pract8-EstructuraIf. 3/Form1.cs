using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract8_EstructuraIf._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblOperacion.Text = "O";
            lblIgual.Text = "=";

            rdbSuma.CheckedChanged += RadioButtons_CheckedChanged;
            rdbResta.CheckedChanged += RadioButtons_CheckedChanged;
            rdbMultiplicacion.CheckedChanged += RadioButtons_CheckedChanged;
            rdbDivicion.CheckedChanged += RadioButtons_CheckedChanged;
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarSimbolo();
            Calcular();
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void ActualizarSimbolo()
        {
            if (rdbSuma.Checked)
            {
                lblOperacion.Text = "+";
            }
            else if (rdbResta.Checked)
            {
                lblOperacion.Text = "-";
            }
            else if (rdbMultiplicacion.Checked)
            {
                lblOperacion.Text = "*";
            }
            else if (rdbDivicion.Checked)
            {
                lblOperacion.Text = "/";
            }
        }

        private void Calcular()
        {
            if (string.IsNullOrWhiteSpace(txtPrimerDig.Text) || string.IsNullOrWhiteSpace(txtSegundoDig.Text))
            {
                txtSolucion.Text = "";
                return;
            }

            decimal primerNumero;
            decimal segundoNumero;

            if (!decimal.TryParse(txtPrimerDig.Text, out primerNumero) || !decimal.TryParse(txtSegundoDig.Text, out segundoNumero))
            {
                txtSolucion.Text = "";
                return;
            }

            if (!rdbSuma.Checked && !rdbResta.Checked && !rdbMultiplicacion.Checked && !rdbDivicion.Checked)
            {
                return;
            }

            decimal resultado = 0;

            if (rdbSuma.Checked)
            {
                resultado = primerNumero + segundoNumero;
            }
            else if (rdbResta.Checked)
            {
                resultado = primerNumero - segundoNumero;
            }
            else if (rdbMultiplicacion.Checked)
            {
                resultado = primerNumero * segundoNumero;
            }
            else if (rdbDivicion.Checked)
            {
                if (segundoNumero == 0)
                {
                    MessageBox.Show("No se puede dividir entre cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSolucion.Text = "";
                    return;
                }
                resultado = primerNumero / segundoNumero;
            }

            txtSolucion.Text = resultado.ToString();
        }
    }
}
 

