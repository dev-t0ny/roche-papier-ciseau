using System;
using System.Collections.Generic;
namespace roche_papier_ciseau
{
    public class Jeu
    {
		private Joueur[] _joueurs;

		public Joueur[] Joueurs
		{
			get { return _joueurs; }
			set { _joueurs = value; }
		}

        public Jeu(Joueur j1, Joueur j2)
        {
            Joueurs = new Joueur[2];
            Joueurs[0] = j1;
            Joueurs[1] = j2;
        }

        /// <summary>
        /// Joue un nouveau tour
        /// </summary>
        /// <returns>Retourne vrai si un des joueurs à perdu la partie, faux dans le cas inverse</returns>
        public bool JouerTour()
        {
            foreach (Joueur j in Joueurs)
            {
                j.ObtenirNouveauChoix();
            }
            
            switch (Joueurs[0].ChoixActuel)
            {
                case Choix.Roche:
                    if (Joueurs[1].ChoixActuel == Choix.Ciseau)
                    {
                        Joueurs[1].PointDeVie--;
                    }
                    else if (Joueurs[1].ChoixActuel == Choix.Papier)
                    {
                        Joueurs[0].PointDeVie--;
                    }
                    break;
                case Choix.Papier:
                    if (Joueurs[1].ChoixActuel == Choix.Ciseau)
                    {
                        Joueurs[1].PointDeVie--;
                    }
                    else if (Joueurs[1].ChoixActuel == Choix.Roche)
                    {
                        Joueurs[0].PointDeVie--;
                    }
                    break;

                case Choix.Ciseau:
                    if (Joueurs[1].ChoixActuel == Choix.Papier)
                    {
                        Joueurs[1].PointDeVie--;
                    }
                    else if (Joueurs[1].ChoixActuel == Choix.Roche)
                    {
                        Joueurs[0].PointDeVie--;
                    }
                    break;
            }

            foreach (Joueur j in Joueurs)
            {
                
                Console.WriteLine($"Point de vie du joueur {j.Nom}: {j.PointDeVie}");
                
                if (j.PointDeVie == 0)
                {
                    Console.WriteLine("Le joueur j gagne la partie!");
                    Console.ReadLine();
                    return true;
                }
            }
            Console.WriteLine("Fin de la manche. Appuyer sur entrer pour continuer");
            Console.ReadLine();
            return false;
        }
    }
}
