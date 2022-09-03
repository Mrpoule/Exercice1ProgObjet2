using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juexDe
{
     public abstract class De
    {
        private int nbFace;
        private string typeDe;
        List<int> faces;

        public int NbFace { get => nbFace;}
        public string TypeDe { get => typeDe;}
        public List<int> Faces { get => faces;}

        protected De(int nbFace, string typeDe)
        {
            this.nbFace = nbFace;
            this.typeDe = typeDe;
            this.faces = new List<int>();
            for (int valeurFace = 1; valeurFace <= NbFace; valeurFace++)
            {
                Faces.Add(valeurFace);
            }
        }

        public virtual int Brasser()
        {
            Random random = new Random();
            int indexChiffre = random.Next(0, Faces.Count);
            return indexChiffre;
        }
        public abstract void ModifierProbalite(List<int> faces);


    }
}
