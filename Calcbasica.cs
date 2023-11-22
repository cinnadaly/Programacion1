using System;

public class Calculadorabasica
{
    public static void Main(string[] args)
    {
        double num1, num2;
        Console.WriteLine("Ingrese el primer numero"); 
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("El resultado de la suma es: " + Suma(num1, num2));
        Console.WriteLine("El resultado de la resta es: " + Resta(num1, num2));
        Console.WriteLine("El resultado de la multiplicacion es: " + Multiplicacion(num1, num2));

        if (num2 != 0)
        {
            Console.WriteLine("El resultado de la division es: " + Division(num1, num2));
        }
        else
        {
            Console.WriteLine("No es posible realizar la division");
        }

        static double Suma(double num1, double num2)
        {
            return num1 + num2;
        }

        static double Resta(double num1, double num2)
        {
            return num1 - num2;
        }

        static double Multiplicacion(double num1, double num2)
        {
            return num1 * num2;
        }

        static double Division(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}