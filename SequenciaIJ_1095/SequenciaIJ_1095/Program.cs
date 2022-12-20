namespace SequenciaIJ_1095 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            int J, I;
            J = 60;
            I = 1;
            while (J >= 0) {                
                Console.WriteLine($"I={I} J={J}");
                J = J - 5;
                I = I + 3;
            }

        }
    }
}