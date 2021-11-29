using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Negocios;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosPresentacion
{
    public partial class Asistencia : Form
    {
        public Asistencia()
        {
            InitializeComponent();
         
        }
        #region Atributos
        NegociosAsistencia negociosAsistencia = new NegociosAsistencia();
        string ordenSQL= "insert into Asistencia (Fecha,Tema,Asistencia,Id_Catecumeno,Id_Catequesis) values ";
        char[] PresenteCate;
        int[] Id_Catecumeno;
        int Cod_Catequesis;
        int CantidadCate;
        int i;
        DateTime Fecha;
        string Tema;
        #endregion

        public void LlenarDGV(DataSet ds, int id_Catequesis, string nombreSalon)

        {
            
            Cod_Catequesis = id_Catequesis;
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)//Lo que muestra esta en dr[0].ToString(), dr[1].ToString(),y asi sucesivamente
                {
                    dgvPersonas.Rows.Add(dr[0], dr[1],dr[2]);////Rellena el dgv por cada ds que trae de la bd
                }
            }
            else
            {
                //lblInformacion.Text = "No hay personas cargadas en el sistema";
            }
            dgvPersonas.Visible = true;
            CantidadCate = dgvPersonas.Rows.Count;
            lblCantidad.Text = System.Convert.ToString(CantidadCate);
            lblNombreSalon.Text = nombreSalon;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtTema.Text == string.Empty)//Si el txt tema esta vacio, no genera la carga
            {
                MessageBox.Show("Por favor, ingrese el tema del encuentro.");
                txtTema.Focus();

            }
            else
            {
                Fecha = dtpFecha.Value;
                Tema = txtTema.Text;
                Id_Catecumeno = new int[CantidadCate];
                PresenteCate = new char[CantidadCate];
                for (i = 0; i < CantidadCate; i++)
                {
                    Id_Catecumeno[i] = System.Convert.ToInt32(dgvPersonas.Rows[i].Cells[0].Value);

                }
                i = 0;
                foreach (DataGridViewRow row in dgvPersonas.Rows)
                {
                    DataGridViewCheckBoxCell cell = row.Cells[3] as DataGridViewCheckBoxCell;

                    if (System.Convert.ToBoolean(cell.Value) == true)
                    {
                        PresenteCate[i] = 'p';
                    }
                    else
                    {
                        PresenteCate[i] = 'a';
                    }

                    i++;
                }
                for (i = 0; i < CantidadCate; i++)//Utilizo un for para una consulta multiple de SQL
                {
                    if (i == 0)
                    {
                        ordenSQL = ordenSQL + "('" + Fecha.Year + " / " + Fecha.Date.Month + " / " + Fecha.Date.Day + "','" + Tema + "','" + PresenteCate[i] + "'," + Id_Catecumeno[i] + "," + Cod_Catequesis + ")";
                    }
                    else
                    {
                        ordenSQL = ordenSQL + ",";
                        ordenSQL = ordenSQL + "('" + Fecha.Year + " / " + Fecha.Date.Month + " / " + Fecha.Date.Day + "','" + Tema + "','" + PresenteCate[i] + "'," + Id_Catecumeno[i] + "," + Cod_Catequesis + ")";
                    }

                }
                int ngrabados = -1;
                ngrabados = negociosAsistencia.altaAsistencia(ordenSQL);
                if (ngrabados != -1)
                {
                    MessageBox.Show("la accion se realizo con exito");

                }
                else
                {
                    MessageBox.Show("Se produjo un error al intentar la acción");
                }
                this.Close();


            }


        }

        private void txtTema_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
