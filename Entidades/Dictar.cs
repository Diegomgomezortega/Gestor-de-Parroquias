using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dictar
    {
        #region Atributos
        private int id_Catequista;
        private int id_Catequesis;
        #endregion
        #region Propiedades y Encapsulamiento
        public int Id_Catequista { get => id_Catequista; set => id_Catequista = value; }
        public int Id_Catequesis { get => id_Catequesis; set => id_Catequesis = value; }
        #endregion
        #region Constructores
        public Dictar()
        {

        }
        public Dictar(int ID_Catequista, int ID_Catequesis)
        {
            id_Catequesis = ID_Catequesis;
            id_Catequista = ID_Catequista;

        }
        #endregion
    }
}
