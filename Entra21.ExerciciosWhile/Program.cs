using Entra21.ExerciciosWhile;

Console.WriteLine(@"-------------MENU-------------
 1 - Exercicio01
 2 - Exercicio02
 3 - Exercicio03
 4 - Exercicio04
 5 - Exercicio05
 6 - Exercicio06
 7 - Exercicio07
 8 - Exercicio08
 9 - Exercicio09
10 - Exercicio10
11 - Exercicio11
12 - Exercicio12
13 - Exercicio13
14 - Exercicio14
15 - Exercicio15
16 - Exercicio16
17 - Exercicio17
");

Console.Write("Digite a opção deseja: ");
int opcaoDeseja = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (opcaoDeseja == 1)
{
    Exercicio01 Exercicio01 = new Exercicio01();
    Exercicio01.Executar();
}
else if (opcaoDeseja == 2)
{
    Exercicio02 Exercicio02 = new Exercicio02();
    Exercicio02.Executar();
}
else if (opcaoDeseja == 3)
{
    Exercicio03 Exercicio03 = new Exercicio03();
    Exercicio03.Executar();
}
else if (opcaoDeseja == 4)
{
    Exercicio04 Exercicio04 = new Exercicio04();
    Exercicio04.Executar();
}
else if (opcaoDeseja == 5)
{
    Exercicio05 Exercicio05 = new Exercicio05();
    Exercicio05.Executar();
}
else if (opcaoDeseja == 6)
{
    Exercicio06 Exercicio06 = new Exercicio06();
    Exercicio06.Executar();
}
else if (opcaoDeseja == 7)
{
    Exercicio07 Exercicio07 = new Exercicio07();
    Exercicio07.Executar();
}
else if (opcaoDeseja == 8)
{
    Exercicio08 Exercicio08 = new Exercicio08();
    Exercicio08.Executar();
}
else if (opcaoDeseja == 9)
{
    Exercicio09 Exercicio09 = new Exercicio09();
    Exercicio09.Executar();
}
else if (opcaoDeseja == 10)
{
    Exercicio10 Exercicio10 = new Exercicio10();
    Exercicio10.Executar();
}
/*else if (opcaoDeseja == 11)
{
    Exercicio11 Exercicio11 = new Exercicio11();
    Exercicio11.Executar();
}
else if (opcaoDeseja == 12)
{
    Exercicio12 Exercicio12 = new Exercicio12();
    Exercicio12.Executar();
}
else if (opcaoDeseja == 13)
{
    Exercicio13 Exercicio13 = new Exercicio13();
    Exercicio13.Executar();
}
else if (opcaoDeseja == 14)
{
    Exercicio14 Exercicio14 = new Exercicio14();
    Exercicio14.Executar();
}
else if (opcaoDeseja == 15)
{
    Exercicio15 Exercicio15 = new Exercicio15();
    Exercicio15.Executar();
}
else if (opcaoDeseja == 16)
{
    Exercicio16 Exercicio16 = new Exercicio16();
    Exercicio16.Executar();
}
else if (opcaoDeseja == 17)
{
    Exercicio17 Exercicio17 = new Exercicio17();
    Exercicio17.Executar();
}*/