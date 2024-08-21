/*-------------------------------------------------------------------
Questão 1: Seleção de Armadura
* Contextualização: Em um jogo de RPG, cada classe de personagem (Guerreiro, Arqueiro, Mago)
possui requisitos diferentes para a escolha da armadura ideal. A armadura é considerada ideal
se a defesa oferecida for alta o suficiente para a classe e se a penalidade de agilidade for
aceitável.
* Comando:
Crie um programa que receba a classe do personagem, o valor de defesa da armadura e a
penalidade de agilidade. O programa deve informar se a armadura é adequada ou não para a
classe.
* Para o Guerreiro, a defesa deve ser maior que 50 e a penalidade de agilidade menor que 20.
* Para o Arqueiro, a defesa deve ser maior que 30 e a penalidade de agilidade menor que 10.
* Para o Mago, a defesa deve ser maior que 20 e a penalidade de agilidade menor que 40.
@Lista: 01 - Lógica de Programação
@Autor: Milton Roney de Oliveira Nobre
@Data: 21/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        string? classe;
        double def, pen;
        double defi;

        Console.Write("Classe (primeira letra minúscula): ");
        classe = Console.ReadLine();
        Console.Write("Defesa: ");
        double.TryParse(Console.ReadLine(), out def);
        Console.Write("Penalidade de agilidade: ");
        double.TryParse(Console.ReadLine(), out pen);


        if (classe == "guerreiro")
        {
            defi = 50;
            if (def >= defi && pen < 20)
            {
                Console.WriteLine("Armadura adequada");
            }
            else
            {
                Console.WriteLine("Armadura não adequada");
            }
        }
        if (classe == "arqueiro")
        {
            defi = 30;
            if (def >= defi && pen < 40)
            {
                Console.WriteLine("Armadura adequada");
            }
            else
            {
                Console.WriteLine("Armadura não adequada");
            }
        }
        if (classe == "mago")
        {
            defi = 20;
            if (def >= defi && pen < 40)
            {
                Console.WriteLine("Armadura adequada");
            }
            else
            {
                Console.WriteLine("Armadura não adequada");
            }
        }


        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}