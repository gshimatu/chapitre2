using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre2 
{
    internal class Etudiant
    {
        string nom;
        string promotion;
        string faculte;
        
        public Etudiant(String nom, string promotion, string faculte)
        {
            this.nom = nom;
            this.promotion = promotion;
            this.faculte = faculte;
        }

        public void Afficher()
        {
            Console.WriteLine($"Nom: {nom}");
            Console.WriteLine($"Promotion: {promotion}");
            Console.WriteLine($"Faculté: {faculte}");

        }

    }
}