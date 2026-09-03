using System;
using System.Collections.Generic;
using System.Text;
namespace ejercicios_video.ejercicios
{
    public class Ej04_EST36
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                System.Console.WriteLine("\n1) Ver registro\n2) Ver meta\n3) Ver rango\n4) Salir\nElija opción:");
                opcion = System.Convert.ToInt32(System.Console.ReadLine());
                if (opcion == 1)
                {
                    System.Console.WriteLine("Mostrando registro...");
                }
                else if (opcion == 2)
                {
                    System.Console.WriteLine("Meta: Transcribir folios.");
                }
                else if (opcion == 3)
                {
                    System.Console.WriteLine("Rango: 1 a 500.");
                }
                else if (opcion == 4)
                {
                    System.Console.WriteLine("Saliendo...");
                }
                else
                {
                    System.Console.WriteLine("Opción no válida.");
                }
            }
            while (opcion != 4);
        }
    }
}
