using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Presentacion
{
    class Class1
    {
      

      public  SqlConnection CN = new SqlConnection("Server = DESKTOP-8CA51GL\\SQLEXPRESS; DataBase= System_Lf; integrated security = true");

        /// <summary>
        /// Abrir Conexion
        /// </summary>
        public void abrir()
        {
            if (CN.State == 0)
            {
                CN.Open();
            }
        }


        /// <summary>
        /// Cerrar Conexion
        /// </summary>
        public void cerrar()
        {
            if(CN.State != 0)
            {
                CN.Close();
            }
        }


      
        
      
    



    }
}
