using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
   public class PAGOS
    {
        user_datos USER_DATOS = new user_datos();

        private String DNI;
        private int NUM_CUOTA;
        private Decimal PAGO, SALDO_PENDIENTE;

        /// <summary>
        /// Constructor
        /// </summary>
        public PAGOS()
        {
            
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="DNI_">Identidad</param>
        /// <param name="n_CUOTA">Numero de Cuota</param>
        /// <param name="TOTAL_PAGO">Total de Pago</param>
        /// <param name="SALDO_PEN">Saldo Pendiente</param>
        public PAGOS(string DNI_,int n_CUOTA,decimal TOTAL_PAGO,decimal SALDO_PEN)
        {
            DNI = DNI_;
            NUM_CUOTA = n_CUOTA;
            PAGO = TOTAL_PAGO;
            SALDO_PENDIENTE = SALDO_PEN;
        }

        /// <summary>
        /// Guardar Pago
        /// </summary>
        /// <returns></returns>
        public string GUARDAR_PAGO()
        {
            try
            {
                USER_DATOS.G_PAGO(DNI,NUM_CUOTA,PAGO,SALDO_PENDIENTE);
                return USER_DATOS.msg;
            }
            catch (Exception ex)
            {
                return ex + "  " + USER_DATOS.msg;
            }
        }

        /// <summary>
        /// Buscar Pago del Cliente
        /// </summary>
        /// <param name="DNI"></param>
        /// <returns></returns>
        public bool B_PAGO(string DNI)
        {
            return USER_DATOS.B_PAGO(DNI);
        }

    }
}
