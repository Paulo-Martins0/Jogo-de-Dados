using System;
using System.Linq;
using System.Timers;
using System.Buffers;

namespace Dados
{
    class Program : Random
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do primeiro Jogador: ");
            string nomePrimeiro = Console.ReadLine();
            Console.Write("Nome do segundo Jogador: ");
            string nomeSegundo = Console.ReadLine();

            int vitoriasUm = 0;
            int vitoriasDois = 0;

            int rodadas = 0;
            while(rodadas < 3)
            {
                Console.WriteLine("_________________________________");
                Console.Write("Jogar dados? (s/n) ");
                char escolha = char.Parse(Console.ReadLine());
                if (escolha == 'n')
                {
                    break;
                }
                else if (escolha == 's')
                {
                    Random rnd = new Random();
                    int valorUm = rnd.Next(1,7);
                    Console.WriteLine("Dado do jogador: " + nomePrimeiro + " caiu " + valorUm);
                    int valorDois = rnd.Next(1,7);
                    Console.WriteLine("Dado do jogador: " + nomeSegundo + " caiu " + valorDois);

                    if(valorUm > valorDois)
                    {
                        Console.WriteLine(nomePrimeiro + " venceu a rodada!");
                        vitoriasUm++;
                    }

                    else if (valorDois > valorUm)
                    {
                        Console.WriteLine(nomeSegundo + " venceu a rodada!");
                        vitoriasDois++;
                    }

                    else
                    {
                        Console.WriteLine("Jogadores empataram!");
                    }

                }

                if(vitoriasUm >= 2 || vitoriasDois >= 2)
                {
                    break;
                }
                rodadas++;
            }

            if(vitoriasUm > vitoriasDois)
            {
                Console.WriteLine(nomePrimeiro + " venceu o jogo!");
            }
            else if ( vitoriasDois > vitoriasUm)
            {
                Console.WriteLine(nomeSegundo + " venceu o jogo!");
            }

            else
            {
                Console.WriteLine("EMPATE!");
            }
                
            
        }
    }
}