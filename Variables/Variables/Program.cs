namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;
            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            */

            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            string myFirstName = Console.ReadLine();
            Console.Write("Type your second name: ");
            string mySecondName = Console.ReadLine();
            Console.WriteLine("Hi, " +  myFirstName + " " + mySecondName);
        }
    }
}
