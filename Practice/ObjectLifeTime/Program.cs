namespace ObjectLifeTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Oldsmobile";
            myCar.Model = "Mitsubishi";
            myCar.Year = 1999;
            myCar.Color = "Silver";

            Car.MyMethod();

            Car otherCar = myCar;
            Console.WriteLine("{0} {1} {2} {3}", otherCar.Make, otherCar.Model, otherCar.Year, otherCar.Color);

            otherCar.Year = 2008;
            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);

            otherCar = null;
            // Console.WriteLine("{0}", otherCar.Model);

            Car mythirdCar = new Car("Yaris", "Toyota", 1998, "Green");
            Console.WriteLine("{0} {1} {2} {3}", mythirdCar.Make, mythirdCar.Model, mythirdCar.Year, mythirdCar.Color);

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
            Make = "Nissan";
        }

        public Car(string make, string model, int year, string color)        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public static void MyMethod()
        {
            Console.WriteLine("This is some static method");
        }

    }
}