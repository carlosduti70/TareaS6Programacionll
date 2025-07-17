using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacionll_ProyectoVS.AccesoDatos
{
    public class Conexion
    {
        //conection string
        private SqlConnection ConectionDB = new SqlConnection("Server=CarlosZ\\SQLEXPRESS; Database=CursosDB; Integrated Security= true; Trusted_Connection=True");
        
        //Abrir la conexion
        public SqlConnection abrirConexion()
        {
            if(ConectionDB.State == ConnectionState.Closed)
                ConectionDB.Open();
            return ConectionDB;
        }

        //cerrar la conexion
        public SqlConnection cerrarConexion() {
            if (ConectionDB.State == ConnectionState.Open)
                ConectionDB.Close();
            return ConectionDB;
        }

    }
}
