using System;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
			//Création d'un tableau de chaîne de caractére contenant presque tous les jours de la semaine.
            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jedi", "Vendredi", "Samedi" };
			//Affiche une chaîne de caractére concaténé avec certains élémenets du tableau.
            Console.WriteLine($"Contenu de l'indice 1 du tableau week : {week[1]}");
            Console.WriteLine($"Contenu de l'indice 4 du tableau week : {week[4]}");
            Console.WriteLine($"Contenu du 1er élément du tableau week : {week[0]}");
            Console.WriteLine($"Contenu du 4e élément du tableau week : {week[3]}");
			//Modification de l'élément positionné à l'indice 3 du tableau.
            week[3] = "Jeudi";
			//Modification de la taille du tableau pour y intégrer un nouvelle élément.
            Array.Resize<string>(ref week, week.Length+1);
            week[6] = "Dimanche";
            foreach(string day in week)
            {
                Console.WriteLine(day);
            }
        }
    }
}
