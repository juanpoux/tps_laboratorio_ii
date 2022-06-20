
namespace PruebaTp3Form
{
    partial class FormVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbPagoElPedido = new System.Windows.Forms.CheckBox();
            this.lblTipoDePago = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.cboMedioDePago = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnEnviarPedido = new System.Windows.Forms.Button();
            this.lblTotalEfectivo = new System.Windows.Forms.Label();
            this.lblCartelTotalEfectivo = new System.Windows.Forms.Label();
            this.lblCartelTotalTarjeta = new System.Windows.Forms.Label();
            this.lblTotalTarjeta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSeleccioneProducto = new System.Windows.Forms.Label();
            this.txtBuscarPorNombre = new System.Windows.Forms.TextBox();
            this.gbVentas = new System.Windows.Forms.GroupBox();
            this.dgvAlimentosStock = new System.Windows.Forms.DataGridView();
            this.rtbObervaciones = new System.Windows.Forms.RichTextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.dgvAlimentosPedido = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimentosStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimentosPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPagoElPedido
            // 
            this.cbPagoElPedido.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbPagoElPedido.BackColor = System.Drawing.Color.Red;
            this.cbPagoElPedido.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbPagoElPedido.FlatAppearance.BorderSize = 0;
            this.cbPagoElPedido.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chartreuse;
            this.cbPagoElPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPagoElPedido.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbPagoElPedido.Location = new System.Drawing.Point(947, 599);
            this.cbPagoElPedido.Name = "cbPagoElPedido";
            this.cbPagoElPedido.Size = new System.Drawing.Size(132, 87);
            this.cbPagoElPedido.TabIndex = 10;
            this.cbPagoElPedido.Text = "PAGO?";
            this.cbPagoElPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbPagoElPedido.UseVisualStyleBackColor = false;
            this.cbPagoElPedido.CheckedChanged += new System.EventHandler(this.cbPagoElPedido_CheckedChanged);
            // 
            // lblTipoDePago
            // 
            this.lblTipoDePago.AutoSize = true;
            this.lblTipoDePago.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoDePago.Location = new System.Drawing.Point(635, 564);
            this.lblTipoDePago.Name = "lblTipoDePago";
            this.lblTipoDePago.Size = new System.Drawing.Size(187, 20);
            this.lblTipoDePago.TabIndex = 7;
            this.lblTipoDePago.Text = "Seleccione medio de pago";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.Location = new System.Drawing.Point(71, 628);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(72, 20);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // numericCantidad
            // 
            this.numericCantidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericCantidad.Location = new System.Drawing.Point(71, 659);
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(144, 27);
            this.numericCantidad.TabIndex = 2;
            // 
            // cboMedioDePago
            // 
            this.cboMedioDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedioDePago.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboMedioDePago.FormattingEnabled = true;
            this.cboMedioDePago.Location = new System.Drawing.Point(635, 596);
            this.cboMedioDePago.Name = "cboMedioDePago";
            this.cboMedioDePago.Size = new System.Drawing.Size(285, 28);
            this.cboMedioDePago.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(356, 633);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(193, 53);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Agregar producto";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1102, 633);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(203, 53);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(1139, 298);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(166, 35);
            this.btnEliminarProducto.TabIndex = 8;
            this.btnEliminarProducto.Text = "Eliminar producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnEnviarPedido
            // 
            this.btnEnviarPedido.Location = new System.Drawing.Point(1102, 571);
            this.btnEnviarPedido.Name = "btnEnviarPedido";
            this.btnEnviarPedido.Size = new System.Drawing.Size(203, 53);
            this.btnEnviarPedido.TabIndex = 9;
            this.btnEnviarPedido.Text = "ENVIAR PEDIDO";
            this.btnEnviarPedido.UseVisualStyleBackColor = true;
            this.btnEnviarPedido.Click += new System.EventHandler(this.btnEnviarPedido_Click);
            // 
            // lblTotalEfectivo
            // 
            this.lblTotalEfectivo.AutoSize = true;
            this.lblTotalEfectivo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalEfectivo.Location = new System.Drawing.Point(120, 67);
            this.lblTotalEfectivo.Name = "lblTotalEfectivo";
            this.lblTotalEfectivo.Size = new System.Drawing.Size(65, 45);
            this.lblTotalEfectivo.TabIndex = 12;
            this.lblTotalEfectivo.Text = "$ 0";
            // 
            // lblCartelTotalEfectivo
            // 
            this.lblCartelTotalEfectivo.AutoSize = true;
            this.lblCartelTotalEfectivo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCartelTotalEfectivo.Location = new System.Drawing.Point(120, 31);
            this.lblCartelTotalEfectivo.Name = "lblCartelTotalEfectivo";
            this.lblCartelTotalEfectivo.Size = new System.Drawing.Size(94, 30);
            this.lblCartelTotalEfectivo.TabIndex = 13;
            this.lblCartelTotalEfectivo.Text = "Efectivo:";
            // 
            // lblCartelTotalTarjeta
            // 
            this.lblCartelTotalTarjeta.AutoSize = true;
            this.lblCartelTotalTarjeta.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCartelTotalTarjeta.Location = new System.Drawing.Point(312, 31);
            this.lblCartelTotalTarjeta.Name = "lblCartelTotalTarjeta";
            this.lblCartelTotalTarjeta.Size = new System.Drawing.Size(82, 30);
            this.lblCartelTotalTarjeta.TabIndex = 15;
            this.lblCartelTotalTarjeta.Text = "Tarjeta:";
            // 
            // lblTotalTarjeta
            // 
            this.lblTotalTarjeta.AutoSize = true;
            this.lblTotalTarjeta.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalTarjeta.Location = new System.Drawing.Point(312, 67);
            this.lblTotalTarjeta.Name = "lblTotalTarjeta";
            this.lblTotalTarjeta.Size = new System.Drawing.Size(65, 45);
            this.lblTotalTarjeta.TabIndex = 14;
            this.lblTotalTarjeta.Text = "$ 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCartelTotalEfectivo);
            this.groupBox1.Controls.Add(this.lblCartelTotalTarjeta);
            this.groupBox1.Controls.Add(this.lblTotalEfectivo);
            this.groupBox1.Controls.Add(this.lblTotalTarjeta);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(635, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 132);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOTAL";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(635, 659);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 27);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblSeleccioneProducto
            // 
            this.lblSeleccioneProducto.AutoSize = true;
            this.lblSeleccioneProducto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccioneProducto.Location = new System.Drawing.Point(15, 22);
            this.lblSeleccioneProducto.Name = "lblSeleccioneProducto";
            this.lblSeleccioneProducto.Size = new System.Drawing.Size(148, 20);
            this.lblSeleccioneProducto.TabIndex = 5;
            this.lblSeleccioneProducto.Text = "Seleccione producto:";
            // 
            // txtBuscarPorNombre
            // 
            this.txtBuscarPorNombre.Location = new System.Drawing.Point(169, 22);
            this.txtBuscarPorNombre.Name = "txtBuscarPorNombre";
            this.txtBuscarPorNombre.PlaceholderText = "Buscar por nombre";
            this.txtBuscarPorNombre.Size = new System.Drawing.Size(400, 23);
            this.txtBuscarPorNombre.TabIndex = 18;
            this.txtBuscarPorNombre.TextChanged += new System.EventHandler(this.txtBuscarPorNombre_TextChanged);
            // 
            // gbVentas
            // 
            this.gbVentas.Controls.Add(this.dgvAlimentosStock);
            this.gbVentas.Controls.Add(this.txtBuscarPorNombre);
            this.gbVentas.Controls.Add(this.lblSeleccioneProducto);
            this.gbVentas.Location = new System.Drawing.Point(0, 2);
            this.gbVentas.Name = "gbVentas";
            this.gbVentas.Size = new System.Drawing.Size(587, 608);
            this.gbVentas.TabIndex = 1;
            this.gbVentas.TabStop = false;
            // 
            // dgvAlimentosStock
            // 
            this.dgvAlimentosStock.AllowUserToAddRows = false;
            this.dgvAlimentosStock.AllowUserToDeleteRows = false;
            this.dgvAlimentosStock.AllowUserToResizeColumns = false;
            this.dgvAlimentosStock.AllowUserToResizeRows = false;
            this.dgvAlimentosStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAlimentosStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlimentosStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlimentosStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAlimentosStock.EnableHeadersVisualStyles = false;
            this.dgvAlimentosStock.Location = new System.Drawing.Point(15, 51);
            this.dgvAlimentosStock.MultiSelect = false;
            this.dgvAlimentosStock.Name = "dgvAlimentosStock";
            this.dgvAlimentosStock.ReadOnly = true;
            this.dgvAlimentosStock.RowHeadersVisible = false;
            this.dgvAlimentosStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvAlimentosStock.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlimentosStock.RowTemplate.Height = 25;
            this.dgvAlimentosStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlimentosStock.Size = new System.Drawing.Size(553, 541);
            this.dgvAlimentosStock.TabIndex = 19;
            // 
            // rtbObervaciones
            // 
            this.rtbObervaciones.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbObervaciones.Location = new System.Drawing.Point(635, 486);
            this.rtbObervaciones.Name = "rtbObervaciones";
            this.rtbObervaciones.Size = new System.Drawing.Size(670, 62);
            this.rtbObervaciones.TabIndex = 18;
            this.rtbObervaciones.Text = "";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(635, 468);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(94, 15);
            this.lblObservaciones.TabIndex = 19;
            this.lblObservaciones.Text = "Oberservaciones";
            // 
            // dgvAlimentosPedido
            // 
            this.dgvAlimentosPedido.AllowUserToAddRows = false;
            this.dgvAlimentosPedido.AllowUserToDeleteRows = false;
            this.dgvAlimentosPedido.AllowUserToResizeColumns = false;
            this.dgvAlimentosPedido.AllowUserToResizeRows = false;
            this.dgvAlimentosPedido.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAlimentosPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlimentosPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlimentosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAlimentosPedido.EnableHeadersVisualStyles = false;
            this.dgvAlimentosPedido.Location = new System.Drawing.Point(635, 24);
            this.dgvAlimentosPedido.MultiSelect = false;
            this.dgvAlimentosPedido.Name = "dgvAlimentosPedido";
            this.dgvAlimentosPedido.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlimentosPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAlimentosPedido.RowHeadersVisible = false;
            this.dgvAlimentosPedido.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvAlimentosPedido.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAlimentosPedido.RowTemplate.Height = 25;
            this.dgvAlimentosPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlimentosPedido.Size = new System.Drawing.Size(670, 262);
            this.dgvAlimentosPedido.TabIndex = 20;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 707);
            this.Controls.Add(this.dgvAlimentosPedido);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.rtbObervaciones);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gbVentas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboMedioDePago);
            this.Controls.Add(this.cbPagoElPedido);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblTipoDePago);
            this.Controls.Add(this.btnEnviarPedido);
            this.Controls.Add(this.numericCantidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbVentas.ResumeLayout(false);
            this.gbVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimentosStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimentosPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.ComboBox cboMedioDePago;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTipoDePago;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnEnviarPedido;
        private System.Windows.Forms.Label lblTotalEfectivo;
        private System.Windows.Forms.Label lblCartelTotalEfectivo;
        private System.Windows.Forms.Label lblCartelTotalTarjeta;
        private System.Windows.Forms.Label lblTotalTarjeta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbPagoElPedido;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblSeleccioneProducto;
        private System.Windows.Forms.TextBox txtBuscarPorNombre;
        private System.Windows.Forms.GroupBox gbVentas;
        private System.Windows.Forms.RichTextBox rtbObervaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.DataGridView dgvAlimentosPedido;
        private System.Windows.Forms.DataGridView dgvAlimentosStock;
    }
}