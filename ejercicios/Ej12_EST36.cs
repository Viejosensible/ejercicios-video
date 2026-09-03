using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej12_EST36
    {
        static void Main(string[] args)
        {
            int conf = 0;
            int pend = 0;
            int i = 1;
            do
            {
                System.Console.Write($"Hectáreas parcela {i}: ");
                double ha = System.Convert.ToDouble(System.Console.ReadLine());
                if (ha >= 400)
                {
                    System.Console.Write("¿Verificado? (1-Sí, 2-No): ");
                    if (System.Convert.ToInt32(System.Console.ReadLine()) == 1)
                    {
                        System.Console.WriteLine("CONFIRMADO");
                        conf++;
                    }
                    else
                    {
                        System.Console.WriteLine("PENDIENTE");
                        pend++;
                    }
                }
                else if (ha >= 150)
                {
                    System.Console.WriteLine("MODERADO");
                }
                else
                {
                    System.Console.WriteLine("LEVE");
                }
                i++;
            }
            while (i <= 7);
            System.Console.WriteLine($"Confirmados: {conf}, Pendientes: {pend}");
        }
    }
}
