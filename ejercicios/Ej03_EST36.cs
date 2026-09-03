using System;
using System.Collections.Generic;
using System.Text;
namespace ejercicios_video.ejercicios
{
    public class Ej03_EST36
    {
        static void Main(string[] args)
        {
            const int MIN_VAL = 0;
            const int MAX_VAL = 900;
            int descargas;
            do
            {
                System.Console.Write("Ingrese descargas (0-900): ");
                descargas = System.Convert.ToInt32(System.Console.ReadLine());
                if (descargas < MIN_VAL || descargas > MAX_VAL)
                {
                    System.Console.WriteLine("Error de rango.");
                }
            }
            while (descargas < MIN_VAL || descargas > MAX_VAL);
            System.Console.WriteLine($"Válido: {descargas}");
        }
    }
}
