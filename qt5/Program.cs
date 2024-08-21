/*-------------------------------------------------------------------
Questão 4: Decisão de Ataque Especial
• Contextualização: Durante uma batalha em um jogo de RPG, o jogador pode realizar um ataque
especial se tiver mana suficiente, se a vida do inimigo estiver baixa e se o nível do jogador for
alto o bastante.
• Comando: Crie um programa que determine se o jogador deve realizar um ataque especial. O
programa deve receber a quantidade de mana do jogador, a vida atual do inimigo em
porcentagem e o nível do jogador. As condições para realizar o ataque especial são:
• Mana maior que 30.
• Vida do inimigo menor que 50%.
• Nível do jogador maior que 5.

@Lista: 01 - Lógica de Programação
@Autor: Milton Roney de Oliveira Nobre
@Data: 21/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        double vidapor, traps, dist;

        Console.Write("Vida(%): ");
        double.TryParse(Console.ReadLine(), out vidapor);
        Console.Write("Armadilhas conhecidas: ");
        double.TryParse(Console.ReadLine(), out traps);
        Console.Write("Distância do aliado (em metros): ");
        double.TryParse(Console.ReadLine(), out dist);

        if (vidapor > 50 && traps < 3)
        {
            Console.WriteLine("Seguir em frente");
        }
        else if (vidapor < 50 && traps < 2 && dist < 10)
        {
            Console.WriteLine("Tentar resgate rápido");
        }
        else
        {
            Console.WriteLine("Recuar");
        }
        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}