using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NegociosAsistencia
    {
        
        DatosAsistencia objDatosAsistencia = new DatosAsistencia();
        public int altaAsistencia( string orden)
        {
            return objDatosAsistencia.AltaAsistencia(orden);
        }

        public DataSet listadoCatequesis(string que, int cual, DateTime fecha)
        {
            return objDatosAsistencia.listadoCatequesis(que,cual,fecha);
            
        }
    }
}
