namespace ParOuImpar_1074 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            int i = 0;
            int num = int.Parse(Console.ReadLine());
            int[] valores = new int[num];

            for (i = 0; i < valores.Length; i++) {

                valores[i] = int.Parse(Console.ReadLine());
                if (valores[i] == 0) {
                    Console.WriteLine("NULL");
                } else if (valores[i] > 0) {
                    if (valores[i] % 2 == 0) {
                        Console.WriteLine("EVEN POSITIVE");
                    } else {
                        Console.WriteLine("ODD POSITIVE");
                    }
                } else if (valores[i] < 0) {
                    if (valores[i] % 2 == 0) {
                        Console.WriteLine("EVEN NEGATIVE");
                    } else {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
            }                           
        }
    }
}