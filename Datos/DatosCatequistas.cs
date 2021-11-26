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
                //orden=insert into Catecumenos values(37594703,'Diana','Pezzelato',2512644879,'1993-10-05','f',8)
                orden = "insert into Catequistas values (" + objCatequista.Dni + ",'" + objCatequista.Nombre + "', '" + objCatequista.Apellido + "', " + objCatequista.Telefono + ",'" + objCatequista.FechNac.Year + "/" + objCatequista.FechNac.Date.Month + "/" + objCatequista.FechNac.Date.Day + "', '" + objCatequista.Sexo + "')";

            //orden = "insert into Alumnos values (" + objalumno.Dni + ",'" + objalumno.Nombre + "','" + objalumno.Apellido + "','" + objalumno.Carrera + "','" + objalumno.Sexo + "','" + objalumno.FechNac.Year + "/" + objalumno.FechNac.Date.Month + "/" + objalumno.FechNac.Date.Day + "');"; Este es el que funciona en Alumnos
            if (accion == "Modificar")
                orden = "update Catequistas set DNI=" + objCatequista.Dni + ",Nombre='" + objCatequista.Nombre + "',Apellido='" + objCatequista.Apellido + "',Telefono=" + objCatequista.Telefono + ",Fecha_nac='" + objCatequista.FechNac.Year + "/" + objCatequista.FechNac.Date.Month + "/" + objCatequista.FechNac.Date.Day + "',Sexo='" + objCatequista.Sexo + "' where Id_Catequista=" + objCatequista.Id_Catequista + "";
            //UPDATE nombre_tabla SET columna1 = valor1, columna2 = valor2 WHERE columna3 = valor3
            if (accion == "Borrar")
                //orden = "delete from Alumnos  where Legajo=" + objalumno.Legajo + "";
                orden = "delete from Catequistas  where Id_Catequista=" + objCatequista.Id_Catequista + "";
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
        public DataSet listadoCatequistas(string que, int cual)//Este método listadoAlumnos devuelve un DataSet ds con los registros solicitados,recibe un string que indica el código que deseo buscar, o si sesolicitan “Todos”
        {
            string orden = string.Empty;
            //if (cual != "Todos")
            //    orden = "select * from Alumnos where Legajo = " + int.Parse(cual) + ";";
            if (que != "Todos")
            {
                orden = "select * from Catequistas where Id_Catequista = " + cual + ";";
                //    if (que == "capillas")
                //    {
                //        orden = "select c.Id_Catecumeno,c.DNI,c.Nombre,c.Apellido,c.Telefono, c.Fecha_nac,c.Sexo,cap.Nombre as 'Salon' from Catecumenos c, Catequesis cq,Salones s, Capillas cap where cap.Id_Capilla='" + cual + "' and c.Cod_Catequesis=cq.Id_Catequesis and  cq.Id_Salon=s.Id_Salon and cap.Id_Capilla=s.Id_Capilla";
                //    }
                //    else
                //    {
                //        orden = "select c.Id_Catecumeno,c.DNI,c.Nombre,c.Apellido,c.Telefono, c.Fecha_nac,c.Sexo,s.Nombre from Catecumenos c, Catequesis cq,Salones s where c.Cod_Catequesis=cq.Id_Catequesis and c.Cod_Catequesis='" + cual + "' and cq.Id_Salon=s.Id_Salon";
                //    }

            }
            //    orden = "select * from Alumnos where Legajo = " + int.Parse(cual) + ";";
            else
                orden = "select * from Catequistas";
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
    }
}
