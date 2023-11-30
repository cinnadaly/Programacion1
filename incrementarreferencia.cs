using System;

public class IncrementadorDeReferencia
{
    public static void Main(string[] args)
    {
        int[] arreglo = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Arreglo original:");
        foreach (int elemento in arreglo)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();

        IncrementarReferencia(ref arreglo);
        Console.WriteLine("Arreglo modificado:");
        foreach (int elemento in arreglo)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }
    static void IncrementarReferencia(ref int[] arreglo)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            arreglo[i] += 1;
        }
    }
}
