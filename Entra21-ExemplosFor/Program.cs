using Entra21.ExemplosFor;

var opcaoDesejada = 0;

while (opcaoDesejada != 6)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@"
-------------MENU-------------
1 - Exemplo01
2 - Exemplo02
3 - Exemplo03
4 - Exemplo04
5 - Exemplo05
6 - SAIR
");

    try
    {
        Console.Write("Digite a opção desejada: ");
        opcaoDesejada = Convert.ToInt32(Console.ReadLine());

        if (opcaoDesejada < 0 || (opcaoDesejada != 1 && opcaoDesejada != 2 && opcaoDesejada != 3 && opcaoDesejada != 4
    && opcaoDesejada != 5 && opcaoDesejada != 6))
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
        var exemplo01 = new Exemplo01();
        exemplo01.Executar();
    }

    if (opcaoDesejada == 2)
    {
        var exemplo02 = new Exemplo02();
        exemplo02.Executar();
    }

    if (opcaoDesejada == 3)
    {
        var exemplo03 = new Exemplo03();
        exemplo03.Executar();
    }

    if (opcaoDesejada == 4)
    {
        var exemplo04 = new Exemplo04();
        exemplo04.Executar();
    }

    if (opcaoDesejada == 5)
    {
        var exemplo05 = new Exemplo05();
        exemplo05.Executar();
    }
}

