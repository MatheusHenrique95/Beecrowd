namespace SeisNumerosImpares_1070 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) {
                num++;
                for (int i = 0; i < 6; i++) {
                    Console.WriteLine(num);
                    num += 2;
                }
            } else if (num % 2 != 0) {
                for (int i = 0; i < 6; i++) {
                    Console.WriteLine(num);
                    num += 2;

                }
            }
            }
    }
}