// Seleccion.cs
namespace Ordenamiento.Algoritmos
{
    public static class Seleccion
    {
        public static void Ordenar(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arreglo.Length; j++)
                {
                    if (arreglo[j] < arreglo[min]) min = j;
                }
                (arreglo[i], arreglo[min]) = (arreglo[min], arreglo[i]);
            }
        }
    }
}