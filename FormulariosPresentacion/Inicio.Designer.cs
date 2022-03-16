
namespace FormulariosPresentacion
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarNuevaPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarNuevaCapillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxFiltro = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblDia = new System.Windows.Forms.Label();
            this.labelSalon = new System.Windows.Forms.Label();
            this.lblCapilla = new System.Windows.Forms.Label();
            this.cbxDia = new System.Windows.Forms.ComboBox();
            this.cbxSalon = new System.Windows.Forms.ComboBox();
            this.cbxCapilla = new System.Windows.Forms.ComboBox();
            this.lblSalon = new System.Windows.Forms.Label();
            this.btnPersonas = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnCatequesis = new System.Windows.Forms.Button();
            this.nuevaCatequesisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.gbxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarNuevaPersonaToolStripMenuItem,
            this.cargarNuevaCapillaToolStripMenuItem,
            this.cargarToolStripMenuItem,
            this.nuevaCatequesisToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarNuevaPersonaToolStripMenuItem
            // 
            this.cargarNuevaPersonaToolStripMenuItem.Name = "cargarNuevaPersonaToolStripMenuItem";
            this.cargarNuevaPersonaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargarNuevaPersonaToolStripMenuItem.Text = "Nueva Persona";
            this.cargarNuevaPersonaToolStripMenuItem.Click += new System.EventHandler(this.cargarNuevaPersonaToolStripMenuItem_Click);
            // 
            // cargarNuevaCapillaToolStripMenuItem
            // 
            this.cargarNuevaCapillaToolStripMenuItem.Name = "cargarNuevaCapillaToolStripMenuItem";
            this.cargarNuevaCapillaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargarNuevaCapillaToolStripMenuItem.Text = "Nueva Capilla";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargarToolStripMenuItem.Text = "Nuevo Salón";
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbxFiltro.Controls.Add(this.btnCancelar);
            this.gbxFiltro.Controls.Add(this.btnBuscar);
            this.gbxFiltro.Controls.Add(this.lblDia);
            this.gbxFiltro.Controls.Add(this.labelSalon);
            this.gbxFiltro.Controls.Add(this.lblCapilla);
            this.gbxFiltro.Controls.Add(this.cbxDia);
            this.gbxFiltro.Controls.Add(this.cbxSalon);
            this.gbxFiltro.Controls.Add(this.cbxCapilla);
            this.gbxFiltro.Controls.Add(this.lblSalon);
            this.gbxFiltro.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.gbxFiltro.Location = new System.Drawing.Point(18, 152);
            this.gbxFiltro.Name = "gbxFiltro";
            this.gbxFiltro.Size = new System.Drawing.Size(392, 335);
            this.gbxFiltro.TabIndex = 4;
            this.gbxFiltro.TabStop = false;
            this.gbxFiltro.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(195, 278);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 31);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(93, 278);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 31);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(91, 193);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(35, 23);
            this.lblDia.TabIndex = 26;
            this.lblDia.Text = "Dia";
            // 
            // labelSalon
            // 
            this.labelSalon.AutoSize = true;
            this.labelSalon.Location = new System.Drawing.Point(91, 128);
            this.labelSalon.Name = "labelSalon";
            this.labelSalon.Size = new System.Drawing.Size(50, 23);
            this.labelSalon.TabIndex = 25;
            this.labelSalon.Text = "Salón";
            // 
            // lblCapilla
            // 
            this.lblCapilla.AutoSize = true;
            this.lblCapilla.Location = new System.Drawing.Point(91, 69);
            this.lblCapilla.Name = "lblCapilla";
            this.lblCapilla.Size = new System.Drawing.Size(59, 23);
            this.lblCapilla.TabIndex = 24;
            this.lblCapilla.Text = "Capilla";
            // 
            // cbxDia
            // 
            this.cbxDia.BackColor = System.Drawing.SystemColors.Control;
            this.cbxDia.FormattingEnabled = true;
            this.cbxDia.Location = new System.Drawing.Point(91, 219);
            this.cbxDia.Name = "cbxDia";
            this.cbxDia.Size = new System.Drawing.Size(184, 31);
            this.cbxDia.TabIndex = 29;
            this.cbxDia.SelectedIndexChanged += new System.EventHandler(this.cbxDia_SelectedIndexChanged);
            // 
            // cbxSalon
            // 
            this.cbxSalon.BackColor = System.Drawing.SystemColors.Control;
            this.cbxSalon.FormattingEnabled = true;
            this.cbxSalon.Location = new System.Drawing.Point(91, 154);
            this.cbxSalon.Name = "cbxSalon";
            this.cbxSalon.Size = new System.Drawing.Size(184, 31);
            this.cbxSalon.TabIndex = 28;
            this.cbxSalon.SelectedIndexChanged += new System.EventHandler(this.cbxSalon_SelectedIndexChanged);
            // 
            // cbxCapilla
            // 
            this.cbxCapilla.BackColor = System.Drawing.SystemColors.Control;
            this.cbxCapilla.FormattingEnabled = true;
            this.cbxCapilla.Location = new System.Drawing.Point(91, 94);
            this.cbxCapilla.Name = "cbxCapilla";
            this.cbxCapilla.Size = new System.Drawing.Size(184, 31);
            this.cbxCapilla.TabIndex = 27;
            this.cbxCapilla.SelectedIndexChanged += new System.EventHandler(this.cbxCapilla_SelectedIndexChanged);
            // 
            // lblSalon
            // 
            this.lblSalon.AutoSize = true;
            this.lblSalon.Location = new System.Drawing.Point(91, 19);
            this.lblSalon.Name = "lblSalon";
            this.lblSalon.Size = new System.Drawing.Size(184, 23);
            this.lblSalon.TabIndex = 23;
            this.lblSalon.Text = "Seleccionar Catequesis";
            // 
            // btnPersonas
            // 
            this.btnPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPersonas.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnPersonas.Location = new System.Drawing.Point(287, 74);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(123, 60);
            this.btnPersonas.TabIndex = 5;
            this.btnPersonas.Text = "Ver Personas";
            this.btnPersonas.UseVisualStyleBackColor = false;
            this.btnPersonas.Click += new System.EventHandler(this.btnPersonas_Click);
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAsistencia.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAsistencia.Location = new System.Drawing.Point(156, 74);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(123, 60);
            this.btnAsistencia.TabIndex = 6;
            this.btnAsistencia.Text = "Tomar Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = false;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // btnCatequesis
            // 
            this.btnCatequesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCatequesis.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCatequesis.Location = new System.Drawing.Point(18, 74);
            this.btnCatequesis.Name = "btnCatequesis";
            this.btnCatequesis.Size = new System.Drawing.Size(123, 60);
            this.btnCatequesis.TabIndex = 7;
            this.btnCatequesis.Text = "Grupos de Catequesis";
            this.btnCatequesis.UseVisualStyleBackColor = false;
            this.btnCatequesis.Click += new System.EventHandler(this.btnCatequesis_Click);
            // 
            // nuevaCatequesisToolStripMenuItem
            // 
            this.nuevaCatequesisToolStripMenuItem.Name = "nuevaCatequesisToolStripMenuItem";
            this.nuevaCatequesisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaCatequesisToolStripMenuItem.Text = "Nueva Catequesis";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(548, 576);
            this.Controls.Add(this.btnCatequesis);
            this.Controls.Add(this.btnAsistencia);
            this.Controls.Add(this.btnPersonas);
            this.Controls.Add(this.gbxFiltro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Text = "Gestor Parroquial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarNuevaPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarNuevaCapillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxFiltro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label labelSalon;
        private System.Windows.Forms.Label lblCapilla;
        private System.Windows.Forms.ComboBox cbxDia;
        private System.Windows.Forms.ComboBox cbxSalon;
        private System.Windows.Forms.ComboBox cbxCapilla;
        private System.Windows.Forms.Label lblSalon;
        private System.Windows.Forms.Button btnPersonas;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnCatequesis;
        private System.Windows.Forms.ToolStripMenuItem nuevaCatequesisToolStripMenuItem;
        //private System.Windows.Forms.DataGridViewTextBoxColumn capilla;
        //private System.Windows.Forms.DataGridViewTextBoxColumn salon;
    }
}

