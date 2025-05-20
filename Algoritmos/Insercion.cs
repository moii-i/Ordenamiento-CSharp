// Insercion.cs
namespace Ordenamiento.Algoritmos
{
    public static class Insercion
    {
        public static void Ordenar(int[] arreglo)
        {
            for (int i = 1; i < arreglo.Length; i++)
            {
                int valor = arreglo[i];
                int j = i - 1;

                while (j >= 0 && arreglo[j] > valor)
                {
                    arreglo[j + 1] = arreglo[j];
                    j--;
                }

                arreglo[j + 1] = valor;
            }
        }
    }
}
