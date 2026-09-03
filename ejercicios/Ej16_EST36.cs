using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej16_EST36
    {
        static void Main(string[] args)
        {
            double totalInc = 0;
            int obs = 0;
            int i = 1;
            do
            {
                System.Console.Write($"Siniestros tramo {i}: ");
                double sin = System.Convert.ToDouble(System.Console.ReadLine());
                System.Console.Write($"Valor base tramo {i}: ");
                double vb = System.Convert.ToDouble(System.Console.ReadLine());
                if (sin >= 15)
                {
                    totalInc += vb * 0.20;
                }
                else if (sin >= 6)
                {
                    totalInc += vb * 0.10;
                }
                else
                {
                    obs++;
                }
                i++;
            }
            while (i <= 9);
            System.Console.WriteLine($"Incentivo total: {totalInc}, Observaciones: {obs}");
        }
    }
}