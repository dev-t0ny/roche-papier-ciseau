using System;

namespace roche_papier_ciseau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Création des objets
            Joueur j1 = new Joueur();
            Joueur j2 = new JoueurOrdinateur();
            Jeu jeu = new Jeu(j1, j2);

            //Lancement du jeu
            while (!jeu.JouerTour())
            {

            }
            Console.WriteLine("Fin de la partie!");
            Console.ReadLine();
        }
    }
}
