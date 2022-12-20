namespace SomaDeImparesConsecutivos1_1071 {
    using System;
    public class Program {
        public static void Main(string[] args) {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if(num1 < num2) {
                int soma = 0;
                for (int count = num1 + 1; count < num2; count++) {
                    if (count%2!=0) {                        
                        soma = soma + count;                        
                    }
                }
                Console.WriteLine(soma);
            } else if (num1 > num2) {
                int soma = 0;
                for (int count = num2 + 1; count < num1; count++) {
                    if (count % 2 != 0) {
                        soma = soma + count;
                    }
                }
                Console.WriteLine(soma);
            }else {
                Console.WriteLine(0);
            }
        }
    }
}