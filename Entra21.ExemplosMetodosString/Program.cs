using Entra21.ExemplosMetodosString;

var opcaoDesejada = 0;

while (opcaoDesejada != 3)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@"
-------------MENU-------------
 1 - Exemplo Replace e Length
 2 - Exemplo Substring e DateTime
 3 - Exemplo StartsWith
 4 - Exemplo EndsWith
 5 - Exemplo Contains
 6 - Exemplo Index
 7 - SAIR
");

    try
    {
        Console.Write("Informe a opção desejada: ");
        opcaoDesejada = Convert.ToInt32(Console.ReadLine());

        if (opcaoDesejada < 0 || (opcaoDesejada != 1 && opcaoDesejada != 2 && opcaoDesejada != 3 && opcaoDesejada != 4
            && opcaoDesejada != 5 && opcaoDesejada != 6 && opcaoDesejada != 7)) 
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
        var exemploReplace = new ExemploReplace();
        exemploReplace.Executar();
    }

    if (opcaoDesejada == 2)
    {
        var exemploSubstring = new ExemploSubstring();
        exemploSubstring.Executar();
    }

    if (opcaoDesejada == 3)
    {
        var exemploStartsWith = new ExemploStartsWith();
        exemploStartsWith.Executar();
    }

    if (opcaoDesejada == 4)
    {
        var exemploEndsWith = new ExemploEndsWith();
        exemploEndsWith.Executar();
    }

    if (opcaoDesejada == 5)
    {
        var exemploContains = new ExemploContains();
        exemploContains.Executar();
    }

    if (opcaoDesejada == 6)
    {
        var exemploIndex = new ExemploIndex();
        exemploIndex.Executar();
    }
}