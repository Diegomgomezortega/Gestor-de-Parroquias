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
        public CrearPersona Edicion;
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
        private string nombre;
        private string apellido;
        
        public Catecumeno objEntCatecumeno = new Catecumeno();
        public Sacerdote sacerdote = new Sacerdote();
        public Catequista catequista = new Catequista();
        public NegociosSacerdotes negociosSacerdotes = new NegociosSacerdotes();
        public NegociosCatequistas negociosCatequistas = new NegociosCatequistas(); 
        public NegociosCatecumenos objNegCatecumeno = new NegociosCatecumenos();
        public NegociosParroquias negociosParroquias = new NegociosParroquias();
        private void LlenarDGVCatecumenos(string que, int cual)

        {
            DataSet ds = new DataSet();
            ds = objNegCatecumeno.listadoCatecumenos(que, cual);//Data set devuelve una lista, en este caso de catecumenos cargados, como el argumento es "Todos", me devolvera todos las personas cargadas
            LLenarDGV(ds);
            

        }
        private void LlenarDGVSacerdotes(string que, int cual)

        {
           
            DataSet ds = new DataSet();
            ds = negociosSacerdotes.listadoSacerdotes(que, cual);//Data set devuelve una lista, en este caso de catecumenos cargados, como el argumento es "Todos", me devolvera todos las personas cargadas
            LLenarDGV(ds);

        }
        private void LlenarDGVCatequistas(string que, int cual)

        {
            DataSet ds = new DataSet();
            ds = negociosCatequistas.listadoCatequistas(que, cual);//Data set devuelve una lista, en este caso de catecumenos cargados, como el argumento es "Todos", me devolvera todos las personas cargadas
            LLenarDGV(ds);

        }

        private void LLenarDGV(DataSet ds)
        {
            if (dgvPersonas.Columns.Contains(nombreColumna))
            {
                dgvPersonas.Columns.Remove(nombreColumna);
            }
            dgvPersonas.Rows.Clear();//vacia el DGV
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
            gbxAcciones.Visible = true;

        }

        private void btnCatequistas_Click(object sender, EventArgs e)
        {
            LlenarDGVCatequistas("Todos", cual);
            EditarCatecumeno = false;
            EditarCatequista = true;
            EditarSacerdote = false;
            gbxAcciones.Visible = true;
        }

        private void btnSacerdotes_Click(object sender, EventArgs e)
        {
            LlenarDGVSacerdotes("Todos", cual);
            EditarCatecumeno = false;
            EditarCatequista = false;
            EditarSacerdote = true;
            gbxAcciones.Visible = true;

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
            EditarPersona();
        }
        private void EditarPersona()
        {
            Edicion = new CrearPersona();
            
            DataSet ds = new DataSet();

            id_Persona = Convert.ToInt32(dgvPersonas.CurrentRow.Cells[0].Value);
            editarPer = true;

            if (EditarCatecumeno == true)
            {
                ds = objNegCatecumeno.listadoCatecumenos("UnCatecumeno", id_Persona);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Edicion.Ds_a_TxtBox(ds, EditarCatecumeno, id_Persona,0);
                    
                }

            }
            if (EditarCatequista == true)
            {
                ds = negociosCatequistas.listadoCatequistas("", id_Persona);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Edicion.Ds_a_TxtBox(ds, EditarCatequista, id_Persona,1);
                }

            }
            if (EditarSacerdote == true)
            {
                ds = negociosSacerdotes.listadoSacerdotes("", id_Persona);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Edicion.Ds_a_TxtBox(ds, EditarSacerdote, id_Persona,2);
                    
                }

            }
            Edicion.ShowDialog();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarPersona();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            nombre = dgvPersonas.CurrentRow.Cells[2].Value.ToString();
            apellido = dgvPersonas.CurrentRow.Cells[3].Value.ToString();
            DialogResult dr = MessageBox.Show("Desea eliminar a "+nombre+" "+apellido+"?", "Atencion!", MessageBoxButtons.OKCancel);
            switch (dr)
            {
                case DialogResult.OK:
                    {
                        BorrarPersona();
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        this.Text = "[Cancel]";
                        break;
                    }
            }
        }

        private void BorrarPersona()
        {
            DataSet ds = new DataSet();
            id_Persona = Convert.ToInt32(dgvPersonas.CurrentRow.Cells[0].Value);
            
            int ngrabados = -1;//la utilizo para detectar si fue grabado exitosamente o no
            if (EditarCatecumeno == true)
            {
                objEntCatecumeno.Id_Catecumeno = id_Persona;
                ngrabados = objNegCatecumeno.abmCatecumeno("Borrar", objEntCatecumeno);
                AvisoConfirmacion(ngrabados);
                LlenarDGVCatecumenos("Todos", cual);

            }
            if (EditarCatequista == true)
            {
                catequista.Id_Catequista = id_Persona;
                ngrabados = negociosCatequistas.abmCatequista("Borrar", catequista);
                AvisoConfirmacion(ngrabados);
                LlenarDGVCatequistas("Todos", cual);

            }
            if (EditarSacerdote == true)
            {
                sacerdote.Id_Sacerdote = id_Persona;
                ngrabados = negociosSacerdotes.abmSacerdotes("Borrar", sacerdote);
                AvisoConfirmacion(ngrabados);
                LlenarDGVSacerdotes("Todos", cual);

            }

        }

        private void AvisoConfirmacion(int ngrabados)
        {
            if (ngrabados != -1)
            {
                MessageBox.Show("la accion se realizo con exito");
            }
            else
            {
                MessageBox.Show("Se produjo un error al intentar la acción");
            }
        }
    }
}
