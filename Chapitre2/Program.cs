using System;

namespace Chapitre2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Etudiant etudiant1 = new Etudiant("GAUTHIER", "G3", "FASI");
            //etudiant1.nom = "Gauthier";
            //etudiant1.promotion = "L3";  
            //etudiant1.faculte = "Fasi";

            etudiant1.Afficher();

            Etudiant etudiant2 = new Etudiant("Shimatu", "L3");
            etudiant2.Afficher();

            etudiant2.SetNom("Chimatu");
            Console.WriteLine($"Nom : {etudiant2.GetNom()}");    

        }
    }
}
