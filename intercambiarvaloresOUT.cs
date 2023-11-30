using System;

public class IntercambioDeValores
{
    public static void Main(string[] args)
    {
        int variable1, variable2;
        IntercambiarValores(out variable1, out variable2);

        Console.WriteLine("La primer variable intercambiada es " + variable1);
        Console.WriteLine("La segunda variable intercambiada es " + variable2);
    }
    static void IntercambiarValores(out int var1, out int var2)
    {
        Console.WriteLine("Ingrese primer numero");
        var1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese segundo numero");
        var2 = int.Parse(Console.ReadLine());

        int temp = var1;
        var1 = var2;
        var2 = temp;
    }
}
