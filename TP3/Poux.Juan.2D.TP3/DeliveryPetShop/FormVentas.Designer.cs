
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
            this.lblDia = new System.Windows.Forms.Label();
            this.gbVentas = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxProductosEnStock = new System.Windows.Forms.ListBox();
            this.lblPrecioTarj = new System.Windows.Forms.Label();
            this.lblCartelPrecioTarj = new System.Windows.Forms.Label();
            this.lblSeleccioneProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCartelPrecio = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.cbPagoElPedido = new System.Windows.Forms.CheckBox();
            this.lblTipoDePago = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.cboMedioDePago = new System.Windows.Forms.ComboBox();
            this.lblCartelFecha = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnEnviarPedido = new System.Windows.Forms.Button();
            this.listBoxProductosPedidos = new System.Windows.Forms.ListBox();
            this.lblTotalEfectivo = new System.Windows.Forms.Label();
            this.lblCartelTotalEfectivo = new System.Windows.Forms.Label();
            this.lblCartelTotalTarjeta = new System.Windows.Forms.Label();
            this.lblTotalTarjeta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(100, 557);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(59, 15);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "24/5/2022";
            // 
            // gbVentas
            // 
            this.gbVentas.Controls.Add(this.textBox1);
            this.gbVentas.Controls.Add(this.listBoxProductosEnStock);
            this.gbVentas.Controls.Add(this.lblPrecioTarj);
            this.gbVentas.Controls.Add(this.lblCartelPrecioTarj);
            this.gbVentas.Controls.Add(this.lblSeleccioneProducto);
            this.gbVentas.Controls.Add(this.lblPrecio);
            this.gbVentas.Controls.Add(this.lblCartelPrecio);
            this.gbVentas.Controls.Add(this.cboProducto);
            this.gbVentas.Location = new System.Drawing.Point(0, 0);
            this.gbVentas.Name = "gbVentas";
            this.gbVentas.Size = new System.Drawing.Size(544, 472);
            this.gbVentas.TabIndex = 1;
            this.gbVentas.TabStop = false;
            this.gbVentas.Text = "Area Ventas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 23);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBoxProductosEnStock
            // 
            this.listBoxProductosEnStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxProductosEnStock.FormattingEnabled = true;
            this.listBoxProductosEnStock.ItemHeight = 21;
            this.listBoxProductosEnStock.Location = new System.Drawing.Point(16, 67);
            this.listBoxProductosEnStock.Name = "listBoxProductosEnStock";
            this.listBoxProductosEnStock.Size = new System.Drawing.Size(515, 340);
            this.listBoxProductosEnStock.TabIndex = 17;
            this.listBoxProductosEnStock.SelectedIndexChanged += new System.EventHandler(this.listBoxProductosEnStock_SelectedIndexChanged);
            // 
            // lblPrecioTarj
            // 
            this.lblPrecioTarj.AutoSize = true;
            this.lblPrecioTarj.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioTarj.Location = new System.Drawing.Point(379, 421);
            this.lblPrecioTarj.Name = "lblPrecioTarj";
            this.lblPrecioTarj.Size = new System.Drawing.Size(70, 32);
            this.lblPrecioTarj.TabIndex = 9;
            this.lblPrecioTarj.Text = "$500";
            // 
            // lblCartelPrecioTarj
            // 
            this.lblCartelPrecioTarj.AutoSize = true;
            this.lblCartelPrecioTarj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCartelPrecioTarj.Location = new System.Drawing.Point(259, 428);
            this.lblCartelPrecioTarj.Name = "lblCartelPrecioTarj";
            this.lblCartelPrecioTarj.Size = new System.Drawing.Size(105, 21);
            this.lblCartelPrecioTarj.TabIndex = 8;
            this.lblCartelPrecioTarj.Text = "Precio Tarjeta:";
            // 
            // lblSeleccioneProducto
            // 
            this.lblSeleccioneProducto.AutoSize = true;
            this.lblSeleccioneProducto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccioneProducto.Location = new System.Drawing.Point(16, 19);
            this.lblSeleccioneProducto.Name = "lblSeleccioneProducto";
            this.lblSeleccioneProducto.Size = new System.Drawing.Size(148, 20);
            this.lblSeleccioneProducto.TabIndex = 5;
            this.lblSeleccioneProducto.Text = "Seleccione producto:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(132, 425);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(70, 32);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "$500";
            // 
            // lblCartelPrecio
            // 
            this.lblCartelPrecio.AutoSize = true;
            this.lblCartelPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCartelPrecio.Location = new System.Drawing.Point(12, 430);
            this.lblCartelPrecio.Name = "lblCartelPrecio";
            this.lblCartelPrecio.Size = new System.Drawing.Size(114, 21);
            this.lblCartelPrecio.TabIndex = 3;
            this.lblCartelPrecio.Text = "Precio Efectivo:";
            // 
            // cboProducto
            // 
            this.cboProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(277, 38);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(254, 23);
            this.cboProducto.TabIndex = 0;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            // 
            // cbPagoElPedido
            // 
            this.cbPagoElPedido.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbPagoElPedido.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbPagoElPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPagoElPedido.Location = new System.Drawing.Point(563, 505);
            this.cbPagoElPedido.Name = "cbPagoElPedido";
            this.cbPagoElPedido.Size = new System.Drawing.Size(285, 28);
            this.cbPagoElPedido.TabIndex = 10;
            this.cbPagoElPedido.Text = "Deja pago el pedido                  ";
            this.cbPagoElPedido.UseVisualStyleBackColor = true;
            // 
            // lblTipoDePago
            // 
            this.lblTipoDePago.AutoSize = true;
            this.lblTipoDePago.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoDePago.Location = new System.Drawing.Point(563, 407);
            this.lblTipoDePago.Name = "lblTipoDePago";
            this.lblTipoDePago.Size = new System.Drawing.Size(187, 20);
            this.lblTipoDePago.TabIndex = 7;
            this.lblTipoDePago.Text = "Seleccione medio de pago";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.Location = new System.Drawing.Point(39, 475);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(72, 20);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // numericCantidad
            // 
            this.numericCantidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericCantidad.Location = new System.Drawing.Point(39, 506);
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(144, 27);
            this.numericCantidad.TabIndex = 2;
            // 
            // cboMedioDePago
            // 
            this.cboMedioDePago.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboMedioDePago.FormattingEnabled = true;
            this.cboMedioDePago.Location = new System.Drawing.Point(563, 430);
            this.cboMedioDePago.Name = "cboMedioDePago";
            this.cboMedioDePago.Size = new System.Drawing.Size(285, 28);
            this.cboMedioDePago.TabIndex = 1;
            // 
            // lblCartelFecha
            // 
            this.lblCartelFecha.AutoSize = true;
            this.lblCartelFecha.Location = new System.Drawing.Point(16, 557);
            this.lblCartelFecha.Name = "lblCartelFecha";
            this.lblCartelFecha.Size = new System.Drawing.Size(78, 15);
            this.lblCartelFecha.TabIndex = 2;
            this.lblCartelFecha.Text = "Fecha Actual:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(338, 480);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(193, 53);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Agregar producto";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(875, 480);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(203, 53);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(912, 237);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(166, 35);
            this.btnEliminarProducto.TabIndex = 8;
            this.btnEliminarProducto.Text = "Eliminar producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEnviarPedido
            // 
            this.btnEnviarPedido.Location = new System.Drawing.Point(875, 421);
            this.btnEnviarPedido.Name = "btnEnviarPedido";
            this.btnEnviarPedido.Size = new System.Drawing.Size(203, 53);
            this.btnEnviarPedido.TabIndex = 9;
            this.btnEnviarPedido.Text = "ENVIAR PEDIDO";
            this.btnEnviarPedido.UseVisualStyleBackColor = true;
            this.btnEnviarPedido.Click += new System.EventHandler(this.btnEnviarPedido_Click);
            // 
            // listBoxProductosPedidos
            // 
            this.listBoxProductosPedidos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxProductosPedidos.ItemHeight = 21;
            this.listBoxProductosPedidos.Location = new System.Drawing.Point(563, 38);
            this.listBoxProductosPedidos.Name = "listBoxProductosPedidos";
            this.listBoxProductosPedidos.Size = new System.Drawing.Size(515, 193);
            this.listBoxProductosPedidos.TabIndex = 10;
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
            this.groupBox1.Location = new System.Drawing.Point(563, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 118);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOTAL";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(563, 468);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 27);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 552);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.gbVentas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboMedioDePago);
            this.Controls.Add(this.cbPagoElPedido);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.listBoxProductosPedidos);
            this.Controls.Add(this.lblTipoDePago);
            this.Controls.Add(this.btnEnviarPedido);
            this.Controls.Add(this.numericCantidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblCartelFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.gbVentas.ResumeLayout(false);
            this.gbVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.GroupBox gbVentas;
        private System.Windows.Forms.Label lblCartelFecha;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.ComboBox cboMedioDePago;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCartelPrecio;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTipoDePago;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblSeleccioneProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Label lblPrecioTarj;
        private System.Windows.Forms.Label lblCartelPrecioTarj;
        private System.Windows.Forms.Button btnEnviarPedido;
        private System.Windows.Forms.ListBox listBoxProductosPedidos;
        private System.Windows.Forms.Label lblTotalEfectivo;
        private System.Windows.Forms.Label lblCartelTotalEfectivo;
        private System.Windows.Forms.Label lblCartelTotalTarjeta;
        private System.Windows.Forms.Label lblTotalTarjeta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbPagoElPedido;
        private System.Windows.Forms.ListBox listBoxProductosEnStock;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}