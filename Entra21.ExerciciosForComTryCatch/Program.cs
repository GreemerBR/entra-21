using Entra21.ExerciciosForComTryCatch;

var opcaoDesejada = 0;

Console.Clear();    

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(@"-------------MENU-------------
  1 - Exercício 01
  5 - Exercício 05
  8 - Exercício 08
 10 - Exercício 10
 12 - Exercício 12
 13 - Exercício 13");

while (opcaoDesejada <= 0)
{
    try
    {
        Console.Write("Digite a opção desejada: ");
        opcaoDesejada = Convert.ToInt32(Console.ReadLine());

        if (opcaoDesejada < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A opção informada não é válida, por favor tente novamente!");
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("A opção informada não é válida, por favor tente novamente!");
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

}
