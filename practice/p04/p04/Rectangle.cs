namespace p04;

public class Rectangle
{
    public int Height { get; set; }
    public int Base { get; set; }
    public Rectangle(int _height,int _base)
    {
        Height = _height;
        Base = _base;
    }
    public int CalculateArea()
    {
        return (Height * Base)/ 2;
    }


}
