using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ControlEmbarque
{
    internal class Controlador
    {
        public int[] IDs = new int[20];
        public string[] Origenes = new string[20];
        public double[] Peso = new double[20];
        public int contador;
        public int[] IDsBuscados = new int[20];
        public string[] OrigenesBuscados = new string[20];
        public double[] PesoBuscados = new double[20];
        public int contadorBuscados;
        
        public void AgregarContenedor(int id, string pais, double peso)
        {
            IDs[contador] = id;
            Origenes[contador] = pais;
            Peso[contador] = peso;
            contador++;
        }

        public void BuscarPorOrigenes(string pais)
        {
            
            contadorBuscados = 0;
            for(int i = 0; i < contador; i++)
            {
                if (Origenes[i] == pais)
                {
                    IDsBuscados[contadorBuscados] = IDs[i];
                    OrigenesBuscados[contadorBuscados] = Origenes[i];
                    PesoBuscados[contadorBuscados] = Peso[i];       
                }
                contadorBuscados++;
            }


            for(int i = 0; i < contadorBuscados - 1; i++)
            {
                for(int j = i + 1; j  < contadorBuscados; j++)
                {
                    if (IDsBuscados[i] > IDsBuscados[j])
                    {
                        int aux1 = IDsBuscados[i];
                        IDsBuscados[i] = IDsBuscados[j];
                        IDsBuscados[j] = aux1;

                        double aux2 = PesoBuscados[i];
                        PesoBuscados[i] = PesoBuscados[j];
                        PesoBuscados[j] = aux2;

                        string aux3 = OrigenesBuscados[i];
                        OrigenesBuscados[i] = OrigenesBuscados[j];
                        OrigenesBuscados[j] = aux3;
                    }
                }
            }
        }
    }
}
