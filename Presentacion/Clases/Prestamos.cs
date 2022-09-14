using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Presentacion.Clases
{
     class Prestamos
    {
        protected static string Nombre_, DNI_,Fecha_I,Fecha_F,fecha_pago;
        protected static decimal Prestamo_,Cuota,Interes,Capital;
        protected static int num_cuota_;


        /// <summary>
        /// Constructor
        /// </summary>
        public Prestamos()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Nombre">Nombre del Cliente</param>
        /// <param name="DNI">Idnetidad</param>
        /// <param name="Fecha_I_">Fecha Inicial</param>
        /// <param name="Fecha_F_">Fecha Final</param>
        /// <param name="Prestamo">Monto del Prestamo</param>
        /// <param name="Cuota_">Cuota</param>
        public Prestamos(string Nombre,string DNI ,string Fecha_I_,string Fecha_F_,decimal Prestamo,decimal Cuota_)
        {
            Nombre_ = Nombre;
            DNI_ = DNI;
            Fecha_I = Fecha_I_;
            Fecha_F = Fecha_F_;
            Prestamo_ = Prestamo;
            Cuota = Cuota_;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Fecha_pago">Fecha De Pago de Cuota</param>
        /// <param name="Interes_">Interes</param>
        /// <param name="capital">Capital</param>
        /// <param name="Cuota_">Cuota a Pagar</param>
        /// <param name="num_cuota">Numero de Cuota a Pagar</param>
        public Prestamos( string Fecha_pago, decimal Interes_,decimal capital, decimal Cuota_,int num_cuota)
        {
           
            fecha_pago = Fecha_pago;
           
            Interes = Interes_;
            Capital = capital;
            Cuota = Cuota_;
            num_cuota_ = num_cuota;
        }

        /// <summary>
        /// Resumen del Prestamo Solicitado
        /// </summary>
        public virtual void Resumen_Prestamo()
        {

        }

        /// <summary>
        /// Resuemn de Cuota a pagar
        /// </summary>
        public void Resumen_Pago()
        {

            string CAPI, INTE, CUOTA;

            CAPI = Capital.ToString("N2");
            INTE = Interes.ToString("N2");
            CUOTA = Cuota.ToString("N2");

            MessageBox.Show("Pago de Cuota N.º"+ num_cuota_  + "\n\n" +
                            "Capital: " + CAPI + "\n" +
                            "Interes: " + INTE + "\n" +
                            "Total a Pagar: " + CUOTA + "\n" +
                            "Fecha de pago: " + fecha_pago + "\n","Aviso de Cuota",MessageBoxButtons.OK,MessageBoxIcon.Information);

           
        }


    }
}
