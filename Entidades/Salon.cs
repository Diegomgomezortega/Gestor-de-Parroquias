using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Salon
    {
        #region Atributos
        int id_Salon;
        string nombre;
        int capacidad;
        int id_Capilla;
        #endregion
        #region Propiedades y encapsulamiento
        public int Id_Salon { get => id_Salon; set => id_Salon = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public int Id_Capilla { get => id_Capilla; set => id_Capilla = value; }
        #endregion
        #region Constructores
        public Salon()
        {

        }
        public Salon(int ID_S, string Nom, int Cap, int ID_Cap)
        {
            id_Salon = ID_S;
            nombre = Nom;
            capacidad = Cap;
            id_Capilla = ID_Cap;

        }
        #endregion
    }
}
