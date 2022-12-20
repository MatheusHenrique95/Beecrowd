namespace TempoDoJogo_1046
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int inicio, final;
            string[] tempo = Console.ReadLine().Split();

            inicio = int.Parse(tempo[0]);
            final = int.Parse(tempo[1]);

            if(final > inicio)
            {
                Console.WriteLine($"O JOGO DUROU {final - inicio} HORA(S)");
            }else
            {
                int count = 0;
                for (count = 0; count+inicio < 24; count++)
                {
                    
                }
                Console.WriteLine($"O JOGO DUROU {count + final} HORA(S)");
            }
        }
    }
}