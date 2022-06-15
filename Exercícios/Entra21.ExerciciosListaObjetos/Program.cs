using Entra21.ExerciciosListaObjetos.Alunos;
using Entra21.ExerciciosListaObjetos.Triangulos;

var opcaoDesejada = 0;

while (opcaoDesejada != 3)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@"
-----------MENU-----------
1 - Exercício Aluno
2 - Exercício Trinângulo
3 - SAIR
");

    try
    {
        Console.Write("Digite a opção desejada: ");
        opcaoDesejada = Convert.ToInt32(Console.ReadLine());

        if (opcaoDesejada < 0 || opcaoDesejada > 3)
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
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("A opção informada não é válida. Por favor informe um número presente no MENU.");
        Console.ForegroundColor = ConsoleColor.Green;
    }

    if (opcaoDesejada == 1)
    {
        var aluno = new AlunoController();
        aluno.GerenciarMenu();
    }

    if (opcaoDesejada == 2)
    {
        var triangulo = new TrianguloController();
        triangulo.GerenciarMenu();
    }
}