using System;

namespace Chapitre2
{
    internal class PresidentEtudiant : Etudiant
    {
        string mandat;
        double avantage;

        // Constructeur par défaut
        public PresidentEtudiant(string nom, string promotion, string faculte, string mandat, double avantage)
            : base(nom, promotion, faculte)
        {
            this.mandat = mandat;
            this.avantage = avantage;
        }

        public override void Afficher()
        {
            //base.Afficher(); // Appel de la méthode Afficher de la classe de base
            Console.WriteLine($"Mandat: {mandat}");
            Console.WriteLine($"Avantage: {avantage}");
            Console.WriteLine("-----------------------------");
        }
    }
}
