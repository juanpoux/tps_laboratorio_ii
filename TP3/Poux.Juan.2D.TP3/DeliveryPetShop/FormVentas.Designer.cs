
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
            this.lblPrecioTarj = new System.Windows.Forms.Label();
            this.lblCartelPrecioTarj = new System.Windows.Forms.Label();
            this.lblTipoDePago = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblSeleccioneProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCartelPrecio = new System.Windows.Forms.Label();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.cboMedioDePago = new System.Windows.Forms.ComboBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.lblCartelFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnEnviarPedido = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblCartelTotal = new System.Windows.Forms.Label();
            this.lblTotalEfectivo = new System.Windows.Forms.Label();
            this.lblCartelTotalEfectivo = new System.Windows.Forms.Label();
            this.lblCartelTotalTarjeta = new System.Windows.Forms.Label();
            this.lblTotalTarjeta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPagoElPedido = new System.Windows.Forms.CheckBox();
            this.gbVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(647, 32);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(59, 15);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "24/5/2022";
            // 
            // gbVentas
            // 
            this.gbVentas.Controls.Add(this.cbPagoElPedido);
            this.gbVentas.Controls.Add(this.lblPrecioTarj);
            this.gbVentas.Controls.Add(this.lblCartelPrecioTarj);
            this.gbVentas.Controls.Add(this.lblTipoDePago);
            this.gbVentas.Controls.Add(this.lblCantidad);
            this.gbVentas.Controls.Add(this.lblSeleccioneProducto);
            this.gbVentas.Controls.Add(this.lblPrecio);
            this.gbVentas.Controls.Add(this.lblCartelPrecio);
            this.gbVentas.Controls.Add(this.numericCantidad);
            this.gbVentas.Controls.Add(this.cboMedioDePago);
            this.gbVentas.Controls.Add(this.cboProducto);
            this.gbVentas.Location = new System.Drawing.Point(12, 50);
            this.gbVentas.Name = "gbVentas";
            this.gbVentas.Size = new System.Drawing.Size(741, 158);
            this.gbVentas.TabIndex = 1;
            this.gbVentas.TabStop = false;
            this.gbVentas.Text = "Area Ventas";
            // 
            // lblPrecioTarj
            // 
            this.lblPrecioTarj.AutoSize = true;
            this.lblPrecioTarj.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioTarj.Location = new System.Drawing.Point(624, 92);
            this.lblPrecioTarj.Name = "lblPrecioTarj";
            this.lblPrecioTarj.Size = new System.Drawing.Size(70, 32);
            this.lblPrecioTarj.TabIndex = 9;
            this.lblPrecioTarj.Text = "$500";
            // 
            // lblCartelPrecioTarj
            // 
            this.lblCartelPrecioTarj.AutoSize = true;
            this.lblCartelPrecioTarj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCartelPrecioTarj.Location = new System.Drawing.Point(504, 99);
            this.lblCartelPrecioTarj.Name = "lblCartelPrecioTarj";
            this.lblCartelPrecioTarj.Size = new System.Drawing.Size(105, 21);
            this.lblCartelPrecioTarj.TabIndex = 8;
            this.lblCartelPrecioTarj.Text = "Precio Tarjeta:";
            // 
            // lblTipoDePago
            // 
            this.lblTipoDePago.AutoSize = true;
            this.lblTipoDePago.Location = new System.Drawing.Point(16, 85);
            this.lblTipoDePago.Name = "lblTipoDePago";
            this.lblTipoDePago.Size = new System.Drawing.Size(146, 15);
            this.lblTipoDePago.TabIndex = 7;
            this.lblTipoDePago.Text = "Seleccione medio de pago";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(314, 35);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(58, 15);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblSeleccioneProducto
            // 
            this.lblSeleccioneProducto.AutoSize = true;
            this.lblSeleccioneProducto.Location = new System.Drawing.Point(16, 30);
            this.lblSeleccioneProducto.Name = "lblSeleccioneProducto";
            this.lblSeleccioneProducto.Size = new System.Drawing.Size(118, 15);
            this.lblSeleccioneProducto.TabIndex = 5;
            this.lblSeleccioneProducto.Text = "Seleccione producto:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(624, 39);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(70, 32);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "$500";
            // 
            // lblCartelPrecio
            // 
            this.lblCartelPrecio.AutoSize = true;
            this.lblCartelPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCartelPrecio.Location = new System.Drawing.Point(504, 46);
            this.lblCartelPrecio.Name = "lblCartelPrecio";
            this.lblCartelPrecio.Size = new System.Drawing.Size(114, 21);
            this.lblCartelPrecio.TabIndex = 3;
            this.lblCartelPrecio.Text = "Precio Efectivo:";
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(314, 53);
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(144, 23);
            this.numericCantidad.TabIndex = 2;
            // 
            // cboMedioDePago
            // 
            this.cboMedioDePago.FormattingEnabled = true;
            this.cboMedioDePago.Location = new System.Drawing.Point(16, 103);
            this.cboMedioDePago.Name = "cboMedioDePago";
            this.cboMedioDePago.Size = new System.Drawing.Size(254, 23);
            this.cboMedioDePago.TabIndex = 1;
            // 
            // cboProducto
            // 
            this.cboProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(16, 52);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(254, 23);
            this.cboProducto.TabIndex = 0;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            // 
            // lblCartelFecha
            // 
            this.lblCartelFecha.AutoSize = true;
            this.lblCartelFecha.Location = new System.Drawing.Point(563, 32);
            this.lblCartelFecha.Name = "lblCartelFecha";
            this.lblCartelFecha.Size = new System.Drawing.Size(78, 15);
            this.lblCartelFecha.TabIndex = 2;
            this.lblCartelFecha.Text = "Fecha Actual:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(765, 32);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "VENTAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(587, 226);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(166, 35);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Agregar producto";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(587, 267);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(166, 35);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(585, 492);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(168, 35);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(587, 308);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(166, 35);
            this.btnEliminarProducto.TabIndex = 8;
            this.btnEliminarProducto.Text = "Eliminar producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEnviarPedido
            // 
            this.btnEnviarPedido.Location = new System.Drawing.Point(587, 451);
            this.btnEnviarPedido.Name = "btnEnviarPedido";
            this.btnEnviarPedido.Size = new System.Drawing.Size(166, 35);
            this.btnEnviarPedido.TabIndex = 9;
            this.btnEnviarPedido.Text = "ENVIAR PEDIDO";
            this.btnEnviarPedido.UseVisualStyleBackColor = true;
            this.btnEnviarPedido.Click += new System.EventHandler(this.btnEnviarPedido_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(12, 226);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(555, 193);
            this.listBox1.TabIndex = 10;
            // 
            // lblCartelTotal
            // 
            this.lblCartelTotal.AutoSize = true;
            this.lblCartelTotal.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCartelTotal.Location = new System.Drawing.Point(12, 436);
            this.lblCartelTotal.Name = "lblCartelTotal";
            this.lblCartelTotal.Size = new System.Drawing.Size(116, 37);
            this.lblCartelTotal.TabIndex = 11;
            this.lblCartelTotal.Text = "TOTAL:";
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
            this.groupBox1.Location = new System.Drawing.Point(14, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 118);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOTAL";
            // 
            // cbPagoElPedido
            // 
            this.cbPagoElPedido.AutoSize = true;
            this.cbPagoElPedido.Location = new System.Drawing.Point(314, 103);
            this.cbPagoElPedido.Name = "cbPagoElPedido";
            this.cbPagoElPedido.Size = new System.Drawing.Size(131, 19);
            this.cbPagoElPedido.TabIndex = 10;
            this.cbPagoElPedido.Text = "Deja pago el pedido";
            this.cbPagoElPedido.UseVisualStyleBackColor = true;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCartelTotal);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEnviarPedido);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblCartelFecha);
            this.Controls.Add(this.gbVentas);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.ComboBox cboMedioDePago;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCartelPrecio;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTipoDePago;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblSeleccioneProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Label lblPrecioTarj;
        private System.Windows.Forms.Label lblCartelPrecioTarj;
        private System.Windows.Forms.Button btnEnviarPedido;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblCartelTotal;
        private System.Windows.Forms.Label lblTotalEfectivo;
        private System.Windows.Forms.Label lblCartelTotalEfectivo;
        private System.Windows.Forms.Label lblCartelTotalTarjeta;
        private System.Windows.Forms.Label lblTotalTarjeta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbPagoElPedido;
    }
}