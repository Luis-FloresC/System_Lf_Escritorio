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
using Dominio;

namespace Presentacion
{
    public partial class Editar_Perfil : Form
    {
        public Editar_Perfil()
        {
            InitializeComponent();
        }

        private void Editar_Perfil_Load(object sender, EventArgs e)
        {
            Load_Edit_perfil();
         

            groupBox1.Location = new Point(216, 106);
            inicial_editar();
        }

        private void Load_Edit_perfil()
        {
            //vista
            LB_USER.Text = Cache_Usuario.Usuario;
            LB_NOMBRE.Text = Cache_Usuario.Nombre;
            LB_APELLIDO.Text = Cache_Usuario.Apellido;
            LB_EMAIL.Text = Cache_Usuario.Email;
            LB_CARGO.Text = Cache_Usuario.Cargo;
            //Panel
            txtuser.Text = Cache_Usuario.Usuario;
            txtnombre.Text = Cache_Usuario.Nombre;
            txt_apellido.Text = Cache_Usuario.Apellido;
            txt_email.Text = Cache_Usuario.Email;
            txt_contra.Text = Cache_Usuario.Contra;
            txt_confirmar.Text = Cache_Usuario.Contra;
            txt_actual.Text = "";
        }
        private void inicial_editar()
        {
            LINK_EDIPASS.Text = "Editar";
            txt_contra.Enabled = false;
            txt_contra.UseSystemPasswordChar = true;
            txt_confirmar.Enabled = false;
            txt_confirmar.UseSystemPasswordChar = true;
            txt_actual.UseSystemPasswordChar = true;
        }

        private void reset()
        {
            Load_Edit_perfil();
            inicial_editar();
            groupBox1.Location = new Point(216, 106);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
           
            groupBox1.Location = new Point(5, 97);
            Load_Edit_perfil();
        }

        private void LINK_EDIPASS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LINK_EDIPASS.Text == "Editar")
            {
                LINK_EDIPASS.Text = "Cancelar";
                txt_contra.Enabled = true;
                txt_contra.Text = "";
                txt_confirmar.Enabled = true;
                txt_confirmar.Text = "";
            }
            else if (LINK_EDIPASS.Text == "Cancelar")
            {
                reset();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_contra.Text.Length >= 5)
            {
                if (txt_contra.Text == txt_confirmar.Text)
                {
                    if (txt_actual.Text == Cache_Usuario.Contra)
                    {
                              var user_model = new Usuarios(
                        id: Cache_Usuario.Id_USER,
                        usuario: txtuser.Text,
                        conraseña: txt_contra.Text,
                        nombre: txtnombre.Text,
                        apellido: txt_apellido.Text,
                        cargo: null,
                        email: txt_email.Text);
                             var resul = user_model.editar_perfil();
                    MessageBox.Show(resul);
                    reset();
                    panel1.Visible = false;
                }
                else
                    MessageBox.Show("La contraseña es incorrecta,Vuela a intentar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                /*Ultima*/
            }
            else
            {
                MessageBox.Show("La contraseña no coincide,Vuela a intentar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
            else
                MessageBox.Show("La contraseña debe tener minimo 5 caracteres,Vuela a intentar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            reset();
        }

        private void BTN_CERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
