﻿namespace ProyectoAplicacion2
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
            this.TextRutaArchivo = new System.Windows.Forms.TextBox();
            this.BtnSeleccionarArchivo = new System.Windows.Forms.Button();
            this.txtFabricas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProveedores = new System.Windows.Forms.TextBox();
            this.btnIngresoDatos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Noreste = new System.Windows.Forms.RadioButton();
            this.Vogel = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // TextRutaArchivo
            // 
            this.TextRutaArchivo.Enabled = false;
            this.TextRutaArchivo.Location = new System.Drawing.Point(22, 28);
            this.TextRutaArchivo.Name = "TextRutaArchivo";
            this.TextRutaArchivo.Size = new System.Drawing.Size(253, 20);
            this.TextRutaArchivo.TabIndex = 1;
            // 
            // BtnSeleccionarArchivo
            // 
            this.BtnSeleccionarArchivo.Location = new System.Drawing.Point(22, 54);
            this.BtnSeleccionarArchivo.Name = "BtnSeleccionarArchivo";
            this.BtnSeleccionarArchivo.Size = new System.Drawing.Size(253, 20);
            this.BtnSeleccionarArchivo.TabIndex = 3;
            this.BtnSeleccionarArchivo.Text = "Seleccionar Archivo (Método Esquina Noreste)";
            this.BtnSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.BtnSeleccionarArchivo.Click += new System.EventHandler(this.BtnSeleccionarArchivo_Click);
            // 
            // txtFabricas
            // 
            this.txtFabricas.CausesValidation = false;
            this.txtFabricas.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtFabricas.Location = new System.Drawing.Point(183, 163);
            this.txtFabricas.Name = "txtFabricas";
            this.txtFabricas.Size = new System.Drawing.Size(33, 20);
            this.txtFabricas.TabIndex = 0;
            this.txtFabricas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número de fábricas a abastecer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número de posibles proveedores";
            // 
            // txtProveedores
            // 
            this.txtProveedores.CausesValidation = false;
            this.txtProveedores.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtProveedores.Location = new System.Drawing.Point(183, 186);
            this.txtProveedores.Name = "txtProveedores";
            this.txtProveedores.Size = new System.Drawing.Size(33, 20);
            this.txtProveedores.TabIndex = 1;
            this.txtProveedores.TabStop = false;
            // 
            // btnIngresoDatos
            // 
            this.btnIngresoDatos.Location = new System.Drawing.Point(93, 212);
            this.btnIngresoDatos.Name = "btnIngresoDatos";
            this.btnIngresoDatos.Size = new System.Drawing.Size(155, 37);
            this.btnIngresoDatos.TabIndex = 2;
            this.btnIngresoDatos.Text = "Iniciar Ingreso de Datos";
            this.btnIngresoDatos.UseVisualStyleBackColor = true;
            this.btnIngresoDatos.Click += new System.EventHandler(this.btnIngresoDatos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Seleccionar Archivo (Método de Vogel)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(22, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Noreste
            // 
            this.Noreste.AutoSize = true;
            this.Noreste.Location = new System.Drawing.Point(223, 166);
            this.Noreste.Name = "Noreste";
            this.Noreste.Size = new System.Drawing.Size(103, 17);
            this.Noreste.TabIndex = 9;
            this.Noreste.TabStop = true;
            this.Noreste.Text = "Esquina Noreste";
            this.Noreste.UseVisualStyleBackColor = true;
            this.Noreste.Checked = true;
            // 
            // Vogel
            // 
            this.Vogel.AutoSize = true;
            this.Vogel.Location = new System.Drawing.Point(223, 189);
            this.Vogel.Name = "Vogel";
            this.Vogel.Size = new System.Drawing.Size(52, 17);
            this.Vogel.TabIndex = 10;
            this.Vogel.TabStop = true;
            this.Vogel.Text = "Vogel";
            this.Vogel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 259);
            this.Controls.Add(this.Vogel);
            this.Controls.Add(this.Noreste);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnIngresoDatos);
            this.Controls.Add(this.txtProveedores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFabricas);
            this.Controls.Add(this.BtnSeleccionarArchivo);
            this.Controls.Add(this.TextRutaArchivo);
            this.MaximumSize = new System.Drawing.Size(354, 298);
            this.MinimumSize = new System.Drawing.Size(354, 298);
            this.Name = "Form1";
            this.Text = "Transporte Inteligente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextRutaArchivo;
        private System.Windows.Forms.Button BtnSeleccionarArchivo;
        private System.Windows.Forms.TextBox txtFabricas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProveedores;
        private System.Windows.Forms.Button btnIngresoDatos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton Noreste;
        private System.Windows.Forms.RadioButton Vogel;
    }
}

