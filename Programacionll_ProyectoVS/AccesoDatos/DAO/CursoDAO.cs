using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programacionll_ProyectoVS.AccesoDatos.Entidades;

namespace Programacionll_ProyectoVS.AccesoDatos.DAO
{
    public class CursoDAO
    {
        //1. Crear la conexion
        private Conexion conexion = new Conexion();
        //2. Enviar el comando SQL
        SqlDataReader transaccion;  //DDL(Create, Alter, Transaction) DML(Select, Insert, Update, Delete)
        SqlCommand comando = new SqlCommand();

        //3. Metodo para insertar
        public bool InsertarCurso(curso nuevoCurso)
        {
            try
            {

                //1 abrir la conexion
                comando.Connection = conexion.abrirConexion();

                //2 crear la sentencia SQL
                comando.CommandText = "Insert into curso (nombre, descripcion, estado) " +
                    "Values('" + nuevoCurso.nombre + "', '" + nuevoCurso.descripcion + "', '" + nuevoCurso.estado + "')";

                //3 Ejecutar la sentencia Sql
                comando.ExecuteNonQuery();

                //4 Cerrar la conexion
                conexion.cerrarConexion();


                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar curso " + ex.Message);
            }
        }

        public DataTable GetListarCursos()
        {
            try
            {
                DataTable dt = new DataTable();
                //1 abrir la conexion
                comando.Connection = conexion.abrirConexion();

                //2 sentencia SQL
                comando.CommandText = "Select * from curso";
                transaccion = comando.ExecuteReader();
                dt.Load(transaccion);

                //4 Cerrar la conexion
                conexion.cerrarConexion();

                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar cursos " + ex.Message);
            }
        }
    }
}
