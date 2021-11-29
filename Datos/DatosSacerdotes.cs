using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosSacerdotes : DatosConexionBD
    {
        #region Metodo ABM Sacerdote

        public int abmSacerdotes(string accion, Sacerdote objSacerdote)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
                
                orden = "insert into Sacerdotes values (" + objSacerdote.Dni + ",'" + objSacerdote.Nombre + "', '" + objSacerdote.Apellido + "', " + objSacerdote.Telefono + ",'" + objSacerdote.FechNac.Year + "/" + objSacerdote.FechNac.Date.Month + "/" + objSacerdote.FechNac.Date.Day + "', '" + objSacerdote.Sexo + "')";

            
            if (accion == "Modificar")
                orden = "update Sacerdotes set DNI=" + objSacerdote.Dni + ",Nombre='" + objSacerdote.Nombre + "',Apellido='" + objSacerdote.Apellido + "',Telefono=" + objSacerdote.Telefono + ",Fecha_nac='" + objSacerdote.FechNac.Year + "/" + objSacerdote.FechNac.Date.Month + "/" + objSacerdote.FechNac.Date.Day + "',Sexo='" + objSacerdote.Sexo + "' where Id_Sacerdote=" + objSacerdote.Id_Sacerdote + "";
            
            if (accion == "Borrar")
            
                orden = "delete from Sacerdotes  where Id_Sacerdote=" + objSacerdote.Id_Sacerdote + "";
            
            SqlCommand cmd = new SqlCommand(orden, conexion);
            {
                try
                {
                    Abrirconexion();
                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {


                    throw new Exception("Error al tratar de guardar,borrar o modificar sacerdotes", e);


                }
                finally
                {
                    Cerrarconexion();
                    cmd.Dispose();
                }
                return resultado;
            }
        }
        #endregion
        #region Listado Sacerdotes
        public DataSet listadoSacerdotes(string que, int cual)//Este método listadoAlumnos devuelve un DataSet ds con los registros solicitados,recibe un string que indica el código que deseo buscar, o si sesolicitan “Todos”
        {
            string orden = string.Empty;
            
            if (que != "Todos")
            {
                orden = "select * from Sacerdotes where Id_Sacerdote = " + cual + ";";
               

            }
            
            else
                orden = "select * from Sacerdotes";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Sacerdotes", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
        #endregion
    }
    
}
