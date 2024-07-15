using System.Runtime.InteropServices;
//BUYUGE CEVİREN
string[] str = {"merhaba","burak","nasilsin"};
foreach(var s in str)
{
     Console.WriteLine(s.ToUpper());
}
//Asal mi
int num;
bool asalmi = true;
Console.WriteLine("Lütfen bir sayı giriniz:");
num = Convert.ToInt32(Console.ReadLine());
if (num <= 1)
    asalmi = false;
else
{
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            asalmi = false;
            break;
        }
    }
}
if (asalmi)
    Console.WriteLine($"{num} asaldir.");
else
    Console.WriteLine($"{num} asal değildir.");

