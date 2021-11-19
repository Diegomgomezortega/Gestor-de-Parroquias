using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Parroquia: Iglesia
    {

        #region Atributos
        private int id_Parroquia;
        private int id_Sacerdote;
        #endregion
        #region Propiedades y encapsulamiento
        public int Id_Parroquia { get => id_Parroquia; set => id_Parroquia = value; }
        public int Id_Sacerdote { get => id_Sacerdote; set => id_Sacerdote = value; }
        #endregion
        #region Constructores
        public Parroquia() //Inicializo nulos los atributos
        {

        }
        public Parroquia(int ID_Par, int ID_Sac)//inicializo solo los atributos propios
        {
            id_Parroquia = ID_Par;
            id_Sacerdote = ID_Sac;

        }

        public Parroquia(int ID_Par, int ID_Sac, string Nom, string Patr, DateTime Fest, string Dir, int Tel): base(Nom, Patr, Fest, Dir, Tel)//inicializo todos los atributos, incluido los de la base
        {
            id_Parroquia = ID_Par;
            id_Sacerdote = ID_Sac;
            Nombre = Nom;
            Patrono = Patr;
            Festividad = Fest;
            Direccion = Dir;
            Telefono = Tel;

        }
        #endregion
    }
}
