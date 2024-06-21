using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_PuntoDeControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Controladora controladora = new Controladora();

        private void button1_Click(object sender, EventArgs e)
        {
            string patente = tbPatente.Text;
            string tipo = cbTipo.Text;
            int modelo = Convert.ToInt32(tbModelo.Text);
            bool electrico;

            if(chbElec.Checked == true)
            {
                electrico = true;
            }
            else { electrico = false; }

            if(controladora.contador < controladora.patentes.Length) 
            {
                controladora.RegistrarVehiculo(patente, tipo, modelo, electrico);
            }
            else { MessageBox.Show("No se registran mas autos"); }


        }

        private void btnVerEstadistica_Click(object sender, EventArgs e)
        {
            ModalVerListado modalVer = new ModalVerListado();
            controladora.OrdenarElectricos();
            for (int i = 0; i< controladora.contadorElectricos; i++)
            {
                modalVer.lbResultados.Items.Add(controladora.patentesElectricos[i] + " - " + controladora.tiposVehiculosElectricos[i] + " - " + controladora.modelosElectricos[i]);
            }
            modalVer.ShowDialog();
            if(modalVer.DialogResult == DialogResult.Cancel) 
            {
                modalVer.lbResultados.Items.Clear();
            }
        }
    }
}
