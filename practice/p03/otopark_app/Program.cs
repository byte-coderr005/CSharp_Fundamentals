int sure = Convert.ToInt32(Console.ReadLine());
char m,a,t;
char giris = Convert.ToChar(Console.ReadLine());
double fiyat = 0;
if(giris == 'm')
{
    if(sure == 1)fiyat = 15;
    else fiyat = sure * (10 * 1.20); 
}
if(giris == 'a')
{
    if(sure == 1) fiyat = 10;
    else fiyat = sure *(15 * 1.25);
}
if(giris == 't')
{
    if(sure == 1) fiyat = 20;
    else fiyat = sure * (20 * 1.30);
}
Console.WriteLine(fiyat.ToString());
