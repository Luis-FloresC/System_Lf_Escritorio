using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
     class Reportes:Class1
    {
        private static string Identidad;
        public Reportes()
        {

        }
        public Reportes(string Dato)
        {
            Identidad = Dato;
        }

        string QUERY = ("SELECT" +
               "C.ID," +
               "C.DNI," +
               "CONCAT(C.NOMBRE_CL,' ', C.APELLIDO_CL)[Nombre_Completo]," +
               "CC.NUM_CUOTA," +
               "CC.FECHA_PAGO," +
               "CC.CAPITAL," +
               "CC.INTERES," +
               "CC.CUOTA," +
               "CC.SALDO," +
               "P.FECHA_INIC," +
               "P.FECHA_FIN," +
               "P.CAPITAL_TOT," +
               "P.MONTO" +
               "FROM CLIENTES C" +
               "JOIN PRESTAMOS P ON P.DNI = C.DNI" +
               "JOIN CUOTAS CC ON CC.DNI = P.DNI" + "WHERE C.DNI = '" + Identidad + "'");

        public void Imprimir_Reporte()
        {
            abrir();
            Consultar("Reports_Prestamo",Identidad);
            FRM_REPORTE_CUOTAS fRM_REPORTE = new FRM_REPORTE_CUOTAS("Report1.rdlc");
            fRM_REPORTE.Show();
        }
    }
}
