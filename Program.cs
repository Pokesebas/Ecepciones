using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, double> calificaciones = new Dictionary<string, double>()
        {
            {"Juan", 95},
            {"Maria", 88},
            {"Pedro", 76},
            {"Ana", 100}
        };

        try
        {
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new Exception("Debe ingresar un nombre.");
            }

            double nota = calificaciones[nombre];

            Console.WriteLine($"\nLa calificación de {nombre} es: {nota}");
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("\nError: El estudiante no existe en el registro.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\nConsulta finalizada.");
        }

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}