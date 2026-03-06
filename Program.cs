using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o tamanho do vetor (N): ");
        int N = int.Parse(Console.ReadLine());

        int[] vetor = new int[N];
        int soma = 0;

        // Leitura dos valores
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o valor da posição {i}: ");
            vetor[i] = int.Parse(Console.ReadLine());
            soma += vetor[i];
        }

        // Cálculo da média
        double media = (double)soma / N;

        int abaixoMedia = 0;
        int indiceMaior = 0;
        int indiceMenor = 0;

        // Análise do vetor
        for (int i = 0; i < N; i++)
        {
            if (vetor[i] < media)
            {
                abaixoMedia++;
            }

            if (vetor[i] > vetor[indiceMaior])
            {
                indiceMaior = i;
            }

            if (vetor[i] < vetor[indiceMenor])
            {
                indiceMenor = i;
            }
        }

        Console.WriteLine("\nResultados:");
        Console.WriteLine("Soma: " + soma);
        Console.WriteLine("Média: " + media);
        Console.WriteLine("Quantidade abaixo da média: " + abaixoMedia);
        Console.WriteLine("Índice do maior valor: " + indiceMaior);
        Console.WriteLine("Índice do menor valor: " + indiceMenor);
    }
}