using System;
using System.Collections.Generic;
using System.Text;


namespace ejercicios_video.ejercicios
{
    public class Ej10_EST36
    {
        static void Main(string[] args)
        {
            const int TOTAL_FOCOS = 9;
            const double UMBRAL = 500;
            double suma = 0;
            int i = 1;
            do
            {
                System.Console.Write($"Hectáreas foco {i}: ");
                suma += System.Convert.ToDouble(System.Console.ReadLine());
                i++;
            }
            while (i <= TOTAL_FOCOS);
            double prom = suma / TOTAL_FOCOS;
            System.Console.WriteLine($"Promedio: {prom:F2} - " + (prom > UMBRAL ? "Requiere intervención." : "Aceptable."));
        }
    }
}