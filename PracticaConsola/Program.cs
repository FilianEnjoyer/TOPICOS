using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace PracticaConcurrencia
{
    internal class Program
    {
        // Método que será ejecutado por los hilos
        static void Proceso(object id)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Hilo {id}: Iteración {i}");
                Thread.Sleep(1000); // Simula un proceso que toma tiempo
            }
        }
        static void Main(string[] args)
        {
            //Creamos los hilos para ejecutar los procesos.
            Thread hilo1 = new Thread(Proceso);
            Thread hilo2 = new Thread(Proceso);
            Thread hilo3 = new Thread(Proceso);
            //Creacion de stopwatch para tomar el tiempo de ejecucion
            Stopwatch stopwatch1 = new Stopwatch();
            Console.WriteLine("Inicio del programa...");
            //incia el contador de tiempo
            stopwatch1.Start();
            //Proceso secuencial sin concurrencia
            Proceso(1);
            Proceso(2);
            Proceso(3);
            //Detiene el contador
            stopwatch1.Stop();
            //Ecribe el tiempo transcurrido en milisegundos.
            Console.WriteLine("Tiempo transcurrido: " + $"{stopwatch1.ElapsedMilliseconds} ms");
            Console.WriteLine("Fin del programa...");
            Stopwatch stopwatch2 = new Stopwatch();
            Console.WriteLine("Inicio del programa...");
            stopwatch2.Start();
            //Inicia los hilos
            hilo1.Start(1);
            hilo2.Start(2);
            hilo3.Start(3);
            //Sincroniza a los hilos
            hilo1.Join();
            hilo2.Join();
            hilo3.Join();
            stopwatch2.Stop();
            Console.WriteLine("Tiempo transcurrido: " + $"{stopwatch2.ElapsedMilliseconds} ms");
            Console.WriteLine("Fin del programa...");
        }
    }
}