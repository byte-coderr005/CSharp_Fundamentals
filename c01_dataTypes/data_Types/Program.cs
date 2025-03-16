﻿//Value Data Types - Değer türünden Data Tipleri
short b = 16; //Range -2^(15) to 2^(15)*1.
int a = 32;//Range -2^(31) to 2(31) -1.
double d = 45;
long l = 6768;
char nu = '\0'; // Null value;
bool k = true; //true or false
//Reference Data Types - Referans Türünden Data Tipleri
string s1 = "Hello";  //string keyword
String s2 = "Welcome"; // from string class
//OBJECT:
object obj;
obj = 20;
Console.WriteLine(obj);
Console.WriteLine(obj.GetType()); //System.Int32
//Dynamic & var veri türü
//Çalışma zamanında (runtime) tip belirlemeye olanak tanıyan özel bir veri türüdür.
//Herhangi bir türde değer atanabilir.
//DERLEYİCİ HATA KONTROLU YAPAMAZ.
dynamic veri = 10;
veri = "Merhaba burak"; // string oldu.
//var veri türü
//var derleme zamanında türü belirler.
//Derleyici değişkene atanan değere bakarak türü otomatik belirlenir..
var sayi = 32; // int 
var metin = "Turbo"; //string
var hata; // HATA!! Değer atanmadığı için tür belirlenemez.