namespace SequenciaDeNumerosESoma_1101 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            int num1 = 1, num2 = 1;
            for (int i = 0; num1 > 0 || num2 > 0; i++) {
                string[] valores = Console.ReadLine().Split();
                num1 = int.Parse(valores[0]);
                num2 = int.Parse(valores[1]);
                if (num1 <=0 || num2 <= 0) {
                    return;
                }else if (num1 > num2) {
                    int soma = 0;
                    for(int count = num2; count <= num1; count++) {
                        Console.Write(count + " ");
                        soma = soma + count;
                    }   
                    Console.WriteLine($"Sum={soma}");
                } else if (num1 < num2) {
                    int soma = 0;
                    for (int count = num1; count <= num2; count++) {
                        Console.Write(count + " ");
                        soma = soma + count;
                    }
                    Console.WriteLine($"Sum={soma}");
                }
            }
        }
    }
}