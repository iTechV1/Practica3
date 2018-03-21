using System;
using System.Collections.Generic;
using System.Text;

namespace Practica3
{
    class Cromosoma
    {
        private Gene[] genes;
        public Cromosoma(int numeroGenes, int tamanioGenes) {
            genes = new Gene[numeroGenes];
            for (int i=0; i<numeroGenes; i++) {
                genes[i] = new Gene(tamanioGenes);
            }
        }
        public Gene[] GetGenes() {
            return this.genes;
        }
        public override string ToString()
        {
            String cromosoma = "";
            for (int i = 0; i < genes.Length; i++) {
                cromosoma += genes[i].GetBinario()+"\n";
            }
            return cromosoma;
        }

    }
}
