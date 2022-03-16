using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;

namespace Negocios
{
    public class NegociosCatecumenos
    {
        //DatosCatecumenos ObjdatosCatecumenos = new DatosCatecumenos();
        

        DatosCatecumenos objDatosCatecumeno = new DatosCatecumenos();
        public int abmCatecumeno(string accion, Catecumeno objCatecumeno)
        {
            return objDatosCatecumeno.abmCatecumeno(accion, objCatecumeno);
        }
        public DataSet listadoCatecumenos(string que, int cual)
        {
            return objDatosCatecumeno.listadoCatecumenos(que, cual);
        }


    }

}
