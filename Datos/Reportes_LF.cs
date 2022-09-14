using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    class Reportes_LF:Conexion
    {

        public DataTable Rep_Prestamos(string DNI_)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"Prestamo_Report";
                    command.Parameters.AddWithValue("@DNU", DNI_);
                 
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }
        }

    }
}
