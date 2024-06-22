using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _2_PuntoDeControl
{
    internal class Controladora
    {
        public string[] patentes = new string[20];
        public string[] tipovehiculo = new string[20];
        public bool[] SonElectricos = new bool[20];
        public int[] Modelos = new int[20];
        public int contador;

        public string[] patentesElectricos = new string[20];
        public string[] tiposVehiculosElectricos = new string[20];
        public int[] modelosElectricos = new int[20];
        public int contadorElectricos;

        public void RegistrarVehiculo(string patente, string tipo, int modelo, bool esElectrico)
        {
            patentes[contador] = patente;
            tipovehiculo[contador] = tipo;
            SonElectricos[contador] = esElectrico;
            Modelos[contador] = modelo;
            contador++;
        }

        public void OrdenarElectricos()
        {
            contadorElectricos = 0;
            for(int i = 0; i < contador; i++)
            {
                if (SonElectricos[i] == true)
                {
                    patentesElectricos[contadorElectricos] = patentes[i];
                    tiposVehiculosElectricos[contadorElectricos] = tipovehiculo[i];
                    modelosElectricos[contadorElectricos] = Modelos[i];
                    contadorElectricos++;
                }
            }

            string auxPatente = "";
            string auxTipoVehiculo = "";
            int auxModelo;

            for(int i = 0; i < contadorElectricos - 1; i++)
            {
                for (int j = i + 1; j < contadorElectricos; j++)
                {
                    if (modelosElectricos[i] > modelosElectricos[j])
                    {
                        auxPatente = patentesElectricos[i];
                        patentesElectricos[i] = patentesElectricos[j];
                        patentesElectricos[j] = auxPatente;

                        auxTipoVehiculo = tiposVehiculosElectricos[i];
                        tiposVehiculosElectricos[i] = tiposVehiculosElectricos[j];
                        tiposVehiculosElectricos[j] = auxTipoVehiculo;

                        auxModelo = modelosElectricos[i];
                        modelosElectricos[i] = modelosElectricos[j];
                        modelosElectricos[j] = auxModelo;

                    }
                }
            }
        }
    }
}
