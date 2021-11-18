using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Catequesis
    {
        #region Atributos
        private int id_catequesis;
        private int anoInicio;
        private string dia;
        private string hora;
        private int id_Salon;


        #endregion
        #region Propiedades Encapsulamiento
        public int Id_catequesis { get => id_catequesis; set => id_catequesis = value; }
        public int AnoInicio { get => anoInicio; set => anoInicio = value; }
        public string Dia { get => dia; set => dia = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Id_Salon { get => id_Salon; set => id_Salon = value; }
        #endregion

        #region Constructores
        public Catequesis() //Constructor por defecto, iniciliza vacio
        {

        }
        public Catequesis(int ID, int Inicio, string Dia,string hor,int IdSalon)//Iniciliaza todos sus atributos
        {
            id_catequesis = ID;
            anoInicio = Inicio;
            dia = Dia;
            hora = hor;
            id_Salon = IdSalon;
        }
        #endregion
    }
}
