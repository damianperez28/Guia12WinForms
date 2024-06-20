using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Rally
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Competencia competencia = new Competencia();
        private void btnAgregarCom_Click(object sender, EventArgs e)
        {
            if(competencia.contador == competencia.nombres.Length)
            {
                MessageBox.Show("Ya no se registrarán mas jugadores");
            }
            else
            {
                Inscripcion modalInscripcion = new Inscripcion();
                modalInscripcion.ShowDialog();

                if (modalInscripcion.DialogResult == DialogResult.OK)
                {
                    string nombre = modalInscripcion.tbNombreCompetidor.Text;
                    competencia.AgregarCompetidor(nombre);
                }
            }
        }
        private void btnCargarTiempos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inscripciones cerradas");
            btnAgregarCom.Enabled = false;
            ModalCargarTiempos modalCargarTiempos = new ModalCargarTiempos();

            for (int i = 0; i < competencia.contador; i++)
            {
                modalCargarTiempos.tbHH.Clear();
                modalCargarTiempos.tbMM.Clear();
                modalCargarTiempos.label4.Text = competencia.nombres[i].ToString();
                modalCargarTiempos.ShowDialog();
                if (modalCargarTiempos.DialogResult == DialogResult.OK)
                {
                    int hora = Convert.ToInt32(modalCargarTiempos.tbHH.Text);
                    int minutos = Convert.ToInt32(modalCargarTiempos.tbMM.Text);
                    competencia.CargarTiempos(hora, minutos);
                }
            }
            modalCargarTiempos.Dispose();
            MessageBox.Show("Tiempos cargados!");
        }

        private void btnVerResultados_Click(object sender, EventArgs e)
        {
            ModalResultados modalResultados = new ModalResultados();
            modalResultados.lbResultados.Items.Clear();
            competencia.OrdenarLista();
            for(int i = 0; i < competencia.contador; i++)
            {
                int horas = competencia.tiempos[i] / 60;
                int minutos = competencia.tiempos[i] - (horas * 60);
                modalResultados.lbResultados.Items.Add(" Nombre: " + competencia.nombres[i].ToString() + " - Tiempo: " + horas + ":" + minutos);
            }
            modalResultados.ShowDialog();
        }
    }
}
