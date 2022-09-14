using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public abstract class Conexion
    {
        private readonly string conexion_st;

        /// <summary>
        /// Cadena de Conexion
        /// </summary>
        public Conexion()
        {
            conexion_st = @"Server = DESKTOP-8CA51GL\SQLEXPRESS; DataBase= System_Lf; integrated security = true";

        }

        /// <summary>
        /// Obtener la conexion
        /// </summary>
        /// <returns><Cadena de Conexion</returns>
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(conexion_st);
        }


    }
}
