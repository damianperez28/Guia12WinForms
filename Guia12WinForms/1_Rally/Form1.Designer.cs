namespace _1_Rally
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
            this.btnAgregarCom = new System.Windows.Forms.Button();
            this.btnCargarTiempos = new System.Windows.Forms.Button();
            this.btnVerResultados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarCom
            // 
            this.btnAgregarCom.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarCom.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAgregarCom.FlatAppearance.BorderSize = 0;
            this.btnAgregarCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCom.Font = new System.Drawing.Font("Nexa Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCom.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCom.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAgregarCom.Location = new System.Drawing.Point(530, 1);
            this.btnAgregarCom.Name = "btnAgregarCom";
            this.btnAgregarCom.Size = new System.Drawing.Size(161, 39);
            this.btnAgregarCom.TabIndex = 0;
            this.btnAgregarCom.Text = "Inscribir";
            this.btnAgregarCom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCom.UseVisualStyleBackColor = false;
            this.btnAgregarCom.Click += new System.EventHandler(this.btnAgregarCom_Click);
            // 
            // btnCargarTiempos
            // 
            this.btnCargarTiempos.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarTiempos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCargarTiempos.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCargarTiempos.FlatAppearance.BorderSize = 0;
            this.btnCargarTiempos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarTiempos.Font = new System.Drawing.Font("Nexa Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarTiempos.ForeColor = System.Drawing.Color.White;
            this.btnCargarTiempos.Location = new System.Drawing.Point(530, 44);
            this.btnCargarTiempos.Name = "btnCargarTiempos";
            this.btnCargarTiempos.Size = new System.Drawing.Size(161, 39);
            this.btnCargarTiempos.TabIndex = 1;
            this.btnCargarTiempos.Text = "Cargar tiempos";
            this.btnCargarTiempos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarTiempos.UseVisualStyleBackColor = false;
            this.btnCargarTiempos.Click += new System.EventHandler(this.btnCargarTiempos_Click);
            // 
            // btnVerResultados
            // 
            this.btnVerResultados.BackColor = System.Drawing.Color.Transparent;
            this.btnVerResultados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVerResultados.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnVerResultados.FlatAppearance.BorderSize = 0;
            this.btnVerResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerResultados.Font = new System.Drawing.Font("Nexa Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerResultados.ForeColor = System.Drawing.Color.White;
            this.btnVerResultados.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnVerResultados.Location = new System.Drawing.Point(530, 87);
            this.btnVerResultados.Name = "btnVerResultados";
            this.btnVerResultados.Size = new System.Drawing.Size(161, 39);
            this.btnVerResultados.TabIndex = 2;
            this.btnVerResultados.Text = "Ver resultados";
            this.btnVerResultados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerResultados.UseVisualStyleBackColor = false;
            this.btnVerResultados.Click += new System.EventHandler(this.btnVerResultados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 422);
            this.Controls.Add(this.btnVerResultados);
            this.Controls.Add(this.btnCargarTiempos);
            this.Controls.Add(this.btnAgregarCom);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCom;
        private System.Windows.Forms.Button btnCargarTiempos;
        private System.Windows.Forms.Button btnVerResultados;
    }
}

