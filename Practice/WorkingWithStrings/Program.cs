using System.Text;

namespace WorkingWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mystring = "";

            // mystring = @"Got to your C:\ Drive";
            // mystring = String.Format("{1} = {0}", "first", "second");

            // mystring = String.Format("{0:C}", 123.45);
            // mystring = String.Format("{0:N}", 123456666);
            // mystring = String.Format("{0:P}", 0.012);
            // mystring = String.Format("{0: (###) ###-####}", 1234569078);

            // mystring = " That summer we took threes across the board ";
            // mystring = mystring.Substring(6);
            // mystring = mystring.ToUpper();
            //mystring = mystring.Replace(" ", "-");
            // mystring = mystring.Remove(6, 14);

            // Console.WriteLine(mystring);

            //Console.WriteLine(String.Format("Before trim: {0}, After trim: {1}", mystring.Length, mystring.Trim().Length));

            /*
            mystring = "";

            for (int i = 0; i < 50; i++)
            {
                mystring += "--" + i.ToString();
            }
            */

            StringBuilder mystring2 = new StringBuilder();

            for (int i=0; i<50; i++)
            {
                mystring2.Append("--");
                mystring2.Append(i);
            }

            Console.WriteLine(mystring2);
        }
    }
}