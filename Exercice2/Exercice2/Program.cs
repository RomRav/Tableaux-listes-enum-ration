using System;
using System.Collections.Generic;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> languages = new List<string> { "CSS", "Javacrit", "jQuery", "PHP", "Bootstrap", "Java"};
			//Appel de la fonction showTab
            showTab(languages);
            Console.WriteLine($"Contenu du 4e élément du tableau languages : {languages[3]}.");
            Console.WriteLine($"Contenu de l'indice 4 du tableau week : {languages[4]}.");
            languages.Remove("Bootstrap");
            languages[languages.IndexOf("Javacrit")] = "Javascript";
            languages.Add("C");           
            showTab(languages);
        }
		//Fonction qui affiche le contenu d'un tabeleau
        public static void showTab (List<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
