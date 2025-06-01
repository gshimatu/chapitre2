// using System;
// using Chapitre2;

// Etudiant etudiant1 = new Etudiant();
// etudiant.nom = "Gauthier";
// etudiant.promotion = "L3";  
// etudiant.faculte = "Fasi";

namespace Chapitre2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Etudiant etudiant1 = new Etudiant();
            etudiant1.nom = "Gauthier";
            etudiant1.promotion = "L3";  
            etudiant1.faculte = "Fasi";

            etudiant1.Afficher();

        }
    }
}
