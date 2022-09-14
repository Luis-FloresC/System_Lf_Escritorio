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
using System.Collections;

namespace Presentacion
{
    public partial class FRM_ESTADISTICAS : Form
    {
        public FRM_ESTADISTICAS()
        {
            InitializeComponent();
        }

        /// <summary>
        /// GENERAR ESTADISTICA DE LOS PRESTAMOS
        /// </summary>
        private void Estadisticas()
        {
            Class1 CL = new Class1();
            using (var CONEXION = CL.CN)
            {
                CONEXION.Open();
                using (var COMANDO = new SqlCommand())
                {
                    COMANDO.Connection = CONEXION;
                    COMANDO.CommandText = "Estadisticas";
                    COMANDO.Parameters.Add("@TOT_CL", SqlDbType.Int,0).Direction = ParameterDirection.Output;
                    COMANDO.Parameters.Add("@TOT_S", SqlDbType.Int, 0).Direction = ParameterDirection.Output;
                    COMANDO.Parameters.Add("@TOT_M", SqlDbType.Int, 0).Direction = ParameterDirection.Output;
                    COMANDO.Parameters.Add("@TOT_Q", SqlDbType.Int, 0).Direction = ParameterDirection.Output;
                    COMANDO.Parameters.Add("@TOT_P", SqlDbType.Int, 0).Direction = ParameterDirection.Output;
                    COMANDO.CommandType = CommandType.StoredProcedure;
                    COMANDO.ExecuteNonQuery();
                    LB_CANT_M.Text = COMANDO.Parameters["@TOT_M"].Value.ToString();
                    LB_CAN_CLIENTES.Text = COMANDO.Parameters["@TOT_CL"].Value.ToString();
                    LB_S.Text = COMANDO.Parameters["@TOT_S"].Value.ToString();
                    LB_P.Text = COMANDO.Parameters["@TOT_P"].Value.ToString();
                    LB_Q.Text = COMANDO.Parameters["@TOT_Q"].Value.ToString();
                }
            }
        }

        ArrayList Plazo = new ArrayList();
        ArrayList Cant = new ArrayList();


        /// <summary>
        /// GENERAR GRAFICO DE PRESTAMOS
        /// </summary>
        private void PLAZOS()
        {
            Class1 CL = new Class1();
           SqlCommand cmd = new SqlCommand("Grafica_Prestamos", CL.CN);
            cmd.CommandType = CommandType.StoredProcedure;
            CL.CN.Open();
           SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Plazo.Add(dr.GetString(0));
                Cant.Add(dr.GetDouble(1));
            }
            chart1.Series[0].Points.DataBindXY(Plazo, Cant);
            dr.Close();
            CL.CN.Close();
        }


        /// <summary>
        /// METODO DE CARGAR DE FORMULARIO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRM_ESTADISTICAS_Load(object sender, EventArgs e)
        {
            try
            {
                Estadisticas();
                PLAZOS();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error," + ex.Message, "Aviso");
            }
        }

       
    }
}
