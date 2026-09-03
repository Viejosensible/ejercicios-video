using System;
using System.Collections.Generic;
using System.Text;
using System;

namespace ejercicios_video.ejercicios
{
    public class Ej17_EST36
    {
        static void Main(string[] args)
        {
            double suma = 0;
            int count = 0;
            double at;
            do
            {
                System.Console.Write("Atenciones (-1 para salir): ");
                at = System.Convert.ToDouble(System.Console.ReadLine());
                if (at != -1)
                {
                    suma += at;
                    count++;
                }
            }
            while (at != -1);
            if (count > 0)
            {
                System.Console.WriteLine($"Promedio: {suma / count:F2}");
            }
        }
    }
}