namespace Mes_1052 {
    using System;
    public class Program {
        static void Main(string[] args) {

            string[] meses = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            int numMes = int.Parse(Console.ReadLine());

            numMes--;
            Console.WriteLine(meses[numMes]);

        }

    }
}