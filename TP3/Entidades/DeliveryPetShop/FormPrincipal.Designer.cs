﻿
namespace PruebaTp3Form
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCartelPedidosRealizados = new System.Windows.Forms.Label();
            this.btnVerPedido = new System.Windows.Forms.Button();
            this.btnRealizarPedidoNuevo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCartelPedidosRealizados
            // 
            this.lblCartelPedidosRealizados.AutoSize = true;
            this.lblCartelPedidosRealizados.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCartelPedidosRealizados.Location = new System.Drawing.Point(12, 20);
            this.lblCartelPedidosRealizados.Name = "lblCartelPedidosRealizados";
            this.lblCartelPedidosRealizados.Size = new System.Drawing.Size(322, 40);
            this.lblCartelPedidosRealizados.TabIndex = 1;
            this.lblCartelPedidosRealizados.Text = "PEDIDOS REALIZADOS";
            // 
            // btnVerPedido
            // 
            this.btnVerPedido.Location = new System.Drawing.Point(540, 152);
            this.btnVerPedido.Name = "btnVerPedido";
            this.btnVerPedido.Size = new System.Drawing.Size(230, 66);
            this.btnVerPedido.TabIndex = 2;
            this.btnVerPedido.Text = "VER PEDIDO";
            this.btnVerPedido.UseVisualStyleBackColor = true;
            this.btnVerPedido.Click += new System.EventHandler(this.btnVerPedido_Click);
            // 
            // btnRealizarPedidoNuevo
            // 
            this.btnRealizarPedidoNuevo.Location = new System.Drawing.Point(540, 63);
            this.btnRealizarPedidoNuevo.Name = "btnRealizarPedidoNuevo";
            this.btnRealizarPedidoNuevo.Size = new System.Drawing.Size(230, 66);
            this.btnRealizarPedidoNuevo.TabIndex = 3;
            this.btnRealizarPedidoNuevo.Text = "REALIZAR NUEVO PEDIDO";
            this.btnRealizarPedidoNuevo.UseVisualStyleBackColor = true;
            this.btnRealizarPedidoNuevo.Click += new System.EventHandler(this.btnRealizarPedidoNuevo_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(12, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(522, 382);
            this.listBox1.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(540, 379);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(230, 66);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 467);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRealizarPedidoNuevo);
            this.Controls.Add(this.btnVerPedido);
            this.Controls.Add(this.lblCartelPedidosRealizados);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCartelPedidosRealizados;
        private System.Windows.Forms.Button btnVerPedido;
        private System.Windows.Forms.Button btnRealizarPedidoNuevo;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}