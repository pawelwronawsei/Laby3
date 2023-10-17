internal class Program
{
    static void Main(string[] args)
    {
        //CompareOperators();
        Zadanie1();
    }
    public static void BoolVariables()
    {
        bool isWarm = false;
        bool canPay = true;
    }
    public static void LogicOperators()
    {
        bool isWarm = false;
        bool isCold = !isWarm;
        bool haveTime = true;
        bool canGoWalk = isWarm && haveTime;
    }
    public static void CompareOperators()
    {
        int temperature = 15;
        if (temperature < 0)
        {
            Console.WriteLine("Mróz");
        }
        else if (temperature < 10)
        {
            Console.WriteLine("Zimno");
        }
        else if (temperature > 10 || temperature == 10)
        {
            Console.WriteLine("Chlodno");
        }
        Console.WriteLine("Koniec");
    }

    public static void Zadanie1()
    {
        double x1 = 0;
        double x2 = 0;
        double a = 2.5;
        double b = 1.4;
        double c = -0.6;
        double delta = b * b - 4 * a * c;

        if(delta > 0)
        {
            x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"x1: {x1}, x2: {x2}");
        }
        else if (delta == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine($"x = {x1}");
        }
        else
        {
            Console.WriteLine("Brak rozwiązań");
        }
    }
}