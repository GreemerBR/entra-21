using Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens;

namespace Entra21.BancoDados01.Ado.Net
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new TipoPersonagemListagemForm());
        }
    }
}