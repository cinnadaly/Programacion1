using System;

public class ConversorDecimalARomano
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresa un número decimal:");
        int numeroD = int.Parse(Console.ReadLine());

        if (numeroD < 1 || numeroD > 3999)
        {
            Console.WriteLine("El número no puede ser convertido a romano");
        }
        else
        {
            string numeroR = ConvertirDecimalARomano(numeroD);
            Console.WriteLine($"El número convertido a romano es: {numeroR}");
        }
    }

    public static string ConvertirDecimalARomano(int numero)
    {
        string[] romanos = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] valores = {    1000,  900,  500, 400, 100,  90,   50,  40,  10,   9,    5,    4,   1 };
        string numeroR = "";

        for (int i = 0; i < romanos.Length; i++)
        {
            while (numero >= valores[i])
            {
                numeroR += romanos[i];
                numero -= valores[i];
            }
        }

        return numeroR;
    }
}
