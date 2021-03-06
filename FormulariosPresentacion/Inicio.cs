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
            //DataGridViewCheckBoxColumn columnaCheck = new DataGridViewCheckBoxColumn();
            //DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            //DataGridViewTextBoxColumn colApellido = new DataGridViewTextBoxColumn();
            

            ////dgvCatecumenos.Columns[1].HeaderText = "DNI";
            //dgvCatecumenos.Columns.Add(colNombre);
            //colNombre.Name = "Nombre";

            //dgvCatecumenos.Columns[0].HeaderText = "Nombre";
            //dgvCatecumenos.Columns["Nombre"].ReadOnly = true;
            //dgvCatecumenos.Columns.Add(colApellido);
            //colApellido.Name = "Apellido";
            //dgvCatecumenos.Columns[1].HeaderText = "Apellido";
            //dgvCatecumenos.Columns["Apellido"].ReadOnly = true;
            
            //dgvCatecumenos.Columns.Add(columnaCheck);
            //dgvCatecumenos.Columns[2].HeaderText = "Presente";
            //dgvCatecumenos.Columns[4].HeaderText = "TELEFONO";
            //dgvCatecumenos.Columns[5].HeaderText = "NACIMIENTO";
            //dgvCatecumenos.Columns[6].HeaderText = "SEXO";
            //dgvCatecumenos.Columns[7].HeaderText = "CAT";
            //dgvCatecumenos.Columns[0].Width = 50;
            //dgvCatecumenos.Columns[1].Width = 100;
            //dgvCatecumenos.Columns[2].Width = 100;
            //dgvCatecumenos.Columns[3].Width = 100;
            //dgvCatecumenos.Columns[4].Width = 100;
            //dgvCatecumenos.Columns[5].Width = 100;
            //dgvCatecumenos.Columns[6].Width = 100;
            //dgvCatecumenos.Columns[7].Width = 50;
            #endregion
            cbxSalon.DropDownStyle = ComboBoxStyle.DropDownList;//Hacer solo lectura el combobox
            cbxCapilla.DropDownStyle = ComboBoxStyle.DropDownList;//Hacer solo lectura el combobox
            cbxDia.DropDownStyle = ComboBoxStyle.DropDownList;//Hacer solo lectura el combobox
            GetCapillas();


        }
        public string capilla;
        public string salon;
        public int[] idCatequesis;
        public int i;
        public string salonhora;
        public int cual;
        public string que = "";
        public bool capillas;
        public bool catequesis;
        public int[] idCapilla;
        public int Cod_cate;
        public bool vercatequesis;
        public bool tomarAsistencia;
        public DateTime fecha;


        public Catecumeno objEntCatecumeno = new Catecumeno();
        public NegociosCatecumenos negociosCatecumeno = new NegociosCatecumenos();
        public NegociosParroquias negociosParroquias = new NegociosParroquias();
        public NegociosAsistencia negociosAsistencia = new NegociosAsistencia();
        
        
        private void btnNuevaPersona_Click(object sender, EventArgs e)
        {
            CrearPersona crear = new CrearPersona();
            crear.ShowDialog();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            //LlenarDGV("Todos",cual);
        }

        private void cargarNuevaPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearPersona crear = new CrearPersona();
            crear.ShowDialog();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //que = "Todos";            
            //LlenarDGV(que,cual);
            //dgvCatecumenos.Visible = true;
        }

        private void todosToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void porCatequesisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbxFiltro.Visible = true;
            catequesis = true;
            GetCapillas();

        }

        private void GetCapillas()
        {
            DataSet dsCapilla = new DataSet();
            dsCapilla = negociosParroquias.listado("Capillas", "");
            i = 0;
            idCapilla = new int[dsCapilla.Tables[0].Rows.Count];
            if (dsCapilla.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in dsCapilla.Tables[0].Rows)//Lo que muestra esta en dr[0].ToString(), dr[1].ToString(),y asi sucesivamente
                {
                    cbxCapilla.Items.Add(dr[0]);
                    idCapilla[i]= System.Convert.ToInt32(dr[1]);
                    i++;


                }
            }


        }
        private void GetSalones(string capilla)
        {
            cbxSalon.Items.Clear();
            DataSet dsSalones = new DataSet();
            dsSalones = negociosParroquias.listado("Salones", capilla);
            idCatequesis = new int[dsSalones.Tables[0].Rows.Count];
            if (dsSalones.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in dsSalones.Tables[0].Rows)//Lo que muestra esta en dr[0].ToString(), dr[1].ToString(),y asi sucesivamente
                {
                    cbxSalon.Items.Add(dr[1]);

                }
            }


        }

        private void cbxCapilla_SelectedIndexChanged(object sender, EventArgs e)
        {
            capilla = cbxCapilla.SelectedItem.ToString();
            cbxDia.Items.Clear();
            GetSalones(capilla);
        }

        private void cbxSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCatequesis[0] = 0;
            i = 0;
            salon = cbxSalon.SelectedItem.ToString();
            cbxDia.Items.Clear();

            DataSet dsDia = new DataSet();
            dsDia = negociosParroquias.listado("Dia", salon);
            if (dsDia.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in dsDia.Tables[0].Rows)//Lo que muestra esta en dr[0].ToString(), dr[1].ToString(),y asi sucesivamente
                {
                    cbxDia.Items.Add(dr[1] + "-" + dr[2]);
                    idCatequesis[i] = System.Convert.ToInt32(dr[0]);
                    i++;



                }

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            i = cbxDia.SelectedIndex;
            cual = idCatequesis[i];
            DataSet ds = new DataSet();
            if (vercatequesis)
            {
                Catequesis listaCatequesis = new Catequesis();
                ds = negociosAsistencia.listadoCatequesis("UnaCatequesis", cual,fecha);
                listaCatequesis.LLenarDGV(ds, cual);
                listaCatequesis.Show();

            }
            else
            {
                ds = negociosCatecumeno.listadoCatecumenos("TomarAsistencia", cual);
                Asistencia asistencia = new Asistencia();
                asistencia.LlenarDGV(ds, cual, salonhora);
                asistencia.Show();

            }
                  
            

        }

        private void cbxDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            salonhora = salon+": "+ System.Convert.ToString(cbxDia.SelectedItem);
            btnBuscar.Visible = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxFiltro.Visible = false;
            //dgvCatecumenos.Visible = false;
            catequesis = false;
            capillas = false;
        }

        private void porCapillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbxCapilla.Items.Clear();
            GetCapillas();
            gbxFiltro.Visible = true;
            cbxSalon.Visible = false;
            cbxDia.Visible = false;
            lblDia.Visible = false;
            lblDia.Visible = false;
            capillas = true;
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            //ABM_Personas aBM_Personas = new ABM_Personas();
            ABM_Personas form = new ABM_Personas();
            form.Show();
            
            this.Hide();
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            tomarAsistencia = true;
            vercatequesis = false;
            gbxFiltro.Visible = true;
            //dgvCatequesis.Visible = false;
        }

        private void btnCatequesis_Click(object sender, EventArgs e)
        {
            vercatequesis = true;
            tomarAsistencia = false;
            gbxFiltro.Visible = true;
            
            



        }
    }
}
