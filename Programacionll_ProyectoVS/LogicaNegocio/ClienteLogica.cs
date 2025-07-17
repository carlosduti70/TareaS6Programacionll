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
    public class ClienteLogica
    {
        //1 acceso a la capa del Cliente DAO
        readonly ClienteDAO clienteDAO;
            public ClienteLogica() { 
            clienteDAO = new ClienteDAO();
        }

        public bool InsertarCliente(Cliente nuevoCliente)
        {
            try {
                return clienteDAO.InsertarCliente(nuevoCliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la logica al insertar cliente " + ex.Message);
            }

        }

        //3 crear consumo del metodo listar
        public DataTable DataListarCliente (){
            try
            {
                return clienteDAO.GetListarCliente();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la logica al listar cliente " + ex.Message);
            }
        }
    }
}
