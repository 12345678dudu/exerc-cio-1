/*-------------------------------------------------------------------
Questão 6: Conversão de Moeda do Jogo
• Contextualização: O jogo possui uma loja onde os jogadores podem trocar moedas de ouro por
cristais.
• Comando: Desenvolva um programa que receba o valor de moedas de ouro, o valor da taxa de
conversão (1 cristal = X moedas de ouro), e dois bônus de conversão (um baseado em eventos
e outro em habilidades), e calcule o número de cristais que o jogador pode obter.
@Lista: 01 - Lógica de Programação
@Autor: Eduardo Gomes de Sena
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
class Programação
{
    static void Main(string[] args)
    {
        double moeda, taxa, evento, habilidade, final;

        System.Console.WriteLine("Qual o valor de moeda?");
        double.TryParse(Console.ReadLine(), out moeda);
        System.Console.WriteLine("Qusl o valor da taxa de conversão?");
        double.TryParse(Console.ReadLine(), out taxa);
        System.Console.WriteLine("Qual o bônus de evento?");
        double.TryParse(Console.ReadLine(), out evento);
        System.Console.WriteLine("Qual o bônus de habilidade");
        double.TryParse(Console.ReadLine(), out habilidade);
        final = ((moeda / taxa) * evento) * habilidade;
        System.Console.WriteLine("pontuação final:" + Math.Floor(final));
        Console.ReadLine();

    }
}