namespace SequenciaIJ3_1097 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            int I, J;
            I = 1;
            J = 7;
            while (I <= 9) {
                for (int i = 0; i<=2 ; i++ ) {
                    Console.WriteLine($"I={I} J={J}");
                    J--;
                }
                I++;
                I++;
                J += 5;
            }
        }
    }
}