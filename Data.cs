class Data
{
    private int dia;        
    private int mes;                    //Declaro as variáveis para dia, mês e ano
    private int ano;

    public Data(int d, int m, int a)
    {
        dia = d;
        mes = m;                        //Crio o construtor para receber os dados e colocar dentro das variáveis
        ano = a;
    }

    public int GetDia()
    {
        return dia;
    }

    public int GetMes()
    {
        return mes;                     //Crio os métodos para retornar os dados do dia, mês e ano
    }

    public int GetAno()
    {
        return ano;
    }

    public void SetDia(int d)
    {
        dia = d;
    }

    public void SetMes(int m)
    {
        mes = m;                        //Crio os métodos para alterar os dados do dia, mês e ano
    }

    public void SetAno(int a)
    {
        ano = a;
    }

    public string ToString()
    {
        return dia.ToString("D2") + "/" + mes.ToString("D2") + "/" + ano;       //Crio o método para retornar a data formatada como string
    }

    public bool DataValida()
    {
        //Valido o ano, mês e dia para verificar se a data é válida

        if (ano <= 1899 || ano >= 2100)
            return false;

        if (mes < 1 || mes > 12)
            return false;

        int diasNoMes;

        switch (mes)
        {
            case 2:
                bool bissexto = (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
                diasNoMes = bissexto ? 29 : 28;
                break;

            case 4:
            case 6:
            case 9:
            case 11:
                diasNoMes = 30;
                break;

            default:
                diasNoMes = 31;
                break;
        }

        if (dia < 1 || dia > diasNoMes)
            return false;

        return true;
    }
}