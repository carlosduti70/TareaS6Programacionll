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
    public class CursoLogica
    {
        //1 acceso a la capa del Cliente DAO
        readonly CursoDAO cursoDAO;
        public CursoLogica()
        {
            cursoDAO = new CursoDAO();
        }

        public bool InsertarCurso(curso nuevoCurso)
        {
            try
            {
                return cursoDAO.InsertarCurso(nuevoCurso);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la logica al insertar curso " + ex.Message);
            }

        }

        //3 crear consumo del metodo listar
        public DataTable DataListarCurso()
        {
            try
            {
                return cursoDAO.GetListarCursos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la logica al listar cursos " + ex.Message);
            }
        }
    }
}
