using System;
using System.Collections.Generic;
using System.Text;


namespace ejercicios_video.ejercicios
{
    public class Ej09_EST36
    {
        static void Main(string[] args)
        {
            double maxV = 0;
            double minV = 0;
            int opMax = 1;
            int opMin = 1;
            int i = 1;
            do
            {
                System.Console.Write($"Operación {i}: ");
                double val = System.Convert.ToDouble(System.Console.ReadLine());
                if (i == 1)
                {
                    maxV = val;
                    minV = val;
                }
                else
                {
                    if (val > maxV)
                    {
                        maxV = val;
                        opMax = i;
                    }
                    if (val < minV)
                    {
                        minV = val;
                        opMin = i;
                    }
                }
                i++;
            }
            while (i <= 7);
            System.Console.WriteLine($"Máx: {maxV} (Op {opMax}), Mín: {minV} (Op {opMin})");
        }
    }
}
