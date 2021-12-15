using System;

namespace Exercice6
{
	//Création d'un enumerable contenant les jour de la semaine.
    public enum week
    {
        Lundi,
        Mardi,
        Mercredi,
        Jeudi,
        Vendredi,
        Samedi,
        Dimanche
    }
    class Program
    {
        static void Main(string[] args)
        {
			//Affichage du contenu et d'un élément de l'énumerable week.
            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine((week)i);
            }
            
            Console.WriteLine((week)4);
        }
    }
}
