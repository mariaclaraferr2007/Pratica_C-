class Questao5
{
    public static void Executar()
    {
        //Solicito o tamanho da vetor 
        Console.Write("Informe a quantidade de alunos (N): ");
        int N = int.Parse(Console.ReadLine()!);

        //Declaro o vetor com o tamanho informado
        Aluno[] alunos = new Aluno[N];

        //percorro o vetor para preencher os dados dos alunos
        for(int i = 0; i < N; i++)
        {
            //Solicito os dados do aluno
            Console.Write($"Digite a matricula do aluno {i + 1}: ");
            string matricula = Console.ReadLine()!;             //Coloco eles dentro de uma variável 
            Console.Write($"Digite o nome do aluno {i + 1}: ");
            string nome = Console.ReadLine()!;
            Console.Write($"Digite a nota1 do aluno {i + 1}: ");
            double nota1 = double.Parse(Console.ReadLine()!);
            Console.Write($"Digite a nota2 do aluno {i + 1}: ");
            double nota2 = double.Parse(Console.ReadLine()!);
            Console.Write($"Digite a nota3 do aluno {i + 1}: ");
            double nota3 = double.Parse(Console.ReadLine()!);

            //Coloco todos os dados dentro de uma posição do vetor de alunos
            alunos[i] = new Aluno(matricula, nome, nota1, nota2, nota3); 
        }

        //Percorro novamento o vetor para imprimir os dados
        for(int i = 0; i < N; i++)
        {
            Console.WriteLine("\nDados do aluno " + (i + 1) + ":");
            Console.WriteLine("Nome: " + alunos[i].GetNome());
            Console.WriteLine("Nota Final: " + alunos[i].GetNotaFinal());
            Console.WriteLine("Resultado: " + alunos[i].GetResultado());
        }
    }
}