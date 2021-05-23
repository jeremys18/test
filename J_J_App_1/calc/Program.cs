using System;
using System.Linq;

namespace calc
{
    internal class Program
    {
        static void Main()
        {
           new Program().Start(); 
        }

        void Start()
        {
            int choice = 0;
            decimal d1 = 0;
            decimal d2 = 0;
            var validChoices = new int[] { 1, 2, 3, 4, 5 };
            var firstPrompt = "\n\nChoose Calc type \r\n1. Add\r\n2. Subtract\r\n3. Multiply\r\n4. Divide\r\n5. Exit\r\nSelection: ";
            var firstNumberPrompt = "Enter first decimal: \r\n";
            var secondNumberPrompt = "Enter second decimal: \r\n";

            do
            {
                Console.WriteLine(firstPrompt);
                choice = int.Parse(Console.ReadLine());
                if (choice != 5&& validChoices.Contains(choice))
                {
                    d1 = GetDecimalInput(firstNumberPrompt);
                    d2 = GetDecimalInput(secondNumberPrompt);
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"the result is: {Calc.Add(d1, d2)}");
                        break;
                    case 2:
                        Console.WriteLine($"the result is: {Calc.Subract(d1, d2)}");
                        break;
                    case 3:
                        Console.WriteLine($"the result is: {Calc.Multiply(d1, d2)}");
                        break;
                    case 4:
                        Console.WriteLine($"the result is: {Calc.Divide(d1, d2)}");
                        break;
                    case 5:
                        choice = 99;
                        break;
                    default:
                        Console.WriteLine("Invalid Selection: \r\n");
                        break;
                }

            } while (validChoices.Contains(choice));
            Console.ReadLine();
        }


        decimal GetDecimalInput(string mesage)
        {
            Console.WriteLine(mesage);
            var result = decimal.Parse(Console.ReadLine());
            return result;
        }
    }
}
