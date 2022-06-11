using Entra21.ExerciciosOrientacaoObjetos.ASCIIs;
using Entra21.ExerciciosOrientacaoObjetos.Farmacias;
using Entra21.ExerciciosOrientacaoObjetos.Livros;
using Entra21.ExerciciosOrientacaoObjetos.Temperaturas;

var opcaoDesejada = 0;

while (opcaoDesejada != 6)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@"
-------------MENU-------------
1 - Exercício Livro
2 - Exercício Temperatura
3 - Exercício ASCII
4 - Exercício Farmácia
5 - Exercício ??
6 - SAIR
");

    try
    {
        Console.Write("Digite a opção desejada: ");
        opcaoDesejada = Convert.ToInt32(Console.ReadLine());

        if (opcaoDesejada < 0 || (opcaoDesejada != 1 && opcaoDesejada != 2 && opcaoDesejada != 3 && opcaoDesejada != 4 && opcaoDesejada != 5 && opcaoDesejada != 6))
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

        var exercicioLivro = new ExercicioLivro();
        exercicioLivro.Executar();
    }

    if (opcaoDesejada == 2)
    {
        var exercicioTemperatura = new ExercicioTemperatura();
        exercicioTemperatura.Executar();
    }

    if (opcaoDesejada == 3)
    {
        var exercicioAscii = new ExercicioConversorAscii();
        exercicioAscii.Executar();
    }

    if (opcaoDesejada == 4)
    {
        var exercicioFarmacia = new ExercicioFarmacia();
        exercicioFarmacia.Executar();
    }
}