using System;

namespace CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {

            int TotalCoffeeCost = 0;
            string UserDecision = " ";

            do {
                string str1 = "hey man";
                int UserChoice = 0;

                do {
                Console.WriteLine("Please select the Coffe Size :  1 - small, 2 - Medium, 3 - Large");
                UserChoice = int.Parse(Console.ReadLine());

                switch (UserChoice)
                {
                    case 1:
                        TotalCoffeeCost += 3;
                        break;
                    case 2:
                        TotalCoffeeCost += 5;
                        break;
                    case 3:
                        TotalCoffeeCost += 7;
                        break;
                    default:
                        Console.WriteLine("Your choice {0} is invalid ", UserChoice);
                        break;
                }
            } while (UserChoice != 1 && UserChoice != 2 && UserChoice != 3);


            do
            {
                Console.WriteLine("Do you Want to Buy another Coffee - Yes or No ? ");
                UserDecision = Console.ReadLine().ToUpper();
                if (UserDecision != "YES" && UserDecision != "NO")
                {
                    Console.WriteLine("Your choice (0) is invalid. Please try again...", UserDecision);
                }
            } while (UserDecision != "YES" && UserDecision != "NO");
        } while(UserDecision != "NO");

            Console.WriteLine("Thank you for shopping with us ");
            Console.WriteLine("Bill Amount = " + TotalCoffeeCost + "$");
        }
    }
}
