namespace HelperMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type your first name: ");
            string myFirstName = Console.ReadLine();
            Console.Write("Type your second name: ");
            string mySecondName = Console.ReadLine();
            Console.Write("Type your adress: ");
            string myAdress = Console.ReadLine();

            DisplayResult(ReverseString(myFirstName), ReverseString(mySecondName), ReverseString(myAdress));
            DisplayResult(ReverseString(myFirstName) + " " + ReverseString(mySecondName) + " " + ReverseString(myAdress));
            
        }
        
        private static void DisplayResult(string reversedFirstName,  string reversedSecondName, string reversedAdress)
        {
            Console.WriteLine(String.Format("{0} {1} {2}", reversedFirstName, reversedSecondName, reversedAdress));
        }
        private static string ReverseString(string message)
        {
            char[] chars = message.ToCharArray();
            Array.Reverse(chars);
            return String.Concat(chars);
        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine(message);
        }
    }
}
