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
    public partial class CrearPersona : Form
    {
        public CrearPersona()
        {
            InitializeComponent();
            string[] rol = new string[3];
            rol[0] = "Catecumeno";
            rol[1] = "Catequista";
            rol[2] = "Sacerdote";
            cbxRol.DataSource = rol;
            cbxRol.DropDownStyle = ComboBoxStyle.DropDownList;//Hacer solo lectura el combobox
            cbxSalon.DropDownStyle = ComboBoxStyle.DropDownList;//Hacer solo lectura el combobox
            cbxCapilla.DropDownStyle = ComboBoxStyle.DropDownList;//Hacer solo lectura el combobox
            cbxDia.DropDownStyle = ComboBoxStyle.DropDownList;//Hacer solo lectura el combobox
            //if (editar == true)
            //{
            //    lblNuevaPersona.Text = "Editar Persona";
            //    cbxRol.Visible = false;
            //}

            GetCapillas();


        }


        //public ABM_Personas aBM = new ABM_Personas();
        private bool catecumeno;
        private bool editarpersona;
        string capilla;
        string salon;
        string dia;
        public int[] id;
        public int i;
        public NegociosCatecumenos negociosCatecumenos = new NegociosCatecumenos();
        public Catecumeno objetoCatecumeno = new Catecumeno();
        public NegociosParroquias negociosParroquias = new NegociosParroquias();

        


        
        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                int ngrabados = -1;//la utilizo para detectar si fue grabado exitosamente o no
                Txtbox_a_obj();
                if (editarpersona)
                {
                    ngrabados = negociosCatecumenos.abmCatecumeno("Modificar", objetoCatecumeno);//Invoco a la capa de negocios


                    if (ngrabados != -1)
                    {
                        MessageBox.Show("Se modifico con exito");
                        
                        //lblInformacion.Text = "Los datos fueron modificados con éxito";
                        //Limpiar();
                        //LlenarDGV();
                        //txtCodigo.Enabled = true;
                    }
                    else
                    {
                        //lblInformacion.Text = ("Se produjo un error al intentar modificar los datos");
                    }

                }
                else


                {

                    ngrabados = negociosCatecumenos.abmCatecumeno("Alta", objetoCatecumeno);//
                    if (ngrabados == -1)
                    {
                        //lblInformacion.Text = "No se pudo grabar los datos en el sistema";
                    }
                    else
                    {
                        //lblInformacion.Text = "Se grabaron los datos con éxito";
                        //LlenarDGV();
                        //Limpiar();//Limpia los textBox
                        //groupBox1.Visible = false;
                        //btnNuevo.Visible = true;
                        //btnBorrar.Visible = false;
                        this.Close();
                    }

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Alumnos", ex);
                //MessageBox.Show(e,"LLenar todos los campos");
            }
            this.Close();
        }

        private void Txtbox_a_obj()//metodo para tomar los datos del formulario/text box y colocar los atributos a la instacia de la clase, Toma los datos de ls txbox y utiliza las propiedades de la clase docente
        {
            i = cbxDia.SelectedIndex;
            objetoCatecumeno.Dni = System.Convert.ToInt32(txtDNI.Text);
            objetoCatecumeno.Apellido = txtApellido.Text;
            objetoCatecumeno.Nombre = txtNombre.Text;
            char Genero = new char();
            if (rbMasculino.Checked)
            {
                Genero = 'M';
            }
            else if (rbFemenino.Checked)
            {
                Genero = 'F';
            }
            
            objetoCatecumeno.Sexo = Genero;
            objetoCatecumeno.FechNac = dtpFecNac.Value;
            objetoCatecumeno.Telefono = System.Convert.ToInt64(txtTelefono.Text);
            objetoCatecumeno.Cod_Catequesis = id[i];
       
        }

        private void cbxRol_SelectedIndexChanged(object sender, EventArgs e)//Ver/Ocultar cbxRol
        {
            if (cbxRol.SelectedIndex == 0)
            {
                gbSalon.Visible = true;
                catecumeno = true;
            }
            else
            {
                gbSalon.Visible = false;
                catecumeno = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxCapilla_SelectedIndexChanged(object sender, EventArgs e)
        {

            capilla=cbxCapilla.SelectedItem.ToString();
            GetSalones(capilla);

        }
       

        private void cbxSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            id[0] = 0;
            i = 0;
            salon = cbxSalon.SelectedItem.ToString();
            cbxDia.Items.Clear();
            
            DataSet dsDia = new DataSet();
            dsDia = negociosParroquias.listado("Dia", salon);
            if (dsDia.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in dsDia.Tables[0].Rows)//Lo que muestra esta en dr[0].ToString(), dr[1].ToString(),y asi sucesivamente
                {
                    cbxDia.Items.Add(dr[1]+"-"+dr[2]);
                    id[i] = System.Convert.ToInt32(dr[0]);
                    i++;
                    
                    
                    
                }
                
            }

        }

       
        private void GetSalones(string capilla)
        {
            cbxSalon.Items.Clear();
            DataSet dsSalones = new DataSet();
            dsSalones = negociosParroquias.listado("Salones", capilla);
            id = new int[dsSalones.Tables[0].Rows.Count];
            if (dsSalones.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in dsSalones.Tables[0].Rows)//Lo que muestra esta en dr[0].ToString(), dr[1].ToString(),y asi sucesivamente
                {
                    cbxSalon.Items.Add(dr[1]);

                }
            }


        }
        private void GetCapillas()
        {
            DataSet dsCapilla = new DataSet();
            dsCapilla = negociosParroquias.listado("Capillas", "");
            if (dsCapilla.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in dsCapilla.Tables[0].Rows)//Lo que muestra esta en dr[0].ToString(), dr[1].ToString(),y asi sucesivamente
                {
                    cbxCapilla.Items.Add(dr[0]);

                }
            }


        }

        
        public void Ds_a_TxtBox(DataSet ds,bool editar, Catecumeno catecumeno)// Para modificar los datos haciendo click en la celda del dgv
        {
            txtDNI.Text = (ds.Tables[0].Rows[0]["DNI"].ToString());
            txtNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtApellido.Text = ds.Tables[0].Rows[0]["Apellido"].ToString();
            txtTelefono.Text= ds.Tables[0].Rows[0]["Telefono"].ToString();
            //dtpFecNac.Value = System.Convert.ToDateTime(ds.Tables[0].Rows[0]["Nacimiento"]);
            //dtpFecNac.Value.= System.Convert.ToDateTime(ds.Tables[0].Rows[0]["Nacimiento"]);
            //cbxMateria.SelectedItem = ds.Tables[0].Rows[0]["MATERIA"].ToString();
            editarpersona = editar;
            objetoCatecumeno.Id_Catecumeno = catecumeno.Id_Catecumeno;
        }


    }

}
