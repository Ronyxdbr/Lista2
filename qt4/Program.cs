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
        double mana, vidapor, nivel;

        Console.Write("Quantidade de mana: ");
        double.TryParse(Console.ReadLine(), out mana);
        Console.Write("Vida do inimigo (em porcentagem): ");
        double.TryParse(Console.ReadLine(), out vidapor);
        Console.Write("Nível do joador: ");
        double.TryParse(Console.ReadLine(), out nivel);

        if (mana > 30 && vidapor < 50 && nivel >= 5)
        {
            Console.WriteLine("Ataque especial realizado!");
        }
        else if (mana < 30 && vidapor < 50 && nivel >= 5)
        {
            Console.WriteLine("Mana insuficiente");
        }
        else if (mana > 30 && vidapor > 50 && nivel >= 5)
        {
            Console.WriteLine("Vida do inimigo muito alta");
        }
        else if (mana > 30 && vidapor < 50 && nivel < 5)
        {
            Console.WriteLine("Nível insuficiente");
        }

        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}