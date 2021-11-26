using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asistencia
    {
        int id_catecumeno;
        int cod_Catequesis;
        string asistencia;
        string tema;
        DateTime fecha;

        public int Id_catecumeno { get => id_catecumeno; set => id_catecumeno = value; }
        public int Cod_Catequesis { get => cod_Catequesis; set => cod_Catequesis = value; }
        
        public string Tema { get => tema; set => tema = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Asistencias { get => asistencia; set => asistencia = value; }
    }
}
