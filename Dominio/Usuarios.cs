using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Common.Cache;

namespace Dominio
{
    public class Usuarios
    {

        /// <summary>
        /// Instancia de la Clase
        /// </summary>
        user_datos user_datos = new user_datos();

        private int id;
        private string usuario;
        private string conraseña;
        private string nombre;
        private string apellido;
        private string cargo;
        private string email;



        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Codigo de Usuario</param>
        /// <param name="usuario">Nombre de Usario</param>
        /// <param name="conraseña">Contraseña</param>
        /// <param name="nombre">Nombre</param>
        /// <param name="apellido">Apellido</param>
        /// <param name="cargo">Cargo del Uusario</param>
        /// <param name="email">Correo Electronico</param>
        public Usuarios(int id, string usuario, string conraseña, string nombre, string apellido, string cargo, string email)
        {
            this.id = id;
            this.usuario = usuario;
            this.conraseña = conraseña;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cargo = cargo;
            this.email = email;
        }


        /// <summary>
        /// Contructor
        /// </summary>
        public Usuarios()
        {

        }


        /// <summary>
        /// Metodo para editar Perfil
        /// </summary>
        /// <returns>Mensaje de Confirmacion</returns>
        public string editar_perfil()
        {

            try
            {
                user_datos.editar_perfil(id, nombre, apellido, email, conraseña, usuario);
                login_user(usuario, conraseña);
                return "Tu perfil se ha actualizado correctamente";
            }
            catch (Exception ex)
            {
                return ex + " El Nombre de usuario ya existe...";
            }
        }

        /// <summary>
        /// Validar inicio de sesion
        /// </summary>
        /// <param name="user">usuario</param>
        /// <param name="pass">Contraseña</param>
        /// <returns>Retorna si estan bien los datos</returns>
        public bool login_user(string user,string pass)
        {
            return user_datos.Login(user, pass);
        }

        /// <summary>
        /// Recuperar la Contraseña
        /// </summary>
        /// <param name="userReqerido">Correo Electronico o DNI</param>
        /// <returns>Retorna Mensaje de Confirmacion</returns>
        public string recuperar_contraseña(String userReqerido)
        {
            return user_datos.recuperar_contraseña(userReqerido);
        }


        /// <summary>
        /// Permisos de Administrador
        /// </summary>
        public void Permiso()
        {
            if (Cache_Usuario.Cargo == "Administrador")
            {
                //code
            }
            else if (Cache_Usuario.Cargo == "Gerente")
            {
                //code
            }
        }
    }
}
