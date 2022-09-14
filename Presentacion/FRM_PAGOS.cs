using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Data.SqlClient;
using Dominio;
using Common.Cache;
using Presentacion.Clases;

namespace Presentacion
{
    public partial class FRM_PAGOS : Form
    {

        /// <summary>
        /// Constructor Iniciador del Login
        /// </summary>
        public FRM_PAGOS()
        {
            InitializeComponent();
        }

        private void FRM_PAGOS_Load(object sender, EventArgs e)
        {

        }
        Class1 CONEXION = new Class1();
        PAGOS PAGOS = new PAGOS();


        /// <summary>
        /// Validaciones
        /// </summary>
        /// <param name="ACCION"></param>
        private void VALIDAR(int ACCION)
        {
            if(ACCION == 1)
            {
                INFO_CLIENTE.Visible = true;
                INFO_PRESTAMO.Visible = true;
                Dg2.Visible = true;
                LB_TOTAL.Visible = true;
                BT_PAGAR.Visible = true;
                BT_PAGAR.Enabled = false;
                BT_CANCELAR.Visible = true;
            }
            else if(ACCION == 2)
            {
                INFO_CLIENTE.Visible = false;
                INFO_PRESTAMO.Visible = false;
                Dg2.Visible = false;
                LB_TOTAL.Visible = false;
                BT_PAGAR.Visible = false;
                BT_CANCELAR.Visible = false;
            }
            else if(ACCION == 3)
            {
                BT_PAGAR.Visible = false;
                BT_CANCELAR.Visible = false;
            }
            else if (ACCION == 4)
            {
                BT_PAGAR.Visible = true;
                BT_PAGAR.Enabled = true;
                BT_CANCELAR.Visible = true;
            }
        }

        /// <summary>
        /// Saldo Pendiente
        /// </summary>
        /// <param name="CUOTA"></param>
        /// <param name="PAGO"></param>
        /// <returns></returns>
        private decimal CALCULAR_SALDO_PENDIENTE(decimal CUOTA, decimal PAGO)
        {
            decimal SALDO = 0;
            SALDO = CUOTA - PAGO;
            return SALDO;
        }


