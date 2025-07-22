using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacionll_ProyectoVS.AccesoDatos.Entidades
{
    public class inscripcion
    {
        public int idInscripcion {  get; set; }
        public DateTime fechaInscripcion { get; set; }
        public int estado {  get; set; }


        //llaves foraneas
        public int? FK_Curso { get; set; }
        public int? FK_Cliente { get; set; }
    }
}
