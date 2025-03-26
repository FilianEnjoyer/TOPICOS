using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    // Variable global para la suma en la ejecución concurrente.
    static int sumaTotal = 0;
    // Objeto para sincronizar el acceso a la variable sumaTotal.
    static object lockObject = new object();

    // Método para calcular la suma de números primos en un rango dado (para ejecución concurrente).
    static void CalcularPrimos(object rango)
    {
        (int inicio, int fin) = ((int, int))rango;
        int suma = 0;
        for (int i = inicio; i <= fin; i++)
        {
            if (EsPrimo(i))
            {
                suma += i;
            }
        }
        // Se utiliza lock para evitar condiciones de carrera al actualizar sumaTotal.
        lock (lockObject)
        {
            sumaTotal += suma;
        }
    }

    // Método que verifica si un número es primo.
    static bool EsPrimo(int numero)
    {
        if (numero < 2) return false;
        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }

    static void Main()
    {
        Console.WriteLine("Ingrese el número límite:");
        int N = int.Parse(Console.ReadLine());
        int M = 4; // Número de hilos para la ejecución concurrente.
        int rango = N / M;
        Thread[] hilos = new Thread[M];

        // ================= Ejecución Secuencial =================
        // Se calcula la suma de números primos hasta N de forma secuencial.
        Stopwatch stopwatchSecuencial = Stopwatch.StartNew();
        int sumaSecuencial = 0;
        for (int i = 1; i <= N; i++)
        {
            if (EsPrimo(i))
            {
                sumaSecuencial += i;
            }
        }
        stopwatchSecuencial.Stop();
        Console.WriteLine($"Suma total secuencial de números primos hasta {N}: {sumaSecuencial}");
        Console.WriteLine($"Tiempo de ejecución secuencial: {stopwatchSecuencial.ElapsedMilliseconds} ms");

        // ================= Ejecución Concurrente =================
        // Se reinicia la suma total para la ejecución concurrente.
        sumaTotal = 0;
        Stopwatch stopwatchConcurrente = Stopwatch.StartNew();
        for (int i = 0; i < M; i++)
        {
            int inicio = i * rango + 1;
            int fin = (i == M - 1) ? N : inicio + rango - 1;
            hilos[i] = new Thread(CalcularPrimos);
            hilos[i].Start((inicio, fin));
        }
        // Se espera a que todos los hilos terminen su ejecución.
        foreach (var hilo in hilos)
        {
            hilo.Join();
        }
        stopwatchConcurrente.Stop();
        Console.WriteLine($"Suma total concurrente de números primos hasta {N}: {sumaTotal}");
        Console.WriteLine($"Tiempo de ejecución concurrente: {stopwatchConcurrente.ElapsedMilliseconds} ms");
    }
}
