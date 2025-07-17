using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacionll_ProyectoVS.AccesoDatos.Entidades
{
    public class Cliente
    {
        public int idCliente {get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public int estado { get; set; }
    }
}
