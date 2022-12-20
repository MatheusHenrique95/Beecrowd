namespace QuadradoEAoCubo_1143 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            int num = int.Parse(Console.ReadLine());
            int count = 1;
            for (int i = 1; i <= num; i++) {
                Console.WriteLine($"{count} {count*count} {count*count*count}");
                count ++;
            }

        }
    }
}