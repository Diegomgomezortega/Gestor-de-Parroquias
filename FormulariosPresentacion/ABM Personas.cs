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
            //public CrearPersona Editar = new CrearPersona();


        }
        public CrearPersona Editar;
        public string nombreColumna="columna";
        public string capilla;
        public int[] idCatequesis;
        public int i;
        public string salon;
        public int cual;
        public string que = "";
        public bool capillas;
        public bool catequesis;
        public bool editarPer;
        public bool EditarCatequista;
        public bool EditarCatecumeno;
        public bool EditarSacerdote;
        public int id_Persona;
        public int[] idCapilla;
        
        public Catecumeno objEntCatecumeno = new Catecumeno();
        public Sacerdote sacerdote = new Sacerdote();
        public Catequista catequista = new Catequista();
        public NegociosSacerdotes negociosSacerdotes = new NegociosSacerdotes();
        public NegociosCatequistas negociosCatequistas = new NegociosCatequistas(); 
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
            if (dgvPersonas.Columns.Contains(nombreColumna))
            {
                dgvPersonas.Columns.Remove(nombreColumna);
            }
            dgvPersonas.Rows.Clear();//vacia el DGV
            DataSet ds = new DataSet();
            ds = negociosSacerdotes.listadoSacerdotes(que, cual);//Data set devuelve una lista, en este caso de catecumenos cargados, como el argumento es "Todos", me devolvera todos las personas cargadas
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
        private void LlenarDGVCatequistas(string que, int cual)

        {
            if (dgvPersonas.Columns.Contains(nombreColumna))
            {
                dgvPersonas.Columns.Remove(nombreColumna);
            }
           
                //dgvPersonas.Columns.Remove(nombreColumna);
            dgvPersonas.Rows.Clear();//vacia el DGV
            DataSet ds = new DataSet();
            ds = negociosCatequistas.listadoCatequistas(que, cual);//Data set devuelve una lista, en este caso de catecumenos cargados, como el argumento es "Todos", me devolvera todos las personas cargadas
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
            EditarCatecumeno = true;
            EditarCatequista = false;
            EditarSacerdote = false;

        }

        private void btnCatequistas_Click(object sender, EventArgs e)
        {
            LlenarDGVCatequistas("Todos", cual);
            EditarCatecumeno = false;
            EditarCatequista = true;
            EditarSacerdote = false;
        }

        private void btnSacerdotes_Click(object sender, EventArgs e)
        {
            LlenarDGVSacerdotes("Todos", cual);
            EditarCatecumeno = false;
            EditarCatequista = false;
            EditarSacerdote = true;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CrearPersona crear = new CrearPersona();
            crear.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio inicio = new Inicio();
            inicio.Show();
        }

        

        private void dgvPersonas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar = new CrearPersona();
            DataSet ds = new DataSet();
            id_Persona = Convert.ToInt32(dgvPersonas.CurrentRow.Cells[0].Value);
            editarPer = true;
            
            if (EditarCatecumeno == true)
            {
                ds = objNegCatecumeno.listadoCatecumenos("", id_Persona);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Editar.Ds_a_TxtBox(ds, EditarCatecumeno, id_Persona);
                    //btnNuevo.Visible = false;
                    //lblInformacion.Text = string.Empty;
                }

            }
            if (EditarCatequista == true)
            {
                ds = negociosCatequistas.listadoCatequistas("", id_Persona);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Editar.Ds_a_TxtBox(ds, EditarCatequista, id_Persona);
                    //btnNuevo.Visible = false;
                    //lblInformacion.Text = string.Empty;
                }

            }
            if (EditarSacerdote == true)
            {
                ds =negociosSacerdotes.listadoSacerdotes ("", id_Persona);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Editar.Ds_a_TxtBox(ds, EditarSacerdote, id_Persona);
                    //btnNuevo.Visible = false;
                    //lblInformacion.Text = string.Empty;
                }

            }
            Editar.ShowDialog();

        }
    }
}
