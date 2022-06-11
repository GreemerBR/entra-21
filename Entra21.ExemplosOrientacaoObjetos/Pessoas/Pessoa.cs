namespace Entra21.ExemplosOrientacaoObjetos.Pessoas
{
    internal class Pessoa
    {
        // Propriedas
        public string Nome;
        public double Altura;
        public double Peso;

        // Método
        // retorno do tipo double quer dizer que o método vai retornar um double => é um método com retorno
        // métodos com retorno precisam conter um, ou mais, RETURN dentro de seu escopo
        // tipoEncapsulamento + tipoRetorno + NomeMetodo(parametros)
        public double CalcularImc()
        {
            var imc = Peso / (Altura * Altura);
            Console.WriteLine("IMC: " + imc);

            return imc;
        }
        // retorno do tipo void quer dizer que o método nãi vai retornar nada => é um método sem retorno
        // tipoEncapsulamento + tipoRetorno + NomeMetodo(parametros)
        public void ApresentarImc()
        {
            var imcAuxiliar = CalcularImc();

            if (imcAuxiliar < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imcAuxiliar < 25)
            {
                Console.WriteLine("Normal");
            }
            else
            {
                Console.WriteLine("Obesidade");
            }
        }
    }
}
