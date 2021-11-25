using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosPresentacion
{
    public partial class ABM_Personas : Form
    {
        public ABM_Personas()
        {
            InitializeComponent();
            #region Formato DGV
            dgvPersonas.ColumnCount = 7;
            dgvPersonas.Columns[0].HeaderText = "Id";
            dgvPersonas.Columns[1].HeaderText = "DNI";
            dgvPersonas.Columns[2].HeaderText = "NOMBRE";
            dgvPersonas.Columns[3].HeaderText = "APELLIDO";
            dgvPersonas.Columns[4].HeaderText = "TELEFONO";
            dgvPersonas.Columns[5].HeaderText = "NACIMIENTO";
            dgvPersonas.Columns[6].HeaderText = "SEXO";
            
            dgvPersonas.Columns[0].Width = 50;
            dgvPersonas.Columns[1].Width = 100;
            dgvPersonas.Columns[2].Width = 100;
            dgvPersonas.Columns[3].Width = 100;
            dgvPersonas.Columns[4].Width = 100;
            dgvPersonas.Columns[5].Width = 100;
            dgvPersonas.Columns[6].Width = 100;
            //dgvPersonas.Columns[7].Width = 50;
            #endregion

            
        }
        public string nombreColumna="columna";
        public string capilla;
        public int[] idCatequesis;
        public int i;
        public string salon;
        public int cual;
        public string que = "";
        public bool capillas;
        public bool catequesis;
        public int[] idCapilla;
        public Catecumeno objEntCatecumeno = new Catecumeno();
        public Sacerdote sacerdote = new Sacerdote();
        public NegociosSacerdotes objNegSacerdotes = new NegociosSacerdotes();
        public NegociosCatecumenos objNegCatecumeno = new NegociosCatecumenos();
        public NegociosParroquias negociosParroquias = new NegociosParroquias();
        private void LlenarDGVCatecumenos(string que, int cual)

        {
            dgvPersonas.Columns.Add(nombreColumna,"Cat");
            
            dgvPersonas.Rows.Clear();//vacia el DGV
            DataSet ds = new DataSet();
            ds = objNegCatecumeno.listadoCatecumenos(que, cual);//Data set devuelve una lista, en este caso de catecumenos cargados, como el argumento es "Todos", me devolvera todos las personas cargadas
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)//Lo que muestra esta en dr[0].ToString(), dr[1].ToString(),y asi sucesivamente
                {
                    if (Convert.ToString(dr[6]) == "m")
                    {
                        dr[6] = "Masculino";
                    }
                    if (Convert.ToString(dr[6]) == "f")
                    {
                        dr[6] = "Femenino";
                    }
                    
                    dgvPersonas.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4], Convert.ToDateTime(dr[5]).ToShortDateString(), dr[6], dr[7].ToString());////Rellena el dgv por cada ds que trae de la bd
                }
            }
            else
            {
                //lblInformacion.Text = "No hay personas cargadas en el sistema";
            }
            dgvPersonas.Visible = true;

        }
        private void LlenarDGVSacerdotes(string que, int cual)

        {
            dgvPersonas.Columns.Remove(nombreColumna);
            dgvPersonas.Rows.Clear();//vacia el DGV
            DataSet ds = new DataSet();
            ds = objNegSacerdotes.listadoSacerdotes(que, cual);//Data set devuelve una lista, en este caso de catecumenos cargados, como el argumento es "Todos", me devolvera todos las personas cargadas
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)//Lo que muestra esta en dr[0].ToString(), dr[1].ToString(),y asi sucesivamente
                {
                    if (Convert.ToString(dr[6]) == "m")
                    {
                        dr[6] = "Masculino";
                    }
                    if (Convert.ToString(dr[6]) == "f")
                    {
                        dr[6] = "Femenino";
                    }

                    dgvPersonas.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4], Convert.ToDateTime(dr[5]).ToShortDateString(), dr[6]);////Rellena el dgv por cada ds que trae de la bd
                }
            }
            else
            {
                //lblInformacion.Text = "No hay personas cargadas en el sistema";
            }
            dgvPersonas.Visible = true;

        }

        private void btnCatecumenos_Click(object sender, EventArgs e)
        {
            LlenarDGVCatecumenos("Todos", cual);

        }

        private void btnCatequistas_Click(object sender, EventArgs e)
        {

        }

        private void btnSacerdotes_Click(object sender, EventArgs e)
        {
            LlenarDGVSacerdotes("Todos", cual);

        }
    }
}
