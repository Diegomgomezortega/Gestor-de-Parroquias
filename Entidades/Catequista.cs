using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Catequista: Persona
    {
        #region Atributos
        private int id_Catequista;
        #endregion
        #region Propiedades
        public int Id_Catequista
        {
            get { return id_Catequista; }
            set { id_Catequista = value; }
        }
        #endregion
        #region Constructores
        public Catequista()//Constructor por defecto
        {

        }
        public Catequista(int Id_Catequista)//Inicializa solo su id
        {
            id_Catequista = Id_Catequista;
            
        }
        public Catequista(int Du, string Nom, string Apel, string Dir, DateTime FecNac, long Tel, char Sex, int Id_Cat) : base(Du, Nom, Apel, Dir, Tel, FecNac, Sex)
        {
            Dni = Du;
            Nombre = Nom;
            Apellido = Apel;
            Direccion = Dir;
            FechNac = FecNac;
            Telefono = Tel;
            Sexo = Sex;
            id_Catequista = Id_Cat;
            

        }//Inicializa todos sus atributos, y los de la base Personas tambien
        #endregion
    }
}
