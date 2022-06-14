namespace Entra21.ExemplosOrientacaoObjetos.Calculadoras
{
    internal class ExemploCalculadora
    {
        public void Executar()
        {
            // Instânciando um objeto da classe Calculadora
            // NomeClasse nomeObjeto = new NomeClasse();
            Calculadora hp = new Calculadora();
            Console.Write("Digite o número 1:");
            hp.Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o número 2:");
            hp.Numero2 = Convert.ToInt32(Console.ReadLine());

            hp.Somar();
            hp.Subtrair();

            Calculadora epson = new Calculadora();
            Console.Write("Digite o número 1:");
            epson.Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o número 2:");
            epson.Numero2 = Convert.ToInt32(Console.ReadLine());

            epson.Somar();
            epson.Subtrair();
        }
    }
}
