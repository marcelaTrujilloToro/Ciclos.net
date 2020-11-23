using System;
using System.Collections.Generic;
using System.Text;

namespace Ciclos.Ejercicios
{
    class SumaDeNumeros
    {
        //calcular la suma de los n primeros numeros

        public void MostrarSuma()
        {
            int num = PedirNumero();
            int suma = Sumar(num);
            Console.WriteLine("La suma de los numeros hasta el numero:" + num + " es " + suma);
        }

        private int Sumar(int num)
        {
            int suma = 0;
            for (int i =1; i <= num; i++)
            {
                suma = suma + i;
            }
            return suma;
        }



        private int PedirNumero()
        {
            Console.WriteLine("Digite un Numero");
            int num = int.Parse(Console.ReadLine());
            return num;
        }


    }
}
