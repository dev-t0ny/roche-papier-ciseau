using System;

namespace roche_papier_ciseau
{
	public enum Choix
	{
		Roche,
		Papier,
		Ciseau
	}

    public class Joueur
    {
		private int _pointDeVie;
		private Choix _choixActuel;
		private string _nom;

		public string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}

		public Choix ChoixActuel
		{
			get { return _choixActuel; }
			set { _choixActuel = value; }
		}

		public int PointDeVie
		{
			get { return _pointDeVie; }
			set { _pointDeVie = value; }
		}

        public Joueur()
        {
			PointDeVie = 3;
			Nom = ObtenirNouveauNom();
        }

		/// <summary>
		/// Obtiens un nouveau nom de joueur
		/// </summary>
		/// <returns>Nom du joueur</returns>
		public virtual string ObtenirNouveauNom()
		{
			Console.Write("Veuillez entrer votre prénom: ");
			return Console.ReadLine();
		}

		/// <summary>
		/// Obtiens un nouveau choix entre Roche Papier Ciseau
		/// </summary>
        public virtual void ObtenirNouveauChoix()
		{
			Console.WriteLine("Veuillez choisir:");
			Console.WriteLine("[1] Roche");
			Console.WriteLine("[2] Papier");
			Console.WriteLine("[3] Ciseau");

			int choixTemp = -1;

			try
			{
				choixTemp = int.Parse((Console.ReadLine()));
			}
			catch
			{
				Console.WriteLine("Erreur. Veuillez faire un choix valide (Un nombre entre 1-3)");
			}
			ChoixActuel = (Choix)choixTemp;
        }
	}
}
