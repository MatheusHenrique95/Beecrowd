namespace SenhaFixa_1114 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            while (true) {

                string senha = Console.ReadLine();
                if (senha != "2002") {
                    Console.WriteLine("Senha Invalida");
                } else {
                    Console.WriteLine("Acesso Permitido");
                    return;
                }
            }
        }
    }
}