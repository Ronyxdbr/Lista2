/*-------------------------------------------------------------------
Questão 3: Loja de Poções
* Contextualização: Em uma loja de poções mágicas, o jogador pode comprar poções que
aumentam sua vida, mana ou resistência. O preço das poções é fixo: Vida custa 10 moedas,
Mana custa 15 moedas, e Resistência custa 20 moedas. Dependendo da classe do jogador, há
um desconto aplicável.
* Comando: Crie um programa que receba a classe do jogador (Guerreiro, Mago, Paladino), o tipo
de poção (Vida, Mana, Resistência), e a quantidade que deseja comprar. Calcule o preço total
das poções, aplicando o desconto correspondente:
* Guerreiro recebe 10% de desconto na compra de poções de Vida.
* Mago recebe 15% de desconto na compra de poções de Mana.
* Paladino recebe 20% de desconto na compra de poções de Resistência.
* Exiba o preço total com e sem desconto.
@Lista: 01 - Lógica de Programação
@Autor: Milton Roney de Oliveira Nobre
@Data: 21/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        string? classe, potion;
        double quant, desc;

        Console.WriteLine("Classe (letra minúscula): ");
        classe = Console.ReadLine();
        Console.WriteLine("Tipo de poção (vida, mana ou resistência): ");
        potion = Console.ReadLine();
        Console.Write("Quantidade: ");
        double.TryParse(Console.ReadLine(), out quant);

        if (classe == "guerreiro")
        {
            desc = 0.10;

            if (potion == "vida")
            {
                Console.WriteLine($"Preço sem desconto {quant * 10}");
                Console.WriteLine($"Preço com desconto {quant * 10 - (quant * 10 * desc)}");
            }
            else if (potion == "mana")
            {
                Console.WriteLine($"Preço sem desconto {quant * 15}");
            }
            else if(potion == "resistência")
            {
                Console.WriteLine($"Preço sem desconto {quant * 20}");
            }
        }
        if (classe == "mago")
        {
            desc = 0.15;

            if (potion == "mana")
            {
                Console.WriteLine($"Preço sem desconto {quant * 15}");
                Console.WriteLine($"Preço com desconto {quant * 15 - (quant * 15 * desc)}");
            }
            else if (potion == "vida")
            {
                Console.WriteLine($"Preço sem desconto {quant * 10}");
            }
            else if(potion == "resistência")
            {
                Console.WriteLine($"Preço sem desconto {quant * 20}");
            }
        }
        if (classe == "paladino")
        {
            desc = 0.20;

            if (potion == "resistência")
            {
                Console.WriteLine($"Preço sem desconto {quant * 20}");
                Console.WriteLine($"Preço com desconto {quant * 20 - (quant * 20 * desc)}");
            }
            else if (potion == "mana")
            {
                Console.WriteLine($"Preço sem desconto {quant * 15}");
            }
            else if(potion == "vida")
            {
                Console.WriteLine($"Preço sem desconto {quant * 10}");
            }
        }

        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}