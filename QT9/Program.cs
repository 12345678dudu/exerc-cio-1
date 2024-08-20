/*-------------------------------------------------------------------
Questão 9: Comparação de Poder de Ataque
• Contextualização: Em um jogo de luta, cada personagem tem um valor de ataque baseado em
sua força, arma e bônus de habilidades.
• Comando: Crie um programa que receba o valor da força do personagem, o poder da arma, o
bônus de habilidades, e dois multiplicadores (um para tipo de inimigo e outro para ambiente), e
calcule o total de ataque.
@Lista: 01 - Lógica de Programação
@Autor: Eduardo Gomes de Sena
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
class Programação
{
    static void Main(string[] args)
    {
        double  forca, arma, bonus,m1,m2,final;

        System.Console.WriteLine("Quantos pontos de habilidade tem a força?");
        double.TryParse(Console.ReadLine(), out forca);
        System.Console.WriteLine("Quantos pontos de habilidade tem de poder de arma?");
        double.TryParse(Console.ReadLine(), out arma);
        System.Console.WriteLine("Quantos pontos de bônus de habilidade?");
        double.TryParse(Console.ReadLine(), out bonus);
        System.Console.WriteLine("Quanto foi o modificador crítico?");
    double.TryParse(Console.ReadLine(), out m1);
      System.Console.WriteLine("Quanto foi o modificador tipo de arma?");
    double.TryParse(Console.ReadLine(), out m2);
        final = forca+(arma*bonus*m1*m2);
        System.Console.WriteLine("pontuação final:" + final);
        Console.ReadLine();

    }
} 
