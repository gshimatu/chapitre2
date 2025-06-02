using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre2
{
    public class PresidentEtudiant2 : IEtudiant
    {
        public string nom { get ; set ; }
        public string promotion { get ; set ; }
        public string faculte { get ; set ; }

        public string avantage { get; set; }

        public void AfficherInfos()
        {
            Console.WriteLine($"Nom: {nom}");
            Console.WriteLine($"Promotion: {promotion}");
            Console.WriteLine($"Faculté: {faculte}");
        }
        public void PayerFrais(double montant)
        {
            throw new NotImplementedException();
        }
    }
}
