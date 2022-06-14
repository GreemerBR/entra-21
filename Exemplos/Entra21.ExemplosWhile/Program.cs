using Entra21.ExemplosWhile;

int opcaoDesejada = 0;

while (opcaoDesejada != 8)
{

    Console.WriteLine(@"
-------------MENU-------------
1 - Exemplo01
2 - Exemplo02
3 - Exemplo03
4 - Exemplo04
5 - Exemplo05
6 - Exemplo06
7 - Exemplo07
8 - SAIR
");

    try
    {
        Console.Write("Digite a opção desejada: ");
        opcaoDesejada = Convert.ToInt32(Console.ReadLine());

        if (opcaoDesejada < 0 || (opcaoDesejada != 1 && opcaoDesejada != 2 && opcaoDesejada != 3 && opcaoDesejada != 4
    && opcaoDesejada != 5 && opcaoDesejada != 6 && opcaoDesejada != 7 && opcaoDesejada != 8))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A opção informada não é válida. Por favor informe um número presente no MENU.");
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else
        {
            Console.Clear();
        }
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("A opção informada não é válida. Por favor informe um número presente no MENU.");
        Console.ForegroundColor = ConsoleColor.Green;
    }

    if (opcaoDesejada == 1)
    {
        //NomeDaClasse nomeVariavel = new NomeDaClasse
        Exemplo01 exemplo01 = new Exemplo01();
        exemplo01.Executar();
    }
    else if (opcaoDesejada == 2)
    {
        Exemplo02 exemplo02 = new Exemplo02();
        exemplo02.Executar();
    }
    else if (opcaoDesejada == 3)
    {
        Exemplo03 exemplo03 = new Exemplo03();
        exemplo03.Executar();
    }
    else if (opcaoDesejada == 4)
    {
        Exemplo04 exemplo04 = new Exemplo04();
        exemplo04.Executar();
    }
    else if (opcaoDesejada == 5)
    {
        Exemplo05 exemplo05 = new Exemplo05();
        exemplo05.Executar();
    }
    else if (opcaoDesejada == 6)
    {
        Exemplo06 exemplo06 = new Exemplo06();
        exemplo06.Executar();
    }
    else if (opcaoDesejada == 7)
    {
        Exemplo07 exemplo07 = new Exemplo07();
        exemplo07.Executar();
    }
}