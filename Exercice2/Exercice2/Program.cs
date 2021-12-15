using System;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] languages = new string[] { "CSS", "Javacrit", "jQuery", "PHP", "Bootstrap", "Java"};
			//Appel de la fonction showTab
            showTab(languages);
            Console.WriteLine($"Contenu du 4e élément du tableau languages : {languages[3]}.");
            Console.WriteLine($"Contenu de l'indice 4 du tableau week : {languages[4]}.");
            languages[5] = "C";
            languages[1] = "Javascript";
            showTab(languages);
        }
		//Fonction qui affiche le contenu d'un tabeleau
        public static void showTab (string[] tab)
        {
            foreach (string item in tab)
            {
                Console.WriteLine(item);
            }
        }
    }
}
