using System;
using System.Collections.Generic;
using System.Text;

namespace Ciclos.Ejercicios
{
    class PromedioCalificaciones
    {

        // suponga que se tiene un ocnjnto de calificaciones de un gorupo de 10 alumnos
        //realizar un algoritmo para calcular la calificacion promedio y la calificacion mas baja de todo el gurpo

        float menorCal = 1000;
        public void MostarPromedioYmenorCalificacion()
        {
            float suma = 0;
         
    
            for (int i =1; i<= 10; i++)
            {
                float nota = PedirNumero();
                suma = suma + nota;
                 menorCal = CalcularMenorCalificacion(nota);
               
            }
            Console.WriteLine("La menor calificacion es: " + menorCal);
            Console.WriteLine("");
            float promedio = CalcularPromedio(suma);
            Console.WriteLine("El promedio de las 10 notas es:" + promedio);
           
           

        }

        private float CalcularMenorCalificacion(float calificacion)
        {
           
            if (calificacion < menorCal)
            {
                menorCal = calificacion;
            }
            return menorCal;
        }


        private float CalcularPromedio(float suma)
        {
            float promedio = suma / 10;
            return promedio;
        }
        

        private float PedirNumero()
        {
            Console.WriteLine("Digite su calificacion");
            float num = float.Parse(Console.ReadLine());
            return num;
        }
    }
}
