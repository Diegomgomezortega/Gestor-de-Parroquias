﻿using Entidades;
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
        public string accion;
        string capilla;
        string salon;
        string dia;
        public int[] Cod_Catequesis;
        public int i;
        public int id_Persona;
        public NegociosCatecumenos negociosCatecumenos = new NegociosCatecumenos();
        public NegociosCatequistas negociosCatequistas = new NegociosCatequistas();
        public NegociosSacerdotes negociosSacerdotes = new NegociosSacerdotes();
        public Catecumeno objetoCatecumeno = new Catecumeno();
        public Catequista objetoCatequista = new Catequista();
        public Sacerdote objetoSacerdote = new Sacerdote();
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
                    accion = "Modificar";
                    objetoCatecumeno.Id_Catecumeno = id_Persona;
                    objetoCatequista.Id_Catequista = id_Persona;
                    objetoSacerdote.Id_Sacerdote = id_Persona;
                }
                else
                {
                    accion = "Alta";
                }
                if (cbxRol.SelectedIndex == 0)
                {


                    ngrabados = negociosCatecumenos.abmCatecumeno(accion, objetoCatecumeno);//Invoco a la capa de negocios

                    if (ngrabados != -1)
                    {
                        MessageBox.Show("la accion se realizo con exito");

                        //lblInformacion.Text = "Los datos fueron modificados con éxito";
                        //Limpiar();
                        //LlenarDGV();
                        //txtCodigo.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error al intentar la acción");
                    }

                }
                if (cbxRol.SelectedIndex == 1)
                {
                    ngrabados = negociosCatequistas.abmCatequista(accion, objetoCatequista);//Invoco a la capa de negocios

                    if (ngrabados != -1)
                    {
                        MessageBox.Show("la accion se realizo con exito");

                        //lblInformacion.Text = "Los datos fueron modificados con éxito";
                        //Limpiar();
                        //LlenarDGV();
                        //txtCodigo.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error al intentar la acción");
                    }

                }
                if (cbxRol.SelectedIndex == 2)
                {
                    //objetoSacerdote.Id_Sacerdote = id_Persona;
                    ngrabados = negociosSacerdotes.abmSacerdotes(accion, objetoSacerdote);//Invoco a la capa de negocios

                    if (ngrabados != -1)
                    {
                        MessageBox.Show("la accion se realizo con exito");

                        //lblInformacion.Text = "Los datos fueron modificados con éxito";
                        //Limpiar();
                        //LlenarDGV();
                        //txtCodigo.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error al intentar la acción");
                    }

                }


            }
            catch (Exception ex)
            {
                throw new Exception("Error de grabado de datos", ex);
                //MessageBox.Show(e,"LLenar todos los campos");
            }
            this.Close();
        }

        private void Txtbox_a_obj()//metodo para tomar los datos del formulario/text box y colocar los atributos a la instacia de la clase, Toma los datos de ls txbox y utiliza las propiedades de la clase docente
        {
            
            if (cbxRol.SelectedIndex == 0)
            {
                objetoCatecumeno.Dni = System.Convert.ToInt32(txtDNI.Text);
                objetoCatecumeno.Apellido = txtApellido.Text;
                objetoCatecumeno.Nombre = txtNombre.Text;
                char Genero = new char();
                if (rbMasculino.Checked)
                {
                    Genero = 'm';
                }
                else if (rbFemenino.Checked)
                {
                    Genero = 'f';
                }

                objetoCatecumeno.Sexo = Genero;
                objetoCatecumeno.FechNac = dtpFecNac.Value;
                objetoCatecumeno.Telefono = System.Convert.ToInt64(txtTelefono.Text);
                i = cbxDia.SelectedIndex;
                objetoCatecumeno.Cod_Catequesis = Cod_Catequesis[i];

            }
            if (cbxRol.SelectedIndex == 1)
            {
                objetoCatequista.Dni = System.Convert.ToInt32(txtDNI.Text);
                objetoCatequista.Apellido = txtApellido.Text;
                objetoCatequista.Nombre = txtNombre.Text;
                char Genero = new char();
                if (rbMasculino.Checked)
                {
                    Genero = 'm';
                }
                else if (rbFemenino.Checked)
                {
                    Genero = 'f';
                }

                objetoCatequista.Sexo = Genero;
                objetoCatequista.FechNac = dtpFecNac.Value;
                objetoCatequista.Telefono = System.Convert.ToInt64(txtTelefono.Text);

            }
            if (cbxRol.SelectedIndex == 2)
            {
                objetoSacerdote.Dni = System.Convert.ToInt32(txtDNI.Text);
                objetoSacerdote.Apellido = txtApellido.Text;
                objetoSacerdote.Nombre = txtNombre.Text;
                char Genero = new char();
                if (rbMasculino.Checked)
                {
                    Genero = 'm';
                }
                else if (rbFemenino.Checked)
                {
                    Genero = 'f';
                }

                objetoSacerdote.Sexo = Genero;
                objetoSacerdote.FechNac = dtpFecNac.Value;
                objetoSacerdote.Telefono = System.Convert.ToInt64(txtTelefono.Text);

            }
            
       
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
            Cod_Catequesis[0] = 0;
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
                    Cod_Catequesis[i] = System.Convert.ToInt32(dr[0]);
                    i++;
                    
                    
                    
                }
                
            }

        }

       
        private void GetSalones(string capilla)
        {
            cbxSalon.Items.Clear();
            DataSet dsSalones = new DataSet();
            dsSalones = negociosParroquias.listado("Salones", capilla);
            Cod_Catequesis = new int[dsSalones.Tables[0].Rows.Count];
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

        
        public void Ds_a_TxtBox(DataSet ds,bool editar, int id)// Para modificar los datos haciendo click en la celda del dgv
        {
            txtDNI.Text = (ds.Tables[0].Rows[0]["DNI"].ToString());
            txtNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtApellido.Text = ds.Tables[0].Rows[0]["Apellido"].ToString();
            txtTelefono.Text= ds.Tables[0].Rows[0]["Telefono"].ToString();
            //dtpFecNac.Value = System.Convert.ToDateTime(ds.Tables[0].Rows[0]["Nacimiento"]);
            //dtpFecNac.Value.= System.Convert.ToDateTime(ds.Tables[0].Rows[0]["Nacimiento"]);
            //cbxMateria.SelectedItem = ds.Tables[0].Rows[0]["MATERIA"].ToString();
            editarpersona = editar;
            id_Persona = id;
        }




    }

}
