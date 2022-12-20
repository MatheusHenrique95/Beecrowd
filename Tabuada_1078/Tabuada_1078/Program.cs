namespace Tabuada_1078 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            int num = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < 10; i++) {                
                count++;
                int conta = num * count;
                Console.WriteLine($"{count} x {num} = {conta}");
            }

        }
    }
}