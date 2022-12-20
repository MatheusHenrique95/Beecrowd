namespace ParesEntreCincoNumeros_1065 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            int valor3 = int.Parse(Console.ReadLine());
            int valor4 = int.Parse(Console.ReadLine());
            int valor5 = int.Parse(Console.ReadLine());

            int[] valores = { valor1, valor2, valor3, valor4, valor5};
            int count = 0;

            for (int i = 0; i < valores.Length; i++) {
                if (valores[i]%2 == 0) {
                    count++;
                }
            }
            Console.WriteLine($"{count} valores pares");
        }
    }
}