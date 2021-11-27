
namespace FormulariosPresentacion
{
    partial class CrearPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDNI = new System.Windows.Forms.Label();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.dtpFecNac = new System.Windows.Forms.DateTimePicker();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblNuevaPersona = new System.Windows.Forms.Label();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.gbSalon = new System.Windows.Forms.GroupBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.labelSalon = new System.Windows.Forms.Label();
            this.lblCapilla = new System.Windows.Forms.Label();
            this.cbxDia = new System.Windows.Forms.ComboBox();
            this.cbxSalon = new System.Windows.Forms.ComboBox();
            this.cbxCapilla = new System.Windows.Forms.ComboBox();
            this.lblSalon = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbSalon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Location = new System.Drawing.Point(57, 127);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(70, 15);
            this.lbDNI.TabIndex = 0;
            this.lbDNI.Text = "Documento";
            // 
            // cbxRol
            // 
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Location = new System.Drawing.Point(135, 87);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(121, 23);
            this.cbxRol.TabIndex = 12;
            this.cbxRol.SelectedIndexChanged += new System.EventHandler(this.cbxRol_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(57, 168);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(57, 214);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(57, 256);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 15);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(58, 299);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(69, 15);
            this.lblFechaNac.TabIndex = 6;
            this.lblFechaNac.Text = "Nacimiento";
            // 
            // dtpFecNac
            // 
            this.dtpFecNac.Location = new System.Drawing.Point(135, 299);
            this.dtpFecNac.Name = "dtpFecNac";
            this.dtpFecNac.Size = new System.Drawing.Size(200, 23);
            this.dtpFecNac.TabIndex = 17;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(57, 342);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(32, 15);
            this.lblSexo.TabIndex = 8;
            this.lblSexo.Text = "Sexo";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(134, 127);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(120, 23);
            this.txtDNI.TabIndex = 13;
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(134, 206);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(120, 23);
            this.txtApellido.TabIndex = 15;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(134, 248);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(120, 23);
            this.txtTelefono.TabIndex = 16;
            // 
            // lblNuevaPersona
            // 
            this.lblNuevaPersona.AutoSize = true;
            this.lblNuevaPersona.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblNuevaPersona.Location = new System.Drawing.Point(188, 26);
            this.lblNuevaPersona.Name = "lblNuevaPersona";
            this.lblNuevaPersona.Size = new System.Drawing.Size(139, 29);
            this.lblNuevaPersona.TabIndex = 17;
            this.lblNuevaPersona.Text = "Formulario";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Location = new System.Drawing.Point(135, 342);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbMasculino.TabIndex = 18;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(235, 342);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(78, 19);
            this.rbFemenino.TabIndex = 19;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // gbSalon
            // 
            this.gbSalon.Controls.Add(this.lblHorario);
            this.gbSalon.Controls.Add(this.labelSalon);
            this.gbSalon.Controls.Add(this.lblCapilla);
            this.gbSalon.Controls.Add(this.cbxDia);
            this.gbSalon.Controls.Add(this.cbxSalon);
            this.gbSalon.Controls.Add(this.cbxCapilla);
            this.gbSalon.Controls.Add(this.lblSalon);
            this.gbSalon.Location = new System.Drawing.Point(41, 367);
            this.gbSalon.Name = "gbSalon";
            this.gbSalon.Size = new System.Drawing.Size(419, 107);
            this.gbSalon.TabIndex = 20;
            this.gbSalon.TabStop = false;
            this.gbSalon.Visible = false;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(276, 48);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(47, 15);
            this.lblHorario.TabIndex = 19;
            this.lblHorario.Text = "Horario";
            // 
            // labelSalon
            // 
            this.labelSalon.AutoSize = true;
            this.labelSalon.Location = new System.Drawing.Point(144, 48);
            this.labelSalon.Name = "labelSalon";
            this.labelSalon.Size = new System.Drawing.Size(36, 15);
            this.labelSalon.TabIndex = 18;
            this.labelSalon.Text = "Salón";
            // 
            // lblCapilla
            // 
            this.lblCapilla.AutoSize = true;
            this.lblCapilla.Location = new System.Drawing.Point(17, 48);
            this.lblCapilla.Name = "lblCapilla";
            this.lblCapilla.Size = new System.Drawing.Size(43, 15);
            this.lblCapilla.TabIndex = 17;
            this.lblCapilla.Text = "Capilla";
            // 
            // cbxDia
            // 
            this.cbxDia.FormattingEnabled = true;
            this.cbxDia.Location = new System.Drawing.Point(276, 78);
            this.cbxDia.Name = "cbxDia";
            this.cbxDia.Size = new System.Drawing.Size(101, 23);
            this.cbxDia.TabIndex = 22;
            // 
            // cbxSalon
            // 
            this.cbxSalon.FormattingEnabled = true;
            this.cbxSalon.Location = new System.Drawing.Point(144, 78);
            this.cbxSalon.Name = "cbxSalon";
            this.cbxSalon.Size = new System.Drawing.Size(110, 23);
            this.cbxSalon.TabIndex = 21;
            this.cbxSalon.SelectedIndexChanged += new System.EventHandler(this.cbxSalon_SelectedIndexChanged);
            // 
            // cbxCapilla
            // 
            this.cbxCapilla.FormattingEnabled = true;
            this.cbxCapilla.Location = new System.Drawing.Point(17, 78);
            this.cbxCapilla.Name = "cbxCapilla";
            this.cbxCapilla.Size = new System.Drawing.Size(101, 23);
            this.cbxCapilla.TabIndex = 20;
            this.cbxCapilla.SelectedIndexChanged += new System.EventHandler(this.cbxCapilla_SelectedIndexChanged);
            // 
            // lblSalon
            // 
            this.lblSalon.AutoSize = true;
            this.lblSalon.Location = new System.Drawing.Point(16, 19);
            this.lblSalon.Name = "lblSalon";
            this.lblSalon.Size = new System.Drawing.Size(127, 15);
            this.lblSalon.TabIndex = 12;
            this.lblSalon.Text = "Seleccionar Catequesis";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 165);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 23);
            this.txtNombre.TabIndex = 14;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(57, 95);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(24, 15);
            this.lblRol.TabIndex = 22;
            this.lblRol.Text = "Rol";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(114, 506);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(101, 23);
            this.btnConfirmar.TabIndex = 23;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(235, 506);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CrearPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 585);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.gbSalon);
            this.Controls.Add(this.rbFemenino);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.lblNuevaPersona);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.dtpFecNac);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cbxRol);
            this.Controls.Add(this.lbDNI);
            this.Name = "CrearPersona";
            this.Text = "CrearPersona";
            this.gbSalon.ResumeLayout(false);
            this.gbSalon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.DateTimePicker dtpFecNac;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblNuevaPersona;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.GroupBox gbSalon;
        private System.Windows.Forms.ComboBox cbxSalon;
        private System.Windows.Forms.ComboBox cbxCapilla;
        private System.Windows.Forms.Label lblSalon;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxDia;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label labelSalon;
        private System.Windows.Forms.Label lblCapilla;
    }
}