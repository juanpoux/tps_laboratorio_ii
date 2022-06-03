using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PruebaTp3Form
{
    public partial class FormPruebas : Form
    {
        List<Cliente> listaClientes;
        public FormPruebas()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            listaClientes = new()
            {
                new Cliente("Juan", "Juan", "saavedra 352"),
                new Cliente("Jose", "Jose", "saavedra 352"),
                new Cliente("Eze", "Eze", "Holi 166"),
                new Cliente("Thiago", "Thiago", "Comahue 1664")
            };

            Dictionary<string, Cliente> valoresCombo = new Dictionary<string, Cliente>();
            foreach (Cliente item in listaClientes)
            {
                valoresCombo.Add(item.Nombre, item);
            }
            this.comboBox1.DisplayMember = "Key";
            this.comboBox1.ValueMember = "Value";
            this.comboBox1.DataSource = valoresCombo.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                Cliente cliente = ((KeyValuePair<string, Cliente>)comboBox1.SelectedItem).Value;
                //MessageBox.Show(cliente.MostrarCliente());
                this.richTextBox1.Text += cliente.MostrarCliente() + "\n";
            }
        }
    }
}
