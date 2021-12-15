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
            string inputInString;
            int result = 0;
            bool stop = false;
            int numberToMultiply;
            string yesOrNo;
            bool verifInput = true;
			//Boucle qui demande des nombres à multiplier entre eux, jusqu'a ce que l'utilisateur demande d'arreter(saisie non).
            while (!stop)
            {
                verifInput = true;
                Console.WriteLine("Saisissez un nombre a multiplier : ");
                inputInString = Console.ReadLine();
                if(int.TryParse(inputInString,out numberToMultiply))
                {
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
                    while (verifInput)
                    {
                        Console.WriteLine("Voulez vous ajouter un nombre à multiplier? (oui/non)");
                        yesOrNo = Console.ReadLine();
                        if (yesOrNo == "non")
                        {
                            stop = true;
                            verifInput = false;
                        }
                        else if(yesOrNo =="oui")
                        {
                            verifInput = false;
                        }
                        else
                        {
                            Console.WriteLine("La saisie n'est pas oui ou non.");
                        }
                    }                 
                }
                else
                {
                    Console.WriteLine("La saisie n'est pas un nombre.");
                }               
            }
            multiplyString += $" = {result}.";
            Console.WriteLine(multiplyString);
        }
    }
}
