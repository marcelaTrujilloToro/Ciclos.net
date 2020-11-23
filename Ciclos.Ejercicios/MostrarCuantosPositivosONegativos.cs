using System;
using System.Collections.Generic;
using System.Text;

namespace Ciclos.Ejercicios
{
    class MostrarCuantosPositivosONegativos
    {

        //Leer 10 numeros e imprimir cuantos son positivos cuantos negativos

        public void MostrarSumaPositivosYNegativos()
        {
            int contPositivos = 0;
            int contNegativo = 0;

            for (int i = 1; i<= 10; i++)
            {
                int num = PedirNumero();
                if (num < 0)
                {
                    contNegativo++;
                }
                else
                {
                    contPositivos++;
                }

            }
            Console.WriteLine("La suma de positivos es: " + contPositivos);
            Console.WriteLine("La suma de negativos es: " + contNegativo);
        }

        private int PedirNumero()
        {
            Console.WriteLine("Digite un numero");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
    }
}
