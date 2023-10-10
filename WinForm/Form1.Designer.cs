
namespace WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPokeinfo = new System.Windows.Forms.DataGridView();
            this.pcbxPokemon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokeinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokeinfo
            // 
            this.dgvPokeinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokeinfo.Location = new System.Drawing.Point(12, 12);
            this.dgvPokeinfo.Name = "dgvPokeinfo";
            this.dgvPokeinfo.Size = new System.Drawing.Size(542, 209);
            this.dgvPokeinfo.TabIndex = 0;
            this.dgvPokeinfo.SelectionChanged += new System.EventHandler(this.dgvPokeinfo_SelectionChanged);
            // 
            // pcbxPokemon
            // 
            this.pcbxPokemon.Location = new System.Drawing.Point(596, 12);
            this.pcbxPokemon.Name = "pcbxPokemon";
            this.pcbxPokemon.Size = new System.Drawing.Size(215, 209);
            this.pcbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxPokemon.TabIndex = 1;
            this.pcbxPokemon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 269);
            this.Controls.Add(this.pcbxPokemon);
            this.Controls.Add(this.dgvPokeinfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokeinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokeinfo;
        private System.Windows.Forms.PictureBox pcbxPokemon;
    }
}

