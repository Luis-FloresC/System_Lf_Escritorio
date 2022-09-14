using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Servicios_Coreeo
{
    class Soporte_Email:Correos
    {

        /// <summary>
        /// Datos de Cuenta de Correo 
        /// </summary>
        public Soporte_Email()
        {
            sender_mail = "dracblack90@gmail.com";
            contraseña = "black1234drac";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            inicial_smtpClient();
        }
    }
}
