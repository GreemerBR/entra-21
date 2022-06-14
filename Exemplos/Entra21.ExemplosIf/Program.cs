using Entra21.ExemplosIf;

var opcaoDesejada = 0;

while (opcaoDesejada != 3)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@"
-------------MENU-------------
 1 - Exemplo 01
 2 - Exemplo 02
 3 - Exemplo 03
 4 - Exemplo 04
 5 - Exemplo 05
 6 - Exemplo 06
 7 - Exemplo 07
 8 - Exemplo 08
 9 - Exemplo 09
10 - Exemplo 10
11 - SAIR
");

    try
    {
        Console.Write("Informe a opção desejada: ");
        opcaoDesejada = Convert.ToInt32(Console.ReadLine());

        if (opcaoDesejada < 0 || (opcaoDesejada != 1 && opcaoDesejada != 2 && opcaoDesejada != 3 && opcaoDesejada != 4
            && opcaoDesejada != 5 && opcaoDesejada != 6 && opcaoDesejada != 7 && opcaoDesejada != 8 && opcaoDesejada != 9
            && opcaoDesejada != 10 && opcaoDesejada != 11))
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

    if (opcaoDesejada == 6)
    {
        var exemplo06 = new Exemplo06();
        exemplo06.Executar();
    }

    if (opcaoDesejada == 7)
    {
        var exemplo07 = new Exemplo07();
        exemplo07.Executar();
    }

    if (opcaoDesejada == 8)
    {
        var exemplo08 = new Exemplo08();
        exemplo08.Executar();
    }

    if (opcaoDesejada == 9)
    {
        var exemplo09 = new Exemplo09();
        exemplo09.Executar();
    }

    if (opcaoDesejada == 10)
    {
        var exemplo10 = new Exemplo10();
        exemplo10.Executar();
    }
}