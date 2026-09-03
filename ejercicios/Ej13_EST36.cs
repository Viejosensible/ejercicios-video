using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej13_EST36
    {
        static void Main(string[] args)
        {
            const double META = 20000;
            double acumulado = 0;
            int periodos = 0;
            do
            {
                periodos++;
                System.Console.Write($"Avance periodo {periodos}: ");
                acumulado += System.Convert.ToDouble(System.Console.ReadLine());
                System.Console.WriteLine($"Acumulado: {acumulado}");
            }
            while (acumulado < META);
            System.Console.WriteLine($"Meta alcanzada en {periodos} periodos.");
        }
    }
}
