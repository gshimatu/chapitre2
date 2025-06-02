using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre2
{
    abstract class AEtudiant
    {
        public string nom { get; set; }
        public string promotion { get; set; }
        public string faculte { get; set; }

        public abstract void AfficherInfos();
        public abstract void PayerFrais(double montant);
    }
}
