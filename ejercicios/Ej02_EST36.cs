using System;
using System.Collections.Generic;
using System.Text;
namespace ejercicios_video.ejercicios
{
    public class Ej02_EST36
    {
        static void Main(string[] args)
        {
            const int TOTAL_PARCELAS = 5;
            const double META_AGUA = 12000;
            double suma = 0;
            int i = 1;
            do
            {
                System.Console.Write($"Litros parcela {i}: ");
                suma += System.Convert.ToDouble(System.Console.ReadLine());
                i++;
            }
            while (i <= TOTAL_PARCELAS);
            System.Console.WriteLine($"Total: {suma}. " + (suma >= META_AGUA ? "Meta alcanzada." : "No se alcanzó la meta."));
        }
    }
}