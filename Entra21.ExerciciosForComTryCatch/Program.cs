using Entra21.ExerciciosForComTryCatch;

var opcaoDesejada = 0;

while (opcaoDesejada != 20)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@"
-------------MENU-------------
 1 - Exercício 01
 5 - Exercício 05
 8 - Exercício 08
10 - Exercício 10
12 - Exercício 12
13 - Exercício 13
20 - SAIR
");

    try
    {
        Console.Write("Digite a opção desejada: ");
        opcaoDesejada = Convert.ToInt32(Console.ReadLine());

        if (opcaoDesejada < 0 || (opcaoDesejada != 1 && opcaoDesejada != 5 && opcaoDesejada != 8 && opcaoDesejada != 10
    && opcaoDesejada != 12 && opcaoDesejada != 13 && opcaoDesejada != 20))
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
        var exercicio01 = new Exercicio01();
        exercicio01.Executar();
    }

    if (opcaoDesejada == 5)
    {
        var exercicio05 = new Exercicio05();
        exercicio05.Executar();
    }

    if (opcaoDesejada == 8)
    {
        var exercicio08 = new Exercicio08();
        exercicio08.Executar();
    }

    if (opcaoDesejada == 10)
    {
        var exercicio10 = new Exercicio10();
        exercicio10.Executar();
    }

    if (opcaoDesejada == 12)
    {
        var exercicio12 = new Exercicio12();
        exercicio12.Executar();
    }

    if (opcaoDesejada == 13)
    {
        var exercicio13 = new Exercicio13();
        exercicio13.Executar();
    }
}
