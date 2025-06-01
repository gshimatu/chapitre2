using System;

namespace Chapitre2;

public class Etudiant
{
    private string nom;
    private string promotion;
    private string faculte;

    public Etudiant(string nom, string promotion, string faculte)
    {
        this.nom = nom;
        this.promotion = promotion;
        this.faculte = faculte;
    }

    

    public void Afficher()
    {
        Console.WriteLine($"Nom: {nom}, Promotion: {promotion}, Faculte: {faculte}");
    }

}
