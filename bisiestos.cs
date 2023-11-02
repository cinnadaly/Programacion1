using System;

public class Clase9
{
    public static void Main(string[] args)
    {
        int Ano;
        do
        {
            Console.WriteLine("Ingrese el año que desea consultar");
            Ano = int.Parse(Console.ReadLine());

            Arregloano(Ano);
            Console.WriteLine("Desea volver a consultar si un año es bisiesto? (S/N) ");
        }
        while (Console.ReadLine().ToLower() == "s");

        static void Arregloano(int Ano)
        {
            if (Ano % 4 != 0)
            { 
                Console.WriteLine("No es bisiesto"); 
            }

            if (Ano % 4 == 0 && Ano % 100 != 0) 
            { 
                Console.WriteLine("Es bisisesto");
            }

            if (Ano % 4 == 0 && Ano % 100 == 0 && Ano % 400 == 0)
            { 
                Console.WriteLine("Es bisiesto"); 
            }

            else if (Ano % 4 == 0 && Ano % 100 == 0 && Ano % 400 != 0)
            {
                Console.WriteLine("No es bisiesto");
            }
         }
     }
}
    
