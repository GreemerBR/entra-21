using Entra21.ExemplosWhile;

Console.WriteLine(@"-------------MENU-------------
1 - Exemplo01
2 - Exemplo02
3 - Exemplo03
4 - Exemplo04
5 - Exemplo05
6 - Exemplo06
7 - Exemplo07");

Console.Write("Digite a opção deseja: ");
int opcaoDeseja = Convert.ToInt32(Console.ReadLine());

if (opcaoDeseja == 1)
{
    //NomeDaClasse nomeVariavel = new NomeDaClasse
    Exemplo01 exemplo01 = new Exemplo01();
    exemplo01.Executar();
}
else if (opcaoDeseja == 2)
{
    Exemplo02 exemplo02 = new Exemplo02();
    exemplo02.Executar();
}
else if (opcaoDeseja == 3)
{
    Exemplo03 exemplo03 = new Exemplo03();
    exemplo03.Executar();
}
else if (opcaoDeseja == 4)
{
    Exemplo04 exemplo04 = new Exemplo04();
    exemplo04.Executar();
}
else if (opcaoDeseja == 5)
{
    Exemplo05 exemplo05 = new Exemplo05();
    exemplo05.Executar();
}
else if (opcaoDeseja == 6)
{
    Exemplo06 exemplo06 = new Exemplo06();
    exemplo06.Executar();
}
else if (opcaoDeseja == 7)
{
    Exemplo07 exemplo07 = new Exemplo07();
    exemplo07.Executar();
}