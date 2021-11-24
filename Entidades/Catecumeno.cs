using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Catecumeno: Persona
    {
        #region Atributos
        private int id_Catecumeno;
        private int cod_Catequesis;
        #endregion
        #region Propiedades
        public int Id_Catecumeno
        {
            get { return id_Catecumeno; }
            set { id_Catecumeno = value; }
        }
        public int Cod_Catequesis
        {
            get { return cod_Catequesis; }
            set { cod_Catequesis = value; }
        }
        #endregion
        #region Constructores
        public Catecumeno()//Constructor por defecto
        {

        }
        public Catecumeno(int Id_Catecumeno, int Cod_Catequesis)//Inicializa solo su id y y el id de la catequesis
        {
            id_Catecumeno = Id_Catecumeno;
            cod_Catequesis = Cod_Catequesis;
        }
        public Catecumeno(int Du, string Nom, string Apel, string Dir, DateTime FecNac, long Tel, char Sex, int Id_Cat, int Cod_Cat) : base(Du, Nom, Apel, Dir, Tel, FecNac, Sex)
        {
            Dni = Du;
            Nombre = Nom;
            Apellido = Apel;
            Direccion = Dir;
            FechNac = FecNac;
            Telefono = Tel;
            Sexo = Sex;
            id_Catecumeno = Id_Cat;
            cod_Catequesis = Cod_Cat;



        }//Inicializa todos los atributos, y los de la base Personas tambien
        #endregion
    }
}
