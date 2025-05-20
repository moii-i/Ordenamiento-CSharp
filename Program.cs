// ===========================
// Archivo: Program.cs
// ===========================
using System;
using System.Diagnostics;
using Ordenamiento.Algoritmos;
using Ordenamiento.Utilidades;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n--- Algoritmos de Ordenamiento en C# ---\n");
        Console.WriteLine("1. Burbuja");
        Console.WriteLine("2. Sacudida");
        Console.WriteLine("3. Inserción");
        Console.WriteLine("4. Selección");
        Console.WriteLine("5. Shell");
        Console.WriteLine("6. Quicksort");
        Console.WriteLine("7. Heapsort");
        Console.Write("Seleccione un algoritmo (1-7): ");

        int opcion = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el tamaño del arreglo: ");
        int tamaño = int.Parse(Console.ReadLine());

        int[] datos = GeneradorDatos.Generar(tamaño);
        int[] copia = (int[])datos.Clone();

        long tiempo = Cronometro.MedirTiempo(() =>
        {
            switch (opcion)
            {
                case 1: Burbuja.Ordenar(copia); break;
                case 2: Sacudida.Ordenar(copia); break;
                case 3: Insercion.Ordenar(copia); break;
                case 4: Seleccion.Ordenar(copia); break;
                case 5: Shell.Ordenar(copia); break;
                case 6: Quicksort.Ordenar(copia, 0, copia.Length - 1); break;
                case 7: Heapsort.Ordenar(copia); break;
                default: Console.WriteLine("Opción no válida."); return;
            }
        });

        Console.WriteLine($"\nTiempo de ejecución: {tiempo} ms\n");
    }
}
