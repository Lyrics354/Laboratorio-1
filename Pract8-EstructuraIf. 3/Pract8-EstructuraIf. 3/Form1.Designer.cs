namespace Pract8_EstructuraIf._3
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
            this.lblIndicaciones = new System.Windows.Forms.Label();
            this.txtPrimerDig = new System.Windows.Forms.TextBox();
            this.txtSegundoDig = new System.Windows.Forms.TextBox();
            this.txtSolucion = new System.Windows.Forms.TextBox();
            this.grpSelecionOpr = new System.Windows.Forms.GroupBox();
            this.rdbSuma = new System.Windows.Forms.RadioButton();
            this.rdbResta = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rdbDivicion = new System.Windows.Forms.RadioButton();
            this.lblIgual = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.grpSelecionOpr.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.AutoSize = true;
            this.lblIndicaciones.Location = new System.Drawing.Point(105, 54);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(265, 16);
            this.lblIndicaciones.TabIndex = 0;
            this.lblIndicaciones.Text = "Ingresa los valores y selecione una opción:";
            // 
            // txtPrimerDig
            // 
            this.txtPrimerDig.Location = new System.Drawing.Point(108, 99);
            this.txtPrimerDig.Name = "txtPrimerDig";
            this.txtPrimerDig.Size = new System.Drawing.Size(100, 22);
            this.txtPrimerDig.TabIndex = 1;
            // 
            // txtSegundoDig
            // 
            this.txtSegundoDig.Location = new System.Drawing.Point(267, 99);
            this.txtSegundoDig.Name = "txtSegundoDig";
            this.txtSegundoDig.Size = new System.Drawing.Size(100, 22);
            this.txtSegundoDig.TabIndex = 2;
            // 
            // txtSolucion
            // 
            this.txtSolucion.Location = new System.Drawing.Point(428, 99);
            this.txtSolucion.Name = "txtSolucion";
            this.txtSolucion.Size = new System.Drawing.Size(100, 22);
            this.txtSolucion.TabIndex = 3;
            // 
            // grpSelecionOpr
            // 
            this.grpSelecionOpr.Controls.Add(this.rdbDivicion);
            this.grpSelecionOpr.Controls.Add(this.rdbMultiplicacion);
            this.grpSelecionOpr.Controls.Add(this.rdbResta);
            this.grpSelecionOpr.Controls.Add(this.rdbSuma);
            this.grpSelecionOpr.Location = new System.Drawing.Point(108, 159);
            this.grpSelecionOpr.Name = "grpSelecionOpr";
            this.grpSelecionOpr.Size = new System.Drawing.Size(320, 220);
            this.grpSelecionOpr.TabIndex = 8;
            this.grpSelecionOpr.TabStop = false;
            this.grpSelecionOpr.Text = "Selecione una operacion:";
            // 
            // rdbSuma
            // 
            this.rdbSuma.AutoSize = true;
            this.rdbSuma.Location = new System.Drawing.Point(25, 35);
            this.rdbSuma.Name = "rdbSuma";
            this.rdbSuma.Size = new System.Drawing.Size(63, 20);
            this.rdbSuma.TabIndex = 0;
            this.rdbSuma.TabStop = true;
            this.rdbSuma.Text = "Suma";
            this.rdbSuma.UseVisualStyleBackColor = true;
            // 
            // rdbResta
            // 
            this.rdbResta.AutoSize = true;
            this.rdbResta.Location = new System.Drawing.Point(25, 73);
            this.rdbResta.Name = "rdbResta";
            this.rdbResta.Size = new System.Drawing.Size(64, 20);
            this.rdbResta.TabIndex = 1;
            this.rdbResta.TabStop = true;
            this.rdbResta.Text = "Resta";
            this.rdbResta.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacion
            // 
            this.rdbMultiplicacion.AutoSize = true;
            this.rdbMultiplicacion.Location = new System.Drawing.Point(25, 111);
            this.rdbMultiplicacion.Name = "rdbMultiplicacion";
            this.rdbMultiplicacion.Size = new System.Drawing.Size(109, 20);
            this.rdbMultiplicacion.TabIndex = 2;
            this.rdbMultiplicacion.TabStop = true;
            this.rdbMultiplicacion.Text = "Multiplicación";
            this.rdbMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rdbDivicion
            // 
            this.rdbDivicion.AutoSize = true;
            this.rdbDivicion.Location = new System.Drawing.Point(25, 150);
            this.rdbDivicion.Name = "rdbDivicion";
            this.rdbDivicion.Size = new System.Drawing.Size(76, 20);
            this.rdbDivicion.TabIndex = 3;
            this.rdbDivicion.TabStop = true;
            this.rdbDivicion.Text = "División";
            this.rdbDivicion.UseVisualStyleBackColor = true;
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Location = new System.Drawing.Point(388, 99);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(14, 16);
            this.lblIgual.TabIndex = 9;
            this.lblIgual.Text = "=";
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(228, 102);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(17, 16);
            this.lblOperacion.TabIndex = 10;
            this.lblOperacion.Text = "O";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.grpSelecionOpr);
            this.Controls.Add(this.txtSolucion);
            this.Controls.Add(this.txtSegundoDig);
            this.Controls.Add(this.txtPrimerDig);
            this.Controls.Add(this.lblIndicaciones);
            this.Name = "Form1";
            this.Text = "PRÁCTICA DE ESTRUCTURA IF";
            this.grpSelecionOpr.ResumeLayout(false);
            this.grpSelecionOpr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIndicaciones;
        private System.Windows.Forms.TextBox txtPrimerDig;
        private System.Windows.Forms.TextBox txtSegundoDig;
        private System.Windows.Forms.TextBox txtSolucion;
        private System.Windows.Forms.GroupBox grpSelecionOpr;
        private System.Windows.Forms.RadioButton rdbMultiplicacion;
        private System.Windows.Forms.RadioButton rdbResta;
        private System.Windows.Forms.RadioButton rdbSuma;
        private System.Windows.Forms.RadioButton rdbDivicion;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.Label lblOperacion;
    }
}

