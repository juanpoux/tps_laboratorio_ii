
namespace PruebaTp3Form
{
    partial class FormClientes
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
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.txtBuscarPorNombre = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtBuscarPorTelefono = new System.Windows.Forms.TextBox();
            this.txtBuscarPorDireccion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(665, 12);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(187, 51);
            this.btnSeleccionarCliente.TabIndex = 1;
            this.btnSeleccionarCliente.Text = "SELECCIONAR CLIENTE";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(665, 69);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(187, 51);
            this.btnNuevoCliente.TabIndex = 2;
            this.btnNuevoCliente.Text = "AGREGAR CLIENTE NUEVO";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(665, 126);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(187, 51);
            this.btnModificarCliente.TabIndex = 3;
            this.btnModificarCliente.Text = "MODIFICAR DATOS";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 321);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(647, 124);
            this.listBox1.TabIndex = 4;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(665, 183);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(187, 51);
            this.btnHistorial.TabIndex = 5;
            this.btnHistorial.Text = "VER HISTORIAL";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // txtBuscarPorNombre
            // 
            this.txtBuscarPorNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBuscarPorNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscarPorNombre.Location = new System.Drawing.Point(12, 12);
            this.txtBuscarPorNombre.Name = "txtBuscarPorNombre";
            this.txtBuscarPorNombre.PlaceholderText = "Buscar por nombre";
            this.txtBuscarPorNombre.Size = new System.Drawing.Size(219, 27);
            this.txtBuscarPorNombre.TabIndex = 7;
            this.txtBuscarPorNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(665, 394);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(187, 51);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtBuscarPorTelefono
            // 
            this.txtBuscarPorTelefono.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBuscarPorTelefono.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscarPorTelefono.Location = new System.Drawing.Point(237, 12);
            this.txtBuscarPorTelefono.Name = "txtBuscarPorTelefono";
            this.txtBuscarPorTelefono.PlaceholderText = "Buscar por telefono";
            this.txtBuscarPorTelefono.Size = new System.Drawing.Size(208, 27);
            this.txtBuscarPorTelefono.TabIndex = 9;
            this.txtBuscarPorTelefono.TextChanged += new System.EventHandler(this.txtBuscarPorTelefono_TextChanged);
            // 
            // txtBuscarPorDireccion
            // 
            this.txtBuscarPorDireccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBuscarPorDireccion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscarPorDireccion.Location = new System.Drawing.Point(451, 12);
            this.txtBuscarPorDireccion.Name = "txtBuscarPorDireccion";
            this.txtBuscarPorDireccion.PlaceholderText = "Buscar por direccion";
            this.txtBuscarPorDireccion.Size = new System.Drawing.Size(208, 27);
            this.txtBuscarPorDireccion.TabIndex = 10;
            this.txtBuscarPorDireccion.TextChanged += new System.EventHandler(this.txtBuscarPorDireccion_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 46;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(647, 212);
            this.dataGridView1.TabIndex = 11;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 451);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBuscarPorDireccion);
            this.Controls.Add(this.txtBuscarPorTelefono);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtBuscarPorNombre);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.TextBox txtBuscarPorNombre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtBuscarPorTelefono;
        private System.Windows.Forms.TextBox txtBuscarPorDireccion;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}