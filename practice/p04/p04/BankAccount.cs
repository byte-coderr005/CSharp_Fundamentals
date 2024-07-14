namespace p04;

public class BankAccount
{
    public string ID { get; set; }
    public int Balance { get; set; }
    public int Total { get; set; }
    public BankAccount(string _ID, int _Balance,int _Total)
    {
        ID = _ID;
        Balance = _Balance;
        Total = _Total;
    }
    public int Deposit(int mb)
    {
       return  mb + Balance;
        
    }
    public int WithDraw()
    {
        Total = mb - Balance;
        return Total;
    }

}
