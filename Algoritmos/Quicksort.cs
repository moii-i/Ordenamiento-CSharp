namespace Ordenamiento.Algoritmos
{
    public static class Quicksort
    {
        public static void Ordenar(int[] arreglo, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int pivote = Particionar(arreglo, inicio, fin);
                Ordenar(arreglo, inicio, pivote - 1);
                Ordenar(arreglo, pivote + 1, fin);
            }
        }

        private static int Particionar(int[] arreglo, int inicio, int fin)
        {
            int pivote = arreglo[fin];
            int i = inicio - 1;

            for (int j = inicio; j < fin; j++)
            {
                if (arreglo[j] <= pivote)
                {
                    i++;
                    (arreglo[i], arreglo[j]) = (arreglo[j], arreglo[i]);
                }
            }

            (arreglo[i + 1], arreglo[fin]) = (arreglo[fin], arreglo[i + 1]);
            return i + 1;
        }
    }
}