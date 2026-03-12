class Questao4
{
    public static void Executar()
    {
        Aluno a = new Aluno(123, "Maria", 70, 80, 60);

        Console.WriteLine("Matrícula: " + a.GetMatricula());
        Console.WriteLine("Nome: " + a.GetNome());
        Console.WriteLine("Nota final: " + a.GetNotaFinal());
        Console.WriteLine("Resultado: " + a.GetResultado());
    }
}