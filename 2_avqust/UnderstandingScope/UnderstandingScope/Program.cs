namespace UnderstandingScope
{
    internal class Program
    {
        private static int k = 0;
        static void Main(string[] args)
        {
            string j ="";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i;
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = "salam";
                }
                //Console.WriteLine(l);
            }
            Console.WriteLine("j outside is " + j);
            Console.WriteLine("k outside is "+ k);
            HelperMethod();
            //Console.WriteLine(i);

            //Car car = new Car();
            Car.DoSomething();
        }
        static void HelperMethod()
        {
            Console.WriteLine("HelperMethod k is " + k);
        }

    }

    class Car
    {
        public static void DoSomething()
        {
            Console.WriteLine(HelperMethod());
        }
        private static string HelperMethod()
        {
            return "Hello World";
        }
    }
}
