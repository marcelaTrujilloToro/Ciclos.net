using System;

namespace Ciclos.Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("");
            Console.WriteLine("1. Calcular la suma de los n primeros numeros");
            Console.WriteLine("2. Calcular la suma de los pares e imperes comprendidos entre 1 y 50");
            Console.WriteLine("3. Leer 10 numeros e imprimir cuantos son positivos cuantos negativos");
            Console.WriteLine("4. Leer 10 calificaciones y mostrar el promedio y la menor calificacion");
            Console.WriteLine("");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion){
                case 1:
                     SumarNumerosHastaElLeido();
                        break;
                case 2:
                    SumaParesEImparesHasta50();
                    break;
                case 3:
                    ContarPositivosYnegativos();
                    break;
                default:
                    MostrarPromedioYMenorCalificacion();
                    break;
            }

        }
        private static void MostrarPromedioYMenorCalificacion()
        {
            PromedioCalificaciones num = new PromedioCalificaciones();
            num.MostarPromedioYmenorCalificacion();
        }

        private static void ContarPositivosYnegativos()
        {
            MostrarCuantosPositivosONegativos suma = new MostrarCuantosPositivosONegativos();
            suma.MostrarSumaPositivosYNegativos();
        }


        private static void SumaParesEImparesHasta50()
        {
            SumaParesEimpares suma = new SumaParesEimpares();
            suma.MostrarSumaParesEImpares();
        }

        private static void SumarNumerosHastaElLeido()
        {
            SumaDeNumeros suma = new SumaDeNumeros();
            suma.MostrarSuma();
        }

    }
}
