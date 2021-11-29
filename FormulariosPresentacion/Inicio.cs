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
            
            
            cbxSalon.DropDownStyle = ComboBoxStyle.DropDownList;//Hacer solo lectura el combobox
            cbxCapilla.DropDownStyle = ComboBoxStyle.DropDownList;//Hacer solo lectura el combobox
            cbxDia.DropDownStyle = ComboBoxStyle.DropDownList;//Hacer solo lectura el combobox
            GetCapillas();


        }

        #region Atributos
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
        #endregion

        #region Métodos


        private void btnNuevaPersona_Click(object sender, EventArgs e)
        {
            CrearPersona crear = new CrearPersona();
            crear.ShowDialog();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
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
                ds = negociosAsistencia.listadoCatequesis("UnaCatequesis", cual);
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
        #endregion
    }
}
