﻿using Datos;
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
        DatosAsistencia ObjDatosAsistencia = new DatosAsistencia();
        //public DataSet listadoAsistencia(string que, int cual)
        //{
        //    return ObjDatosAsistencia.listadoAsistencia(que, cual);
        //}

        DatosAsistencia objDatosAsistencia = new DatosAsistencia();
        public int altaAsistencia( string orden)
        {
            return objDatosAsistencia.AltaAsistencia(orden);
        }
    }
}
