namespace SimpleClasses
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

            Console.WriteLine(String.Format("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color));

            // decimal myCarValue = DetermineMarketValue(myCar);
            // Console.WriteLine("Car value: {0:C}", myCarValue);

            Console.WriteLine("{0:C}", myCar.DetermineCarValue());
        }

        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.0M;

            return carValue;
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineCarValue()
        {
            decimal carValue;

            if (Year > 1990)
            {
                carValue = 100000;
            }
            else
            {
                carValue = 50000;
            }
            return carValue;
        }

    }
}