/*-------------------------------------------------------------------
Questão 8: Cálculo de Pontos de Habilidade
• Contextualização: Ao subir de nível, um jogador recebe pontos de habilidade que podem ser
distribuídos entre força, agilidade, inteligência e dois atributos adicionais.
• Comando: Desenvolva um programa que receba a quantidade de pontos de habilidade
atribuídos a cada uma das cinco características e calcule o total de pontos distribuídos.
@Lista: 01 - Lógica de Programação
@Autor: Eduardo Gomes de Sena
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
class Programação
{
    static void Main(string[] args)
    {
        double  forca, agilidade, inteligencia,destressa,vitalidade,final;

        System.Console.WriteLine("Quantos pontos de habilidade tem a força?");
        double.TryParse(Console.ReadLine(), out forca);
        System.Console.WriteLine("Quantos pontos de habilidade tem a agilidade?");
        double.TryParse(Console.ReadLine(), out agilidade);
        System.Console.WriteLine("Quantos pontos de habilidade tem a inteligencia?");
        double.TryParse(Console.ReadLine(), out inteligencia);
        System.Console.WriteLine("Quantos pontos de habilidade tem a destressa?");
    double.TryParse(Console.ReadLine(), out destressa);
      System.Console.WriteLine("Quantos pontos de habilidade tem a vitalidade?");
    double.TryParse(Console.ReadLine(), out vitalidade);
        final = forca+agilidade+inteligencia+destressa+vitalidade;
        System.Console.WriteLine("pontuação final:" + final);
        Console.ReadLine();

    }
} 