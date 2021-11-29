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
        public Catequesis()
        {
            InitializeComponent();
            cbxFecha.DropDownStyle = ComboBoxStyle.DropDownList;
            GetFecha();

        }
        int id_Catequesis;
        string fecha;
        DateTime[] fech = new DateTime[20];
        
        int i = 0;

        NegociosAsistencia negociosAsistencia = new NegociosAsistencia();
        
        public void LLenarDGV(DataSet ds, int id_catequesis)
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
        private void GetFecha()
        {
            fech[0] = DateTime.Now;
            DataSet dataSet = new DataSet();
            dataSet = negociosAsistencia.listadoCatequesis("Fechas", id_Catequesis,fech[0]);
            fech = new DateTime[dataSet.Tables.Count];
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                
            
                foreach (DataRow dr in dataSet.Tables[0].Rows)//Lo que muestra esta en dr[0].ToString(), dr[1].ToString(),y asi sucesivamente
                {
                cbxFecha.Items.Add(Convert.ToDateTime(dr[0]).ToShortDateString());
                fech[i] = Convert.ToDateTime(dr[0]);
                    i++;
                }
            

                //dgvPersonas.Rows.Add(dr[0].ToString(), dr[1], dr[2]);////Rellena el dgv por cada ds que trae de la bd
                //lblNombre.Text = System.Convert.ToString(dr[3]);
            }
        }
        private void dgvCatequesis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Catequesis_Load(object sender, EventArgs e)
        {
            GetFecha();
        }

        private void cbxFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            i = cbxFecha.SelectedIndex;
            
            //fecha = cbxFecha.SelectedItem.ToString();
            ds = negociosAsistencia.listadoCatequesis("Tema", id_Catequesis, fech[i]);
            if (ds.Tables[0].Rows.Count > 0)
            {


                foreach (DataRow dr in ds.Tables[0].Rows)//Lo que muestra esta en dr[0].ToString(), dr[1].ToString(),y asi sucesivamente
                {
                    lblTema.Text = System.Convert.ToString(dr[0]);
                }
                    //
                //dgvPersonas.Rows.Add(dr[0].ToString(), dr[1], dr[2]);////Rellena el dgv por cada ds que trae de la bd
                //lblNombre.Text = System.Convert.ToString(dr[3]);
            }

        }
    }
}
