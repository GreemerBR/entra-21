namespace Entra21.ExerciciosListaObjetos.Triangulos
{
    public class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();

        private int codigoAtual = 1;

        public bool Adicionar(int lado1, int lado2, int lado3)
        {
            Triangulo triangulo = new Triangulo();

            triangulo.Lado1 = lado1;
            triangulo.Lado2 = lado2;
            triangulo.Lado3 = lado3;
            triangulo.Tipo = triangulo.ObterTipoTriangulo();

            if (triangulo.ValidarTriangulo() == true)
            {
                triangulo.Codigo = codigoAtual;

                triangulos.Add(triangulo);

                codigoAtual = codigoAtual + 1;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Editar(int codigo, int lado1, int lado2, int lado3)
        {
            Triangulo trianguloParaAlterar = ObterPorCodigo(codigo);

            if (trianguloParaAlterar == null)
            {
                return false;
            }

            if (trianguloParaAlterar.ValidarTriangulo() == true)
            {
                trianguloParaAlterar.Lado1 = lado1;
                trianguloParaAlterar.Lado2 = lado2;
                trianguloParaAlterar.Lado3 = lado3;
                trianguloParaAlterar.Tipo = trianguloParaAlterar.ObterTipoTriangulo();

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Apagar(int codigo)
        {
            Triangulo trianguloParaRemover = ObterPorCodigo(codigo);

            if (trianguloParaRemover == null)
            {
                return false;
            }

            triangulos.Remove(trianguloParaRemover);

            return true;
        }

        public List<Triangulo> ObterTodos()
        {
            return triangulos;
        }

        public Triangulo ObterPorCodigo(int codigo)
        {
            for (var i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                if (trianguloAtual.Codigo == codigo)
                {
                    return trianguloAtual;
                }
            }

            return null;
        }        
    }
}