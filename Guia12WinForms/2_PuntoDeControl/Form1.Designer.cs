namespace _2_PuntoDeControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPatente = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.chbElec = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVerEstadistica = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.chbElec);
            this.groupBox1.Controls.Add(this.tbModelo);
            this.groupBox1.Controls.Add(this.tbPatente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(46, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar vehiculo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de vehiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo";
            // 
            // tbPatente
            // 
            this.tbPatente.Location = new System.Drawing.Point(146, 53);
            this.tbPatente.Name = "tbPatente";
            this.tbPatente.Size = new System.Drawing.Size(124, 20);
            this.tbPatente.TabIndex = 3;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(146, 128);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(124, 20);
            this.tbModelo.TabIndex = 5;
            // 
            // chbElec
            // 
            this.chbElec.AutoSize = true;
            this.chbElec.Location = new System.Drawing.Point(57, 164);
            this.chbElec.Name = "chbElec";
            this.chbElec.Size = new System.Drawing.Size(81, 17);
            this.chbElec.TabIndex = 6;
            this.chbElec.Text = "Es electrico";
            this.chbElec.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVerEstadistica
            // 
            this.btnVerEstadistica.Location = new System.Drawing.Point(46, 318);
            this.btnVerEstadistica.Name = "btnVerEstadistica";
            this.btnVerEstadistica.Size = new System.Drawing.Size(330, 26);
            this.btnVerEstadistica.TabIndex = 8;
            this.btnVerEstadistica.Text = "Ver estadistica";
            this.btnVerEstadistica.UseVisualStyleBackColor = true;
            this.btnVerEstadistica.Click += new System.EventHandler(this.btnVerEstadistica_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Automóvil",
            "Motocicleta",
            "Camioneta",
            "Camión"});
            this.cbTipo.Location = new System.Drawing.Point(146, 89);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(124, 21);
            this.cbTipo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 381);
            this.Controls.Add(this.btnVerEstadistica);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Registro de vehiculo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chbElec;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbPatente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerEstadistica;
        private System.Windows.Forms.ComboBox cbTipo;
    }
}

