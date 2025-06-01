using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre2 
{
    internal class Etudiant
    {
        // Attributs
        string nom;
        string promotion;
        string faculte;
        
        public Etudiant(String nom, string promotion, string faculte)
        {
            this.nom = nom;
            this.promotion = promotion;
            this.faculte = faculte;
        }

        // Deuxième constructeur
        public Etudiant(String nom, string promotion) : this(nom, promotion, "(Non attribue)")
        {
            this.nom = nom;
            this.promotion = promotion;
        }

        public void Afficher()
        {
            Console.WriteLine($"Nom: {nom}");
            Console.WriteLine($"Promotion: {promotion}");
            Console.WriteLine($"Faculté: {faculte}");

        }

    }
}