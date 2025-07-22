using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programacionll_ProyectoVS.AccesoDatos.DAO;
using Programacionll_ProyectoVS.AccesoDatos.Entidades;

namespace Programacionll_ProyectoVS.LogicaNegocio
{
    public class InscripcionLogica
    {
        //1 acceso a la capa del Inscripcion DAO
        readonly InscripcionDAO inscripcionDAO;
        public InscripcionLogica()
        {
            inscripcionDAO = new InscripcionDAO();
        }

        public bool InsertarInscripcion(inscripcion nuevaInscripcion)
        {
            try
            {
                return inscripcionDAO.InsertarInscripcion(nuevaInscripcion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la logica al insertar inscripcion " + ex.Message);
            }

        }

        //3 crear consumo del metodo listar
        public DataTable DataListarInscripcion()
        {
            try
            {
                return inscripcionDAO.GetListarInscripciones();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la logica al listar inscripciones " + ex.Message);
            }
        }
    }
}
