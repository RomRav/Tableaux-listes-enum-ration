using System;

namespace Exercice6
{
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
            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine((week)i);
            }
            
            Console.WriteLine((week)4);
        }
    }
}
