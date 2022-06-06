
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVerPedido = new System.Windows.Forms.Button();
            this.btnRealizarPedidoNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPedidosTotales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosTotales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerPedido
            // 
            this.btnVerPedido.Location = new System.Drawing.Point(776, 124);
            this.btnVerPedido.Name = "btnVerPedido";
            this.btnVerPedido.Size = new System.Drawing.Size(188, 66);
            this.btnVerPedido.TabIndex = 2;
            this.btnVerPedido.Text = "VER PEDIDO";
            this.btnVerPedido.UseVisualStyleBackColor = true;
            this.btnVerPedido.Click += new System.EventHandler(this.btnVerPedido_Click);
            // 
            // btnRealizarPedidoNuevo
            // 
            this.btnRealizarPedidoNuevo.Location = new System.Drawing.Point(776, 52);
            this.btnRealizarPedidoNuevo.Name = "btnRealizarPedidoNuevo";
            this.btnRealizarPedidoNuevo.Size = new System.Drawing.Size(188, 66);
            this.btnRealizarPedidoNuevo.TabIndex = 3;
            this.btnRealizarPedidoNuevo.Text = "REALIZAR NUEVO PEDIDO";
            this.btnRealizarPedidoNuevo.UseVisualStyleBackColor = true;
            this.btnRealizarPedidoNuevo.Click += new System.EventHandler(this.btnRealizarPedidoNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(776, 524);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(188, 66);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "PEDIDOS REALIZADOS";
            // 
            // dgvPedidosTotales
            // 
            this.dgvPedidosTotales.AllowUserToAddRows = false;
            this.dgvPedidosTotales.AllowUserToDeleteRows = false;
            this.dgvPedidosTotales.AllowUserToResizeColumns = false;
            this.dgvPedidosTotales.AllowUserToResizeRows = false;
            this.dgvPedidosTotales.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPedidosTotales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPedidosTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPedidosTotales.EnableHeadersVisualStyles = false;
            this.dgvPedidosTotales.Location = new System.Drawing.Point(12, 52);
            this.dgvPedidosTotales.MultiSelect = false;
            this.dgvPedidosTotales.Name = "dgvPedidosTotales";
            this.dgvPedidosTotales.ReadOnly = true;
            this.dgvPedidosTotales.RowHeadersVisible = false;
            this.dgvPedidosTotales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvPedidosTotales.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidosTotales.RowTemplate.Height = 25;
            this.dgvPedidosTotales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidosTotales.Size = new System.Drawing.Size(758, 538);
            this.dgvPedidosTotales.TabIndex = 9;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 602);
            this.Controls.Add(this.dgvPedidosTotales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRealizarPedidoNuevo);
            this.Controls.Add(this.btnVerPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosTotales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVerPedido;
        private System.Windows.Forms.Button btnRealizarPedidoNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPedidosTotales;
    }
}