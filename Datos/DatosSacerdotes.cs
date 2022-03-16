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
                //orden=insert into Catecumenos values(37594703,'Diana','Pezzelato',2512644879,'1993-10-05','f',8)
                orden = "insert into Sacerdotes values (" + objSacerdote.Dni + ",'" + objSacerdote.Nombre + "', '" + objSacerdote.Apellido + "', " + objSacerdote.Telefono + ",'" + objSacerdote.FechNac.Year + "/" + objSacerdote.FechNac.Date.Month + "/" + objSacerdote.FechNac.Date.Day + "', '" + objSacerdote.Sexo + "')";

            //orden = "insert into Alumnos values (" + objalumno.Dni + ",'" + objalumno.Nombre + "','" + objalumno.Apellido + "','" + objalumno.Carrera + "','" + objalumno.Sexo + "','" + objalumno.FechNac.Year + "/" + objalumno.FechNac.Date.Month + "/" + objalumno.FechNac.Date.Day + "');"; Este es el que funciona en Alumnos
            if (accion == "Modificar")
                orden = "update Sacerdotes set DNI=" + objSacerdote.Dni + ",Nombre='" + objSacerdote.Nombre + "',Apellido='" + objSacerdote.Apellido + "',Telefono=" + objSacerdote.Telefono + ",Fecha_nac='" + objSacerdote.FechNac.Year + "/" + objSacerdote.FechNac.Date.Month + "/" + objSacerdote.FechNac.Date.Day + "',Sexo='" + objSacerdote.Sexo + "' where Id_Sacerdote=" + objSacerdote.Id_Sacerdote + "";
            //UPDATE nombre_tabla SET columna1 = valor1, columna2 = valor2 WHERE columna3 = valor3
            if (accion == "Borrar")
                //orden = "delete from Alumnos  where Legajo=" + objalumno.Legajo + "";
                orden = "delete from Sacerdotes  where Id_Sacerdote=" + objSacerdote.Id_Sacerdote + "";
            //DELETE FROM nombre_tabla WHERE nombre_columna = valor
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
        public DataSet listadoSacerdotes(string que, int cual)//Este método listadoSacerdotes devuelve un DataSet ds con los registros solicitados,recibe un string que indica el código que deseo buscar, o si sesolicitan “Todos”
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
    }
}
