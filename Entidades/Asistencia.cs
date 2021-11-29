using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asistencia

    {
        #region Atributos
        int id_catecumeno;
        int cod_Catequesis;
        string asistencia;
        string tema;
        DateTime fecha;
        #endregion
        #region Propiedades

        public int Id_catecumeno { get => id_catecumeno; set => id_catecumeno = value; }
        public int Cod_Catequesis { get => cod_Catequesis; set => cod_Catequesis = value; }
        
        public string Tema { get => tema; set => tema = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Asistencias { get => asistencia; set => asistencia = value; }
        #endregion

        #region Constructores
        public Asistencia()
        {

        }
        public Asistencia( int ID, int Cod,string asis, string T, DateTime Fe)
        {
            id_catecumeno = ID;
            cod_Catequesis = Cod;
            asistencia = asis;
            tema = T;
            fecha = Fe;

        }
        #endregion
    }
}
