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
    public class NegociosCatequistas
    {
        DatosCatequistas ObjDatosCatequista = new DatosCatequistas();
        public DataSet listadoCatequistas(string que, int cual)
        {
            return ObjDatosCatequista.listadoCatequistas(que, cual);
        }

        //DatosCatequistas objDatosCatequista = new DatosCatequistas();
        public int abmCatequista(string accion, Catequista objCatequista)
        {
            return ObjDatosCatequista.abmCatequista(accion, objCatequista);
        }
    }
}
