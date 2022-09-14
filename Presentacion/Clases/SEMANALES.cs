using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentacion.Clases
{
    class SEMANALES:Prestamos
    {
        private static  Double INTERES_;


        /// <summary>
        /// Constructor
        /// </summary>
        public SEMANALES()
        { }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="INTERES">Interes</param>
        public SEMANALES(Double INTERES)
        {
            INTERES_ = INTERES;
        }

        /// <summary>
        /// Resumen de Prestamo
        /// </summary>
        public override void Resumen_Prestamo()
        {
            MessageBox.Show("Sr(a): " + Nombre_ + "\n" +
                            "con Identidad: " + DNI_ + "\n" +
                            "Su Prestamo Inicia  en la Fecha: " + Fecha_I + "\n" +
                            "y Termina  en la Fecha: " + Fecha_F + "\n" +
                            "Solicito un Monto de: " + "Lps. " + Prestamo_ + "\n" +
                            "Cada Semana debe pagar los intereses de: " + "Lps. " + INTERES_ + "."
                          , "Resumen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
