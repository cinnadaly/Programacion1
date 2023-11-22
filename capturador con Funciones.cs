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

        BuscarNumero(numeros);

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
        int n = numeros.Length;
        int[] copiaNumeros = new int[n];
        Array.Copy(numeros, copiaNumeros, n);

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (copiaNumeros[j] > copiaNumeros[j + 1])
                {
                    int temp = copiaNumeros[j];
                    copiaNumeros[j] = copiaNumeros[j + 1];
                    copiaNumeros[j + 1] = temp;
                }
            }
        }

        return copiaNumeros;
    }

    static void BuscarNumero(int[] numeros)
    {
        int numpos = 0, numbus = 0;
        Console.WriteLine("Desea buscar un dato en baso de numero (N) o posicion (P) ?");
        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case (opcion.ToLower() == "p")
                Console.WriteLine("Ingrese la posicion que desea consultar");
                numpos = Convert.ToInt32(Console.ReadLine());
                if (numpos >= 1 && numpos <= numeros.Length)
                {
                    int numbuscado = numeros[numpos - 1];
                    Console.WriteLine($"{numbuscado} se encuentra en la posicion {numpos} de la lista");
                }
                else
                {
                    Console.WriteLine($"{numpos} no se encuentra en la lista");
                }
                break;

            case (opcion.ToLower() == "v")
                Console.WriteLine("Ingrese el numero que desea buscar");
                numbus = Convert.ToInt32(Console.ReadLine());
                if (numbus >= 1 && numbus <= numeros.Length)
                {
                    int numbuscado = numeros[numbus - 1];
                    Console.WriteLine($"{numbuscado} se encuentra en la posicion {numbus} de la lista");
                }
                else
                {
                    Console.WriteLine($"{numbus} no se encuentra en la lista");
                }
                break;

            default:
                Console.WriteLine("Se ha ingresado una opcion no valida");
                break;
        }
    }
}