using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej15_EST36
    {
        static void Main(string[] args)
        {
            const int CLAVE = 2019;
            int intentos = 4;
            bool acceso = false;
            do
            {
                System.Console.Write("Código de acceso: ");
                if (System.Convert.ToInt32(System.Console.ReadLine()) == CLAVE)
                {
                    acceso = true;
                    System.Console.WriteLine("¡Acceso concedido!");
                }
                else
                {
                    intentos--;
                    System.Console.WriteLine($"Incorrecto. Quedan {intentos}");
                }
            }
            while (!acceso && intentos > 0);
        }
    }
}