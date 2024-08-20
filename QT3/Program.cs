/*-------------------------------------------------------------------
Questão 3: Cálculo de Vida Restante
• Contextualização: Durante um combate, o jogador recebe dano e a vida do personagem
diminui.
• Comando: Crie um programa que receba o valor da vida inicial, o dano recebido, o bônus de
regeneração, do atacado, e dois modificadores, do atacante, (um para equipamentos e outro
para habilidades), e calcule a vida restante.

@Lista: 01 - Lógica de Programação
@Autor: Eduardo Gomes de Sena
@Data: 19/08/2024
---------------------------------------------------------------------*/
using System;
class Programação
{
static void Main(string[] args)
{
        double  vida,dano,bonus,m1,m2,final1,final;
       
        System.Console.WriteLine("Qual a vida inicial do jogador?");
        double.TryParse(Console.ReadLine(), out vida);
        System.Console.WriteLine("Qual foi o dano recebido?");
           double.TryParse(Console.ReadLine(), out dano);
        System.Console.WriteLine("Qual foi o bônus da missão?");
           double.TryParse(Console.ReadLine(), out bonus);
         System.Console.WriteLine("Qual foi o multiplicador de equipamento?");
           double.TryParse(Console.ReadLine(), out m1);
            System.Console.WriteLine("Qual foi o multiplicador de Habilidade?");
           double.TryParse(Console.ReadLine(), out m2);
          final=(m1*dano)-(bonus*m2);
          final1=vida-final;
        System.Console.WriteLine("pontuação final:"+final1);
        Console.ReadLine();

}

}