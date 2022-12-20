namespace Resto2_1075 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            int count = 0;
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < 10000; i++) {
                count++;
                if (count % num == 2) {
                    Console.WriteLine(count);
                }
            }            
        }
    }
}