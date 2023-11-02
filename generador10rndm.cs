using System;

public class generador
{
    public static void Main(string[] args)
    {
        do
        {
            Numrandoms();
            Console.WriteLine("Desea volver a generar 10 numeros aleatorios? (S/N)");
        }
        while (Console.ReadLine().ToLower() == "s");
      

        static void Numrandoms()
        {
            int[] nums = new int[10];
            Random aleatorio = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = aleatorio.Next(0, 100);
            }
            foreach (var num in nums)
            {
                Console.WriteLine($"Numero: {num}");
            }
        }
    }
}