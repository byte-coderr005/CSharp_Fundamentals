using System.Runtime.Intrinsics.Arm;
using System.Xml.XPath;

Console.WriteLine("Welcome!...");
Console.WriteLine("Press 0 to exit...");
string input = Console.ReadLine();
if(input == "0")
{
    Console.WriteLine("Exiting..");
}
else
{
    int num;
    Console.WriteLine("Please enter a number for factorial");
    num = Convert.ToInt32(Console.ReadLine());
    if(num == 0)
    Console.WriteLine("0 factorial is 1");
    else if(num >= 1)
    {
        int result = 1;
        for(int i = 1; i<=num; i++)
        {
            result *= i;
        }
        Console.WriteLine($"{num} 's factorial is {result}.");
    }

}
