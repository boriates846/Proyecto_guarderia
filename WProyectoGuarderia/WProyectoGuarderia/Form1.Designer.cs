namespace WProyectoGuarderia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.btnApoderado = new System.Windows.Forms.Button();
            this.btnDocente = new System.Windows.Forms.Button();
            this.btnDirector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApoderado
            // 
            this.btnApoderado.BackColor = System.Drawing.Color.Transparent;
            this.btnApoderado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApoderado.BackgroundImage")));
            this.btnApoderado.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApoderado.ForeColor = System.Drawing.SystemColors.Info;
            this.btnApoderado.Location = new System.Drawing.Point(125, 153);
            this.btnApoderado.Name = "btnApoderado";
            this.btnApoderado.Size = new System.Drawing.Size(147, 60);
            this.btnApoderado.TabIndex = 0;
            this.btnApoderado.Text = "Padre o Madre de Familia";
            this.btnApoderado.UseVisualStyleBackColor = false;
            this.btnApoderado.Click += new System.EventHandler(this.btnApoderado_Click);
            // 
            // btnDocente
            // 
            this.btnDocente.BackColor = System.Drawing.Color.Transparent;
            this.btnDocente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDocente.BackgroundImage")));
            this.btnDocente.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocente.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDocente.Location = new System.Drawing.Point(310, 153);
            this.btnDocente.Name = "btnDocente";
            this.btnDocente.Size = new System.Drawing.Size(147, 60);
            this.btnDocente.TabIndex = 1;
            this.btnDocente.Text = "Docente";
            this.btnDocente.UseVisualStyleBackColor = false;
            this.btnDocente.Click += new System.EventHandler(this.btnDocente_Click);
            // 
            // btnDirector
            // 
            this.btnDirector.BackColor = System.Drawing.Color.Transparent;
            this.btnDirector.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDirector.BackgroundImage")));
            this.btnDirector.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirector.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDirector.Location = new System.Drawing.Point(218, 39);
            this.btnDirector.Name = "btnDirector";
            this.btnDirector.Size = new System.Drawing.Size(147, 58);
            this.btnDirector.TabIndex = 2;
            this.btnDirector.Text = "Director(a)";
            this.btnDirector.UseVisualStyleBackColor = false;
            this.btnDirector.Click += new System.EventHandler(this.btnDirector_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImage = global::WProyectoGuarderia.Properties.Resources.portNiños;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 365);
            this.Controls.Add(this.btnDirector);
            this.Controls.Add(this.btnDocente);
            this.Controls.Add(this.btnApoderado);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Windows.Forms.Button btnApoderado;
        private System.Windows.Forms.Button btnDocente;
        private System.Windows.Forms.Button btnDirector;
    }
}

