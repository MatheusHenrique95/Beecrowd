namespace TempoDeJogoComMinutos_1047
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int inicioH, finalH, inicioM, finalM;
            string[] tempo = Console.ReadLine().Split();

            inicioH = int.Parse(tempo[0]);
            inicioM= int.Parse(tempo[1]);
            finalH = int.Parse(tempo[2]);
            finalM= int.Parse(tempo[3]);

            int inicioT = (inicioH * 60) + inicioM;
            int finalT = (finalH * 60) + finalM;

            if (finalT > inicioT)
            {
                int minutos = finalT - inicioT;
                int horas = minutos / 60;
                minutos = minutos % 60;
                Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
            } else if(finalT < inicioT)
            {
                int count = 0;
                for (count = 0; count + inicioT < 24 * 60; count++)
                {

                }
                int minutos = count + finalT;
                int horas = minutos / 60;
                minutos = minutos % 60;
                Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
            }else 
            {
                Console.WriteLine($"O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }

        }
    }
}