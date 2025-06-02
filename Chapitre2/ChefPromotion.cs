using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre2
{
    class ChefPromotion : AEtudiant
    {
        public string responsabilite { get; set; }

        public ChefPromotion(string nom, string promotion, string faculte, string responsabilite)
            : base(nom, promotion, faculte)
        {
            this.responsabilite = responsabilite;
        }
        public override void AfficherInfos()
        {
            Console.WriteLine($"Nom: {nom}");
            Console.WriteLine($"Promotion: {promotion}");
            Console.WriteLine($"Faculté: {faculte}");
            Console.WriteLine($"Responsabilité: {responsabilite}");
            //throw new NotImplementedException();
        }

        public override void PayerFrais(double montant)
        {
            Console.WriteLine($"Le montant {montant} USD payé pour les frais académique");
            //throw new NotImplementedException();
        }

         
    }
}