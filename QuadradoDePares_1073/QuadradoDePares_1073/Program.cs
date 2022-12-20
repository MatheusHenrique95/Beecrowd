namespace QuadradoDePares_1073 {
    using System;
    public class Program {
        public static void Main(string[] args) {
            
            int num = int.Parse(Console.ReadLine());
            

            for (int count = 2; count <=num; count++) {
                if(count%2 == 0) {
                    int qua = count*count;
                    Console.WriteLine($"{count}^2 = {qua}");
                }
            }
        }
    }
}