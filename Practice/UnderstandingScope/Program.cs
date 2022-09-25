namespace UnderstandingScope
{
    internal class Program
    {
        private static string k = "";
        static void Main(string[] args)
        {
            string j = "";

            for(int i=0; i<5; i++)
            {
                Console.WriteLine(i);
                j = i.ToString();
                k = i.ToString();
            }
            Console.WriteLine("Value of j outside for loop: {0}", j);
            Console.WriteLine("Value of k inside method but outside for loop: {0}", k);

            MyMethod();

            Car myCar = new Car();
            Car.DoSomething();

        }

        static void MyMethod()
        {
            Console.WriteLine("Value of k inside other method: {0}", k);
        }
    }

    class Car
    {
        public static void DoSomething()
        {
            Console.WriteLine("Inside public mehtod");
            MakeSomething();
        }

        private static void MakeSomething()
        {
            Console.WriteLine("Insdie private method");
        }
    }
}