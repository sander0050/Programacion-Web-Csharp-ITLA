using System;
using System.Collections.Generic;
using System.Text;

namespace Programacion_Web_CSharp
{
    class Arreglo
    {
        public Arreglo() { }
        public int[] numbers = new int[10]{ 3, 4, 2, 12, 5, 4, 32, 1, 7, 54 };

        public int ValorMaximo(int[] arreglo) {
            int max = arreglo[0];

            for (int i = 1; i < arreglo.Length; i++)
            {
                if (max < arreglo[i]) {
                    max = arreglo[i];
                }
            }

            return max;
        }

        public int SumaValores(int[] arreglo)
        {
            int suma = 0;

            for (int i = 1; i < arreglo.Length; i++)
            {
                suma += arreglo[i];
            }

            return suma;

        }

        public int[] ValoresMayoresA18(int[] arreglo)
        {
            int[] mayores;
            int counter = 0;

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] > 18) {
                    counter++;
                }
            }

            mayores = new int[counter];
            counter = 0;

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] > 18)
                {
                    mayores[counter] = arreglo[i];
                    counter++;
                }
            }

            return mayores;

        }
    }
}
