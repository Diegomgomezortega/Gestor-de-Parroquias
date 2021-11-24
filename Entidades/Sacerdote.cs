using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sacerdote: Persona
    {
        private int id_Sacerdote;

        public int Id_Sacerdote { get => id_Sacerdote; set => id_Sacerdote = value; }

        public Sacerdote()
        {

        }
        public Sacerdote(int ID_Sac)
        {
            id_Sacerdote = ID_Sac;
        }
        public Sacerdote(int Du, string Nom, string Apel, string Dir, DateTime FecNac, long Tel, char Sex, int Id_Sac) : base(Du, Nom, Apel, Dir, Tel, FecNac, Sex)
        {

            Dni = Du;
            Nombre = Nom;
            Apellido = Apel;
            Direccion = Dir;
            FechNac = FecNac;
            Telefono = Tel;
            Sexo = Sex;
            id_Sacerdote = Id_Sac;

        }
    }
}
