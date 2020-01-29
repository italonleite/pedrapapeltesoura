using System;

namespace junior
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador humano = new Jogador();
            Jogador computador = new Jogador();
            int opcao;
            Console.WriteLine("Digite Seu Nome");
            humano.Nome = Console.ReadLine();
            computador.Nome = "reserve";
            Console.WriteLine("Bem vindo ao jogo {0}, o seu adversário é o {1}", humano.Nome, computador.Nome);
            Console.WriteLine("Escolha umas das opções \n 1-pedra, 2-papel, 3-tesoura");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    partida p1 = new partida();
                    int OpcaoPedra = opcao;    
                    p1.Partida(OpcaoPedra, humano, computador);
                    break;
                case 2:
                    partida p2 = new partida();
                    int OpcaoPapel = opcao;    
                    p2.Partida(OpcaoPapel, humano, computador);
                    break;
                case 3:
                    partida p3 = new partida();
                    int OpcaoTesousa= opcao;    
                    p3.Partida(OpcaoTesousa, humano, computador);
                    break;
            }
        }
    }
}
