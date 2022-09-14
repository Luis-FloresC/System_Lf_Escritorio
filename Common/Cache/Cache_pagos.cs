using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class Cache_pagos
    {

        /// <summary>
        /// Datos de Memoria cache
        /// </summary>
        
        public static string DNI { get; set; }
        public static string NOMBRE { get; set; }

        public static string DIRECCION { get; set; }

        public static string TELEFONO { get; set; }

        public static decimal MONTO { get; set; }

        public static decimal CUOTA { get; set; }

        public static string FECHA_INICIAL { get; set; }

        public static string FECHA_FINAL { get; set; }

        public static string PLAZO { get; set; }


    }
}
