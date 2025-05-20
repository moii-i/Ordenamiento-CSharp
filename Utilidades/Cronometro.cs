using System;
using System.Diagnostics;

namespace Ordenamiento.Utilidades
{
    public static class Cronometro
    {
        public static long MedirTiempo(Action metodo)
        {
            var cronometro = Stopwatch.StartNew();
            metodo();
            cronometro.Stop();
            return cronometro.ElapsedMilliseconds;
        }
    }
}
