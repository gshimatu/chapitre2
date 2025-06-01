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
        protected string nom { get; set; }
        protected string promotion { get; set; }
        protected string faculte { get; set; }

        // Variables de classe
        static int nombreEtudiants = 0;

        // Constructeur par défaut
        // public Etudiant()
        // {

        // } // Suppression du constructeur par défaut

        public Etudiant(String nom, string promotion, string faculte)
        {
            this.nom = nom;
            this.promotion = promotion;
            this.faculte = faculte;
            nombreEtudiants++;
        }

        // Deuxième constructeur
        public Etudiant(String nom, string promotion) : this(nom, promotion, "(Non attribue)")
        {
            this.nom = nom;
            this.promotion = promotion;
        }

        public virtual void Afficher()
        {
            Console.WriteLine($"Nom: {nom}");
            Console.WriteLine($"Promotion: {promotion}");
            Console.WriteLine($"Faculté: {faculte}");
            Console.WriteLine($"Nombre d'étudiants: {nombreEtudiants}");

        }

        // Ajout des accesseurs (getters et setters)
        // public string Nom
        // {
        //     get { return nom; }
        //     set { nom = value; }
        // }

        /*

        public string GetNom()
        {
            return nom;
        }

        public void SetNom(string nom)
        {
            this.nom = nom;
        }

        public string GetPromotion()
        {
            return promotion;
        }

        public void SetPromotion(string promotion)
        {
            this.promotion = promotion;
        }

        public string GetFaculte()
        {
            return faculte;
        }
        
        public void SetFaculte(string faculte)
        {
            this.faculte = faculte;
        }

        */

    }
}