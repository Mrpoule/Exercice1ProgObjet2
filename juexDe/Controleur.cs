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
            List<string> resultats = new List<string>();

            De deChoisie = deAleoatoire();
            resultats.Add(deChoisie.TypeDe);

            resultats.Add(deChoisie.Brasser().ToString());

            total += deChoisie.Brasser();
            resultats.Add(total.ToString());

            return resultats;
            
        }

        private De deAleoatoire()
        {
            De deChoisie;
            Random random = new Random();

            int indexDe = random.Next(des.Count);
            deChoisie = des[indexDe];

            return deChoisie;
        }

    }
}
