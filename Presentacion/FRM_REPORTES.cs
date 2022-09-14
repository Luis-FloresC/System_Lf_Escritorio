using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FRM_REPORTES : Form
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public FRM_REPORTES()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Abrir Formulario En panel
        /// </summary>
        /// <param name="Formhijo"></param>
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.Panel_Contenedor.Controls.Count > 0)
                this.Panel_Contenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Panel_Contenedor.Controls.Add(fh);
            this.Panel_Contenedor.Tag = fh;
            fh.Show();
        }

        /// <summary>
        /// Genera El Reporte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FRM_REPORTE_CUOTAS(textBox1.Text));

        }
        /// <summary>
        /// Limpia el Textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Numero de Identidad del Cliente")
            {
                textBox1.Text = "";
            }
        }

        /// <summary>
        /// Agregar palabra clave al textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "Numero de Identidad del Cliente";
            }
        }

        /// <summary>
        /// Carga 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRM_REPORTES_Load(object sender, EventArgs e)
        {

        }
    }
}
