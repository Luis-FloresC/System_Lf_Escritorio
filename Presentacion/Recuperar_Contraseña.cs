using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class Recuperar_Contraseña : Form
    {
        public Recuperar_Contraseña()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Envio de Correo Electronico 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            var user = new Usuarios();
            var resul = user.recuperar_contraseña(textBox1.Text);
            MessageBox.Show(resul, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //label2.Text = resul;
            this.Close();
        }

        private void Recuperar_Contraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
