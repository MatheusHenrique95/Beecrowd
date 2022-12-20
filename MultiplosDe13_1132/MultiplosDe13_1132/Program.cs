namespace MultiplosDe13_1132 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int count;
            int res = 0;

            if (num1 > num2) {
                for (count = num2; count <= num1; count++) {
                    if (count % 13 != 0) {
                        res = res + count;
                    }
                }
                Console.WriteLine(res);
            } else if (num2 > num1) {
                for (count = num1; count <= num2; count++) {
                    if (count % 13 != 0) {
                        res = res + count;
                    }
                }
                Console.WriteLine(res);
            } else {
                if (num2 % 13 != 0) {
                    int soma = num1 + num2;
                    Console.WriteLine(soma);
                }
            }

        }
    }
}