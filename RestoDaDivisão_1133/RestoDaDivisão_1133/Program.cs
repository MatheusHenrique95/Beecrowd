namespace RestoDaDivisão_1133 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            int count;
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2) {
                for (count = num2 + 1; count < num1; count++) {
                    if (count % 5 == 2 || count % 5 == 3) {
                        Console.WriteLine(count);
                    }
                }
            } else if (num1 < num2) {
                for (count = num1 + 1; count < num2; count++) {
                    if (count % 5 == 2 || count % 5 == 3) {
                        Console.WriteLine(count);
                    }
                }
            }
        }
    }
}