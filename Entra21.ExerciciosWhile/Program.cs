using Entra21.ExerciciosWhile;

int opcaoDesejada = 0;

while (opcaoDesejada != 18)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@"-------------MENU-------------
 1 - Exercício 01
 2 - Exercício 02
 3 - Exercício 03
 4 - Exercício 04
 5 - Exercício 05
 6 - Exercício 06
 7 - Exercício 07
 8 - Exercício 08
 9 - Exercício 09
10 - Exercício 10
11 - Exercício 11
12 - Exercício 12
13 - Exercício 13
14 - Exercício 14
15 - Exercício 15
16 - Exercício 16
17 - Exercício 17
18 - SAIR
");

    try
    {
        Console.Write("Digite a opção desejada: ");
        opcaoDesejada = Convert.ToInt32(Console.ReadLine());

        if (opcaoDesejada < 0 || (opcaoDesejada != 1 && opcaoDesejada != 2 && opcaoDesejada != 3 && opcaoDesejada != 4 && opcaoDesejada != 5 && opcaoDesejada != 6
            && opcaoDesejada != 7 && opcaoDesejada != 8 && opcaoDesejada != 9 && opcaoDesejada != 10 && opcaoDesejada != 11 && opcaoDesejada != 12 && opcaoDesejada != 13
            && opcaoDesejada != 14 && opcaoDesejada != 15 && opcaoDesejada != 16 && opcaoDesejada != 17 && opcaoDesejada != 18)) 
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
        Exercicio01 Exercicio01 = new Exercicio01();
        Exercicio01.Executar();
    }
    else if (opcaoDesejada == 2)
    {
        Exercicio02 Exercicio02 = new Exercicio02();
        Exercicio02.Executar();
    }
    else if (opcaoDesejada == 3)
    {
        Exercicio03 Exercicio03 = new Exercicio03();
        Exercicio03.Executar();
    }
    else if (opcaoDesejada == 4)
    {
        Exercicio04 Exercicio04 = new Exercicio04();
        Exercicio04.Executar();
    }
    else if (opcaoDesejada == 5)
    {
        Exercicio05 Exercicio05 = new Exercicio05();
        Exercicio05.Executar();
    }
    else if (opcaoDesejada == 6)
    {
        Exercicio06 Exercicio06 = new Exercicio06();
        Exercicio06.Executar();
    }
    else if (opcaoDesejada == 7)
    {
        Exercicio07 Exercicio07 = new Exercicio07();
        Exercicio07.Executar();
    }
    else if (opcaoDesejada == 8)
    {
        Exercicio08 Exercicio08 = new Exercicio08();
        Exercicio08.Executar();
    }
    else if (opcaoDesejada == 9)
    {
        Exercicio09 Exercicio09 = new Exercicio09();
        Exercicio09.Executar();
    }
    else if (opcaoDesejada == 10)
    {
        Exercicio10 Exercicio10 = new Exercicio10();
        Exercicio10.Executar();
    }
    else if (opcaoDesejada == 11)
    {
        Exercicio11 Exercicio11 = new Exercicio11();
        Exercicio11.Executar();
    }
    else if (opcaoDesejada == 12)
    {
        Exercicio12 Exercicio12 = new Exercicio12();
        Exercicio12.Executar();
    }
    else if (opcaoDesejada == 13)
    {
        Exercicio13 Exercicio13 = new Exercicio13();
        Exercicio13.Executar();
    }
    else if (opcaoDesejada == 14)
    {
        Exercicio14 Exercicio14 = new Exercicio14();
        Exercicio14.Executar();
    }
    else if (opcaoDesejada == 15)
    {
        Exercicio15 Exercicio15 = new Exercicio15();
        Exercicio15.Executar();
    }
    else if (opcaoDesejada == 16)
    {
        Exercicio16 Exercicio16 = new Exercicio16();
        Exercicio16.Executar();
    }
    else if (opcaoDesejada == 17)
    {
        Exercicio17 Exercicio17 = new Exercicio17();
        Exercicio17.Executar();
    }
}