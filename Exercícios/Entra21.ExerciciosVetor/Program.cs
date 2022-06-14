using Entra21.ExerciciosVetor;

Console.ForegroundColor = ConsoleColor.Green;
var opcaoDesejada = 0;

while (opcaoDesejada != 9)
{
    Console.Write(@"
------ MENU ------
1 - Exercício 01
2 - Exercício 02
3 - Exercício 03
4 - Exercício 04
5 - Exercício 05
6 - Exercício 06
7 - Exercício 07
8 - Exemplo Professor
9 - SAIR

Informe a opção desejada: ");

    try
    {
        opcaoDesejada = Convert.ToInt32(Console.ReadLine().Trim());

        if (opcaoDesejada < 0 || (opcaoDesejada > 0 && (opcaoDesejada != 1 && opcaoDesejada != 2 && opcaoDesejada != 3 && opcaoDesejada != 4
            && opcaoDesejada != 5 && opcaoDesejada != 6 && opcaoDesejada != 7 && opcaoDesejada != 8 && opcaoDesejada != 9)))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A opção informada não é valida. Por favor informe um número presente no MENU.");
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
        Console.WriteLine("A opção informada não é valida. Por favor informe um número presente no MENU.");
        Console.ForegroundColor = ConsoleColor.Green;
    }

    if (opcaoDesejada == 1)
    {
        var exercicio01 = new Exercicio01();
        exercicio01.Executar();
    }

    if (opcaoDesejada == 2)
    {
        var exercicio02 = new Exercicio02();
        exercicio02.Executar();
    }

    if (opcaoDesejada == 3)
    {
        var exercicio03 = new Exercicio03();
        exercicio03.Executar();
    }

    if (opcaoDesejada == 4)
    {
        var exercicio04 = new Exercicio04();
        exercicio04.Executar();
    }

    if (opcaoDesejada == 5)
    {
        var exercicio05 = new Exercicio05();
        exercicio05.Executar();
    }

    if (opcaoDesejada == 6)
    {
        var exercicio06 = new Exercicio06();
        exercicio06.Executar();
    }

    if (opcaoDesejada == 7)
    {
        var exercicio07 = new Exercicio07();
        exercicio07.Executar();
    }

    if (opcaoDesejada == 8)
    {
        var exemploProfessor = new ExemploProfessor();
        exemploProfessor.Executar();
    }
}