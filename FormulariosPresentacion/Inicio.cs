using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace FormulariosPresentacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            #region Formato DGV
            dgvCatecumenos.ColumnCount = 8;
            dgvCatecumenos.Columns[0].HeaderText = "Id Cat";
            dgvCatecumenos.Columns[1].HeaderText = "DNI";
            dgvCatecumenos.Columns[2].HeaderText = "NOMBRE";
            dgvCatecumenos.Columns[3].HeaderText = "APELLIDO";
            dgvCatecumenos.Columns[4].HeaderText = "TELEFONO";
            dgvCatecumenos.Columns[5].HeaderText = "NACIMIENTO";
            dgvCatecumenos.Columns[6].HeaderText = "SEXO";
            dgvCatecumenos.Columns[7].HeaderText = "CATEQUESIS";
            dgvCatecumenos.Columns[0].Width = 50;
            dgvCatecumenos.Columns[1].Width = 100;
            dgvCatecumenos.Columns[2].Width = 100;
            dgvCatecumenos.Columns[3].Width = 100;
            dgvCatecumenos.Columns[4].Width = 100;
            dgvCatecumenos.Columns[5].Width = 100;
            dgvCatecumenos.Columns[6].Width = 100;
            dgvCatecumenos.Columns[7].Width = 50;
            #endregion
            LlenarDGV();
        }

        //A la instancia de la clase Profesional de la capa de Entidad la llamaremos objEntProf
        public Catecumeno objEntCatecumeno = new Catecumeno();
        //A la instancia de la clase NegProfesionales de la capa de Negocios la llamaremos objNegProf
        public NegociosCatecumenos objNegCatecumeno = new NegociosCatecumenos();
        private void LlenarDGV()

        {
            dgvCatecumenos.Rows.Clear();//vacia el DGV
            DataSet ds = new DataSet();
            ds = objNegCatecumeno.listadoCatecumenos("Todos");//Data set devuelve una lista, en este caso de catecumenos cargados, como el argumento es "Todos", me devolvera todos las personas cargadas
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)//Lo que muestra esta en dr[0].ToString(), dr[1].ToString(),y asi sucesivamente
                {
                    if (Convert.ToString(dr[7]) == "m")
                    {
                        dr[7] = "Masculino";
                    }
                    if (Convert.ToString(dr[7]) == "f")
                    {
                        dr[7] = "Femenino";
                    }
                    if (Convert.ToString(dr[7]) == "X")
                    {
                        dr[7] = "Indefinido";
                    }
                    dgvCatecumenos.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4], Convert.ToDateTime(dr[5]).ToShortDateString(), dr[7], dr[8].ToString());////Rellena el dgv por cada ds que trae de la bd
                }
            }

        }
    }
}
