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
    public class DatosCatequistas: DatosConexionBD
    {
        #region Metodo ABM Catequista
        public int abmCatequista(string accion, Catequista objCatequista)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
                
                orden = "insert into Catequistas values (" + objCatequista.Dni + ",'" + objCatequista.Nombre + "', '" + objCatequista.Apellido + "', " + objCatequista.Telefono + ",'" + objCatequista.FechNac.Year + "/" + objCatequista.FechNac.Date.Month + "/" + objCatequista.FechNac.Date.Day + "', '" + objCatequista.Sexo + "')";

            
            if (accion == "Modificar")
                orden = "update Catequistas set DNI=" + objCatequista.Dni + ",Nombre='" + objCatequista.Nombre + "',Apellido='" + objCatequista.Apellido + "',Telefono=" + objCatequista.Telefono + ",Fecha_nac='" + objCatequista.FechNac.Year + "/" + objCatequista.FechNac.Date.Month + "/" + objCatequista.FechNac.Date.Day + "',Sexo='" + objCatequista.Sexo + "' where Id_Catequista=" + objCatequista.Id_Catequista + "";
            
            if (accion == "Borrar")
            
                orden = "delete from Catequistas  where Id_Catequista=" + objCatequista.Id_Catequista + "";
            
            SqlCommand cmd = new SqlCommand(orden, conexion);
            {
                try
                {
                    Abrirconexion();
                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {


                    throw new Exception("Error al tratar de guardar,borrar o modificar catequistas", e);


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
        #region Listado Catequistas
        public DataSet listadoCatequistas(string que, int cual)//Este método listadoAlumnos devuelve un DataSet ds con los registros solicitados,recibe un string que indica el código que deseo buscar, o si sesolicitan “Todos”
        {
            string orden = string.Empty;
            
            if (que != "Todos")
            {
                orden = "select * from Catequistas where Id_Catequista = " + cual + ";";
                

            }
            else
            {
                orden = "select * from Catequistas";
            }
                
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
                throw new Exception("Error al listar Catequistas", e);
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
