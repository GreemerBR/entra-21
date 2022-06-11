namespace Entra21.ExemplosListaObjetos
{
    // enum não tem propriedades ou métodos e não é uma classe.
    // enum serve para enumerar algo

    public enum ProjetoStatus
    {
        // chave = valor,
        Backlog = 0,
        EmRefinamento = 1,
        Refinado = 2,
        EmExecucao = 3,
        Teste = 4,
        Done = 5,
        Cancelado = 6 // No último não vai a ,

        // Poderia ser feito assim:
        //Backlog,
        //EmRefinamento,
        //Refinado,
        //EmExecucao,
        //Teste,
        //Done,
        //Cancelado

        // Quando não se coloca "= valor" ele automaticamente começa no 0
        // Se usar o "= valor" ele pode começar pelo número que se desejar    

        // Converter int para enum
        // int tamanhoRoupaClaudio = 2;
        // tipo nomeVariavel = (tipo) nomeVariavelInformada
        // RoupaTamanho roupaClaudio = (RoupaTamanho)tamanhoRoupaClaudio;

        // Converter enum para int
        // int roupaClaudioInteiro = Convert.ToInt32(roupaClaudio);
    }
}
