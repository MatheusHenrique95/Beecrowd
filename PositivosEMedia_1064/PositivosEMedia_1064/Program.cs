namespace PositivosEMedia_1064 {
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
            double media1 = 0;

            for (int i = 0; i < valores.Length; i++) {
                if (valores[i] > 0) {
                    count++;
                    media1 = media1 + valores[i];
                }
            }
            double media = media1 / count;
            Console.WriteLine($"{count} valores positivos");
            Console.WriteLine($"{media:F1}");
        }
    }
}