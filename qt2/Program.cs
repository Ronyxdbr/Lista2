/*-------------------------------------------------------------------
Questão 2: Sistema de Pontuação em Batalha
* Contextualização: Em um jogo de RPG, o jogador ganha pontos após derrotar inimigos em uma
batalha. A pontuação máxima é de 100 pontos, e é determinada pela quantidade de inimigos
derrotados, a duração da batalha e se o jogador sofreu danos crítico.
* Comando: Crie um programa que calcule a pontuação final do jogador. O programa deve
receber o número de inimigos derrotados, a duração da batalha em minutos e se o jogador
sofreu danos crítico (sim ou não). A pontuação é calculada da seguinte forma:
* 10 pontos para cada inimigo derrotado;
* Subtraia 10 pontos se a batalha durar mais de 5 minutos;
* Subtraia 10 pontos se o jogador sofreu dano crítico;

@Lista: 01 - Lógica de Programação
@Autor: Milton Roney de Oliveira Nobre
@Data: 21/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        string? dano;
        double inim, temp, pontos;

        Console.Write("inimigos derrotados: ");
        double.TryParse(Console.ReadLine(), out inim);
        Console.Write("Duração da batalha (min): ");
        double.TryParse(Console.ReadLine(), out temp);
        Console.Write("Sofreu danos críticos? (letra minúscula): ");
        dano = Console.ReadLine();

         if (dano == "sim" && temp <= 5)
        {
           pontos = ((inim * 10) - 10);
            
            if (pontos < 100)
            {
                Console.WriteLine($"{pontos} pontos");
            }
            else if (pontos > 100)
            {
                Console.WriteLine($"100 pontos");
            }
        }
         if (dano == "sim" && temp >= 5)
        {
           pontos = ((inim * 10) - 10 - 10);
            
            if (pontos < 100)
            {
                Console.WriteLine($"{pontos} pontos");
            }
            else if (pontos > 100)
            {
                Console.WriteLine($"100 pontos");
            }
        }
        if (dano == "não" && temp >= 5)
        {
           pontos = ((inim * 10) - 10);
            
            if (pontos < 100)
            {
                Console.WriteLine($"{pontos} pontos");
            }
            else if (pontos > 100)
            {
                Console.WriteLine($"100 pontos");
            }
        }
         if (dano == "não" && temp <= 5)
        {
           pontos = ((inim * 10));
            
            if (pontos < 100)
            {
                Console.WriteLine($"{pontos} pontos");
            }
            else if (pontos > 100)
            {
                Console.WriteLine($"100 pontos");
            }
        }

        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}