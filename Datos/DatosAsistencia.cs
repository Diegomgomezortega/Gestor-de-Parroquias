using System;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosAsistencia: DatosConexionBD
    {
        public int AltaAsistencia(string accion, string orden)
        {
            int resultado = -1;
            //string orden = string.Empty;
            //if (accion == "Alta")
                //orden=insert into Catecumenos values(37594703,'Diana','Pezzelato',2512644879,'1993-10-05','f',8)
                //orden = "insert into Sacerdotes values (" + objAsistencia.Dni + ",'" + objAsistencia.Nombre + "', '" + objAsistencia.Apellido + "', " + objAsistencia.Telefono + ",'" + objAsistencia.FechNac.Year + "/" + objAsistencia.FechNac.Date.Month + "/" + objAsistencia.FechNac.Date.Day + "', '" + objAsistencia.Sexo + "')";

            //orden = "insert into Alumnos values (" + objalumno.Dni + ",'" + objalumno.Nombre + "','" + objalumno.Apellido + "','" + objalumno.Carrera + "','" + objalumno.Sexo + "','" + objalumno.FechNac.Year + "/" + objalumno.FechNac.Date.Month + "/" + objalumno.FechNac.Date.Day + "');"; Este es el que funciona en Alumnos
            //if (accion == "Modificar")
               // orden = "update Sacerdotes set DNI=" + objAsistencia.Dni + ",Nombre='" + objAsistencia.Nombre + "',Apellido='" + objAsistencia.Apellido + "',Telefono=" + objAsistencia.Telefono + ",Fecha_nac='" + objAsistencia.FechNac.Year + "/" + objAsistencia.FechNac.Date.Month + "/" + objAsistencia.FechNac.Date.Day + "',Sexo='" + objAsistencia.Sexo + "' where Id_Sacerdote=" + objAsistencia.Id_Sacerdote + "";
            //UPDATE nombre_tabla SET columna1 = valor1, columna2 = valor2 WHERE columna3 = valor3
            //if (accion == "Borrar")
                //orden = "delete from Alumnos  where Legajo=" + objalumno.Legajo + "";
                //orden = "delete from Sacerdotes  where Id_Sacerdote=" + objAsistencia.Id_Sacerdote + "";
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

    }
}
