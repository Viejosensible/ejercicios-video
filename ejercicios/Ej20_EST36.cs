using System;
using System.Collections.Generic;
using System.Text;


namespace ejercicios_video.ejercicios
{
    public class Ej20_EST36
    {
        static void Main(string[] args)
        {
            int op;
            double total = 0;
            bool cargado = false;
            do
            {
                System.Console.Write("\n1) Cargar\n2) Reporte\n3) Simular\n4) Salir\nOpción: ");
                op = System.Convert.ToInt32(System.Console.ReadLine());
                if (op == 1)
                {
                    total = 0;
                    int i = 1;
                    do
                    {
                        System.Console.Write($"Precisión {i}: ");
                        total += System.Convert.ToDouble(System.Console.ReadLine());
                        i++;
                    }
                    while (i <= 5);
                    cargado = true;
                }
                else if (op == 2 && cargado)
                {
                    System.Console.WriteLine($"Promedio: {total / 5:F2}");
                }
                else if (op == 3 && cargado)
                {
                    System.Console.WriteLine("Simulación completada.");
                }
            }
            while (op != 4);
        }
    }
}