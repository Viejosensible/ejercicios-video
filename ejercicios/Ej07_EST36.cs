using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej07_EST36
    {
        static void Main(string[] args)
        {
            const double U_ALTA = 180;
            const double U_MEDIA = 70;
            int alta = 0;
            int media = 0;
            int baja = 0;
            int i = 1;
            do
            {
                System.Console.Write($"Km tramo {i}: ");
                double km = System.Convert.ToDouble(System.Console.ReadLine());
                if (km >= U_ALTA)
                {
                    System.Console.WriteLine("ALTA");
                    alta++;
                }
                else if (km >= U_MEDIA)
                {
                    System.Console.WriteLine("MEDIA");
                    media++;
                }
                else
                {
                    System.Console.WriteLine("BAJA");
                    baja++;
                }
                i++;
            }
            while (i <= 9);
            System.Console.WriteLine($"Resumen: Alta={alta}, Media={media}, Baja={baja}");
        }
    }
}