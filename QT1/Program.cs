/*Questão 1: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir as informações básicas do
personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
personagem e exiba esses dados no console.

@Lista: 01 - Lógica de Programação
@Autor: Eduardo Gomes de Sena
@Data: 19/08/2024*/
using System;
class Programação
{
    static void Main(string[] args)
    {
        string? nome, raca;
        int  idade, nivelinicial, classe;
        System.Console.WriteLine("Escreva seu nome de jogador:");
        nome = Console.ReadLine();
        System.Console.WriteLine("Escreva a idade so seu jogador");
        int.TryParse(Console.ReadLine(), out idade);
        System.Console.WriteLine("Escreva seu nivel inicial do seu jogador");
           int.TryParse(Console.ReadLine(), out nivelinicial);
        System.Console.WriteLine("Escreva a classe do jogador");
           int.TryParse(Console.ReadLine(), out classe);
        System.Console.WriteLine("Escreva a raça do jogador");
        raca = Console.ReadLine();
        System.Console.WriteLine("Nome:" + nome+ "\nidade: " + idade+ "\nnível inicial: " + nivelinicial+ "\nclasse: " + classe+"\nraça:" + raca);
        Console.ReadLine();

    }

}