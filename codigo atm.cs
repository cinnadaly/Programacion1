using System;

public class ATM
{
    public static void Main(string[] args)
    {
        int Cantdin;
        do
        {
            Console.WriteLine("Que cantidad de dinero desea cambiar?");
            Cantdin = int.Parse(Console.ReadLine());

            Arreglobilletes(Cantdin);
            Console.WriteLine("Desea volver a consultar a cambiar dinero? (S/N) ");
        }
        while (Console.ReadLine().ToLower() == "s");
    }
    
        static void Arreglobilletes(int Cantdin)
        {
            int[] billetes = { 1000, 500, 200, 100, 50, 20 };
        Console.WriteLine("Tu cambio es: ");
        
        
        foreach (var billete in billetes)
            {
            int cambio = Cantdin / billete;
            if(cambio > 0) 
            {
                Console.WriteLine($"{cambio} billetes de {billete} ");
                Cantdin%=billete;
               
            }
            }
        if (Cantdin > 0)
        {
            Console.WriteLine($"El sobrante es {Cantdin} pesos");
        }
       }
    }
