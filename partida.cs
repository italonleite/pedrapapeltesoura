using System;

namespace junior
{
    public class partida
    {
        string resultado;

        public partida(){

        }
         public void Partida(int OpcaoHumano, Jogador j2){
            Random rnd = new Random();
            int OpcaoComputador = rnd.Next(1,4);
            //Aqui eu iria fazer as validações do resultados baseado nos inputs do Humano e o random do computador
            if(OpcaoComputador == 3 ){
                Console.WriteLine("");
            }

            
         }

    }
}