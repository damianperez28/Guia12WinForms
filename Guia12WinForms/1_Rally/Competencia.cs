using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Rally
{
    internal class Competencia
    {
        public string[] nombres = new string[50];
        public int[] tiempos = new int[50];
        public int contador = 0;
        public int contadorTiempos = 0;

        public void AgregarCompetidor(string nombre)
        {
            if (contador < 50)
            {
                nombres[contador] = nombre;
                contador++;
            }
        }

        public void CargarTiempos(int hh, int mm)
        {
            int horas = hh;
            int minutos = mm;
            minutos = minutos + (hh*60);
            tiempos[contadorTiempos] = minutos;
            contadorTiempos++;

        }

        public void OrdenarLista()
        {
            int aux1;
            string aux2 = "";
            for(int i = 0; i < contador - 1; i++)
            {
                for(int j = i + 1; j < contador; j++)
                {
                    if (tiempos[i] < tiempos[j])
                    {
                        aux1 = tiempos[i];
                        tiempos[i] = tiempos[j];
                        tiempos[j] = aux1;

                        aux2 = nombres[i];
                        nombres[i] = nombres[j];
                        nombres[j] = aux2;
                    }
                }
            }
        }


    }
}
