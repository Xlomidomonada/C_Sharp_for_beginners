using System.Collections;
using System.Collections.Generic;

namespace WorkingWithCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book() { Name = "1984", ISBN = "123456789", Author = "George Orwell"};

            Car car1 = new Car() { Make = "Oldsmobile", Model = "Cutlas Supreme", ID = "1" };
            Car car2 = new Car() { Make = "Oldsmobile", Model = "442", ID = "2" };

            ArrayList myArray = new ArrayList();
            myArray.Add(car1);
            myArray.Add(car2);
            myArray.Add(book1);
            myArray.Remove(book1);
            foreach (Car car in myArray)
            {
                Console.WriteLine(car.Make + " " + car.Model);
            }

            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(book1);

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Make + " " + car.Model);
            }

            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.ID, car1);
            myDictionary.Add(car2.ID, car2);

            Console.WriteLine(myDictionary[car2.ID].Model);

            List<Car> list2 = new List<Car>()
            {
                new Car { Model = "Nissan", ID = "11" , Make ="BMW"},
                new Car { Model = "Hundei", ID = "22", Make = "Mercedes"}
            };
        }
    }

    class Car
    {
        public string ID {  get; set; }
        public string Model { get; set; }
        public string Make {  get; set; }
    }

    class Book
    {
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set;}
    }
}
