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
using System.Runtime.InteropServices;
using FontAwesome.Sharp;

namespace Presentacion
{
    public partial class Menu_principal : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
    

        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Menu_principal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            M_vertical.Controls.Add(leftBorderBtn);
        }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="acc">accion  para abrir un nuevo Formulario</param>
        public Menu_principal(bool acc)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            M_vertical.Controls.Add(leftBorderBtn);
            if (acc == true)
            {
                AbrirFormEnPanel(new FRM_ESTADISTICAS());
            }
        }


        /// <summary>
        /// Estructura para Colores
        /// </summary>
        public struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(255, 255, 255);
            public static Color color6 = Color.FromArgb(0, 134, 196);
        }


        /// <summary>
        /// Activar Botones
        /// </summary>
        /// <param name="senderBtn"></param>
        /// <param name="color">Recibe un Color</param>
        public void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(49, 50, 74);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
               
                MENU.IconColor = Color.FromArgb(255, 255, 255);
                label1.Text = currentBtn.Text;
                label1.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }


        /// <summary>
        /// Desactivar Efecto de los Botones al Cambiar de Formurlario
        /// </summary>
       public void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(49, 50, 74);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        /// <summary>
        /// Restablecer
        /// </summary>
       public void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            MENU.IconChar = IconChar.Home;
            MENU.IconColor = Color.MediumPurple;
            label1.Text = "Home";
            label1.ForeColor = Color.MediumPurple;
        }


      
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

 
    /// <summary>
    /// Evento para Cargar Datos del Usuario
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void Menu_principal_Load(object sender, EventArgs e)
        {
            LB_NOMBRE.Text = Cache_Usuario.Nombre + ",  " + Cache_Usuario.Apellido;
            LB_CARGO.Text = Cache_Usuario.Cargo;
            LB_EMAIL.Text = Cache_Usuario.Email;
           
       


          
        }


        /// <summary>
        /// Link para Editar El Perfil del Usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormEnPanel(new Editar_Perfil());
        }

        /// <summary>
        /// para desplazar el panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (M_vertical.Width == 250)
            {
                M_vertical.Width = 100;
            }
            else
                M_vertical.Width = 250;
        }

        /// <summary>
        /// Para Restaurar El formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ICON_RES_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
          
        }


        /// <summary>
        /// Para Maximizar El formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ICON_MIN_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        /// <summary>
        /// Para Mover El Formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Para Mover El Formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel_C_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Para Mover El Formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void M_vertical_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /// <summary>
        /// Para Abrir un Formulario En un Panel
        /// </summary>
        /// <param name="Formhijo"></param>
        public void AbrirFormEnPanel(object Formhijo)
        {
            if (this.Panel_c.Controls.Count > 0)
                this.Panel_c.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Panel_c.Controls.Add(fh);
            this.Panel_c.Tag = fh;
            fh.Show();
        }


        /// <summary>
        /// Para Cerrar Sesion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            if (MessageBox.Show("Estas seguro que quieres Salir?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            this.Close();
        }

        /// <summary>
        /// Formulario  de Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            AbrirFormEnPanel(new FRM_CLIENTES());
        }

        /// <summary>
        /// Formulario de Prestamo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            AbrirFormEnPanel(new FRM_PRESTAMOS());
        }

        /// <summary>
        /// Formulario de Pagos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            AbrirFormEnPanel(new FRM_PAGOS());
        }


        /// <summary>
        /// Formulario De Reportes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            AbrirFormEnPanel(new FRM_REPORTES());
        }


        /// <summary>
        /// Para Desplazar el panel de la Izquierda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MENU_Click(object sender, EventArgs e)
        {
            if (M_vertical.Width == 250)
            {
                M_vertical.Width = 100;
            }
            else
                M_vertical.Width = 250;
        }


        /// <summary>
        /// Restaurar los Botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Reset();
        }

 
        /// <summary>
        /// Minimizar el Formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BT_MIN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        /// <summary>
        /// Cerrar la Aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CERRAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Restaura Formulario 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_RES_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BT_RESTAURAR.Visible = false; 
            BT_MAX.Visible = true;
        }



        /// <summary>
        ///  para Maximizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_MAX1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BT_MAX.Visible = false;
            BT_RESTAURAR.Visible = true;
        }
        /// <summary>
        /// Minimizar la Pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Formulario De Estadisticas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            AbrirFormEnPanel(new FRM_ESTADISTICAS());
        }

        private void Panel_c_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
