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
    public partial class FRM_CLIENTES : Form 
    {
        public FRM_CLIENTES()
        {
            InitializeComponent();
        }

  

        private void FRM_CLIENTES_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Funcion para Limpiar los Campos
        /// </summary>
        public void limpiar()
        {
            txt_ape.Clear();
            txt_dire.Clear();
            txt_dni.Clear();
            txt_nom.Clear();
            txt_tel.Clear();
            CMB_GEN.Text = "SELECCIONE";
            textBox1.Clear();
            comboBox1.Text = "SELECCIONE";
        }


        /// <summary>
        /// Funcion para Desactivar Los campos
        /// </summary>
        public void DISABLE_CAM()
        {
            txt_ape.Clear();
            txt_dire.Clear();
            txt_dni.Clear();
            txt_nom.Clear();
            txt_tel.Clear();
            CMB_GEN.Text = "SELECCIONE";
            txt_ape.Enabled = false;
            txt_dire.Enabled = false;
            txt_dni.Enabled = false;
            txt_nom.Enabled = false;
            txt_tel.Enabled = false;
            CMB_GEN.Enabled = false;

        }

        /// <summary>
        /// Activar los Campos
        /// </summary>
        public void ACTIVE_CAM()
        {
            txt_ape.Enabled = true;
            txt_dire.Enabled = true;
            txt_dni.Enabled = true;
            txt_nom.Enabled = true;
            txt_tel.Enabled = true;
            CMB_GEN.Enabled = true;
        }


        /// <summary>
        /// Validacion de Campos Vacios
        /// </summary>
        public void DISABLE_MSG()
        {
            LB_ERROR_APE.Visible = false;
            LB_ERROR_DIRE.Visible = false;
            Lb_error_DND.Visible = false;
            LB_ERROR_GEN.Visible = false;
            LB_ERROR_NOMBRE.Visible = false;
        }
   
        /// <summary>
        /// Guardar Datos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Guardar_Click(object sender, EventArgs e)
        {
            if(txt_dni.Text == "" && txt_nom.Text == "" && txt_ape.Text == "" && CMB_GEN.Text == "SELECCIONE" && txt_dire.Text == "")
            {
                LB_ERROR_APE.Visible = true;
                LB_ERROR_DIRE.Visible = true;
                Lb_error_DND.Visible = true;
                LB_ERROR_GEN.Visible = true;
                LB_ERROR_NOMBRE.Visible = true;
            }
            else if (txt_dni.Text == "")
            {
                Lb_error_DND.Visible = true;

            }
            else if (txt_nom.Text == "")
            {
                if (txt_dni.Text != "")
                {
                    DISABLE_MSG();
                }
                LB_ERROR_NOMBRE.Visible = true;
            }
            else if (txt_ape.Text == "")
            {
                if (txt_nom.Text != "")
                {
                    DISABLE_MSG();
                }
                LB_ERROR_APE.Visible = true;
            }
            else if(CMB_GEN.Text == "SELECCIONE")
            {
                if (txt_ape.Text != "")
                {
                    DISABLE_MSG();
                }
                LB_ERROR_GEN.Visible = true;
            }
            else if(txt_dire.Text == "")
            {
                if (CMB_GEN.Text != "SELECCIONE")
                {
                    DISABLE_MSG();
                }
                LB_ERROR_DIRE.Visible = true;
            }
            else
            {

                DISABLE_MSG();
                var Cl = new Clientes(DNI: txt_dni.Text,
                                      NOMBRE: txt_nom.Text,
                                      APELLIDO: txt_ape.Text,
                                      GEN: CMB_GEN.Text,
                                      TEL: txt_tel.Text,
                                      DIRECC: txt_dire.Text,
                                      EST: 1);
                var RESUL = Cl.Guardar_Datos();
                MessageBox.Show(RESUL, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DISABLE_CAM();
            }
        }

        /// <summary>
        /// Activar los Campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton1_Click(object sender, EventArgs e)
        {
            ACTIVE_CAM();
        }



        /// <summary>
        /// BUSCAR CLIENTE POR NUMERO DE IDNETIDAD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BUSCAR_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Nº DE IDENTIDAD")
            {
                Buscar_DNI();
            }
        }


        /// <summary>
        /// PROCESO ALMACENADO DE BUSCAR
        /// </summary>
        public void Buscar_DNI()
        {
            Clientes CL = new Clientes();
            var VAL_BUS = CL.BUSCAR_DNI(textBox1.Text);
            if (VAL_BUS == true)
            {
                ACTIVE_CAM();
                txt_nom.Text = Cache_Clientes.NOMBRE;
                txt_dni.Text = Cache_Clientes.DNI;
                txt_ape.Text = Cache_Clientes.APELLIDO;
                if(Cache_Clientes.GEN == "M")
                {
                    CMB_GEN.Text = "Masculino";

                }
                else
                {
                    CMB_GEN.Text = "Femenino";   
                }
                txt_tel.Text = Cache_Clientes.TEL;
                txt_dire.Text = Cache_Clientes.DIRE;
            }
            else
            {
                limpiar();
                MessageBox.Show("NO SE ENCONTRO EL CLIENTE", "SISTEMA LF");
            }
        }


        /// <summary>
        /// AGREGAR GUION (-) A DNI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txt_dni.Text.Length == 4 )
            {
                txt_dni.AppendText("-");
            }
            else if(txt_dni.Text.Length == 9)
            {
                txt_dni.AppendText("-");
            }

        }


        /// <summary>
        /// DESACTIVAR TODOS LOS CAMPOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IC_CANCELAR_Click(object sender, EventArgs e)
        {
            DISABLE_CAM();
        }

        /// <summary>
        /// LIMPIAR TODOS LOS CAMPOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IC_LIMPIAR_Click(object sender, EventArgs e)
        {
            limpiar();
        }


        /// <summary>
        /// ACTULIZAR DATOS DEL CLIENTE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (txt_dni.Text == "" && txt_nom.Text == "" && txt_ape.Text == "" && CMB_GEN.Text == "SELECCIONE" && txt_dire.Text == "")
            {
                LB_ERROR_APE.Visible = true;
                LB_ERROR_DIRE.Visible = true;
                Lb_error_DND.Visible = true;
                LB_ERROR_GEN.Visible = true;
                LB_ERROR_NOMBRE.Visible = true;
            }
            else if (txt_dni.Text == "")
            {
                Lb_error_DND.Visible = true;

            }
            else if (txt_nom.Text == "")
            {
                if (txt_dni.Text != "")
                {
                    DISABLE_MSG();
                }
                LB_ERROR_NOMBRE.Visible = true;
            }
            else if (txt_ape.Text == "")
            {
                if (txt_nom.Text != "")
                {
                    DISABLE_MSG();
                }
                LB_ERROR_APE.Visible = true;
            }
            else if (CMB_GEN.Text == "SELECCIONE")
            {
                if (txt_ape.Text != "")
                {
                    DISABLE_MSG();
                }
                LB_ERROR_GEN.Visible = true;
            }
            else if (txt_dire.Text == "")
            {
                if (CMB_GEN.Text != "SELECCIONE")
                {
                    DISABLE_MSG();
                }
                LB_ERROR_DIRE.Visible = true;
            }
            else
            {

                DISABLE_MSG();
                var Cl = new Clientes(DNI: txt_dni.Text,
                                      NOMBRE: txt_nom.Text,
                                      APELLIDO: txt_ape.Text,
                                      GEN: CMB_GEN.Text,
                                      TEL: txt_tel.Text,
                                      DIRECC: txt_dire.Text,
                                      EST: 1);
                var RESUL = Cl.A_CL();
                MessageBox.Show(RESUL, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DISABLE_CAM();
                limpiar();
            }
        }

        /// <summary>
        /// LISTA DE TODOS LOS CLIENTES
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MOSTRAR_Click(object sender, EventArgs e)
        {
            FRM_Lista__de_Clientes CLM = new FRM_Lista__de_Clientes();
            CLM.Show();
        }

        /// <summary>
        /// CERRAR FORMULARIO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CERRAR_Click(object sender, EventArgs e)
        {

            
            this.Close();

        }
    }
}
