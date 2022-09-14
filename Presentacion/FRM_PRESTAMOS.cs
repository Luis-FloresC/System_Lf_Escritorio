using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Common.Cache;
using Dominio;
using Presentacion.Clases;

namespace Presentacion
{
    public partial class FRM_PRESTAMOS : Form
    {
        
        public FRM_PRESTAMOS()
        {
            InitializeComponent();
        }

      

       /// <summary>
       /// MOSTRAR CLIENTES RECIEN REGISTRADOS
       /// </summary>
        private void mostrar()
        {
            
            DataTable DT = new DataTable();
            try
            {
                Class1 cl = new Class1();
                cl.abrir();
                SqlDataAdapter DTA = new SqlDataAdapter("SELECT DNI [Numero de Identidad],CONCAT(NOMBRE_CL,' ',APELLIDO_CL)[Nombre Completo] FROM CLIENTES WHERE COD_ESTADO = 1 order by [Nombre Completo]", cl.CN);
                DTA.Fill(DT);
                Dg2.DataSource = DT;
                var V = new int();
                V = Dg2.Rows.Count;
                label7.Text = "Total: " + V;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// CARGAR FECHA ACTUAL  Y CLIENTES
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRM_PRESTAMOS_Load(object sender, EventArgs e)
        {
            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;
            dateTimePicker1.Value = date;
            dt_fecha_i.Value = date;

            mostrar();
        }
        private string Nombre;

        /// <summary>
        /// SELECCIONAR NUMERO DE IDENTIDAD DEL CLIENTE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dg2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dg2.Rows.Count > 0)
            {
                txt_dni.Text = Dg2.CurrentRow.Cells[0].Value.ToString();
                Nombre = Dg2.CurrentRow.Cells[1].Value.ToString();
            }
        }

   
        public double MON, TASA, CAPI, CPT, INT, ISV,CUO,SA,SANT;

     /// <summary>
     /// Calcular Cuotas depende al Plazo
     /// </summary>
     /// <param name="sender"></param>
     /// <param name="e"></param>
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (cmb_plazo.Text != "SEMANAL" && cmb_plazo.Text != "QUINCENAL" && cmb_plazo.Text != "SELECCIONE")
            {
                DG1.Rows.Clear();
                CALCULO_MENSUAL();
            }
            else if (cmb_plazo.Text == "SEMANAL" || cmb_plazo.Text == "QUINCENAL")
            {
                DG1.Rows.Clear();
                CALCULO();
            }
            else
            {
                MessageBox.Show("SELECCIONE UN PLAZO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


     /// <summary>
     /// Guardar Prestamo en la base de datos
     /// </summary>
     /// <param name="sender"></param>
     /// <param name="e"></param>
        private void iconButton2_Click(object sender, EventArgs e)
        {
            string DNI = txt_dni.Text;
            try
            {
                var P_G = new PRESTAMOS(DNI: txt_dni.Text,
                        FECHA_I: dt_fecha_i.Value.ToString(),
                        FECHA_F: LB_FECHA.Text,
                        MONTO: Convert.ToDouble(txt_monto.Text),
                        INTERES_T: Convert.ToDouble(LB_INT_T.Text),
                        CAP_T: Convert.ToDouble(LB_INT_CAP_F.Text),
                        CU: Convert.ToDouble(LB_CUO.Text),
                        PLAZ: cmb_plazo.Text);
                var RESUL = P_G.GUARDAR_DATOS();
                MessageBox.Show(RESUL, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                G_PRESTAMO();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                string source = dt_fecha_i.Value.ToString();
                string toremove = " 00:00:00";
                string result = string.Empty;
                int j = source.IndexOf(toremove);

                if (j >= 0)
                {
                    result = source.Remove(j, toremove.Length);
                }

            
                FRM_REPORTE_CUOTAS fRM = new FRM_REPORTE_CUOTAS(DNI);
                Prestamos PRESTAMOS = new Prestamos(Nombre, txt_dni.Text, result, LB_FECHA.Text,decimal.Parse(txt_monto.Text),decimal.Parse(LB_CUO.Text));
                Mensuales mensuales = new Mensuales();
                Quincenales quincenales = new Quincenales(double.Parse(LB_INT.Text));
                SEMANALES semanal = new SEMANALES(double.Parse(LB_INT.Text));


                if (MessageBox.Show("¿Desea imprimir el estado de cuenta?", "Advertencia",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                { 
                    fRM.ShowDialog();
                }
                else
                {
                    switch(cmb_plazo.SelectedIndex)
                    {
                        case 4:
                            quincenales.Resumen_Prestamo();
                        break;
                        case 5:
                            semanal.Resumen_Prestamo();
                        break;
                        default:
                            mensuales.Resumen_Prestamo();
                        break;

                    }
                }
                limpiar();
                mostrar();
            }

        }
        Class1 CL1 = new Class1();

   
        /// <summary>
        /// Cerrar El Formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PN_TABLA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DG1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Limpiar Campos
        /// </summary>
        private void limpiar()
        {
            DG1.Visible = false;
            LB_CAP.Text = "****";
            LB_CUO.Text = "****";
            LB_FECHA.Text = "****";
            LB_INT.Text = "****";
            LB_INT_CAP_F.Text = "****";
            LB_INT_T.Text = "****";
            txt_dni.Clear();
            txt_monto.Clear();
            txt_tasa.Clear();
            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;
            dt_fecha_i.Value = date;
           

        }

        /// <summary>
        /// guardar todas las cuotas del prestamo
        /// </summary>
        private void G_PRESTAMO()
        {
            string MSG;
            if(DG1.Rows.Count == 0)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                string DNI = txt_dni.Text;
                try
                {
                    CL1.abrir();
                    using (var CMD = new SqlCommand())
                    {
                        CMD.Connection = CL1.CN;
                        CMD.CommandText = "G_CUOTAS";

                        foreach(DataGridViewRow row in DG1.Rows)
                        {
                            CMD.Parameters.Clear();
                            CMD.Parameters.AddWithValue("@NUM_CUOTA", Convert.ToInt32(row.Cells["COL1"].Value));
                            CMD.Parameters.AddWithValue("@DNI",DNI);
                            CMD.Parameters.AddWithValue("@FECHA_PAGO", Convert.ToString(row.Cells["COL5"].Value));
                            CMD.Parameters.AddWithValue("@CAPITAL", Convert.ToString(row.Cells["COL2"].Value));
                            CMD.Parameters.AddWithValue("@INTERES", Convert.ToString(row.Cells["COL3"].Value));
                            CMD.Parameters.AddWithValue("@CUOTA", Convert.ToString(row.Cells["COL4"].Value));
                            CMD.Parameters.AddWithValue("@SALDO", Convert.ToString(row.Cells["COL6"].Value));
                            CMD.Parameters.Add("@MSJ", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;
                            CMD.CommandType = CommandType.StoredProcedure;
                            CMD.ExecuteNonQuery();
                           
                        }
                        MSG = CMD.Parameters["@MSJ"].Value.ToString();
                        MessageBox.Show(MSG, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(Exception ex)
                {
                    txt_monto.Text = ex.Message;
                    MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
                }
            }
        }
        public int N_C,fila,R;
        

        /// <summary>
        /// Tabla de Amortizacion
        /// </summary>
        /// <param name="C">Numero de Cuota</param>
        private void Tabla_Amor(int C)
        {

            DG1.Visible = true;
            DataGridViewRow FILA = new DataGridViewRow();
            FILA.CreateCells(DG1);
            
            
            FILA.Cells[1].Value = CAPI;
            FILA.Cells[0].Value = C;
            FILA.Cells[2].Value = ISV;
            FILA.Cells[3].Value = CUO;
            
            FILA.Cells[4].Value = LB_FECHA.Text;
            FILA.Cells[5].Value = SA;
            DG1.Rows.Add(FILA);
            int V;
            V = DG1.Rows.Count;
            label13.Text = "Total" + V;
        }
        int r;

        /// <summary>
        /// Numero de Cuota
        /// </summary>
        private void NC()
        {
            if(cmb_plazo.Text == "12 MESES")
            {
                N_C = 12;
            }
            else if(cmb_plazo.Text == "15 MESES")
            {
                N_C = 15;
            }
            else if (cmb_plazo.Text == "18 MESES")
            {
                N_C = 18;
            }
            else if (cmb_plazo.Text == "24 MESES")
            {
                N_C = 24;
            }
            else if(cmb_plazo.Text == "SEMANAL")
            {
                N_C = 2;
                r = 7;
            }
            else
            {
                r = 15;
                N_C = 4;
            }
        }

        /// <summary>
        /// Calcular Prestamos Mensuales
        /// </summary>
        private void CALCULO_MENSUAL()
        {
            try
            {
                MON = Convert.ToDouble(txt_monto.Text);
                TASA = Convert.ToDouble(txt_tasa.Text);
                TASA = TASA / 100;
                NC();
                var I = new int();
                I = 1;

                SA = 0;
                while (I <= N_C)
                {
                   
                    ISV = MON * TASA;
                    INT = ISV * N_C;
                    CPT = MON + INT;
                    CUO = CPT / N_C;
                    CAPI = CUO - ISV;
                    if(I == 1)
                    {
                        SA = CPT - CUO;
                    }
                    else
                        {
                            SA = SA - CUO;
                        }
                    if(I == N_C)
                    {
                        SA = 0.00;
                    }
                    CAPI = Math.Round(Convert.ToDouble(CAPI), 2, MidpointRounding.ToEven);
                    CUO = Math.Round(Convert.ToDouble(CUO), 2, MidpointRounding.ToEven);
                    INT = Math.Round(Convert.ToDouble(INT), 2, MidpointRounding.ToEven);
                    CPT = Math.Round(Convert.ToDouble(CPT), 2, MidpointRounding.ToEven);
                    ISV = Math.Round(Convert.ToDouble(ISV), 2, MidpointRounding.ToEven);
                    SA = Math.Round(Convert.ToDouble(SA), 2, MidpointRounding.ToEven);
                    dateTimePicker1.Value = dt_fecha_i.Value.AddMonths(I);

                    
                    

                    string source = dateTimePicker1.Value.ToString();
                    string toremove = " 00:00:00";
                    string result = string.Empty;
                    int j = source.IndexOf(toremove);

                    if (j >= 0)
                    {
                        result = source.Remove(j, toremove.Length);
                    }

                    LB_FECHA.Text = result;

                    Tabla_Amor(I);
                    I++;
                   
                }


                //REDONDEO





                LB_CAP.Text = Convert.ToString(CAPI);
                LB_CUO.Text = Convert.ToString(CUO);
                LB_INT_T.Text = Convert.ToString(INT);
                LB_INT.Text = Convert.ToString(ISV);
                LB_INT_CAP_F.Text = Convert.ToString(CPT);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        /// <summary>
        /// Prestamos Semanales y Quincenales
        /// </summary>
        private void CALCULO()
        {
            try
            {
                MON = Convert.ToDouble(txt_monto.Text);
                TASA = Convert.ToDouble(txt_tasa.Text);
                TASA = TASA / 100;
                NC();
                var I = new int();
                I = 1;

                SA = 0;
                while (I <= N_C)
                {

                    ISV = MON * TASA;
                    INT = ISV * 0;
                    CPT = 0;
                    CUO = ISV;
                    CAPI = 0;
              


                    CAPI = Math.Round(Convert.ToDouble(CAPI), 2, MidpointRounding.ToEven);
                    CUO = Math.Round(Convert.ToDouble(CUO), 2, MidpointRounding.ToEven);
                    INT = Math.Round(Convert.ToDouble(INT), 2, MidpointRounding.ToEven);
                    CPT = Math.Round(Convert.ToDouble(CPT), 2, MidpointRounding.ToEven);
                    ISV = Math.Round(Convert.ToDouble(ISV), 2, MidpointRounding.ToEven);
                    SA = Math.Round(Convert.ToDouble(SA), 2, MidpointRounding.ToEven);
                    dateTimePicker1.Value = dt_fecha_i.Value.AddDays(r);
                    LB_FECHA.Text = dateTimePicker1.Value.ToString();

                    string source = dateTimePicker1.Value.ToString();
                    string toremove = " 00:00:00";
                    string result = string.Empty;
                    int j = source.IndexOf(toremove);

                    if (j >= 0)
                    {
                        result = source.Remove(j, toremove.Length);
                    }
                                                                       
                    LB_FECHA.Text = result;
                    r = r + r;



                    Tabla_Amor(I);
                    I++;

                }


                //REDONDEO

                dateTimePicker1.Value = dt_fecha_i.Value.AddMonths(N_C);
               
                LB_CAP.Text = Convert.ToString(CAPI);
                LB_CUO.Text = Convert.ToString(CUO);
                LB_INT_T.Text = Convert.ToString(INT);
                LB_INT.Text = Convert.ToString(ISV);
                LB_INT_CAP_F.Text = Convert.ToString(CPT);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
