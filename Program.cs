using System;

public class Program
{
    public static void Main(string[] args)
    {
        int num, sumatoria = 0;

        Console.WriteLine("Ingrese un numero");
        num = int.Parse(Console.ReadLine());

        while (num > 0)
        {
            sumatoria = sumatoria + num;
            Console.WriteLine("Ingrese otro numero");
            num = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(sumatoria);
    }
}
