
namespace FormulariosPresentacion
{
    partial class ABM_Personas
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
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.btnCatecumenos = new System.Windows.Forms.Button();
            this.btnSacerdotes = new System.Windows.Forms.Button();
            this.btnCatequistas = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.gbxAcciones = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.gbxAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(12, 229);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.RowTemplate.Height = 25;
            this.dgvPersonas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPersonas.Size = new System.Drawing.Size(752, 269);
            this.dgvPersonas.TabIndex = 0;
            this.dgvPersonas.Visible = false;
            // 
            // btnCatecumenos
            // 
            this.btnCatecumenos.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCatecumenos.Location = new System.Drawing.Point(18, 102);
            this.btnCatecumenos.Name = "btnCatecumenos";
            this.btnCatecumenos.Size = new System.Drawing.Size(148, 37);
            this.btnCatecumenos.TabIndex = 1;
            this.btnCatecumenos.Text = "Catecumenos";
            this.btnCatecumenos.UseVisualStyleBackColor = true;
            this.btnCatecumenos.Click += new System.EventHandler(this.btnCatecumenos_Click);
            // 
            // btnSacerdotes
            // 
            this.btnSacerdotes.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSacerdotes.Location = new System.Drawing.Point(183, 102);
            this.btnSacerdotes.Name = "btnSacerdotes";
            this.btnSacerdotes.Size = new System.Drawing.Size(148, 37);
            this.btnSacerdotes.TabIndex = 2;
            this.btnSacerdotes.Text = "Sacerdotes";
            this.btnSacerdotes.UseVisualStyleBackColor = true;
            this.btnSacerdotes.Click += new System.EventHandler(this.btnSacerdotes_Click);
            // 
            // btnCatequistas
            // 
            this.btnCatequistas.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCatequistas.Location = new System.Drawing.Point(348, 102);
            this.btnCatequistas.Name = "btnCatequistas";
            this.btnCatequistas.Size = new System.Drawing.Size(148, 37);
            this.btnCatequistas.TabIndex = 3;
            this.btnCatequistas.Text = "Catequistas";
            this.btnCatequistas.UseVisualStyleBackColor = true;
            this.btnCatequistas.Click += new System.EventHandler(this.btnCatequistas_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(6, 22);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 29);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBorrar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.Location = new System.Drawing.Point(111, 22);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(99, 29);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // gbxAcciones
            // 
            this.gbxAcciones.Controls.Add(this.btnEditar);
            this.gbxAcciones.Controls.Add(this.btnBorrar);
            this.gbxAcciones.Location = new System.Drawing.Point(12, 162);
            this.gbxAcciones.Name = "gbxAcciones";
            this.gbxAcciones.Size = new System.Drawing.Size(325, 61);
            this.gbxAcciones.TabIndex = 6;
            this.gbxAcciones.TabStop = false;
            // 
            // ABM_Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.gbxAcciones);
            this.Controls.Add(this.btnCatequistas);
            this.Controls.Add(this.btnSacerdotes);
            this.Controls.Add(this.btnCatecumenos);
            this.Controls.Add(this.dgvPersonas);
            this.Name = "ABM_Personas";
            this.Text = "ABM_Personas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.gbxAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Button btnCatecumenos;
        private System.Windows.Forms.Button btnSacerdotes;
        private System.Windows.Forms.Button btnCatequistas;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox gbxAcciones;
    }
}