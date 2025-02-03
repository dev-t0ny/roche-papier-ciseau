using System;

namespace roche_papier_ciseau
{
    public class JoueurOrdinateur : Joueur
    {
        public override string ObtenirNouveauNom()
        {
            string[] firstNames = new string[]
            {
            "John", "Emma", "Michael", "Sophia", "William",
            "Olivia", "James", "Ava", "Benjamin", "Isabella"
            };
            Random rnd = new Random();
            int choix = rnd.Next(firstNames.Length);
            return firstNames[choix];
        }
        public override void ObtenirNouveauChoix()
        {
            Random rnd = new Random();
            int choix = rnd.Next(2);
            ChoixActuel = (Choix)choix;
        }
    }
}
