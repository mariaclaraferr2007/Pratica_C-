class Questao2
{
    public static void Executar()
    {
        double [,] vetor = new double[6,6]; //criei o vetor
        Random random = new Random(); //criei o random para preencher o vetor 

        double soma = 0; //variável para armazenar a soma dos elementos
        int contador = 0; //variável para contar quantos elementos estão sendo somados  


        for (int i = 0; i < 6; i++) //percorrendo linhas 
        {
            for (int j = 0; j < 6; j++) //percorrendo colunas
            {
                vetor[i,j] = random.Next(1,7);
            }
        }


        Console.WriteLine("Matriz:");
        for (int i = 0; i < 6; i++) //percorrendo linhas 
        {
            for (int j = 0; j < 6; j++) //percorrendo colunas
            {
                Console.Write($"{vetor[i,j]:F2} ");
            }
            Console.WriteLine(); //quebra de linha para formatar a matriz
        }

        for (int i = 0; i < 6; i++) //percorrendo linhas 
        {
            for (int j = 0; j < 6; j++) //percorrendo colunas
            {
                if (i + j <= 5)
                {
                    soma += vetor[i,j];
                    contador++;
                }
            }
        }

        double media = soma / contador; //calculando a média dos elementos

        Console.WriteLine($"Soma dos elementos: {soma:F2}");
        Console.WriteLine($"Média dos elementos: {media:F2}");
    }
}