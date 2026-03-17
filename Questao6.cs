class TestaData
{
    public static void Questao6()
    {
        Data d1 = new Data(29, 2, 2024);                        //Crio um objeto da classe Data com uma data válida (29 de fevereiro de 2024, que é um ano bissexto)

        Console.WriteLine("Data: " + d1.ToString());            //Imprimo a data usando o método ToString()

        if (d1.DataValida())                                    //Verifico se a data é válida usando o método DataValida()
            Console.WriteLine("Data válida");
        else
            Console.WriteLine("Data inválida");

        d1.SetDia(31);                                          //Altero o dia para 31, o que torna a data inválida (31 de fevereiro não existe)                
        d1.SetMes(4);

        Console.WriteLine("Nova data: " + d1.ToString());       //Imprimo a nova data usando o método ToString()

        if (d1.DataValida())                                    //Verifico novamente se a data é válida usando o método DataValida()        
            Console.WriteLine("Data válida");
        else
            Console.WriteLine("Data inválida");
    }
}