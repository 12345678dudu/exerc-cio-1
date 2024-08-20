/*-------------------------------------------------------------------
Questão 5: Cálculo de Distância Percorrida
• Contextualização: Um veículo no jogo percorre uma certa distância em um tempo determinado.
• Comando: Crie um programa que receba a velocidade do veículo, o tempo de viagem e dois
multiplicadores (um para condições climáticas e outro para estado do veículo), e calcule a
distância total percorrida.

@Lista: 01 - Lógica de Programação
@Autor: Eduardo Gomes de Sena
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
class Programação
{
    static void Main(string[] args)
    {
        double veiculo, tempo, clima, estado, final;

        System.Console.WriteLine("Qual a velocidade do veículo?");
        double.TryParse(Console.ReadLine(), out veiculo);
        System.Console.WriteLine("Qual o tempo de viagem?");
        double.TryParse(Console.ReadLine(), out tempo);
        System.Console.WriteLine("Quanto foi o multiplicador climático?");
        double.TryParse(Console.ReadLine(), out clima);
        System.Console.WriteLine("Quanto é o multiplicador estado de veículo");
        double.TryParse(Console.ReadLine(), out estado);
        final = ((tempo*veiculo) * clima) * estado;
        System.Console.WriteLine("pontuação final:" + final);
        Console.ReadLine();

    }

}