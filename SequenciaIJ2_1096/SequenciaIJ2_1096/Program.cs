namespace SequenciaIJ2_1096 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            int I, J;
            I = 1;
            while( I <=9) {
                for (J = 7; J>=5;J--) {
                    Console.WriteLine($"I={I} J={J}");
                }
                I++;
                I++;
            }
        }
    }
}