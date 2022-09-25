// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");
int x, y;
x = 1;
y = x + 4;

Console.WriteLine(y);
*/

/*
string firstName, lastName;
Console.WriteLine("Enter first name: ");
firstName = Console.ReadLine();

Console.WriteLine("Enter last name: ");
lastName = Console.ReadLine();

Console.WriteLine("Your name is " + firstName + lastName);
*/



string zig = "You can get what you want out of life";

char[] charArray = zig.ToCharArray();

for (int i = 0; i < charArray.Length; i++)
{
    Console.Write(charArray[i]);
}

Array.Reverse(charArray);

foreach (char c in charArray)
{
    Console.Write(c);
}













