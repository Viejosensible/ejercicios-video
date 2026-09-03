using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej18_EST36
    {
        static void Main(string[] args)
        {
            int total = 0;
            int i = 1;
            do
            {
                System.Console.Write($"Teleconsultas año {2020 + i}: ");
                total += System.Convert.ToInt32(System.Console.ReadLine());
                i++;
            }
            while (i <= 12);
            System.Console.WriteLine($"Total teleconsultas: {total}");
        }
    }
}