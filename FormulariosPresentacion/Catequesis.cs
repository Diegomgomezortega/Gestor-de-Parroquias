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
    public partial class Catequesis : Form
    {
        #region Constructor Formulario Catequesis
        public Catequesis()
        {
            InitializeComponent();
            cbxFecha.DropDownStyle = ComboBoxStyle.DropDownList;//Combobox solo lectura
            GetFecha();

        }
        #endregion
        #region Atributos Propios del Formulario
        int id_Catequesis;
        DateTime[] fech = new DateTime[20];
        int i = 0;
        NegociosAsistencia negociosAsistencia = new NegociosAsistencia();//Inicializo una instancia de NegociosAsistencia
        #endregion
        #region Métodos
        public void LLenarDGV(DataSet ds, int id_catequesis)//Metodo publico, generalmente es invocado desde otro formulario
        {

            id_Catequesis = id_catequesis;
            dgvPersonas.Rows.Clear();//vacia el DGV
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)//Lo que muestra esta en dr[0].ToString(), dr[1].ToString(),y asi sucesivamente
                {

                    dgvPersonas.Rows.Add(dr[0].ToString(), dr[1], dr[2]);////Rellena el dgv por cada ds que trae de la bd
                    lblNombre.Text = System.Convert.ToString(dr[3]);
                }
                
            }
            else
            {
                //lblInformacion.Text = "No hay catequesis cargadas en el sistema";
            }
            dgvPersonas.Visible = true;
        }
        private void GetFecha()//Metodo que trae de la base de datos los encuentros separados por fechas, para ver la asistencia
        {
            DataSet dataSet = new DataSet();
            dataSet = negociosAsistencia.listadoCatequesis("Fechas", id_Catequesis);//Metodo que recibe dos parametros
            fech = new DateTime[dataSet.Tables[0].Rows.Count];
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                i = 0;
                
            
                foreach (DataRow dr in dataSet.Tables[0].Rows)//Lo que muestra esta en dr[0].ToString(), dr[1].ToString(),y asi sucesivamente
                {

                cbxFecha.Items.Add(Convert.ToDateTime(dr[0]).ToShortDateString());
                fech[i] = Convert.ToDateTime(dr[0]);
                    i++;
                }
            
            }
        }
        private void dgvCatequesis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Catequesis_Load(object sender, EventArgs e)
        {
            GetFecha();
        }//Se dispara cuando se comienza a cargar el formulario

        private void cbxFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPersonas.Rows.Clear();
            DataSet ds = new DataSet();
            i = cbxFecha.SelectedIndex;
            
            ds = negociosAsistencia.listadoCatequesis("Tema", id_Catequesis, fech[i]);
            if (ds.Tables[0].Rows.Count > 0)
            {


                foreach (DataRow dr in ds.Tables[0].Rows)//Lo que muestra esta en dr[0].ToString(), dr[1].ToString(),y asi sucesivamente
                {
                    if (Convert.ToString(dr[3]) == "p")
                    {
                        dr[3] = "Presente";
                    }
                    else
                    {
                        dr[3] = "Ausente";
                    }
                    lblTema.Text = System.Convert.ToString(dr[4]);

                    dgvPersonas.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3]);
                }
            }

        }//Metodo que se dispara al seleccionar un item del combobox fecha

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }//Evento click del boton
        #endregion
    }
}
