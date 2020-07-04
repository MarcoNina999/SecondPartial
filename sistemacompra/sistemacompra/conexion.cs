using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sistemacompra
{
    class conexion
    {
        //Cadena de Conexion
        string cadena = "data source = GAZZUCR7\\SQLEXPRESS; initial catalog = purchases; user id = sa; password = 1234";
        public SqlConnection conectar = new SqlConnection();

        public conexion()
        {
            conectar.ConnectionString = cadena;
        }
        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                conectar.Open();
                Console.WriteLine("Conexion Hecha");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error de conexion" + ex.Message);
            }
        }
        //Metodo para cerrar la conexion
        public void cerrar()
        {
            conectar.Close();
        }
    }
}
