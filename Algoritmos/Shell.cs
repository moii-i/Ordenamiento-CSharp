namespace Ordenamiento.Algoritmos
{
    public static class Shell
    {
        public static void Ordenar(int[] arreglo)
        {
            int n = arreglo.Length;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arreglo[i];
                    int j = i;
                    while (j >= gap && arreglo[j - gap] > temp)
                    {
                        arreglo[j] = arreglo[j - gap];
                        j -= gap;
                    }
                    arreglo[j] = temp;
                }

                gap /= 2;
            }
        }
    }
}
