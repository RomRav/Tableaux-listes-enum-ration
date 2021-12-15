using System;
using System.Collections.Generic;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Random rand = new Random();
            int numberOfNumber = rand.Next(1, 20);
            string addString = "Le calcule : ";
            int result = 0;
            for(int i = 0; i < numberOfNumber; i++)
            {
                int numberToAdd = rand.Next(1, 20);
                numbers.Add(numberToAdd);
                result += numberToAdd;
                if (numbers.Count == 1)
                {
                    addString += $"{numberToAdd}";
                }
                else
                {
                    addString += $" + {numberToAdd}";
                }               
            }
            addString += $" = {result}.";
            Console.WriteLine(addString);
        }
    }
}
