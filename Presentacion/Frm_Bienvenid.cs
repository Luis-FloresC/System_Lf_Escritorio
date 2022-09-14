using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace Presentacion
{
    public partial class Frm_Bienvenid : Form
    {
        public Frm_Bienvenid()
        {
            InitializeComponent();
        }
      //  int cont = 0;

            /// <summary>
            /// Aumenta la Opacidad
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            circularProgressBar1.Value += 1;

            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();

            }
        }


        /// <summary>
        /// Disminuye la Opacidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();

            }
        }
            private void Frm_Bienvenid_Load(object sender, EventArgs e)
        {
            LB_USER.Text = Cache_Usuario.Nombre + " " + Cache_Usuario.Apellido;
            this.Opacity = 0.0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timer1.Start();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
