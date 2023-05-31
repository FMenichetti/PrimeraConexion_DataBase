
namespace PrimeraConexion_DataBase
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
            this.dataGridViewPokemon = new System.Windows.Forms.DataGridView();
            this.pictureBox1Pokemon = new System.Windows.Forms.PictureBox();
            this.dataGridView1Elementos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Pokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Elementos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPokemon
            // 
            this.dataGridViewPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPokemon.Location = new System.Drawing.Point(12, 37);
            this.dataGridViewPokemon.Name = "dataGridViewPokemon";
            this.dataGridViewPokemon.Size = new System.Drawing.Size(422, 232);
            this.dataGridViewPokemon.TabIndex = 0;
            this.dataGridViewPokemon.SelectionChanged += new System.EventHandler(this.dataGridViewPokemon_SelectionChanged);
            // 
            // pictureBox1Pokemon
            // 
            this.pictureBox1Pokemon.Location = new System.Drawing.Point(483, 37);
            this.pictureBox1Pokemon.Name = "pictureBox1Pokemon";
            this.pictureBox1Pokemon.Size = new System.Drawing.Size(305, 107);
            this.pictureBox1Pokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Pokemon.TabIndex = 1;
            this.pictureBox1Pokemon.TabStop = false;
            // 
            // dataGridView1Elementos
            // 
            this.dataGridView1Elementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Elementos.Location = new System.Drawing.Point(483, 167);
            this.dataGridView1Elementos.Name = "dataGridView1Elementos";
            this.dataGridView1Elementos.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1Elementos.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1Elementos);
            this.Controls.Add(this.pictureBox1Pokemon);
            this.Controls.Add(this.dataGridViewPokemon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Pokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Elementos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPokemon;
        private System.Windows.Forms.PictureBox pictureBox1Pokemon;
        private System.Windows.Forms.DataGridView dataGridView1Elementos;
    }
}

