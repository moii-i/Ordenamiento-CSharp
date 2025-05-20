namespace Ordenamiento.Algoritmos
{
    public static class Burbuja
    {
        public static void Ordenar(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length - 1; i++)
                for (int j = 0; j < arreglo.Length - i - 1; j++)
                    if (arreglo[j] > arreglo[j + 1])
                        (arreglo[j], arreglo[j + 1]) = (arreglo[j + 1], arreglo[j]);
        }
    }
}