class Aluno
{
    // Atributos (privados)
    private string matricula;
    private string nome;
    private double nota1;
    private double nota2;
    private double nota3;

    // Construtor
    public Aluno(string mat, string nome, double n1, double n2, double n3)
    {
        this.matricula = mat;
        this.nome = nome;
        this.nota1 = n1;
        this.nota2 = n2;
        this.nota3 = n3;
    }

    // Retorna matrícula
    public string GetMatricula()
    {
        return matricula;
    }

    // Retorna nome
    public string GetNome()
    {
        return nome;
    }

    // Calcula média das três notas
    public double GetNotaFinal()
    {
        return (nota1 + nota2 + nota3) / 3.0;
    }

    // Retorna resultado final
    public string GetResultado()
    {
        double notaFinal = GetNotaFinal();

        if (notaFinal >= 60)
        {
            return "Aprovado";
        }
        else if (notaFinal >= 40)
        {
            return "Recuperação";
        }
        else
        {
            return "Reprovado";
        }
    }
}
