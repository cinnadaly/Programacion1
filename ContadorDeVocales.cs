using System;
public class ContadorVocales
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresa una palabra");
        string palabra = Console.ReadLine();

        ContarVocales(palabra);
    }

    static void ContarVocales(string palabra)
    {
        int a = 0;
        int e = 0;
        int i = 0;
        int o = 0;
        int u = 0;

        foreach (char letra in palabra)
        {
            if (letra == 'a' || letra == 'A')
            {
                a++;
            }
            else if (letra == 'e' || letra == 'E')
            {
                e++;
            }
            else if (letra == 'i' || letra == 'I')
            {
                i++;
            }
            else if (letra == 'o' || letra == 'O')
            {
                o++;
            }
            else if (letra == 'u' || letra == 'U')
            {
                u++;
            }
        }

        Console.WriteLine($"La palabra '{palabra}' tiene:");
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"e = {e}");
        Console.WriteLine($"i = {i}");
        Console.WriteLine($"o = {o}");
        Console.WriteLine($"u = {u}");
    }
}
