using System;
using System.Collections.Generic;
using System.Text;

namespace Practica3
{
    class Gene
    {
        private int[] gene;
        //Constructor de GeneParticion, recibe el tamaño del gene
        public Gene(int size)
        {
            gene = new int[size];
            Random random = new Random();
            //se crea llena el gene de tamaño size con numeros aleatorios de 1´s y 0´s
            for (int x = 0; x < size; x++)
            {
                gene[x] = random.Next(2);
            }
        }
        //Representacion en codigo binario del Gene
        public string GetBinario()
        {
            string s = "";
            for (int i = 0; i < gene.Length; i++)
            {
                s += gene[i];
            }
            return s;
        }
        //Representacion en codigo gray del Gene
        public string GetGrey()
        {
            string s = "";
            for (int i = 1; i < gene.Length; i++)
            {
                s += gene[i - 1] ^ gene[i];
            }
            return gene[0] + s;
        }
    }
}
