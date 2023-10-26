class Zad
{
    static void Main(string[] args)
    {
        double a, b, wynik;
        string znak;
        Console.WriteLine("Podaj a: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj b: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj znak operacji (+, -, * lub /: ");
        znak = Console.ReadLine();
        if(znak=="+")
        {
            wynik = a + b;
            Console.WriteLine(wynik);
        }
        else if (znak == "-")
        {
            wynik = a - b;
            Console.WriteLine(wynik);
        }
        else if (znak == "*")
        {
            wynik = a * b;
            Console.WriteLine(wynik);
        }
        else if (znak == "/")
        {
            wynik = a / b;
            Console.WriteLine(wynik);
        }
        else
        {
            Console.WriteLine("Podano zły znak!");
        }
        Console.ReadKey();
    }
}