namespace ParesImparesPositivosENEgativos_1066 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            int valor3 = int.Parse(Console.ReadLine());
            int valor4 = int.Parse(Console.ReadLine());
            int valor5 = int.Parse(Console.ReadLine());

            int[] valores = { valor1, valor2, valor3, valor4, valor5 };
            int countPar = 0;
            int countImpar = 0;
            int countPositivo = 0;
            int countNegativo = 0;

            for (int i = 0; i < valores.Length; i++) {
                if (valores[i] % 2 == 0) {
                    countPar++;
                }
                if (valores[i] % 2 != 0) {
                    countImpar++;
                }
                if (valores[i] > 0) {
                    countPositivo++;
                }
                if (valores[i] < 0) {
                    countNegativo++;
                }
            }
            Console.WriteLine($"{countPar} valor(es) par(es)");
            Console.WriteLine($"{countImpar} valor(es) impar(es)");
            Console.WriteLine($"{countPositivo} valor(es) positivo(s)");
            Console.WriteLine($"{countNegativo} valor(es) negativo(s)");
        }
    }
}