using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej05_EST36
    {
        static void Main(string[] args)
        {
            const int UMBRAL = 150;
            int cumplen = 0;
            int noCumplen = 0;
            int i = 1;
            do
            {
                System.Console.Write($"Objeto {i}: ");
                int valor = System.Convert.ToInt32(System.Console.ReadLine());
                if (valor >= UMBRAL)
                {
                    System.Console.WriteLine("CUMPLE");
                    cumplen++;
                }
                else
                {
                    System.Console.WriteLine("NO CUMPLE");
                    noCumplen++;
                }
                i++;
            }
            while (i <= 5);
            System.Console.WriteLine($"Cumplen: {cumplen}, No cumplen: {noCumplen}");
        }
    }
}
