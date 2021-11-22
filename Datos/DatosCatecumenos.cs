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
    public class DatosCatecumenos: DatosConexionBD
    {
        #region Metodo ABM Catecumeno
        public int abmCatecumeno(string accion, Catecumeno objCatecumeno)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
                //orden=insert into Catecumenos values(37594703,'Diana','Pezzelato',2512644879,'1993-10-05','f',8)
                orden = "insert into Catecumenos values ("+objCatecumeno.Dni+",'"+objCatecumeno.Nombre+"', '"+ objCatecumeno.Apellido+"', "+ objCatecumeno.Telefono+ ",'" + objCatecumeno.FechNac.Year + "/" + objCatecumeno.FechNac.Date.Month + "/" + objCatecumeno.FechNac.Date.Day + "', '"+objCatecumeno.Sexo+"', "+objCatecumeno.Cod_Catequesis+")";
                //orden = "insert into Alumno values (" + objalumno.Dni + ",'" + objalumno.Nombre + "','" + objalumno.Apellido + "','" + objalumno.Carrera + "','" + objalumno.Sexo + "'," + objalumno.FechNac.Date.Day + "/" +objalumno.FechNac.Date.Month+"/" + objalumno.FechNac.Year+ ");";
                //orden = "insert into Alumno values (" + objalumno.Dni + ",'" + objalumno.Nombre + "','" + objalumno.Apellido + "','" + objalumno.Carrera + "','" + objalumno.Sexo + "'," + objalumno.FechNac.Year +" / " + objalumno.FechNac.Date.Month + "/ " + objalumno.FechNac.Date.Day + ");";//Me guarda con e año 1900
                //orden = "insert into Alumnos values (" + objalumno.Dni + ",'" + objalumno.Nombre + "','" + objalumno.Apellido + "','" + objalumno.Carrera + "','" + objalumno.Sexo + "'," + objalumno.FechNac.Year + "/" + objalumno.FechNac.Date.Month + "/" + objalumno.FechNac.Date.Day + ");";//Me guarda con e año 1900
            //orden = "insert into Alumnos values (" + objalumno.Dni + ",'" + objalumno.Nombre + "','" + objalumno.Apellido + "','" + objalumno.Carrera + "','" + objalumno.Sexo + "','" + objalumno.FechNac.Year + "/" + objalumno.FechNac.Date.Month + "/" + objalumno.FechNac.Date.Day + "');"; Este es el que funciona en Alumnos
            //if (accion == "Modificar")
            //    orden = "update Alumnos set DNI=" + objalumno.Dni + " ,Nombre ='" + objalumno.Nombre + "',Apellido='" + objalumno.Apellido + "',Carrera='" + objalumno.Carrera + "',Genero='" + objalumno.Sexo + "',FechaNac='" + objalumno.FechNac.Year + "/" + objalumno.FechNac.Date.Month + "/" + objalumno.FechNac.Date.Day + "'  where Legajo=" + objalumno.Legajo + " ";
            //UPDATE nombre_tabla SET columna1 = valor1, columna2 = valor2 WHERE columna3 = valor3
            if (accion == "Borrar")
                //orden = "delete from Alumnos  where Legajo=" + objalumno.Legajo + "";
            orden = "delete from Alumnos  where Id_Catecumeno=" + objCatecumeno.Id_Catecumeno + "";
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


                    throw new Exception("Error al tratar de guardar,borrar o modificar estudiantes", e);


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
        public DataSet listadoCatecumenos(string cual)//Este método listadoAlumnos devuelve un DataSet ds con los registros solicitados,recibe un string que indica el código que deseo buscar, o si sesolicitan “Todos”
        {
            string orden = string.Empty;
            //if (cual != "Todos")
            //    orden = "select * from Alumnos where Legajo = " + int.Parse(cual) + ";";
            if(cual != "Todos")
            {
                orden = "select ";
            }
            //    orden = "select * from Alumnos where Legajo = " + int.Parse(cual) + ";";
            else
                orden = "select * from Catecumenos";
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
                throw new Exception("Error al listar Alumnos", e);
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
