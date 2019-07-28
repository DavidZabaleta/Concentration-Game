namespace Concentrese_2._0
{
    partial class Concentrese
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Concentrese));
            this.Salir = new System.Windows.Forms.PictureBox();
            this.Jugar = new System.Windows.Forms.PictureBox();
            this.Titulo = new System.Windows.Forms.PictureBox();
            this.Creditos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Titulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Creditos)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Salir.BackColor = System.Drawing.Color.Transparent;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(894, 390);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(183, 79);
            this.Salir.TabIndex = 5;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Jugar
            // 
            this.Jugar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Jugar.BackColor = System.Drawing.Color.Transparent;
            this.Jugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Jugar.Image = ((System.Drawing.Image)(resources.GetObject("Jugar.Image")));
            this.Jugar.Location = new System.Drawing.Point(0, 390);
            this.Jugar.Name = "Jugar";
            this.Jugar.Size = new System.Drawing.Size(239, 79);
            this.Jugar.TabIndex = 4;
            this.Jugar.TabStop = false;
            this.Jugar.Click += new System.EventHandler(this.Jugar_Click);
            // 
            // Titulo
            // 
            this.Titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Image = ((System.Drawing.Image)(resources.GetObject("Titulo.Image")));
            this.Titulo.Location = new System.Drawing.Point(103, 60);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(874, 114);
            this.Titulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Titulo.TabIndex = 3;
            this.Titulo.TabStop = false;
            // 
            // Creditos
            // 
            this.Creditos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Creditos.BackColor = System.Drawing.Color.Transparent;
            this.Creditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Creditos.Image = global::Concentrese_2._0.Properties.Resources.Creditos4;
            this.Creditos.Location = new System.Drawing.Point(942, 691);
            this.Creditos.Name = "Creditos";
            this.Creditos.Size = new System.Drawing.Size(137, 28);
            this.Creditos.TabIndex = 6;
            this.Creditos.TabStop = false;
            this.Creditos.Click += new System.EventHandler(this.Creditos_Click);
            // 
            // Concentrese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.Creditos);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Jugar);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Concentrese";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Concentrese_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jugar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Titulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Creditos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.PictureBox Jugar;
        private System.Windows.Forms.PictureBox Titulo;
        private System.Windows.Forms.PictureBox Creditos;
    }
}

