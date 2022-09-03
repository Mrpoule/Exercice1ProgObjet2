using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juexDe
{
    public class Controleur
    {
        List<De> des;
        int total = 0;

        public List<De> Des { get => des;}
        public int Total { get => total; }

        public Controleur()
        {
            des = new List<De>()
            {
                new De6Orginal(),
                new De6Pipe()
            };
            
        }
        public List<string> BrasserLesDes()
        {
            De deChoisie;
            Random random = new Random();
            List<string> resultats = new List<string>();

            int indexDe=random.Next(des.Count);
            deChoisie = des[indexDe];
            resultats.Add(deChoisie.TypeDe);

            int indexTirage=random.Next(deChoisie.Faces.Count);
            int tirage = deChoisie.Faces[indexTirage];
            resultats.Add(tirage.ToString());

            total += tirage;
            resultats.Add(total.ToString());

            return resultats;
            
        }

    }
}
