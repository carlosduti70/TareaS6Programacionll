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
    public class InscripcionDAO
    {
        //1. Crear la conexion
        private Conexion conexion = new Conexion();
        //2. Enviar el comando SQL
        SqlDataReader transaccion;  //DDL(Create, Alter, Transaction) DML(Select, Insert, Update, Delete)
        SqlCommand comando = new SqlCommand();

       


        //3. Metodo para insertar
        public bool InsertarInscripcion(inscripcion nuevaInscripcion)
        {
            try
            {
                string fechaSql = nuevaInscripcion.fechaInscripcion.ToString("yyyy-MM-dd HH:mm:ss");

                //1 abrir la conexion
                comando.Connection = conexion.abrirConexion();

                //2 crear la sentencia SQL con todos los campos necesarios
                comando.CommandText = "INSERT INTO inscripcion (fecha_Inscripcion, estado, FK_Curso, FK_Cliente) " +
                                      "VALUES ('" + fechaSql + "', '" + nuevaInscripcion.estado + "', '" +
                                      nuevaInscripcion.FK_Curso + "', '" + nuevaInscripcion.FK_Cliente + "')";

                //3 Ejecutar la sentencia Sql
                comando.ExecuteNonQuery();

                //4 Cerrar la conexion
                conexion.cerrarConexion();


                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar inscripcion " + ex.Message);
            }
        }

        public DataTable GetListarInscripciones()
        {
            try
            {
                DataTable dt = new DataTable();
                //1 abrir la conexion
                comando.Connection = conexion.abrirConexion();

                //2 sentencia SQL
                comando.CommandText = "Select * from inscripcion";
                transaccion = comando.ExecuteReader();
                dt.Load(transaccion);

                //4 Cerrar la conexion
                conexion.cerrarConexion();

                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar inscripciones " + ex.Message);
            }
        }

        public bool EliminarInscripcion(int idInscripcion)
        {
            try
            {
                //1 abrir la conexion
                comando.Connection = conexion.abrirConexion();

                //2 crear la sentencia SQL para eliminar
                comando.CommandText = "DELETE FROM inscripcion WHERE idInscripcion = '" + idInscripcion + "'";

                //3 ejecutar
                int filasAfectadas = comando.ExecuteNonQuery();

                //4 cerrar la conexion
                conexion.cerrarConexion();

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la inscripción: " + ex.Message);
            }
        }

    }
}
