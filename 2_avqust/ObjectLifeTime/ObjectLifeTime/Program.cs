namespace ObjectLifeTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car.MyMethod();

            /*
            Car myCar = new Car();

            Console.WriteLine("Model: {0}, Make: {1}, Year: {2}, Color: {3}", myCar.Model, myCar.Make, myCar.Year, myCar.Color);

            Car myCar2 = new Car("BMW", "Mercedes", 1990, "Black");

            Console.WriteLine("Model: {0}, Make: {1}, Year: {2}, Color: {3}", myCar2.Model, myCar2.Make, myCar2.Year, myCar2.Color);

            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Car myOtherCar = myCar;

            Console.WriteLine("Model: {0}, Make: {1}, Year: {2}, Color: {3}", myOtherCar.Model, myOtherCar.Make, myOtherCar.Year, myOtherCar.Color);

            myOtherCar.Model = "98";

            Console.WriteLine("Model: {0}, Make: {1}, Year: {2}, Color: {3}", myCar.Model, myCar.Make, myCar.Year, myCar.Color);

            myOtherCar = null;

            //Console.WriteLine("Model: {0}, Make: {1}, Year: {2}, Color: {3}", myOtherCar.Model, myOtherCar.Make, myOtherCar.Year, myOtherCar.Color);

            myCar = null;
            */
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year {  get; set; }
        public string Color {  get; set; }

        public Car()
        {
            Make = "Nissan";
        }
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public static void MyMethod()
        {
            Console.WriteLine("Called the static method");
        }
    }


}
