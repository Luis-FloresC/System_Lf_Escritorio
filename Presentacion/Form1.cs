using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Dominio;
using Common.Cache;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Se Limpiara el texto y cambiara el color de la fuente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if(txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;

            }
        }
        /// <summary>
        /// Se agregara la palabra clave al textbox y Cambia el color de fuente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Black;

            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if(txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if(txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = false;
            }
        }
        /// <summary>
        /// Cuadro de Dialogo para salir del Programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Estas seguro que quieres Salir?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)

            Application.Exit();

        }
        /// <summary>
        /// Sirve para Minimizar la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// Linea de Codigo para arrastrar El formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Linea de Codigo para arrastrar El formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Linea de Codigo para arrastrar El formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /// <summary>
        /// Metodo para Iniciar Sesion 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

           
            if(txtuser.Text != "Usuario")
            {
                if(txtpass.Text != "Contraseña")
                {
                    Usuarios user = new Usuarios();
                    var validLogin = user.login_user(txtuser.Text, txtpass.Text);
                    if(validLogin == true && txtuser.Text == Cache_Usuario.Usuario && txtpass.Text == Cache_Usuario.Contra)
                    {
                        this.Hide();
                        Frm_Bienvenid welcome = new Frm_Bienvenid();
                        welcome.ShowDialog();
                        Menu_principal menu = new Menu_principal();
                        //Editar_Perfil menu = new Editar_Perfil();
                        menu.Show();
                        menu.FormClosed += Cerrar_Sesion;
                       
                    }
                    else
                    {
                        Error("Usuario Incorrecto o Contraseña\n       Intente de nuevo");
                        txtpass.UseSystemPasswordChar = false;
                        txtpass.Text = "Contraseña";
                        txtuser.Focus();
                    }
                }
                else
                {
                    Error("Por Favor Ingrese su Contraseña");
                }
               
            }
            else
            {
                Error("Por Favor Ingrese su Usuario");
            }
        }


        /// <summary>
        /// Metodo de Activacion de errores
        /// </summary>
        /// <param name="msg"></param>
        private void Error(string msg)
        {
            Lb_error.Text = "       " + msg;
            Lb_error.Visible = true;
        }



        /// <summary>
        /// Metodo para Cerrar Sesiom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cerrar_Sesion(Object sender,FormClosedEventArgs e)
        {
            txtpass.UseSystemPasswordChar = false;
            txtpass.Text = "Contraseña";
            txtuser.Clear();
            Lb_error.Visible = false;
            this.Show() ;
            txtuser.Text = "Usuario";
        }

        /// <summary>
        /// Metodo para Recuperar Contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recuperar = new Recuperar_Contraseña();
            recuperar.ShowDialog();
        }
    }
}
