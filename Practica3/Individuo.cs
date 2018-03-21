using System;
using System.Collections.Generic;
using System.Text;

namespace Practica3
{
    class Individuo
    {
        private Cromosoma cromosoma;

        public Individuo(int numeroGenes, int tamanioGenes) {
            cromosoma = new Cromosoma(numeroGenes, tamanioGenes);
        }

        public void CruzaPor1Punto(Individuo individuo, int puntoDeCruza) {
            Gene[] genesPadre = this.cromosoma.GetGenes();
            Gene[] genesMadre = individuo.cromosoma.GetGenes();
            if (genesPadre.Length == genesMadre.Length)
            {
                try {
                    if (genesPadre[0].GetBinario().Length == genesMadre[0].GetBinario().Length)
                    {
                        string hijo1 = "";
                        string hijo2 = "";
                        for (int i = 0; i < genesPadre.Length && i < genesMadre.Length; i++)
                        {
                            hijo1 += genesPadre[i].GetBinario().Substring(0, puntoDeCruza) + "\t" + genesMadre[i].GetBinario().Substring(puntoDeCruza) + "\n";
                            hijo2 += genesMadre[i].GetBinario().Substring(0, puntoDeCruza) + "\t" + genesPadre[i].GetBinario().Substring(puntoDeCruza) + "\n";
                        }
                        Console.WriteLine("Hijos Padre");
                        Console.WriteLine(hijo1);
                        Console.WriteLine("Hijos Madre");
                        Console.WriteLine(hijo2);
                    }
                    else
                    {
                        Console.WriteLine("Individuos incompatibles, genes de longitud diferente");
                    }
                }
                catch (Exception e) {
                    Console.WriteLine("numero de Genes = 0");
                }
            }
            else {
                Console.WriteLine("Individuos incompatibles, cromosomas de longitud diferente");
            }
        }
        public override string ToString()
        {
            return cromosoma.ToString();
        }
    }
}