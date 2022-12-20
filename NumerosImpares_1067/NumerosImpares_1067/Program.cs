namespace NumerosImpares_1067 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            int num = int.Parse(Console.ReadLine());

            for( int i = 0; i<=num ; i++ ) {
            
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }

        }
    }
}