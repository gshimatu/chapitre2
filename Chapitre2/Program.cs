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

            // etudiant1.Afficher(); Mise en commentaire pour ne voir que l'affichage du président étudiant

            Etudiant etudiant2 = new Etudiant("Shimatu", "L3");
            // etudiant2.Afficher();  Mise en commentaire pour ne voir que l'affichage du président étudiant

            //etudiant2.SetNom("Chimatu");
            //Console.WriteLine($"Nom : {etudiant2.GetNom()}");    

            PresidentEtudiant president1 = new PresidentEtudiant("Shimatologue", "G3", "FASI", "2024-2025", 1500.0);
            president1.Afficher();

            ChefPromotion cp = new ChefPromotion("Stone", "L3", "FASI", "Assurer le bon deroulement du cours dans sa promotion et represente les étudiants au pres du doyen");
            cp.AfficherInfos();
            cp.PayerFrais(900);
        }
    }
}
