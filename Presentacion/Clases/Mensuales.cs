using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Clases
{
    class Mensuales:Prestamos
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Mensuales() { }


        /// <summary>
        /// Resumen de Prestamo Mensual
        /// </summary>
        public override void Resumen_Prestamo()
        {
            MessageBox.Show("Sr(a): " + Nombre_ + "\n" + 
                            "con Identidad: " + DNI_ + "\n" +
                            "Su Prestamo Inicia  en la Fecha: " + Fecha_I + "\n" + 
                            "y Termina  en la Fecha: " + Fecha_F  + "\n" +
                            "Solicito un Monto de: " +"Lps. " + Prestamo_ + "\n" +
                            "Cada mes debe pagar una Cuota de: " + "Lps. " + Cuota  + "."
                ,"Resumen",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
