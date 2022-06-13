using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryPetShop
{
    public partial class FormMostrador : Form
    {
        string mensaje;
        public FormMostrador()
        {
            InitializeComponent();
        }

        public FormMostrador(string mensaje) : this()
        {
            this.mensaje = mensaje;
        }

        /// <summary>
        /// Carga el richTextBox con la informacion que recibe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMostrador_Load(object sender, EventArgs e)
        {
            this.richTextBox1.Text = this.mensaje;
        }

        /// <summary>
        /// Cambia el estado de DialogResult a OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
