class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha a questão:");
        Console.WriteLine("1 - Questão 1");
        Console.WriteLine("2 - Questão 2");
        Console.WriteLine("3 - Questão 3");

        int op = int.Parse(Console.ReadLine()!);

        if (op == 1)
            Questao1.Executar();
        else if (op == 2)
            Questao2.Executar();
        else if (op == 3)
            Questao3.Executar();
    }
}