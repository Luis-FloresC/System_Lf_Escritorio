using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Clases
{
    class Quincenales:Prestamos
    {
        private static double Interes_;

        /// <summary>
        /// Constructor
        /// </summary>
        public Quincenales()
        { }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Interes">Interes</param>
        public Quincenales(double Interes)
        {
            Interes_ = Interes;
        }


        /// <summary>
        /// Resumen de Prestamo
        /// </summary>
        public new void Resumen_Prestamo()
        {
            MessageBox.Show("Sr(a): " + Nombre_ + "\n" +
                            "con Identidad: " + DNI_ + "\n" +
                            "Su Prestamo Inicia  en la Fecha: " + Fecha_I + "\n" +
                            "y Termina  en la Fecha: " + Fecha_F + "\n" +
                            "Solicito un Monto de: " + "Lps. " + Prestamo_ + "\n" +
                            "Cada 15 dias debe pagar solo los interes de: " + "Lps. " + Interes_ + "."
                          , "Resumen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
