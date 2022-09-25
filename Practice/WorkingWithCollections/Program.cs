using System.Collections;

namespace WorkingWithCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlus Supreme";
            car1.VIN = "C1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "C2";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft XML and Web Services";
            b1.ISBN = "0-0-0000-0000";

            // Collections: ArrayList are dynamically sized

            /*
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */

            // Generic Collections: List<T>
            
            List<Car> myCarList = new List<Car>();
            myCarList.Add(car1);
            myCarList.Add(car2);

            // Cannot add book to car collections
            // myCarList.Add(b1);

            foreach (Car car in myCarList)
            {
                Console.WriteLine(car.Model);
            }

            // Dictionary<TKey, TValue>
            Dictionary<string, Car> myCarDictionary = new Dictionary<string, Car>();
            myCarDictionary.Add(car1.VIN, car1);
            myCarDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myCarDictionary["C2"].Make);

            // Object Initializer Syntax
            // No need for constructor
            Car car3 = new Car()
            {
                Make = "BMW",
                Model = "750li",
                VIN = "C3"
            };

            // Collection Iniitalizer
            List<Car> myNewCarList = new List<Car>()
            {
                new Car { Make= "Toyota", Model="Yaris", VIN="C4" },
                new Car { Make= "Corolla", Model="Mitsubi", VIN="C5"}
            };

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}