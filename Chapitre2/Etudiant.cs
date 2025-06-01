using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre2 
{
    internal class Etudiant
    {
        public string nom;
        public string promotion;
        public string faculte;

        public void Afficher()
        {
            Console.WriteLine($"Nom: {nom}");
            Console.WriteLine($"Promotion: {promotion}");    
            Console.WriteLine($"Faculté: {faculte}");
           
        }

    }
}