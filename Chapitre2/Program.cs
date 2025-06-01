using System;

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
