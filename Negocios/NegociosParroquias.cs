using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NegociosParroquias
    {
        DatosParroquias ObjdatosParroquias = new DatosParroquias();
        public DataSet listado(string que,string cual)
        {
            return ObjdatosParroquias.listado(que,cual);
        }

        //DatosCatecumenos objDatosCatecumeno = new DatosCatecumenos();
        //public int abmCatecumeno(string accion, Catecumeno objCatecumeno)
        //{
        //    return objDatosCatecumeno.abmCatecumeno(accion, objCatecumeno);
        //}
    }
}
