using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej19_EST36
    {
        static void Main(string[] args)
        {
            int recursos = 3;
            int puntos = 0;
            int est;
            do
            {
                System.Console.Write("1) Intensiva (+150), 2) Preventiva (+75), 3) Salir: ");
                est = System.Convert.ToInt32(System.Console.ReadLine());
                if (est == 1 && recursos > 0)
                {
                    puntos += 150;
                    recursos--;
                }
                else if (est == 2)
                {
                    puntos += 75;
                }
            }
            while (est != 3 && recursos > 0 && puntos < 4000);
            System.Console.WriteLine($"Puntaje final: {puntos}");
        }
    }
}