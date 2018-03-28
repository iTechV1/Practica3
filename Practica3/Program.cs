using System;

namespace Practica3
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Numero de individuos");
            int numeroIndividuos = int.Parse(Console.ReadLine()); // Numero de individuos que tendra cada generación
            Console.WriteLine("Valor minimo");
            int valorMinimo = int.Parse(Console.ReadLine()); // Valor minimo del Individuo
            Console.WriteLine("Valor maximo");
            int valorMaximo = int.Parse(Console.ReadLine()); // Valor maximo del Individuo

            Individuo[] individuos = new Individuo[numeroIndividuos]; // Arreglo de individuos
            Individuo[] hijos = new Individuo[numeroIndividuos]; // Arreglo de hijos de los individuos

            //Individuos Padres
            Console.WriteLine("Padres");
            for (int i = 0; i < numeroIndividuos; i++)
            {
                individuos[i] = new Individuo(valorMinimo,valorMaximo, 4096);
                Console.WriteLine(individuos[i]);
            }
            //Cruza de individuos
            for (int i = 0; i < individuos.Length; i += 2)
            {
                Individuo[] hijo = individuos[i].CruzaPor1Punto(individuos[i + 1], 6);
                hijos[i] = hijo[0];
                hijos[i + 1] = hijo[1];
            }
            //Se imprimen los hijos de los individuos
            Console.WriteLine("Hijos");
            for (int i = 0; i < numeroIndividuos; i++)
            {
                Console.WriteLine(hijos[i]);
            }

            Console.ReadLine();
        }
    }
}
