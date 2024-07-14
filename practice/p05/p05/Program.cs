 public void Run()
    {
        Console.Write("Bir sayı girin: ");
        string girdi = Console.ReadLine();

        if (int.TryParse(girdi, out int sayi))
        {
            if (AsalMi(sayi))
            {
                Console.WriteLine($"{sayi} asal bir sayıdır.");
            }
            else
            {
                Console.WriteLine($"{sayi} asal bir sayı değildir.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz giriş! Lütfen bir tam sayı girin.");
        }
    }

    // AsalMi method
    public bool AsalMi(int sayi)
    {
        if (sayi <= 1) return false;
        if (sayi == 2) return true;

        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if (sayi % i == 0) return false;
        }

        return true;
    }
