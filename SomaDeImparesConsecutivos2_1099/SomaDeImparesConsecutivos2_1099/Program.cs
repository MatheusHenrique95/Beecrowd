namespace SomaDeImparesConsecutivos2_1099 {
    using System;
    using System.ComponentModel;

    public class Program {
        public static void Main(string[] args) {

            int num = int.Parse(Console.ReadLine());
            int[] num1 = new int[num];
            int[] num2 = new int[num];
            for (int i = 0; i < num; i++) {
                string[] valores = Console.ReadLine().Split();
                num1[i] = int.Parse(valores[0]);
                num2[i] = int.Parse(valores[1]);
                if (num1[i] < num2[i]) {
                    int soma = 0;
                    for (int count = num1[i] + 1; count < num2[i]; count++) {
                        if (count % 2 != 0) {
                            soma = soma + count;
                        }
                    }
                    Console.WriteLine(soma);
                } else if (num1[i] > num2[i]) {
                    int soma = 0;
                    for (int count = num2[i] + 1; count < num1[i]; count++) {
                        if (count % 2 != 0) {
                            soma = soma + count;
                        }
                    }
                    Console.WriteLine(soma);
                } else {
                    Console.WriteLine(0);
                }
            }
        }
    }
}