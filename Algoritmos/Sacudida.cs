// Sacudida.cs
namespace Ordenamiento.Algoritmos
{
    public static class Sacudida
    {
        public static void Ordenar(int[] arreglo)
        {
            int inicio = 0, fin = arreglo.Length - 1;
            bool cambio = true;

            while (cambio)
            {
                cambio = false;
                for (int i = inicio; i < fin; i++)
                {
                    if (arreglo[i] > arreglo[i + 1])
                    {
                        (arreglo[i], arreglo[i + 1]) = (arreglo[i + 1], arreglo[i]);
                        cambio = true;
                    }
                }

                if (!cambio) break;

                cambio = false;
                fin--;

                for (int i = fin; i > inicio; i--)
                {
                    if (arreglo[i] < arreglo[i - 1])
                    {
                        (arreglo[i], arreglo[i - 1]) = (arreglo[i - 1], arreglo[i]);
                        cambio = true;
                    }
                }

                inicio++;
            }
        }
    }
}