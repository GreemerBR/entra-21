using Entra21.ExerciciosVetor;

Console.ForegroundColor = ConsoleColor.Green;

var opcaoDesejada = 0;
while (opcaoDesejada != 8)
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
8 - SAIR


Informe a opção desejada: ");

    var teste = false;
    while (teste == false)
    {
        try
        {
            opcaoDesejada = Convert.ToInt32(Console.ReadLine().Trim());

            if (opcaoDesejada < 0 || (opcaoDesejada > 0 && (opcaoDesejada != 1 && opcaoDesejada != 2 && opcaoDesejada != 3 && opcaoDesejada != 4
                && opcaoDesejada != 5 && opcaoDesejada != 6 && opcaoDesejada != 7 && opcaoDesejada != 8)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A opção informada não é valida. Por favor informe um número presente no MENU.");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                teste = true;
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A opção informada não é valida. Por favor informe um número presente no MENU.");
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }

    if (opcaoDesejada == 1)
    {
        var exercicio01 = new Exercicio01();
        exercicio01.Executar();
    }
}
