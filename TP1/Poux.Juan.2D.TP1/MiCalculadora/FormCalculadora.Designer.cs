﻿
namespace MiCalculadora
{
    partial class formCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCalculadora));
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConvertirABinario = new System.Windows.Forms.Button();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btnConvertirADecimal = new System.Windows.Forms.Button();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lstOperaciones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(12, 134);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(127, 43);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(171, 134);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 43);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(307, 134);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(127, 43);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConvertirABinario
            // 
            this.btnConvertirABinario.Location = new System.Drawing.Point(12, 199);
            this.btnConvertirABinario.Name = "btnConvertirABinario";
            this.btnConvertirABinario.Size = new System.Drawing.Size(205, 43);
            this.btnConvertirABinario.TabIndex = 6;
            this.btnConvertirABinario.Text = "Convertir a Binario";
            this.btnConvertirABinario.UseVisualStyleBackColor = true;
            this.btnConvertirABinario.Click += new System.EventHandler(this.btnConvertirABinario_Click);
            // 
            // txtNumero1
            // 
            this.txtNumero1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero1.Location = new System.Drawing.Point(12, 73);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(127, 43);
            this.txtNumero1.TabIndex = 0;
            this.txtNumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero2.Location = new System.Drawing.Point(307, 73);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(127, 43);
            this.txtNumero2.TabIndex = 2;
            this.txtNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConvertirADecimal
            // 
            this.btnConvertirADecimal.Location = new System.Drawing.Point(229, 200);
            this.btnConvertirADecimal.Name = "btnConvertirADecimal";
            this.btnConvertirADecimal.Size = new System.Drawing.Size(205, 43);
            this.btnConvertirADecimal.TabIndex = 7;
            this.btnConvertirADecimal.Text = "Convertir a Decimal";
            this.btnConvertirADecimal.UseVisualStyleBackColor = true;
            this.btnConvertirADecimal.Click += new System.EventHandler(this.btnConvertirADecimal_Click);
            // 
            // cmbOperador
            // 
            this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Location = new System.Drawing.Point(187, 73);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(75, 45);
            this.cmbOperador.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(12, 9);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(422, 48);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "0";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstOperaciones
            // 
            this.lstOperaciones.FormattingEnabled = true;
            this.lstOperaciones.ItemHeight = 15;
            this.lstOperaciones.Location = new System.Drawing.Point(459, 9);
            this.lstOperaciones.Name = "lstOperaciones";
            this.lstOperaciones.Size = new System.Drawing.Size(278, 244);
            this.lstOperaciones.TabIndex = 0;
            this.lstOperaciones.TabStop = false;
            // 
            // formCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(752, 260);
            this.Controls.Add(this.lstOperaciones);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.btnConvertirADecimal);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.btnConvertirABinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Juan Poux de 2° A";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formCalculadora_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formCalculadora_FormClosed);
            this.Load += new System.EventHandler(this.formCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvertirABinario;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnConvertirADecimal;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ListBox lstOperaciones;
    }
}

