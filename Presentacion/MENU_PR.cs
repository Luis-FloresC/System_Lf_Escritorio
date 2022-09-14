using Common.Cache;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class MENU_PR : Form
    {
        public MENU_PR()
        {
            InitializeComponent();
        }

        private void MENU_PR_Load(object sender, EventArgs e)
        {
            LB_NOMBRE.Text = Cache_Usuario.Nombre + "," + Cache_Usuario.Apellido;
            LB_CARGO.Text = Cache_Usuario.Cargo;
            LB_CORREO.Text = Cache_Usuario.Email;

            DateTime DT = new DateTime();
            DT = DateTime.Today;
            string source = DT.ToString();
            string toremove = " 00:00:00";
            string result = string.Empty;
            int j = source.IndexOf(toremove);

            if (j >= 0)
            {
                result = source.Remove(j, toremove.Length);
            }

            LB_FECHA.Text = result;
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BTN_MAXIMIZAR.Visible = false;
            BTN_RESTAURAR.Visible = true;
        }

        private void BTN_RESTAURAR_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BTN_MAXIMIZAR.Visible = true;
            BTN_RESTAURAR.Visible = false;
        }

        private void mover_Imagen(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 24, b.Location.Y - 25);
            imgSlide.SendToBack();
        }
        private void AbrirFormEnPanel(object Formhijo)
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
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            mover_Imagen(sender);
            AbrirFormEnPanel(new Editar_Perfil());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            mover_Imagen(sender);
            AbrirFormEnPanel(new FRM_CLIENTES());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            mover_Imagen(sender);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            mover_Imagen(sender);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel_c_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
