/*-------------------------------------------------------------------
Atividade 7: Experiência e Nível do Jogador após Batalha
• Contextualização: Em um jogo, o jogador enfrenta dois tipos diferentes de inimigos em uma
batalha. Cada tipo de inimigo concede uma quantidade específica de XP. Após a batalha, o
jogador ganha esse XP e precisa somá-lo ao XP total acumulado para determinar o nível atual
do personagem.
• Comando:Desenvolva um programa que receba a quantidade de XP acumulado, o XP concedido
pelo primeiro tipo de inimigo, o XP concedido pelo segundo tipo de inimigo, o número de cada
tipo de inimigo derrotado, e a constante de nível. O programa deve calcular o XP total
acumulado após a batalha e determinar o nível atual do jogador.
@Lista: 01 - Lógica de Programação
@Autor: Eduardo Gomes de Sena
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
class Programação
{
    static void Main(string[] args)
    {
        double acumulado, inimigo, derrotados, inimigos2, derrotados2, constante, final, final1;

        System.Console.WriteLine("Qual foi o xp acumulado");
        double.TryParse(Console.ReadLine(), out acumulado);
        System.Console.WriteLine("Qual o número de pontos por inimigo derrotado?");
        double.TryParse(Console.ReadLine(), out inimigo);
        System.Console.WriteLine("Qual foi o número de inimigos derrotados?");
        double.TryParse(Console.ReadLine(), out derrotados);
        System.Console.WriteLine("Qual a o número de pontos conquistado no inimigo 2 derrotado? ");
        double.TryParse(Console.ReadLine(), out inimigos2);
        System.Console.WriteLine("Qual foi o número de inimigos 2 derrotados?");
        double.TryParse(Console.ReadLine(), out derrotados2);
        System.Console.WriteLine("Qual foi a constante de nível?");
        double.TryParse(Console.ReadLine(), out constante);
        final = (inimigo * derrotados) + (inimigos2 * derrotados2) + acumulado;
        final1 = final / constante;
        System.Console.WriteLine("pontuação final:" + final + " nível:" + final1);
        Console.ReadLine();

    }
}
