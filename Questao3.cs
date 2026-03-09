class Questao3
{
    public static void Executar()
    {
        //variaveis
       int sexo = 0;
       int idade = 0;               //Variáveis que seriam string estão como int para retornar o valor numérico correspondente à escolha do usuário
       int estadoCivil = 0;
       int radioPreferida = 0;
       int totalEntrevistados = 0;
       int bhfm = 0;
       int fm98 = 0;
       int jovempan = 0;
       int itatiaia = 0;
       int cdl = 0;
       int outros = 0;
       double porcenbhfm = 0;
       double porcenfm98 = 0;
       double porcenjovempan = 0;
       double porcenitatiaia = 0;
       double porcencdl = 0;
       double porcenoutros = 0;
       int mulheresDivorciadasCDL = 0;
       int homensMenor18JovemPan = 0;
       int somaIdades = 0;
       int homens = 0;
       int mulheres = 0;
       double porcenHomens = 0;
       double porcenMulheres = 0;
       double mediaIdades = 0;

            //colhendo as informações do usuário
            Console.WriteLine("Digite a idade:");
            idade = int.Parse(Console.ReadLine()!);
            while (idade != 0)
        {
            Console.WriteLine("Digite o sexo (1-M/2-F):");
            sexo = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o estado civil (1-Solteiro/2-Casado/3-Viúvo/4-Divorciado):");
            estadoCivil = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite a rádio preferida (1-BHFM/2-FM98/3-JovemPan/4-Itatiaia/5-CDL/6-Outros):");
            radioPreferida = int.Parse(Console.ReadLine()!);

            //contadores e somas para calcular as porcentagens e médias
            
            totalEntrevistados++;
            
            
            somaIdades += idade;

            //verificando condicionais 
            if (radioPreferida == 1)
            {
                bhfm++;
            }
            else if (radioPreferida == 2)
            {
                fm98++;
            }
            else if (radioPreferida == 3)
            {
                jovempan++;
            }
            else if (radioPreferida == 4)
            {
                itatiaia++;
            }
            else if (radioPreferida == 5)
            {
                cdl++;
                if (sexo == 2 && estadoCivil == 4)
                {
                    mulheresDivorciadasCDL++;
                }
            }
            else
            {
                outros++;
            }

            if (sexo == 1 && idade < 18 && radioPreferida == 3)
            {
                homensMenor18JovemPan++;
            }

            if (sexo == 1)
            {
                homens++;
            }
            else if (sexo == 2)
            {
                mulheres++;
            }



            Console.WriteLine("Digite a idade:");
            idade = int.Parse(Console.ReadLine()!);
        }

            //calculando porcentagens 
            porcenbhfm = (double)bhfm / totalEntrevistados * 100;
            porcenfm98 = (double)fm98 / totalEntrevistados * 100;
            porcenjovempan = (double)jovempan / totalEntrevistados * 100;
            porcenitatiaia = (double)itatiaia / totalEntrevistados * 100;
            porcencdl = (double)cdl / totalEntrevistados * 100;
            porcenoutros = (double)outros / totalEntrevistados * 100;
            porcenMulheres = (double)mulheres / totalEntrevistados * 100;
            porcenHomens = (double)homens / totalEntrevistados * 100;
            

            //imprimindo os resultados
            Console.WriteLine($"A porcentagem de cada rádio foi: BHfm: {porcenbhfm:F2}%, FM98: {porcenfm98:F2}%, JovemPan: {porcenjovempan:F2}%, Itatiaia: {porcenitatiaia:F2}%, CDL: {porcencdl:F2}%, Outros: {porcenoutros:F2}%");
            Console.WriteLine($"A quantidade de mulheres divorciadas que preferem a rádio CDL é: {mulheresDivorciadasCDL}");
            Console.WriteLine($"A quantidade de homens menores de 18 anos que preferem a rádio Jovem Pan é: {homensMenor18JovemPan}");
            mediaIdades = (double)somaIdades / totalEntrevistados;
            Console.WriteLine($"A média de idade dos entrevistados é: {mediaIdades:F2}");
            Console.WriteLine($"A porcentagem de homens é: {porcenHomens:F2}%");
            Console.WriteLine($"A porcentagem de mulheres é: {porcenMulheres:F2}%");
    }
}