using System;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jedi", "Vendredi", "Samedi" };
            Console.WriteLine($"Contenu de l'indice 1 du tableau week : {week[1]}");
            Console.WriteLine($"Contenu de l'indice 4 du tableau week : {week[4]}");
            Console.WriteLine($"Contenu du 1er élément du tableau week : {week[0]}");
            Console.WriteLine($"Contenu du 4e élément du tableau week : {week[3]}");
            week[3] = "Jeudi";
            Array.Resize<string>(ref week, week.Length+1);
            week[6] = "Dimanche";
            foreach(string day in week)
            {
                Console.WriteLine(day);
            }
        }
    }
}
