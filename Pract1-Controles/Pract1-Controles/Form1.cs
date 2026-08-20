//Pract1-Controles Programado por: Wilson Wu 2-756-299//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract1_Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrará la ventana");

            MessageBox.Show("Cerrando");

            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtDia.Text == "" || txtMes.Text == "" || txtAño.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            lblFecha.Text = "La fecha es: " + txtDia.Text + " / " +
                            txtMes.Text + " / " +
                            txtAño.Text;
        }
    }
    
}
