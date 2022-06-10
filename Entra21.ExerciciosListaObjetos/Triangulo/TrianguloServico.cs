﻿namespace Entra21.ExerciciosListaObjetos.Triangulo
{
    internal class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();

        private int codigoAtual = 1;

        public bool Adicionar(int lado1, int lado2, int lado3)
        {
            Triangulo triangulo = new Triangulo();

            triangulo.Lado1 = lado1;
            triangulo.Lado2 = lado2;
            triangulo.Lado3 = lado3;

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

            trianguloParaAlterar.Lado1 = lado1;
            trianguloParaAlterar.Lado2 = lado2;
            trianguloParaAlterar.Lado3 = lado3;

            return true;
        }

        private Triangulo ObterPorCodigo(int codigo)
        {
            for (var i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                if ()
            }
        }
    }
}