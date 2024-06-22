using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_ControlEmbarque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModalAgregarContenedor modalAgregar = new ModalAgregarContenedor();
            Controlador controlador = new Controlador();
            modalAgregar.ShowDialog();
            if(modalAgregar.DialogResult == DialogResult.OK)
            {
                int id = Convert.ToInt32(modalAgregar.udID.Text);
                double peso = Convert.ToDouble(modalAgregar.udPeso.Text);
                string pais = modalAgregar.cboxPaisRegistro.Text;
                controlador.AgregarContenedor(id, pais, peso);
            }
        }
    }
}
