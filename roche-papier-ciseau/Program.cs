using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roche_papier_ciseau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Joueur j1 = new Joueur();
            Joueur j2 = new JoueurOrdinateur();
            Jeu jeu = new Jeu(j1, j2);

            while (!jeu.JouerTour())
            {

            }
        }
    }
}
