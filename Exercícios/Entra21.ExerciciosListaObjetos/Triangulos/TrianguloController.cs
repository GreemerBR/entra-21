namespace Entra21.ExerciciosListaObjetos.Triangulos
{
    internal class TrianguloController
    {
        private TrianguloServico trianguloServico = new TrianguloServico();

        public void GerenciarMenu()
        {
            int codigo = 0;

            while (codigo != 6)
            {
                Console.Clear();

                codigo = ApresentarMenu();

                Console.Clear();

                if (codigo == 1)
                {
                    Cadastrar();
                }

                if (codigo == 2)
                {
                    Editar();
                }

                if (codigo == 3)
                {
                    Apagar();
                }

                if (codigo == 4)
                {
                    ApresentarTodos();
                }

                if (codigo == 5)
                {
                    ApresentarTriangulo();
                }

                if (codigo != 6)
                {
                    Console.WriteLine(@"
Aperte alguma tecla para continuar.");
                    Console.ReadKey();
                }
            }
        }

        private int ApresentarMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
----------------MENU----------------
1 - Cadastrar
2 - Editar
3 - Apagar
4 - Apresentar todos os triângulos
5 - Apresentar o triângulo desejado
6 - SAIR
");

            int codigo = SolicitarCodigo();

            return codigo;
        }

        private int SolicitarCodigo()
        {
            int codigo = 0;

            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.Write("Digite a opção desejada: ");
                    codigo = Convert.ToInt32(Console.ReadLine().Trim());

                    if (codigo < 1 || codigo > 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"
A opção informada não é válida.
Por favor informe um número presente no MENU.
");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Digite a opção desejada: ");
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"
A opção informada não é válida.
Por favor informe um número presente no MENU.
");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Digite a opção desejada: ");
                }
            }

            return codigo;
        }

        private void Cadastrar()
        {
            Console.Write("Por favor informe o tamanho do primeiro lado do triângulo: ");
            var lado1 = Convert.ToInt32(Console.ReadLine().Trim());

            Console.Write("Por favor informe o tamanho do segundo lado do triângulo: ");
            var lado2 = Convert.ToInt32(Console.ReadLine().Trim());

            Console.Write("Por favor informe o tamanho do terceiro lado do triângulo: ");
            var lado3 = Convert.ToInt32(Console.ReadLine().Trim());

            var cadastrou = trianguloServico.Adicionar(lado1, lado2, lado3);

            if (cadastrou == true)
            {
                Console.WriteLine(@"
Triângulo cadastrado com sucesso.");
            }
            else
            {
                Console.WriteLine(@"
Não foi possível cadastrar este triângulo, suas medias não são válidas.");
            }
        }

        private void Editar()
        {
            ApresentarTodos();

            Console.Write("Por favor informe o código do triângulo que você deseja editar: ");
            var codigo = Convert.ToInt32(Console.ReadLine().Trim());

            Console.Write("Por favor informe o tamanho do primeiro lado do triângulo: ");
            var lado1 = Convert.ToInt32(Console.ReadLine().Trim());

            Console.Write("Por favor informe o tamanho do segundo lado do triângulo: ");
            var lado2 = Convert.ToInt32(Console.ReadLine().Trim());

            Console.Write("Por favor informe o tamanho do terceiro lado do triângulo: ");
            var lado3 = Convert.ToInt32(Console.ReadLine().Trim());

            var codigoExiste = trianguloServico.ObterPorCodigo(codigo);

            if (codigoExiste == null)
            {

            }

            var alterou = trianguloServico.Editar(codigo, lado1, lado2, lado3);

            if (alterou == false)
            {
                Console.WriteLine(@"
Não foi possível cadastrar este triângulo, suas medias não são válidas.");
            }
            else
            {
                Console.WriteLine(@"
Triângulo alterado com sucesso.");
            }
        }

        private void Apagar()
        {
            ApresentarTodos();

            Console.Write("Por favor informe o código do triângulo que você deseja apagar: ");
            var codigo = Convert.ToInt32(Console.ReadLine().Trim());

            var apagou = trianguloServico.Apagar(codigo);

            if (apagou == false)
            {
                Console.WriteLine(@"
Código digitado não existe.");
            }
            else
            {
                Console.WriteLine(@"
Triângulo apagado com sucesso.");
            }
        }        

        private void ApresentarTodos()
        {
            var triangulos = trianguloServico.ObterTodos();

            if (triangulos.Count == 0)
            {
                Console.WriteLine(@"
Nenhum triângulo cadastrado.");

                return;
            }

            Console.WriteLine("Lista de triângulos:");

            for (var i = 0; i < triangulos.Count(); i++)
            {
                var trianguloAtual = triangulos[i];

                Console.WriteLine($@"Código {trianguloAtual.Codigo}
Tipo: {trianguloAtual.Tipo}
");
            }
        }

        private void ApresentarTriangulo()
        {
            ApresentarTodos();

            Console.Write("Digite o código do triângulo a ser detalhado: ");
            var codigo = Convert.ToInt32(Console.ReadLine().Trim());

            var triangulo = trianguloServico.ObterPorCodigo(codigo);

            if (triangulo == null)
            {
                Console.WriteLine(@"
Triângulo não cadastrado.");

                return;
            }

            Console.Clear();
            Console.WriteLine($@"Código {triangulo.Codigo}
Tipo: {triangulo.Tipo}
Lado 1: {triangulo.Lado1}
Lado 2: {triangulo.Lado2}
Lado 3: {triangulo.Lado3}");
        }
    }
}