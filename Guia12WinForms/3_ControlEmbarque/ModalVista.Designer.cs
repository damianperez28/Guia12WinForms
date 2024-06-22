namespace _3_ControlEmbarque
{
    partial class ModalVista
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
            this.lbVista = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbVista
            // 
            this.lbVista.FormattingEnabled = true;
            this.lbVista.Location = new System.Drawing.Point(12, 31);
            this.lbVista.Name = "lbVista";
            this.lbVista.Size = new System.Drawing.Size(469, 186);
            this.lbVista.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ModalVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbVista);
            this.Name = "ModalVista";
            this.Text = "ModalVista";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox lbVista;
    }
}