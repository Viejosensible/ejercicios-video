using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej11_EST36
    {
        static void Main(string[] args)
        {
            int opcion;
            int urgentes = 0;
            do
            {
                System.Console.WriteLine("\n1) Registrar\n2) Consultar\n3) Salir\nOpción:");
                opcion = System.Convert.ToInt32(System.Console.ReadLine());
                if (opcion == 1)
                {
                    System.Console.Write("Zona (1-Norte, 2-Sur): ");
                    int zona = System.Convert.ToInt32(System.Console.ReadLine());
                    System.Console.Write("Urgente (1-Sí, 2-No): ");
                    int urg = System.Convert.ToInt32(System.Console.ReadLine());
                    if (urg == 1)
                    {
                        System.Console.WriteLine("Registrado URGENTE.");
                        urgentes++;
                    }
                    else
                    {
                        System.Console.WriteLine("Registrado normal.");
                    }
                }
                else if (opcion == 2)
                {
                    System.Console.WriteLine("Meta: Suministro continuo.");
                }
                else if (opcion == 3)
                {
                    System.Console.WriteLine($"Saliendo. Urgentes: {urgentes}");
                }
            }
            while (opcion != 3);
        }
    }
}