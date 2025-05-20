// GeneradorDatos.cs
using System;

namespace Ordenamiento.Utilidades
{
    public static class GeneradorDatos
    {
        public static int[] Generar(int cantidad)
        {
            Random random = new Random();
            int[] arreglo = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
                arreglo[i] = random.Next(0, 10000);
            return arreglo;
        }
    }
}