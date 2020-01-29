using System;

namespace junior
{
    public class partida
    {
        public partida(){

        }
        public void Partida(int OpcaoHumano, Jogador humano, Jogador computador)
        {
            Random rnd = new Random();
            int OpcaoComputador = rnd.Next(1, 4);
            //Aqui eu iria fazer as validações do resultados baseado nos inputs do Humano e o random do computador
            // ValidarResultado(OpcaoHumano, OpcaoComputador);
        
            if (OpcaoHumano == 1 && OpcaoComputador == 3)
            {

                Console.WriteLine("{0}{1} x {2}{3} ", humano.Nome, OpcaoHumano, OpcaoComputador, computador.Nome);
                Console.WriteLine("{0} Voce ganhou ", humano.Nome);
                Console.ReadKey();

            }

            else if (OpcaoHumano == 2 && OpcaoComputador == 1)
            {
                Console.WriteLine("{0}{1} x {2}{3} ", humano.Nome, OpcaoHumano, OpcaoComputador, computador.Nome);
                Console.WriteLine("{0} Voce ganhou ", humano.Nome);
                Console.ReadKey();
            }
            else if (OpcaoHumano == 3 && OpcaoComputador == 2)
            {
                Console.WriteLine("{0}{1} x {2}{3} ", humano.Nome, OpcaoHumano, OpcaoComputador, computador.Nome);
                Console.WriteLine("{0} Voce ganhou ", humano.Nome);
                Console.ReadKey();
            }
            else if (OpcaoHumano == 1 && OpcaoComputador == 1 || OpcaoHumano == 2 && OpcaoComputador == 2 || OpcaoHumano == 3 && OpcaoComputador == 3)
            {
                Console.WriteLine("{0}{1} x {2}{3} ",humano.Nome, OpcaoHumano, OpcaoComputador, computador.Nome);
                Console.WriteLine("Empate");
                Console.ReadKey();
            }
            else {
                Console.WriteLine("{0}{1} x {2}{3} ", humano.Nome, OpcaoHumano, OpcaoComputador, computador.Nome);
                Console.WriteLine("Voce perdeu!! o Computador {0} ganhou", computador.Nome);
                Console.ReadKey();
            }

        }

    }
}