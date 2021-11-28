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
    public partial class Asistencia : Form
    {
        public Asistencia()
        {
            InitializeComponent();
            #region Formato DGV
            //DataGridViewCheckBoxColumn columnaCheck = new DataGridViewCheckBoxColumn();
            //DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            //DataGridViewTextBoxColumn colApellido = new DataGridViewTextBoxColumn();
            //DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();

            ////dgvCatecumenos.Columns[1].HeaderText = "DNI";
            //dgvPersonas.Columns.Add(colId);
            //colId.Name = "Id";
            //dgvPersonas.Columns["Id"].ReadOnly = true;
            //dgvPersonas.Columns[0].HeaderText = "Id";

            //dgvPersonas.Columns.Add(colNombre);
            //colNombre.Name = "Nombre";
            //dgvPersonas.Columns[1].HeaderText = "Nombre";
            //dgvPersonas.Columns["Nombre"].ReadOnly = true;

            //dgvPersonas.Columns.Add(colApellido);
            //colApellido.Name = "Apellido";
            //dgvPersonas.Columns[2].HeaderText = "Apellido";
            //dgvPersonas.Columns["Apellido"].ReadOnly = true;

            //dgvPersonas.Columns.Add(columnaCheck);
            //columnaCheck.Name = "Presente";
            //dgvPersonas.Columns[3].HeaderText = "Presente";
            
            #endregion

        }
        string ordenSQL;
        char[] PresenteCate;
        int[] Id_Catecumeno;
        int Cod_Catequesis;
        int CantidadCate;
        int i;

        public void LlenarDGV(DataSet ds, int id_Catequesis)

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
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            
            Id_Catecumeno = new int[CantidadCate];
            PresenteCate = new char [CantidadCate];
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

            
        }
    }
}
