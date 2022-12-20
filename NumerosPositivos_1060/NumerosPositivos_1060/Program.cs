namespace NumerosPositivos_1060 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            double valor1 = double.Parse(Console.ReadLine());
            double valor2 = double.Parse(Console.ReadLine());
            double valor3 = double.Parse(Console.ReadLine());
            double valor4 = double.Parse(Console.ReadLine());
            double valor5 = double.Parse(Console.ReadLine());
            double valor6 = double.Parse(Console.ReadLine());

            double[] valores = { valor1, valor2, valor3, valor4, valor5, valor6 };
            int count = 0;

            foreach (double i in valores) {
                if (i > 0) {
                    count++;
                }
            }
            Console.WriteLine($"{count} valores positivos");
        }
    }
}