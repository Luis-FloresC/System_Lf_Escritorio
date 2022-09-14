using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace Datos
{
    public class user_datos:Conexion
    {
        public string msg;

        /// <summary>
        /// Funcion para Editar Perfil
        /// </summary>
        /// <param name="id">codigo</param>
        /// <param name="nombre">nombre del usuario</param>
        /// <param name="apellido">apellido</param>
        /// <param name="email">correo electronico</param>
        /// <param name="contra">contraseña</param>
        /// <param name="usuario">usuario</param>
        public void editar_perfil(int id,string nombre, string apellido,string email,string contra,string usuario)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "update Usuarios set Nombre_Usuario = @user ,Contraseña = @contra,Nombre = @nombre,Apellido = @apellido,Email = @mail where ID_Usuario = @id";
                    comando.Parameters.AddWithValue("@user", usuario);
                    comando.Parameters.AddWithValue("@contra", contra);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@apellido", apellido);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@mail", email);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
        }


        /// <summary>
        /// Proceso Almacenado Guardar Prestamo
        /// </summary>
        /// <param name="DNI">Identidad</param>
        /// <param name="MONTO">Monto del prestamo</param>
        /// <param name="FECHA_IN">fecha inicial</param>
        /// <param name="FECHA_FIN">Fecha Final</param>
        /// <param name="CUOTA">Cuota</param>
        /// <param name="INT_T">Interes Total</param>
        /// <param name="T_CAP">Capital Total</param>
        /// <param name="PLAZO">Plazo</param>
        public void G_PRESTAMO(string DNI,double MONTO,string FECHA_IN,string FECHA_FIN,double CUOTA,double INT_T,double T_CAP,string PLAZO)
        {
            using (var CN = GetConnection())
            {
                CN.Open();
                using (var CMD = new SqlCommand())
                {
                    CMD.Connection = CN;
                    CMD.CommandText = "G_PRESTAMO";
                    CMD.Parameters.AddWithValue("@DNI", DNI);
                    CMD.Parameters.AddWithValue("@MONTO", MONTO);
                    CMD.Parameters.AddWithValue("@FECHA_INIC", FECHA_IN);
                    CMD.Parameters.AddWithValue("@FECHA_FIN", FECHA_FIN);
                    CMD.Parameters.AddWithValue("@CUOTA", CUOTA);
                    CMD.Parameters.AddWithValue("@INT_T", INT_T);
                    CMD.Parameters.AddWithValue("@CAP_T", T_CAP);
                    CMD.Parameters.AddWithValue("@PLAZO", PLAZO);
                    CMD.Parameters.Add("@MSJ", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.ExecuteNonQuery();
                    msg = CMD.Parameters["@MSJ"].Value.ToString();
                }
            }
        }
      
        /// <summary>
        /// Guardar Pago
        /// </summary>
        /// <param name="DNI">Identidad</param>
        /// <param name="NUM_CUOTA">Numero de Cuota</param>
        /// <param name="PAGO">Pago Total</param>
        /// <param name="SALDO_PENDIENTE">Saldo Pendiente</param>
        public void G_PAGO(string DNI,int NUM_CUOTA,Decimal PAGO,decimal SALDO_PENDIENTE)
        {
            using (var CN = GetConnection())
            {
                CN.Open();
                using (var CMD = new SqlCommand())
                {
                    CMD.Connection = CN;
                    CMD.CommandText = "G_PAGOS";
                    CMD.Parameters.AddWithValue("@DNI", DNI);
                    CMD.Parameters.AddWithValue("@NUM_CUOTA", NUM_CUOTA);
                    CMD.Parameters.AddWithValue("@PAGO", PAGO);
                    CMD.Parameters.AddWithValue("@SALDO_PENDIENTE", SALDO_PENDIENTE);
                    CMD.Parameters.Add("@AVISO", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.ExecuteNonQuery();
                    msg = CMD.Parameters["@AVISO"].Value.ToString();
                }
            }
        }

        /// <summary>
        /// Proceso Almacenado de Guardar Cliente
        /// </summary>
        /// <param name="DNI">Identidad</param>
        /// <param name="NOMBRE">Nombre del Cliente</param>
        /// <param name="APELLIDO">Apellido del Cliente</param>
        /// <param name="GEN">Genero del Cliente</param>
        /// <param name="TEL">Telefono</param>
        /// <param name="DIRECC">Direccion</param>
        /// <param name="EST">Esatdo</param>
        public void Guardar_clientes(string DNI,string NOMBRE,string APELLIDO,string GEN,string TEL,string DIRECC,int EST)
        {
            using (var CONEXION = GetConnection())
            {
                CONEXION.Open();
                using (var COMANDO = new SqlCommand())
                {
                    COMANDO.Connection = CONEXION;
                    COMANDO.CommandText = "G_CLIENTE";
                    COMANDO.Parameters.AddWithValue("@DNI", DNI);
                    COMANDO.Parameters.AddWithValue("@NOMBRE_CL", NOMBRE);
                    COMANDO.Parameters.AddWithValue("@APELLIDO_CL", APELLIDO);
                    COMANDO.Parameters.AddWithValue("@GENERO", GEN);
                    COMANDO.Parameters.AddWithValue("@TELEFONO_CL", TEL);
                    COMANDO.Parameters.AddWithValue("@DIRECCION_CL", DIRECC);
                    COMANDO.Parameters.AddWithValue("@ESTADO_CL", EST);

                    //SqlParameter MSG_PAR = new SqlParameter("@MSJ", SqlDbType.NVarChar, 150);
                    //MSG_PAR.Direction = ParameterDirection.Output;
                    COMANDO.Parameters.Add("@MSJ", SqlDbType.VarChar, 150).Direction = ParameterDirection.Output;
                    COMANDO.CommandType = CommandType.StoredProcedure;
                    COMANDO.ExecuteNonQuery();
                    msg = COMANDO.Parameters["@MSJ"].Value.ToString();
                }
            }
        }


        /// <summary>
        /// Proceso de Actulizar Cliente
        /// </summary>
        /// <param name="DNI">Identidad del Cliente</param>
        /// <param name="NOMBRE">Nombre</param>
        /// <param name="APELLIDO">Apellido</param>
        /// <param name="GEN">Genero</param>
        /// <param name="TEL">Telefono</param>
        /// <param name="DIRECC">Direccion</param>
        public void A_Clientes(string DNI, string NOMBRE, string APELLIDO, string GEN, string TEL, string DIRECC)
        {
            using (var CN = GetConnection())
            {
                CN.Open();
                using (var CMD = new SqlCommand())
                {
                    CMD.Connection = CN;
                    CMD.CommandText = "A_CLIENTES";
                    CMD.Parameters.AddWithValue("@DNI", DNI);
                    CMD.Parameters.AddWithValue("@NOMBRE_CL", NOMBRE);
                    CMD.Parameters.AddWithValue("@APELLIDO_CL", APELLIDO);
                    CMD.Parameters.AddWithValue("@GENERO", GEN);
                    CMD.Parameters.AddWithValue("@TELEFONO_CL", TEL);
                    CMD.Parameters.AddWithValue("@DIRECCION_CL", DIRECC);
                    CMD.Parameters.Add("@MSJ", SqlDbType.VarChar, 150).Direction = ParameterDirection.Output;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.ExecuteNonQuery();
                    msg = CMD.Parameters["@MSJ"].Value.ToString();
                }
            }
        }


        /// <summary>
        /// Inicio de sesion
        /// </summary>
        /// <param name="user">Usuario</param>
        /// <param name="pass">Contraseña</param>
        /// <returns></returns>
        public bool Login(string user, string pass)
        {
            
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select * from Usuarios where Nombre_Usuario = @user and Contraseña = @contra ";
                    comando.Parameters.AddWithValue("@user", user);
                    comando.Parameters.AddWithValue("@contra", pass);
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            
                            Cache_Usuario.Id_USER = reader.GetInt32(0);
                            Cache_Usuario.Usuario = reader.GetString(1);
                            Cache_Usuario.Nombre = reader.GetString(3);
                            Cache_Usuario.Apellido = reader.GetString(4);
                            Cache_Usuario.Cargo = reader.GetString(5);
                            Cache_Usuario.Email = reader.GetString(6);
                            Cache_Usuario.Contra = reader.GetString(2);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }


        /// <summary>
        /// Busqueda del cliente
        /// </summary>
        /// <param name="DNI">Identidad</param>
        /// <returns></returns>
        public bool B_DNI(string DNI)
        {
            using (var CONEXION = GetConnection())
            {
                CONEXION.Open();
                using (var CMD = new SqlCommand())
                {
                    CMD.Connection = CONEXION;
                    CMD.CommandText = "SELECT DNI,NOMBRE_CL,APELLIDO_CL,GENERO,TELEFONO_CL,DIRECCION_CL FROM CLIENTES WHERE DNI = @DNI";
                    CMD.Parameters.AddWithValue("@DNI", DNI);
                    CMD.CommandType = CommandType.Text;
                    SqlDataReader RD = CMD.ExecuteReader();
                    if(RD.HasRows)
                    {
                        while(RD.Read())
                        {
                            Cache_Clientes.DNI = RD.GetString(0);
                            Cache_Clientes.NOMBRE = RD.GetString(1);
                            Cache_Clientes.APELLIDO = RD.GetString(2);
                            Cache_Clientes.GEN = RD.GetString(3);
                            Cache_Clientes.TEL = RD.GetString(4);
                            Cache_Clientes.DIRE = RD.GetString(5);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// Recuperar Contraseña
        /// </summary>
        /// <param name="userReqerid">Usuario Requerido</param>
        /// <returns></returns>
        public string recuperar_contraseña(string userReqerid)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select * from Usuarios where Nombre_Usuario = @user or Email = @email";
                    comando.Parameters.AddWithValue("@user", userReqerid);
                    comando.Parameters.AddWithValue("@email", userReqerid);
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();
                    if(reader.Read() == true)
                    {
                        string Nombre_usuario = reader.GetString(3) + ", " + reader.GetString(4);
                        string Email = reader.GetString(6);
                        string contraseña_user = reader.GetString(2);
                        var mail_servicios = new Servicios_Coreeo.Soporte_Email();
                        mail_servicios.Enviar_Email(sujeto: "BLACKDRAC COMPANY: solicitud de recuperación de contraseña",
                            body: "Hola " + Nombre_usuario + "\nPidió recuperar su contraseña.\n" 
                            + "tu contraseña actual es: " + contraseña_user + "\nSin embargo, le pedimos que cambie su contraseña inmediatamente una vez que ingrese al sistema.",
                            receptor: new List<string> { Email });

                        return "Hola " + Nombre_usuario + "\nPidió recuperar su contraseña.\n" +
                            "Por favor revise su correo: " + Email + "\nSin embargo, le pedimos que cambie su contraseña inmediatamente una vez que ingrese al sistema.";
                    }
                    else
                    {
                        return "Lo sentimos, no tienes una cuenta con ese correo o nombre de usuario";
                    }
                }
            }
        }


        /// <summary>
        /// Permisos
        /// </summary>
        public void Permiso()
        {
            if (Cache_Usuario.Cargo == Cargos.Administrador)
            {
                //code
            }
            else if (Cache_Usuario.Cargo == Cargos.Gerente)
            {
                //code
            }
        }


        /// <summary>
        /// Buscar Pago
        /// </summary>
        /// <param name="DNI">Identidad</param>
        /// <returns></returns>
        public bool B_PAGO(string DNI)
        {
            using (var CONEXION = GetConnection())
            {
                CONEXION.Open();
                using (var CMD = new SqlCommand())
                {
                    CMD.Connection = CONEXION;
                    CMD.CommandText = "BUSCAR_PAGO";
                    CMD.Parameters.AddWithValue("@DNI", DNI);
                    CMD.CommandType = CommandType.StoredProcedure;
                    SqlDataReader RD = CMD.ExecuteReader();
                    if (RD.HasRows)
                    {
                        while (RD.Read())
                        {
                            Cache_pagos.NOMBRE = RD.GetString(0);
                            Cache_pagos.TELEFONO = RD.GetString(1);
                            Cache_pagos.DIRECCION = RD.GetString(2);
                            Cache_pagos.MONTO = RD.GetDecimal(3);
                            Cache_pagos.PLAZO = RD.GetString(4);
                            Cache_pagos.CUOTA = RD.GetDecimal(5);
                            Cache_pagos.FECHA_INICIAL = RD.GetString(6);
                            Cache_pagos.FECHA_FINAL= RD.GetString(7);
                            Cache_pagos.DNI = RD.GetString(8);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }



    }
}
