using System.ComponentModel.DataAnnotations;

namespace Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bob's giveaway: Choose 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            /*
            string message = "";

            if (userValue == "1")
                message = "You won a boat";
            else if (userValue == "2")
                message = "You won a car";
            else if (userValue == "3")
                message = "You won nothing";
            else
                message = "We didn't understand";
            Console.Write(message);
            */

            string message = (userValue == "1") ? "Car" : "nothing";
            Console.WriteLine("You won {0}, Because you choose {1}", message, userValue);
        }
    }
}
