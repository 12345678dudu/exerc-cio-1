/*-------------------------------------------------------------------
Questão 10: Atualização de Pontos de Vida
• Contextualização: Em um jogo de estratégia, um personagem pode ganhar pontos de vida a
cada nível alcançado.
• Comando: Desenvolva um programa que receba os pontos de vida iniciais e o aumento de vida
por nível, e calcule a quantidade de pontos de vida após alcançar um novo nível.
@Lista: 01 - Lógica de Programação
@Autor: Eduardo Gomes de Sena
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
class Programação
{
    static void Main(string[] args)
    {
        double  vida,aumento,alcancado,final;

        System.Console.WriteLine("Quantos pontos de vida inicial?");
        double.TryParse(Console.ReadLine(), out vida);
        System.Console.WriteLine("Qual foi o aumento de vida?");
        double.TryParse(Console.ReadLine(), out aumento);
        System.Console.WriteLine("Qual foi o nível alcançado?");
        double.TryParse(Console.ReadLine(), out alcancado);
        final = (aumento*alcancado)+vida;
        System.Console.WriteLine("pontuação final:" + final);
        Console.ReadLine();

    }
} 
