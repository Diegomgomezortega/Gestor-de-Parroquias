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
        DatosCatecumenos ObjdatosCatecumenos = new DatosCatecumenos();
        public DataSet listadoCatecumenos(string cual)
        {
            return ObjdatosCatecumenos.listadoCatecumenos(cual);
        }
    }
}
