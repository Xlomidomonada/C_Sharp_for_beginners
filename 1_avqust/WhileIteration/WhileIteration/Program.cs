namespace WhileIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (MainMenu())
            {
                Console.Clear();
            }
        }
        private static bool MainMenu()
        {
            Console.WriteLine("Choose an option: \n" +
                "1) Guessing Game\n" +
                "2) Printing Numbers\n" +
                "3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                GuessingGame();
                return true;
            }
            else if (result == "2")
            {
                PrintingNumbers();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else return true;
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Random random = new Random();
            int myRandom = random.Next(1,11);
            Console.WriteLine("Guess the number!");
            bool incorrect = true;
            int guesses = 0;
            do
            {
                guesses++;
                string guessedNumber = Console.ReadLine();
                if (guessedNumber == myRandom.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }
            }while (incorrect);
            Console.WriteLine("You found the correct number in {0} guesses", guesses);
            Console.ReadLine();
        }
        private static void PrintingNumbers()
        {
            Console.Clear();
            Console.WriteLine("Write a number!");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number + 1; i++)
            {
                Console.Write("--{0}", i);
            }
            Console.ReadLine();
        }
    }
}
