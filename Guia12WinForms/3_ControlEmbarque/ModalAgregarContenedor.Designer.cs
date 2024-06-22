namespace _3_ControlEmbarque
{
    partial class ModalAgregarContenedor
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
            this.udID = new System.Windows.Forms.DomainUpDown();
            this.udPeso = new System.Windows.Forms.DomainUpDown();
            this.cboxPaisRegistro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // udID
            // 
            this.udID.Location = new System.Drawing.Point(99, 33);
            this.udID.Name = "udID";
            this.udID.Size = new System.Drawing.Size(120, 20);
            this.udID.TabIndex = 0;
            this.udID.Text = "domainUpDown1";
            // 
            // udPeso
            // 
            this.udPeso.Location = new System.Drawing.Point(99, 109);
            this.udPeso.Name = "udPeso";
            this.udPeso.Size = new System.Drawing.Size(120, 20);
            this.udPeso.TabIndex = 1;
            this.udPeso.Text = "domainUpDown2";
            // 
            // cboxPaisRegistro
            // 
            this.cboxPaisRegistro.AutoCompleteCustomSource.AddRange(new string[] {
            "Argentina",
            "Brasil",
            "China",
            "Uruaguay"});
            this.cboxPaisRegistro.FormattingEnabled = true;
            this.cboxPaisRegistro.Location = new System.Drawing.Point(98, 72);
            this.cboxPaisRegistro.Name = "cboxPaisRegistro";
            this.cboxPaisRegistro.Size = new System.Drawing.Size(121, 21);
            this.cboxPaisRegistro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pais Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Peso";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRegistrar.Location = new System.Drawing.Point(34, 161);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(185, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // ModalAgregarContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 211);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxPaisRegistro);
            this.Controls.Add(this.udPeso);
            this.Controls.Add(this.udID);
            this.Name = "ModalAgregarContenedor";
            this.Text = "ModalAgregarContenedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrar;
        public System.Windows.Forms.DomainUpDown udID;
        public System.Windows.Forms.ComboBox cboxPaisRegistro;
        public System.Windows.Forms.DomainUpDown udPeso;
    }
}