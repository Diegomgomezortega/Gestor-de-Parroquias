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
    public class NegociosSacerdotes
    {
        DatosSacerdotes ObjDatosSacerdote = new DatosSacerdotes();
        public DataSet listadoSacerdotes(string que, int cual)
        {
            return ObjDatosSacerdote.listadoSacerdotes(que, cual);
        }

        DatosSacerdotes objDatosSacerdote = new DatosSacerdotes();
        public int abmSacerdotes(string accion, Sacerdote objSacerdote)
        {
            return objDatosSacerdote.abmSacerdotes(accion, objSacerdote);
        }
    }
}
