namespace p04;

public class Car
{
    
    public string _marka;
    public string _model;
    public int _yil;
    public Car(string marka, string model, int yil)
    {
        _marka = marka;
        _model = model;
        _yil = yil;
        
    }
    public string StartEng()
    {
        return $"{_marka} {_model} {_yil} araba motoru calisti.";
    }

    

}
