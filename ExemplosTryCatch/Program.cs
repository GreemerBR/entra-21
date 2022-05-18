using Entra21.ExemplosTryCatch;

var opcaoDesejada = 0;

while (opcaoDesejada != 3)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@"
-------------MENU-------------
 1 - Exemplo 01
 2 - Exemplo 02
 3 - SAIR
");

    try
    {
        Console.Write("Informe a opção desejada: ");
        opcaoDesejada = Convert.ToInt32(Console.ReadLine());

        if (opcaoDesejada < 0 || (opcaoDesejada != 1 && opcaoDesejada != 2 && opcaoDesejada != 3))
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
}