using System;
using System.Collections.Generic;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersToMultiply = new List<int>();

            string multiplyString = "La multiplication est : ";
            int result = 0;
            bool stop = false;
            int numberToMultiply;
            string yesOrNo;
            while (!stop)
            {
                Console.WriteLine("Saisissez un nombre a multiplier : ");
                numberToMultiply = Convert.ToInt32(Console.ReadLine());
                numbersToMultiply.Add(numberToMultiply);
                
                if (numbersToMultiply.Count == 1)
                {
                    multiplyString += $"{numberToMultiply}";
                    result = numberToMultiply;
                }
                else
                {
                    multiplyString += $" x {numberToMultiply}";
                    result *= numberToMultiply;
                }
                Console.WriteLine("Voulez vous ajouter un nombre à multiplier? (oui/non)");
                yesOrNo = Console.ReadLine();
                if(yesOrNo == "non")
                {
                    stop = true;
                }
            }

            multiplyString += $" = {result}.";
            Console.WriteLine(multiplyString);
        }
    }
}
