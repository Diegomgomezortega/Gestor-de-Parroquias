using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace Datos
{
    public class DatosConexionBD
    {
        #region Atributos

        public SqlConnection conexion; //Instancio un objeto de clase SqlConnection
        //guardo en CadenaConexion el origen de la BD
        public string Cadenaconexion = "Data Source=DESKTOP-UM2AVUB\\SQLEXPRESS;Initial Catalog=GestorParroquialBD;Integrated Security=True";
        #endregion
        #region Contructor
        public DatosConexionBD() //Cuando se crea un objeto de DatosConexionBD, inicializo conexion pasando como argumento CadenaConexion
        {
            conexion = new SqlConnection(Cadenaconexion);//
        }
        #endregion
        #region Metodos de Apertura y Cierre de conexion
        public void Abrirconexion()//Metodo para abrir la conexion
        {
            try //Intento: Si la conexion esta cerrada o quebrada, abro la conexion con el metodo .Open(),
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==
                ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }
        public void Cerrarconexion() ////Metodo para cerrar la conexion
        {
            try//Intento: Si el estado de la conexion es igual a Open, ejecuta el metodo cerrar .Close;
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }
        #endregion
    }
}
