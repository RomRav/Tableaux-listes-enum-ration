using System;
using System.Collections.Generic;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
			//Création d'un list d'entier.
            List<int> numbers = new List<int>();
			//Crée un entier aléatoire
            Random rand = new Random();
            int numberOfNumber = rand.Next(1, 20);
            int result = 0;
			//Ajoute un nombre aléatoire de nombre aléatoire à la liste.
            for(int i = 0; i < numberOfNumber; i++)
            {
                int numberToAdd = rand.Next(1, 20);
                numbers.Add(numberToAdd);
                result += numberToAdd;    
            }
            Console.WriteLine($"Le résultat de l'addition de : {string.Join(" + ", numbers)} = {result}.");
        }
    }
}
