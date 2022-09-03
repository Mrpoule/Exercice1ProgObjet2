using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juexDe
{
    public class De6Pipe : De
    {
        public De6Pipe() : base(6, "Pipé")
        {
            ModifierProbalite(Faces);

        }

        public override void ModifierProbalite(List<int> faces)
        {
            for (int valeurFace = 4; valeurFace <= NbFace; valeurFace++)
            {
                Faces.Add(valeurFace);
            }
        }
    }
}
