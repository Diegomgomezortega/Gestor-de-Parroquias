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
    public class DatosAsistencia: DatosConexionBD//Clase DatosAsistencia que hereda de DatosConexion
    {
        public int AltaAsistencia( string orden)
        {
            int resultado = -1;
                      
            SqlCommand cmd = new SqlCommand(orden, conexion); //Instancio e inicializo un objeto SqlCommand que necesita de argumento la orden a ejecutar y la conexion a la BD
            {
                try
                {
                    Abrirconexion();
                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {


                    throw new Exception("Error al tratar de guardar,borrar o modificar la asistencia", e);


                }
                finally
                {
                    Cerrarconexion();
                    cmd.Dispose();
                }
                return resultado;
            }
        }
        public DataSet listadoCatequesis(string que, int cual, DateTime fecha)
        {
            string orden = string.Empty;
            if (que == "Todos")
            {
                orden= "select c.Id_Catequesis,cap.Nombre, s.Nombre, c.Hora from Catequesis c, Salones s,Capillas cap where cap.Id_Capilla = s.Id_Capilla and c.Id_salon = s.Id_Salon";

            }
            if (que =="UnaCatequesis")
            {
                orden = "select b.Id_Catecumeno, b.Nombre,b.Apellido, c.Nombre from Catequesis a, Catecumenos b, Catequistas c, Dictar d where b.Cod_Catequesis=a.Id_Catequesis and a.Id_Catequesis=d.Id_Catequesis and d.Id_Catequista=c.Id_Catequista and a.Id_Catequesis=" + cual + ";";

            }
            if (que == "Fechas")
            {
                orden = "select distinct Fecha from Asistencia a, Catequesis c where c.Id_Catequesis=" + cual + " and a.Id_Catequesis=c.Id_Catequesis";
            }
            if (que == "Tema")
            {
                orden = "select distinct Tema from Asistencia where Fecha='"+fecha.Year+"/"+fecha.Date.Month+"/"+fecha.Date.Day+"' and Id_Catequesis=" + cual + ";";
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

    }
}
