using System;
using Entidades;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosParroquias: DatosConexionBD

    {
        public DataSet listado(string que, string cual)//
        {
            string orden = string.Empty;
            
            if (que == "Capillas")
            {
                orden = "select c.Nombre, c.Id_Capilla from Capillas c where c.Id_Parroquia=1";
                //orden = "select s.Id_Capilla,c.Nombre,s.Nombre from Capillas c,Salones s where  c.Id_Capilla=s.Id_Capilla";
            }
            if (que == "Salones")
            {
                orden = "select s.Id_Salon, s.nombre as 'Salon', c.Nombre as 'Capilla' from Salones s, Capillas c where c.Nombre='"+cual+"' and s.Id_Capilla=c.Id_Capilla";
                //orden = "select s.Id_Capilla,c.Nombre,s.Nombre from Capillas c,Salones s where  c.Id_Capilla=s.Id_Capilla";
            }
            if (que == "Dia")
            {
                orden = "select c.Id_Catequesis,c.Dia, c.Hora from Catequesis c, Salones s where c.Id_Salon=s.Id_Salon and s.Nombre='"+cual+"'";
                //orden = "select s.Id_Capilla,c.Nombre,s.Nombre from Capillas c,Salones s where  c.Id_Capilla=s.Id_Capilla";
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
