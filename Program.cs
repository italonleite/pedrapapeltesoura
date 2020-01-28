using System;

namespace junior
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador();
            int opcao;
            j1.Nome = "italo";
            j2.Nome = "reserve";
            Console.WriteLine("Escolha umas das opções \n 1-pedra, 2-papel, 3-tesoura");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    partida p1 = new partida();
                    int OpcaoPedra = opcao;    
                    p1.Partida(OpcaoPedra, j2);
                    break;
                case 2:
                    partida p2 = new partida();
                    int OpcaoPapel = opcao;    
                    p2.Partida(OpcaoPapel, j2);
                    break;
                case 3:
                    partida p3 = new partida();
                    int OpcaoTesousa= opcao;    
                    p3.Partida(OpcaoTesousa, j2);
                    break;
            }
        }
    }
}
