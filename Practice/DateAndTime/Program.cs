namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;


            Console.WriteLine(date.ToString());
            Console.WriteLine(date.ToShortDateString());
            Console.WriteLine(date.ToShortTimeString());

            Console.WriteLine(date.ToLongDateString());
            Console.WriteLine(date.ToLongTimeString());

            Console.WriteLine(date.AddDays(3).ToLongDateString());
            Console.WriteLine(date.AddDays(-3).ToLongDateString());

            Console.WriteLine(date.Month);

            DateTime mybirthDay = new DateTime(1985, 3, 10);
             Console.WriteLine(mybirthDay.ToShortDateString());

            DateTime myBirthDay = DateTime.Parse("10/03/1985");
            Console.WriteLine(myBirthDay.ToShortDateString());
            TimeSpan myAge = DateTime.Now.Subtract(myBirthDay);

            Console.WriteLine(myAge.TotalDays);
        }
    }
}