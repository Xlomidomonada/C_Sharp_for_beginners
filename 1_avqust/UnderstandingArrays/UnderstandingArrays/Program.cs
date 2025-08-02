namespace UnderstandingArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            Console.WriteLine(numbers[1]);
            */

            //int[] numbers = { 1, 2, 3 };

            //string[] names = { "eddie", "david", "malcolm", "ted" };

            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);

            }
            */

            /*
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            */

            string zig = "You can get what you want in life by helping others get what they want";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);
            foreach (char c in charArray)
            {
                Console.Write(c);
            }
        }
    }
}
