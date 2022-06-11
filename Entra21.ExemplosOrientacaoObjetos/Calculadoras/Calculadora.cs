namespace Entra21.ExemplosOrientacaoObjetos.Calculadoras
{
    public class Calculadora
    {
        // Propriedades
        public int Numero1;
        public int Numero2;

        // Métodos
        // retorno do tipo string quer dizer que o método vai retornar uma string => método com retorno
        // tipoEncapsulamento + tipoRetorno + NomeMetodo(parametros)
        public string Somar()
        {
            var soma = Numero1 + Numero2;
            return $"Soma: {soma}";
        }
        public string Subtrair()
        {
            var subtracao = Numero1 - Numero2;
           return $"Subtração: {subtracao}";
        }
    }
}