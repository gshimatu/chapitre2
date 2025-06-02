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

        public PresidentEtudiant2(string nom, string promotion, string faculte, string avantage)
        {
            this.nom = nom;
            this.promotion = promotion;
            this.faculte = faculte;
            this.avantage = avantage;
        }

        public void AfficherInfos()
        {
            Console.WriteLine($"Nom: {nom}");
            Console.WriteLine($"Promotion: {promotion}");
            Console.WriteLine($"Faculté: {faculte}");
            Console.WriteLine($"Avantage bénéficié: {avantage}");
        }
        public void PayerFrais(double montant)
        {
            Console.WriteLine($"Le frais payé est de {montant}");
        }
    }
}
