using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre2
{
    internal interface IEtudiant
    {
        string nom { get; set; }
        string promotion { get; set; }
        string faculte { get; set; }
        void AfficherInfos();
        void PayerFrais(double montant);
    }
}
