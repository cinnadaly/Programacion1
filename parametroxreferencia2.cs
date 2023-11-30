using System;
public class DevolverValorduplicado
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un valor");
        int num = int.Parse(Console.ReadLine());

        int resultado = DuplicarValor(num);
        Console.WriteLine("El resultado es " + resultado);
    }
    static int DuplicarValor(int numero)
    {
        return numero * 2;
    }
}
