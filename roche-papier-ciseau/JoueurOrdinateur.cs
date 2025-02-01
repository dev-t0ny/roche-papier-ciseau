using System;

namespace roche_papier_ciseau
{
    public class JoueurOrdinateur : Joueur
    {
        public new void ObtenirNouveauChoix()
        {
            Random rnd = new Random();
            int choix = rnd.Next(2);
            ChoixActuel = (Choix)choix;
        }
    }
}
