using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Iglesia
    {
        #region Atributos
        private string nombre;
        private string patrono;
        private DateTime festividad;
        private string direccion;
        private int telefono;


        #endregion
        #region Propiedades y Encapsulamiento
        public string Nombre { get => nombre; set => nombre = value; }
        public string Patrono { get => patrono; set => patrono = value; }
        public DateTime Festividad { get => festividad; set => festividad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        #endregion

        #region Constructores
        public Iglesia()
        {

        }
        public Iglesia(string Nom, string Patr, DateTime Fest, string Dir,int Tel)//Inicializa todos sus atributos
        {
            nombre = Nom;
            patrono = Patr;
            festividad = Fest;
            direccion = Dir;
            telefono = Tel;

        }
        #endregion

    }
}
