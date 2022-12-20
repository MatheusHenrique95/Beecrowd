namespace CalculoSimples_1010
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] peca1 = Console.ReadLine().Split();
            string[] peca2 = Console.ReadLine().Split();

            double total = int.Parse(peca1[1]) * double.Parse(peca1[2]) +
                int.Parse(peca2[1]) * double.Parse(peca2[2]);

            Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");

        }
    }
}