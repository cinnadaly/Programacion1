using System;

public class Capturar10num
{
    public static void Main(string[] args)
    {
        int[] numeros = new int[10];

        Capturador(numeros);

        Console.WriteLine("Los números ingresados son:");
        Imprimnum(numeros);

        int sumatoria = Sumatoriatotal(numeros); 
        Console.WriteLine($"La suma de los números ingresados es: {sumatoria}");

        int[] ascendente = MenorAMayor(numeros);
        Console.WriteLine("Los números de menor a mayor son:");
        Imprimnum(ascendente);

        BuscarPorPosicion(numeros);

    }

    static void Capturador(int[] numeros)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese un número entero:");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    static void Imprimnum(int[] numeros)
    {
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }

    static int Sumatoriatotal(int[] numeros)
    {
        int sumatoria = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            sumatoria += numeros[i];
        }
        return sumatoria;
    }

    static int[] MenorAMayor(int[] numeros)
    {
        int[] ascendente = new int[numeros.Length];
        Array.Copy(numeros, ascendente, numeros.Length);

        Array.Sort(ascendente);

        return ascendente;
    }

    static void BuscarPorPosicion(int[] numeros)
    {
        int numpos = 0;
        Console.WriteLine("Ingrese la posicion que desea consultar: ");
        numpos = Convert.ToInt32(Console.ReadLine());

        if (numpos >=1 && numpos <= numeros.Length)
        {
            int numbuscado = numeros[numpos - 1];
            Console.WriteLine($"{numbuscado} se encuentra en la posicion {numpos} de la lista");
        }
        else
        {
            Console.WriteLine($"{numpos} no se encuentra en la lista");
        }
    }
}


