using System.Security.Cryptography.X509Certificates;

namespace p04;

public class Person
{
    private string? _ad;
    private string? _soyad;
    private int yas;
    public Person(string Ad,string Soyad,int Yas)
    {
        _ad = Ad;
        _soyad = Soyad;
        yas =  Yas;      
    }
    public string Print()
    {
       return $"{_ad} {_soyad} {yas}";
    }

}
