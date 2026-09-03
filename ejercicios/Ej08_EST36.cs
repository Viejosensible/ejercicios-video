using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej08_EST36
    {
        static void Main(string[] args)
        {
            int i = 1;
            int pares = 0;
            int impares = 0;
            do
            {
                System.Console.Write($"Artículo ({i}/5): ");
                int num = System.Convert.ToInt32(System.Console.ReadLine());
                if (num % 2 == 0)
                {
                    System.Console.WriteLine("Mañana (Par)");
                    pares++;
                }
                else
                {
                    System.Console.WriteLine("Tarde (Impar)");
                    impares++;
                }
                i++;
            }
            while (i <= 5);
            System.Console.WriteLine($"Pares: {pares}, Impares: {impares}");
        }
    }
}
