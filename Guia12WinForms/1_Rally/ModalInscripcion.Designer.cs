namespace _1_Rally
{
    partial class Inscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscripcion));
            this.btnAgregarComp = new System.Windows.Forms.Button();
            this.tbNombreCompetidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarComp
            // 
            this.btnAgregarComp.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarComp.Location = new System.Drawing.Point(39, 138);
            this.btnAgregarComp.Name = "btnAgregarComp";
            this.btnAgregarComp.Size = new System.Drawing.Size(135, 23);
            this.btnAgregarComp.TabIndex = 0;
            this.btnAgregarComp.Text = "Agregar";
            this.btnAgregarComp.UseVisualStyleBackColor = true;
            this.btnAgregarComp.Click += new System.EventHandler(this.btnAgregarComp_Click);
            // 
            // tbNombreCompetidor
            // 
            this.tbNombreCompetidor.Location = new System.Drawing.Point(91, 112);
            this.tbNombreCompetidor.Name = "tbNombreCompetidor";
            this.tbNombreCompetidor.Size = new System.Drawing.Size(83, 20);
            this.tbNombreCompetidor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // Inscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(413, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombreCompetidor);
            this.Controls.Add(this.btnAgregarComp);
            this.Name = "Inscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripcion";
            this.Load += new System.EventHandler(this.Inscripcion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnAgregarComp;
        public System.Windows.Forms.TextBox tbNombreCompetidor;
    }
}