using System;
using System.Collections.Generic;
using System.Text;

namespace Ciclos.Ejercicios
{
    class SumaParesEimpares
    {

        //Se desea calcular independientemente la suma de los primeros pares e imperes comprendidos entre 1 y 50 
        public void MostrarSumaParesEImpares()
        {
            int sumaPar = SumarPares();
            Console.WriteLine("La suma de los numeros pares entre 1 y 50 es: " + sumaPar);
            Console.WriteLine("");
            int sumaImpar = SumarImpares();
            Console.WriteLine("La suma de los numeros impares entre 1 y 50 es: " + sumaImpar);


        }


        private int SumarPares()
        {
            int sumaPar = 0;
            for (int i =2; i <= 49; i++)
            {
                
                if(i %2 == 0)
                {
                     sumaPar = sumaPar + i;
                }
            }
            return sumaPar;
        }

        private int SumarImpares()
        {
            int sumaImpar = 0;
            for (int i = 2; i <= 49; i++)
            {

                if (i % 2 != 0)
                {
                    sumaImpar = sumaImpar + i;
                }
            }
            return sumaImpar;
        }

               
    }
}
