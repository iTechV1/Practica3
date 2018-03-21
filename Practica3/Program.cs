using System;

namespace Practica3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de genes");
            int numeroGenes = int.Parse(Console.ReadLine());
            Console.WriteLine("Tamaño de los genes");
            int tamanioGenes = int.Parse(Console.ReadLine());
            Console.WriteLine("Punto de cruza");
            int puntoDeCruza = int.Parse(Console.ReadLine());

            Individuo individuo1 = new Individuo(numeroGenes,tamanioGenes);
            Individuo individuo2 = new Individuo(numeroGenes,tamanioGenes);

            Console.WriteLine("Individuo 1");
            Console.WriteLine(individuo1.ToString());

            Console.WriteLine("Individuo 2");
            Console.WriteLine(individuo2.ToString());

            individuo1.CruzaPor1Punto(individuo2,puntoDeCruza);

            Console.ReadLine();
        }
    }
}
