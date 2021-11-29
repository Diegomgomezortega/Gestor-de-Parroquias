using System;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class DatosAsistencia: DatosConexionBD
    {
        #region Alta de Asistencias y Get por fechas
        public int AltaAsistencia( string orden)
        {
            int resultado = -1;
                      
            SqlCommand cmd = new SqlCommand(orden, conexion);
            {
                try
                {
                    Abrirconexion();
                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {


                    throw new Exception("Error al tratar de guardar los datos", e);


                }
                finally
                {
                    Cerrarconexion();
                    cmd.Dispose();
                }
                return resultado;
            }
        }
        public DataSet listadoCatequesis(string que, int cual)
        {
            string orden = string.Empty;
            if (que == "Todos")//Trae todos los catecumenos
            {
                orden= "select c.Id_Catequesis,cap.Nombre, s.Nombre, c.Hora from Catequesis c, Salones s,Capillas cap where cap.Id_Capilla = s.Id_Capilla and c.Id_salon = s.Id_Salon";

            }
            if (que =="UnaCatequesis")//Solo un salon
            {
                orden = "select b.Id_Catecumeno, b.Nombre,b.Apellido, c.Nombre from Catequesis a, Catecumenos b, Catequistas c, Dictar d where b.Cod_Catequesis=a.Id_Catequesis and a.Id_Catequesis=d.Id_Catequesis and d.Id_Catequista=c.Id_Catequista and a.Id_Catequesis=" + cual + ";";

            }
            if (que == "Fechas")//De acuerdo a la fecha
            {
                orden = "select distinct Fecha from Asistencia a, Catequesis c where c.Id_Catequesis=" + cual + " and a.Id_Catequesis=c.Id_Catequesis";
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
                throw new Exception("Error al listar", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

        public DataSet listadoCatequesis(string que, int cual, DateTime fecha)//Sobrecarga del método ListoadoCatequesis
        {
            string orden = string.Empty;
            
            if (que == "Tema")
            {
                orden = "select b.Id_Catecumeno, b.Nombre,b.Apellido,e.Asistencia, e.Tema  from Catequesis a, Catecumenos b, Asistencia e where b.Cod_Catequesis=a.Id_Catequesis and b.Id_Catecumeno=e.Id_Catecumeno and a.Id_Catequesis=" + cual + " and e.Fecha='" + fecha.Year + "/" + fecha.Date.Month + "/" + fecha.Date.Day + "'";
                
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
                throw new Exception("Error al listar", e);
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