        /// <summary>
        /// Buscar Cliente 
        /// </summary>
        /// <param name="DNI_TXT"></param>
        private void BUSCAR(string DNI_TXT)
        {
            decimal Monto=0, Cuota = 0;
            var VALIDAR_BUSCAR_PAGO = PAGOS.B_PAGO(DNI_TXT);
            if(VALIDAR_BUSCAR_PAGO == true)
            {
                LB_NOMBRE.Text = Cache_pagos.NOMBRE;
                LB_TELEFONO.Text = Cache_pagos.TELEFONO;
                LB_DIRECCION.Text = Cache_pagos.DIRECCION;
                Monto = Cache_pagos.MONTO;
                LB_MONTO.Text = Monto.ToString("N2");
                LB_PLAZO.Text = Cache_pagos.PLAZO;
                Cuota = Cache_pagos.CUOTA;
                LB_CUOTA.Text = Cuota.ToString("N2");
                LB_FECHA_INI.Text = Cache_pagos.FECHA_INICIAL;
                LB_FECHA_FIN.Text = Cache_pagos.FECHA_FINAL;
                LB_DNI.Text = Cache_pagos.DNI;
                MessageBox.Show("Por favor seleccione la fila de la cuota que desea pagar...","Aviso");
            }
            else
            {
                MessageBox.Show("El Cliente no Existe", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

       /// <summary>
       /// Cuotas del Cliente
       /// </summary>
       /// <param name="DNI"></param>
        private void DATAGRID_CUOTAS(String DNI)
        {

            DataTable DT = new DataTable();
            try
            {
                Class1 cl = new Class1();
                cl.abrir();
                SqlDataAdapter DTA = new SqlDataAdapter("PAGOS_CUOTAS", cl.CN);
                DTA.SelectCommand.CommandType = CommandType.StoredProcedure;
                DTA.SelectCommand.Parameters.AddWithValue("@DNI", DNI);
                DTA.Fill(DT);
                Dg2.DataSource = DT;
                var V = new int();
                V = Dg2.Rows.Count;
                LB_TOTAL.Text = "Total: " + V;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       /// <summary>
       /// Cerrar Formulario
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void BTN_CERRAR_Click(object sender, EventArgs e)
        {
          
           
            this.Close();
        }

        /// <summary>
        /// cargar datos del Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VALIDAR(1);
                BUSCAR(textBox1.Text);
                DATAGRID_CUOTAS(textBox1.Text);
              
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error, " + ex, "Aviso",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }
        public static Color COLOR1 = Color.FromArgb(255, 62, 48);
        public static Color color2 = Color.FromArgb(41, 170, 32);
        /// <summary>
        ///  CAMBIAR DE COLOR LAS FILAS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dg2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Convert.ToString(Dg2.Columns[e.ColumnIndex].Name) == "Estado")
            {
                if(e.Value != null)
                {
                    if(e.Value.GetType() != typeof(System.DBNull))
                    {

                        if ((e.Value).ToString() == "Pendiente")
                        {

                            e.CellStyle.BackColor = COLOR1;
                               
                            e.CellStyle.ForeColor = Color.White;
                        }
                        else if((e.Value).ToString() == "Pago")
                        {
                            e.CellStyle.BackColor = color2;
                            e.CellStyle.ForeColor = Color.Black;
                        }

                    }
                }
            }
        }

      
        string Efectivo;

        /// <summary>
        /// Metodo de Pago
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_PAGAR_Click(object sender, EventArgs e)
        {
            decimal SALDO_PENDIENTE = 0;
            Efectivo = Microsoft.VisualBasic.Interaction.InputBox(
               "Efectivo a Pagar: ",
               "Cambio");
            if(decimal.Parse(Efectivo) <= CUOTA)
            {
                SALDO_PENDIENTE = CALCULAR_SALDO_PENDIENTE(CUOTA, decimal.Parse(Efectivo));
            }
            else
            {
                SALDO_PENDIENTE = decimal.Parse(Efectivo) - CUOTA;
            }
            PAGOS pAGOS = new PAGOS(DNI_: LB_DNI.Text, n_CUOTA: N_CUOTA, TOTAL_PAGO: decimal.Parse(Efectivo), SALDO_PEN: SALDO_PENDIENTE);
            var RESULTADO = pAGOS.GUARDAR_PAGO();
            MessageBox.Show(RESULTADO, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VALIDAR(2);
        }

     
        string FECHA_PAGO = "";
        decimal INTE = 0, CAP = 0, CUOTA = 0;

        /// <summary>
        /// Llenar Textbox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "Escribe tu numero de Identidad";
            }
        }


        /// <summary>
        /// vaciar Textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Escribe tu numero de Identidad")
            {
                textBox1.Text = "";
            }
        }

        int N_CUOTA = 0;

        /// <summary>
        /// Selccionar una Fila del Datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dg2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
            if (Dg2.RowCount > 0)
            {
                N_CUOTA = int.Parse(Dg2.CurrentRow.Cells[0].Value.ToString());
                FECHA_PAGO = Dg2.CurrentRow.Cells[1].Value.ToString();
                CAP = decimal.Parse(Dg2.CurrentRow.Cells[2].Value.ToString());
                CUOTA = decimal.Parse(Dg2.CurrentRow.Cells[4].Value.ToString());
                INTE = decimal.Parse(Dg2.CurrentRow.Cells[3].Value.ToString());
                VALIDAR(4);
            }
            Prestamos PRESTAMOS = new Prestamos(FECHA_PAGO, INTE, CAP, CUOTA, N_CUOTA);
            PRESTAMOS.Resumen_Pago();
        }
    }
}
