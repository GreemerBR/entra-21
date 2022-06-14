using Entra21.ExerciciosLista;

var opcaoDesejada = 0;

while (opcaoDesejada != 4)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@"
-------------MENU-------------
1 - Exercício 01
2 - Exercício 02
3 - Exercício 03
4 - SAIR
");

    try
    {
        Console.Write("Digite a opção desejada: ");
        opcaoDesejada = Convert.ToInt32(Console.ReadLine());

        if (opcaoDesejada < 0 || (opcaoDesejada != 1 && opcaoDesejada != 2 && opcaoDesejada != 3 && opcaoDesejada != 4))
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
}