/*-------------------------------------------------------------------
Questão 4: Somatório de Moedas
Contextualização: No seu jogo, o jogador coleta moedas durante uma fase. A cada coleta, o total
de moedas aumenta.
• Comando: Desenvolva um programa que receba cinco valores de moedas coletadas e some-os,
exibindo o total de moedas coletadas ao final.
@Lista: 01 - Lógica de Programação
@Autor: Eduardo Gomes de Sena
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
class Programação
{
static void Main(string[] args)
{
        double  moedas,moedas1,moedas2,moedas3,moedas4,final;
       
        System.Console.WriteLine("Indique o valor da primeira moeda coletada?");
        double.TryParse(Console.ReadLine(), out moedas);
        System.Console.WriteLine("Indique o valor da segunda moeda coletada?");
           double.TryParse(Console.ReadLine(), out moedas1);
        System.Console.WriteLine("Indique o valor da terceira moeda coletada?");
           double.TryParse(Console.ReadLine(), out moedas2);
         System.Console.WriteLine("Indique o valor da quarta moeda coletada?");
           double.TryParse(Console.ReadLine(), out moedas3);
            System.Console.WriteLine("Indique o valor da primeira moeda coletada?");
           double.TryParse(Console.ReadLine(), out moedas4);
          final=moedas+moedas1+moedas2+moedas3+moedas4;
        System.Console.WriteLine("pontuação final:"+final);
        Console.ReadLine();

}

}