// See https://aka.ms/new-console-template for more information
Basla();

void Basla()
{
    try
    {
        Console.WriteLine("Hangi yarım küredesiniz?");
        string? yarimkure = Console.ReadLine();
        Console.WriteLine("Kaçıncı aydasınız?");
        int ay = Convert.ToInt32(Console.ReadLine());

        if (yarimkure == "k" && (ay == 12 || ay == 1 || ay == 2))
        {
            Console.WriteLine("Kış mevsimindesiniz.");
        }
        else if (yarimkure == "k" && (ay == 3 || ay == 4 || ay == 5))
        {
            Console.WriteLine("İlkbahar mevsimindesiniz.");
        }
        else if (yarimkure == "k" && (ay == 6 || ay == 7 || ay == 8))
        {
            Console.WriteLine("Yaz mevsimindesiniz.");
        }
        else if (yarimkure == "k" && (ay == 9 || ay == 10 || ay == 11))
        {
            Console.WriteLine("Sonbahar mevsimindesiniz.");
        }
        else if (yarimkure == "g" && (ay == 12 || ay == 1 || ay == 2))
        {
            Console.WriteLine("Yaz mevsimindesiniz.");
        }
        else if (yarimkure == "g" && (ay == 3 || ay == 4 || ay == 5))
        {
            Console.WriteLine("Sonbahar mevsimindesiniz.");
        }
        else if (yarimkure == "g" && (ay == 6 || ay == 7 || ay == 8))
        {
            Console.WriteLine("Kış mevsimindesiniz.");
        }
        else if (yarimkure == "g" && (ay == 9 || ay == 10 || ay == 11))
        {
            Console.WriteLine("Kış mevsimindesiniz.");
        }
        else
        {
            Console.WriteLine("Yanlış veri girdiniz");
        }
        Console.ReadLine();
        Basla();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}


