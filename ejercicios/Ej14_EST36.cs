using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej14_EST36
    {
        static void Main(string[] args)
        {
            const double UMBRAL = 500;
            double totalGen = 0;
            int zona = 1;
            do
            {
                double subtotal = 0;
                int dia = 1;
                do
                {
                    System.Console.Write($"Dosis día {dia}: ");
                    subtotal += System.Convert.ToDouble(System.Console.ReadLine());
                    dia++;
                }
                while (dia <= 4);
                System.Console.WriteLine($"Subtotal Zona {zona}: {subtotal} - " + (subtotal > UMBRAL ? "ÓPTIMA" : "BAJA"));
                totalGen += subtotal;
                zona++;
            }
            while (zona <= 2);
            System.Console.WriteLine($"Total general: {totalGen}");
        }
    }
}