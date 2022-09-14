using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Common.Cache;

namespace Dominio
{
    public class Clientes
    {
        user_datos user_datos = new user_datos();

        private string DNI;
        private string NOMB;
        private string APE;
        private string GEN;
        private string TEL;
        private string DIRE;
        private int EST;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="DNI">Identidad</param>
        /// <param name="NOMBRE">Nombre del Cliente</param>
        /// <param name="APELLIDO">Apellido del Cliente</param>
        /// <param name="GEN">Genero del Cliente</param>
        /// <param name="TEL">telefono del Cliente</param>
        /// <param name="DIRECC">Direccion del Cliente</param>
        /// <param name="EST">Estado</param>
        public Clientes(string DNI, string NOMBRE, string APELLIDO, string GEN, string TEL, string DIRECC, int EST)
        {
            this.DNI = DNI;
            this.NOMB = NOMBRE;
            this.APE = APELLIDO;
            this.GEN = GEN;
            this.TEL = TEL;
            this.DIRE = DIRECC;
            this.EST = EST;

        }

     /// <summary>
     /// Constructor
     /// </summary>
        public Clientes()
        {

        }


        /// <summary>
        /// Guardar Datos del Cliente
        /// </summary>
        /// <returns>devuelve un msj de confirmacion</returns>
        public  string Guardar_Datos()
        {


            try
            {
                user_datos.Guardar_clientes(DNI, NOMB, APE, GEN, TEL, DIRE, EST);
                return user_datos.msg;
            }
            catch (Exception ex)
            {
                return ex + "  " +  user_datos.msg;
            }


        }

        /// <summary>
        /// Actualizar Cliente
        /// </summary>
        /// <returns>Devuelve msj de confirmacion</returns>
        public string A_CL()
        {
            try
            {
                user_datos.A_Clientes(DNI, NOMB, APE, GEN, TEL, DIRE);
                return user_datos.msg;
            }
            catch(Exception ex)
            {
               return ex + " " + user_datos.msg;
            }
        }

        /// <summary>
        /// Buscar Cliente 
        /// </summary>
        /// <param name="DNI_C">Identidad</param>
        /// <returns>Devuelve un aviso</returns>
        public bool BUSCAR_DNI(string DNI_C)
        {
            return user_datos.B_DNI(DNI_C);
        }
    }
}
