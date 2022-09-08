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

        public De(int nbFace, string typeDe)
        {
            this.nbFace = nbFace;
            this.typeDe = typeDe;
            this.faces = new List<int>();
            for (int valeurFace = 1; valeurFace <= NbFace; valeurFace++)
            {
                Faces.Add(valeurFace);
            }
        }
        public abstract void ModifierProbalite(List<int> faces);
        public virtual int Brasser()
        {
            Random random = new Random();

            int indexTirage = random.Next(Faces.Count);
            int tirage = Faces[indexTirage];
            return tirage;
        }


     }
}
