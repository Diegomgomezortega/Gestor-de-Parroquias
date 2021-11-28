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
                
            //orden = "insert into Alumnos values (" + objalumno.Dni + ",'" + objalumno.Nombre + "','" + objalumno.Apellido + "','" + objalumno.Carrera + "','" + objalumno.Sexo + "','" + objalumno.FechNac.Year + "/" + objalumno.FechNac.Date.Month + "/" + objalumno.FechNac.Date.Day + "');"; Este es el que funciona en Alumnos
            if (accion == "Modificar")
            {
                orden = "update Catecumenos set DNI=" + objCatecumeno.Dni + ",Nombre='" + objCatecumeno.Nombre + "',Apellido='" + objCatecumeno.Apellido + "',Telefono=" + objCatecumeno.Telefono + ",Fecha_nac='" + objCatecumeno.FechNac.Year + "/" + objCatecumeno.FechNac.Date.Month + "/" + objCatecumeno.FechNac.Date.Day + "',Sexo='" + objCatecumeno.Sexo + "',Cod_Catequesis=" + objCatecumeno.Cod_Catequesis + " where Id_Catecumeno=" + objCatecumeno.Id_Catecumeno + "";
                //UPDATE nombre_tabla SET columna1 = valor1, columna2 = valor2 WHERE columna3 = valor3
            }
            if (accion == "Borrar")
            {
                //orden = "delete from Alumnos  where Legajo=" + objalumno.Legajo + "";
                orden = "delete from Asistencia where Id_Catecumeno=" + objCatecumeno.Id_Catecumeno + ";delete from Catecumenos where Id_Catecumeno=" + objCatecumeno.Id_Catecumeno + "";
            }
                
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


                    throw new Exception("Error al tratar de guardar,borrar o modificar catecumenos", e);


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
        public DataSet listadoCatecumenos(string que, int cual)//Este método listadoAlumnos devuelve un DataSet ds con los registros solicitados,recibe un string que indica el código que deseo buscar, o si sesolicitan “Todos”
        {
            string orden = string.Empty;
            //if (cual != "Todos")
            //    orden = "select * from Alumnos where Legajo = " + int.Parse(cual) + ";";
            if(que != "Todos")
            {
                //if (que == "capillas")
                //{
                //    orden = "select c.Id_Catecumeno,c.DNI,c.Nombre,c.Apellido,c.Telefono, c.Fecha_nac,c.Sexo,cap.Nombre as 'Salon' from Catecumenos c, Catequesis cq,Salones s, Capillas cap where cap.Id_Capilla='"+cual+"' and c.Cod_Catequesis=cq.Id_Catequesis and  cq.Id_Salon=s.Id_Salon and cap.Id_Capilla=s.Id_Capilla";
                //}
                orden= "select * from Catecumenos where Id_Catecumeno = " + cual + ";";

                //orden = "select c.Id_Catecumeno,c.DNI,c.Nombre,c.Apellido,c.Telefono, c.Fecha_nac,c.Sexo,s.Nombre from Catecumenos c, Catequesis cq,Salones s where c.Cod_Catequesis=cq.Id_Catequesis and c.Cod_Catequesis='" + cual + "' and cq.Id_Salon=s.Id_Salon";
                
                
            }
            if (que == "Asistencia")
            {
                orden = "select c.Id_Catecumeno,c.Nombre, c.Apellido from Catecumenos c, Catequesis ca where c.Cod_Catequesis = ca.Id_Catequesis and ca.Id_Catequesis =" + cual + "";

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
