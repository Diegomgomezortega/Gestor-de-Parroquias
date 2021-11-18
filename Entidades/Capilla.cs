using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Capilla:Iglesia
    {
        #region Atributos
        private int id_Capilla;
        private int id_Parroquia;
        private int id_Sacerdote;
        #endregion

        #region Propiedades y Encapsulamiento
        public int Id_Capilla { get => id_Capilla; set => id_Capilla = value; }
        public int Id_Parroquia { get => id_Parroquia; set => id_Parroquia = value; }
        public int Id_Sacerdote { get => id_Sacerdote; set => id_Sacerdote = value; }
        #endregion

        #region Constructores
        public Capilla()//Iniciliza en nulos sus atributos
        {

        }
        public Capilla(int ID_Cap, int ID_Par, int ID_Sac)//Inicializo solos los atributos propios de capilla
        {
            id_Capilla = ID_Cap;
            id_Parroquia = ID_Par;
            id_Sacerdote = ID_Sac;

        }
        public Capilla(int ID_Cap, int ID_Par, int ID_Sac, string Nom, string Patr, DateTime Fest, string Dir, int Tel) : base(Nom, Patr, Fest, Dir, Tel)//inicializo todos los atributos, incluido los de la base
        {
            id_Capilla = ID_Cap;
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
