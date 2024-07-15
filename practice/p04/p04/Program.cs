using System.Runtime.InteropServices;
using p04;

Person p1 = new Person("Burak", "Ozturk", 27);
Console.WriteLine(p1.Print());
Car car = new Car("Bmw","535i",1993);
Console.WriteLine(car.StartEng());
Rectangle r1 = new Rectangle(10,2);
Console.WriteLine(r1.CalculateArea());