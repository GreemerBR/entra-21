namespace Entra21.ExerciciosListaObjetos.Alunos
{
    internal class AlunoController
    {
        private AlunoServico alunoServico = new AlunoServico();

        public void GerenciarMenu()
        {
            int codigo = 0;

            while (codigo != 13)
            {
                Console.Clear();

                codigo = ApresentarMenu();

                Console.Clear();

                //if (codigo == 1)
                //{
                //    AdicionarNovoAluno();
                //}

                //if (codigo == 2)
                //{
                //    ExcluirAluno();
                //}

                //if (codigo == 3)
                //{
                //    AlterarDadosCadastrais();
                //}

                //if (codigo == 4)
                //{
                //    EditarNotasAlunos();
                //}

                //if (codigo == 5)
                //{
                //    ObterNomes();
                //}

                //if (codigo == 6)
                //{
                //    ObterMedias();
                //}

                //if (codigo == 7)
                //{
                //    ObterAprovados();
                //}

                //if (codigo == 8)
                //{
                //    ObterReprovado();
                //}

                //if (codigo == 9)
                //{
                //    ObtereEmExame();
                //}

                //if (codigo == 10)
                //{
                //    ObterMediaPorCodigoMatricula();
                //}

                //if (codigo == 11)
                //{
                //    ObterStatusPorCodigoMatricula();
                //}

                //if (codigo == 12)
                //{
                //    ObterMediasPorIdade();
                //}

                if (codigo != 13)
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
 1 - Adicionar aluno
 2 - Remover aluno
 3 - Editar dados cadastrais de um aluno
 4 - Editar notas de um aluno
 5 - Obter os nomes dos alunos
 6 - Obter as médias dos alunos
 7 - Obter a lista de alunos aprovados
 8 - Obter a lista de alunos reprovados
 9 - Obter a lista de aprovados
10 - Obter a média por código de matrícula
11 - Obter o status por código de matrícula
12 - Obter a média de idade dos alunos
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
    }
}