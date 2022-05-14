using Entra21.ExemplosFor;

Console.WriteLine(@"-------------MENU-------------
1 - Exemplo01
2 - Exemplo02
3 - Exemplo03
4 - Exemplo04
5 - Exemplo05");

Console.Write("Digite a opção deseja: ");
int opcaoDeseja = Convert.ToInt32(Console.ReadLine());

if (opcaoDeseja == 1)
{
    Exemplo01 exemplo01 = new Exemplo01();
    exemplo01.Executar();
}