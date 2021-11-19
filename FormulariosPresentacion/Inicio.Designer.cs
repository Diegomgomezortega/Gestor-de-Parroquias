
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
            this.dgvCatecumenos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatecumenos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCatecumenos
            // 
            this.dgvCatecumenos.AllowUserToAddRows = false;
            this.dgvCatecumenos.AllowUserToDeleteRows = false;
            this.dgvCatecumenos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatecumenos.Location = new System.Drawing.Point(55, 274);
            this.dgvCatecumenos.Name = "dgvCatecumenos";
            this.dgvCatecumenos.ReadOnly = true;
            this.dgvCatecumenos.RowTemplate.Height = 25;
            this.dgvCatecumenos.Size = new System.Drawing.Size(817, 150);
            this.dgvCatecumenos.TabIndex = 0;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.dgvCatecumenos);
            this.Name = "Inicio";
            this.Text = "Gestor Parroquial";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatecumenos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCatecumenos;
    }
}

