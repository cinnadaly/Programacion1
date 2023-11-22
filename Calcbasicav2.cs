using System;

public class Calculadorabasica2
{
    public static void Main(string[] args)
    {
        double num1, num2, operador;
        Console.WriteLine("     Menu     \n\r 1.-Suma \n\r 2.-Resta \n\r 3.-Multiplicacion \n\r 4.-Division");
        operador = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el primer numero");
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        num2 = double.Parse(Console.ReadLine());

        RealizarOperacion(num1, num2, operador);

        static void RealizarOperacion(double num1, double num2, double operador)
        {
            switch (operador)
            {
                case 1:
                    double suma = num1 + num2;
                    Console.WriteLine("El resultado de la suma es: " + suma);
                    break;


                case 2:
                    double resta = num1 - num2;
                    Console.WriteLine("El resultado de la resta es: " + resta);
                    break;

                case 3:
                    double multiplcacion = num1 * num2;
                    Console.WriteLine("El resultado de la multiplicacion es: " + multiplcacion);
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        double divison = num1 / num2;
                        Console.WriteLine("El resultado de la division es: " + divison);
                    }
                    else
                    {
                        Console.WriteLine("No es posible realizar la division");
                    }
                    break;

                default:
                    Console.WriteLine("No se ha ingresado una opcion valida");
                    break;
            }
        }
    }
}