using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos
        private int dni;
        private string nombre;
        private string apellido;
        private string direccion;
        private int telefono;
        private DateTime Fecha_nac;
        private char sexo;
        #endregion
        #region Propiedades Encapsulamiento

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public DateTime FechNac
        {
            get { return Fecha_nac; }
            set { Fecha_nac = value; }
        }
        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        #endregion
        #region Constructores
        public Persona()//por defecto
        { }
        public Persona(int Dni, string Nom, string Apel, string Dir, int Tel, DateTime FecNac, char Sex)//Contructor hecho por programador
        {

            nombre = Nom;
            dni = Dni;
            apellido = Apel;
            direccion = Dir;
            telefono = Tel;
            Fecha_nac = FecNac;
            sexo = Sex;
        }
        #endregion
        #region Metodos
        public int Edad()
        {
            int edad;
            edad = FechNac.Year - DateTime.Now.Year;
            return edad;
        }
        #endregion
    }
}
