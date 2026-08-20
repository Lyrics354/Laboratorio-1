namespace Pract2_Descuentos___Programado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValorVenta = new System.Windows.Forms.Label();
            this.lblDescuentoDolar = new System.Windows.Forms.Label();
            this.lblDescuentoPorcentual = new System.Windows.Forms.Label();
            this.lblVentaFinal = new System.Windows.Forms.Label();
            this.txtValorVenta = new System.Windows.Forms.TextBox();
            this.txtDescuentoDolar = new System.Windows.Forms.TextBox();
            this.txtDescuentoPorcentual = new System.Windows.Forms.TextBox();
            this.txtVentaFinal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorVenta
            // 
            this.lblValorVenta.AutoSize = true;
            this.lblValorVenta.Location = new System.Drawing.Point(96, 84);
            this.lblValorVenta.Name = "lblValorVenta";
            this.lblValorVenta.Size = new System.Drawing.Size(80, 16);
            this.lblValorVenta.TabIndex = 0;
            this.lblValorVenta.Text = "Valor Venta:";
            // 
            // lblDescuentoDolar
            // 
            this.lblDescuentoDolar.AutoSize = true;
            this.lblDescuentoDolar.Location = new System.Drawing.Point(96, 158);
            this.lblDescuentoDolar.Name = "lblDescuentoDolar";
            this.lblDescuentoDolar.Size = new System.Drawing.Size(119, 16);
            this.lblDescuentoDolar.TabIndex = 1;
            this.lblDescuentoDolar.Text = "Descuento (Dolar):";
            // 
            // lblDescuentoPorcentual
            // 
            this.lblDescuentoPorcentual.AutoSize = true;
            this.lblDescuentoPorcentual.Location = new System.Drawing.Point(96, 230);
            this.lblDescuentoPorcentual.Name = "lblDescuentoPorcentual";
            this.lblDescuentoPorcentual.Size = new System.Drawing.Size(153, 16);
            this.lblDescuentoPorcentual.TabIndex = 2;
            this.lblDescuentoPorcentual.Text = "Descuento (Porcentual): ";
            // 
            // lblVentaFinal
            // 
            this.lblVentaFinal.AutoSize = true;
            this.lblVentaFinal.Location = new System.Drawing.Point(96, 313);
            this.lblVentaFinal.Name = "lblVentaFinal";
            this.lblVentaFinal.Size = new System.Drawing.Size(77, 16);
            this.lblVentaFinal.TabIndex = 3;
            this.lblVentaFinal.Text = "Venta Final:";
            // 
            // txtValorVenta
            // 
            this.txtValorVenta.Location = new System.Drawing.Point(280, 78);
            this.txtValorVenta.Name = "txtValorVenta";
            this.txtValorVenta.Size = new System.Drawing.Size(100, 22);
            this.txtValorVenta.TabIndex = 4;
            // 
            // txtDescuentoDolar
            // 
            this.txtDescuentoDolar.Location = new System.Drawing.Point(280, 152);
            this.txtDescuentoDolar.Name = "txtDescuentoDolar";
            this.txtDescuentoDolar.Size = new System.Drawing.Size(100, 22);
            this.txtDescuentoDolar.TabIndex = 5;
            // 
            // txtDescuentoPorcentual
            // 
            this.txtDescuentoPorcentual.Location = new System.Drawing.Point(280, 230);
            this.txtDescuentoPorcentual.Name = "txtDescuentoPorcentual";
            this.txtDescuentoPorcentual.Size = new System.Drawing.Size(100, 22);
            this.txtDescuentoPorcentual.TabIndex = 6;
            // 
            // txtVentaFinal
            // 
            this.txtVentaFinal.Location = new System.Drawing.Point(280, 313);
            this.txtVentaFinal.Name = "txtVentaFinal";
            this.txtVentaFinal.Size = new System.Drawing.Size(100, 22);
            this.txtVentaFinal.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(520, 84);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(520, 193);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(520, 306);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtVentaFinal);
            this.Controls.Add(this.txtDescuentoPorcentual);
            this.Controls.Add(this.txtDescuentoDolar);
            this.Controls.Add(this.txtValorVenta);
            this.Controls.Add(this.lblVentaFinal);
            this.Controls.Add(this.lblDescuentoPorcentual);
            this.Controls.Add(this.lblDescuentoDolar);
            this.Controls.Add(this.lblValorVenta);
            this.Name = "Form1";
            this.Text = "Descuentos – Programado por: Wilson Wu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorVenta;
        private System.Windows.Forms.Label lblDescuentoDolar;
        private System.Windows.Forms.Label lblDescuentoPorcentual;
        private System.Windows.Forms.Label lblVentaFinal;
        private System.Windows.Forms.TextBox txtValorVenta;
        private System.Windows.Forms.TextBox txtDescuentoDolar;
        private System.Windows.Forms.TextBox txtDescuentoPorcentual;
        private System.Windows.Forms.TextBox txtVentaFinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

