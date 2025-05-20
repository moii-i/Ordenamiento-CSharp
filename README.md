# Algoritmos de Ordenamiento en C#

Este proyecto presenta la implementación de diversos algoritmos de ordenamiento en C#, probados con conjuntos de datos pequeños y grandes. El objetivo es comparar su rendimiento y observar sus características en diferentes escenarios.

## 📌 Algoritmos Implementados

- Ordenamiento Burbuja
- Ordenamiento de Sacudida (Cocktail Sort)
- Ordenamiento por Inserción
- Ordenamiento por Selección
- Shell Sort
- Quicksort
- Heapsort

## 🧠 Estructura del Proyecto

- `Program.cs`: Punto de entrada que permite seleccionar y probar cada algoritmo.
- Carpeta `Algoritmos/`: Contiene cada algoritmo implementado.
- Carpeta `Utilidades/`:
  - `GeneradorDatos.cs`: Genera arreglos aleatorios.
  - `Cronometro.cs`: Mide el tiempo de ejecución.

## 🚀 Ejecución

Compila y ejecuta el proyecto. Se solicitará:
1. Algoritmo a probar (1 al 7).
2. Tamaño del arreglo.

El programa genera un arreglo aleatorio, lo ordena y muestra el tiempo de ejecución.

```bash
dotnet run
