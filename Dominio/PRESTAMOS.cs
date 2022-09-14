using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Common.Cache;

namespace Dominio
{
   public class PRESTAMOS
    {
        user_datos user_datos = new user_datos();

        private string DNI;
        private double MONTO;
        private string FECHA_INI;
        private string FECHA_FIN;
        private double CAPITAL_T;
        private double INTERES_T;
        private double CUOTA;
        private string PLAZO;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="DNI">Identidad</param>
        /// <param name="FECHA_I">Fecha de Inicio</param>
        /// <param name="FECHA_F">Fecha final</param>
        /// <param name="MONTO">Monto del Prestamo</param>
        /// <param name="INTERES_T">Interes Total</param>
        /// <param name="CAP_T">Capital Total</param>
        /// <param name="CU">Cuota del Prestamo</param>
        /// <param name="PLAZ">Plazo</param>
        public PRESTAMOS(string DNI, string FECHA_I,string FECHA_F,double MONTO,double INTERES_T,double CAP_T,double CU,string PLAZ)
        {
            string source = FECHA_I;
            string toremove = " 00:00:00";
            string result = string.Empty;
            int j = source.IndexOf(toremove);

            if (j >= 0)
            {
                result = source.Remove(j, toremove.Length);
            }

            this.DNI = DNI;
            this.MONTO = MONTO;
            this.FECHA_INI = result;
            this.FECHA_FIN = FECHA_F;
            this.CAPITAL_T = CAP_T;
            this.INTERES_T = INTERES_T;
            this.CUOTA = CU;
            this.PLAZO = PLAZ;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public PRESTAMOS()
        {

        }
    
        /// <summary>
        /// Guardar Prestamo
        /// </summary>
        /// <returns>Mensaje de Confirmacion</returns>
        public string GUARDAR_DATOS()
        {
            try
            {
                
                user_datos.G_PRESTAMO(DNI, MONTO, FECHA_INI, FECHA_FIN, CUOTA,INTERES_T,CAPITAL_T,PLAZO);
                return user_datos.msg;
            }
            catch(Exception EX)
            {
                return EX + " " + user_datos.msg;
            }
        }
    }
}
