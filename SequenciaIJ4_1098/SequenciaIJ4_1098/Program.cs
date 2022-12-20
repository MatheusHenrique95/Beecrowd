namespace SequenciaIJ4_1098 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            double J = 0;
            double I = 0;

            while (I <= 2) {

                Console.WriteLine($"I={I} J={I + 1}");
                Console.WriteLine($"I={I} J={I + 2}");
                Console.WriteLine($"I={I} J={I + 3}");

                I += 0.2;
            }
        }
    }
}