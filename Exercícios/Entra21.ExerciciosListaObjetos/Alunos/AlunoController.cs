﻿using Entra21.ExerciciosListaObjetos.Alunos.TestesDeValidacaoDeInformacoes;

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

                if (codigo == 1)
                {
                    AdicionarNovoAluno();
                }

                if (codigo == 2)
                {
                    ExcluirAluno();
                }

                if (codigo == 3)
                {
                    AlterarDadosCadastrais();
                }

                if (codigo == 4)
                {
                    EditarNotasAlunos();
                }

                if (codigo == 5)
                {
                    ObterListaDeNomes();
                }

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
13 - SAIR
");

            int codigo = SolicitarCodigo();

            return codigo;
        }

        private int SolicitarCodigo()
        {
            int codigo = 0;

            while (codigo < 1 || codigo > 13)
            {
                try
                {
                    Console.Write("Digite a opção desejada: ");
                    codigo = Convert.ToInt32(Console.ReadLine().Trim());

                    if (codigo < 1 || codigo > 13)
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

        private void AdicionarNovoAluno()
        {
            var nomeAlunoValido = new NomeAlunoValido();
            var idadeAlunoValida = new IdadeAlunoValida();
            var materiaFavoritaValida = new MateriaFavoritaValida();
            var notaValida = new NotaValida();

            Console.Clear();

            Console.Write("Por favor, informe o nome do(a) aluno(a) a ser cadastrado(a): ");
            var nome = nomeAlunoValido.ObterNome();

            Console.Write("Por favor, informe a idade do(a) aluno(a) a ser cadastrado(a): ");
            var idade = idadeAlunoValida.ObterIdade();

            Console.Write("Por favor, informe o nome da matéria favorita do(a) aluno(a) a ser cadastrado(a): ");
            var materiaFavorita = materiaFavoritaValida.ObterMateriaFavorita();

            Console.Write("Por favor, informe a nota 1 do(a) aluno(a) a ser cadastrado(a): ");
            var nota1 = notaValida.ObterNota();

            Console.Write("Por favor, informe a nota 2 do(a) aluno(a) a ser cadastrado(a): ");
            var nota2 = notaValida.ObterNota();

            Console.Write("Por favor, informe a nota 3 do(a) aluno(a) a ser cadastrado(a): ");
            var nota3 = notaValida.ObterNota();

            alunoServico.AdicionarAluno(nome, idade, materiaFavorita, nota1, nota2, nota3);
        }

        private string ExcluirAluno()
        {
            ObterListaDeNomes();

            var nomeAlunoValido = new NomeAlunoValido();

            Console.Write("Por favor, informe o nome do(a) aluno(a) que você deseja apagar do cadastro: ");
            var nome = nomeAlunoValido.ObterNome();

            var apagou = alunoServico.RemoverAluno(nome);

            if (apagou == true)
            {
                return $"O cadastro do(a) aluno(a) {nome} foi apagado com sucesso.";
            }
            else
            {
                return $@"O cadastro do(a) aluno(a) {nome} não foi apagado, pois o mesmo não foi encontrado.
Por favor, verifique se o nome informado é o correto e tente novamente.";
            }
        }

        private string AlterarDadosCadastrais()
        {
            var codigoMatriculaValido = new CodigoMatriculaValido();
            var nomeAlunoValido = new NomeAlunoValido();
            var idadeAlunoValida = new IdadeAlunoValida();
            var materiaFavoritaValida = new MateriaFavoritaValida();

            AlunosComNomeCodigo();

            Console.Write("Por favor, informe o código de matrícula do(a) aluno(a) que deseja alterar os dados cadastrais: ");
            var codigoMatricula = codigoMatriculaValido.ObterCodigoMatriculaValido();

            Console.Write("Por favor, informe o novo nome do(a) aluno(a): ");
            var nome = nomeAlunoValido.ObterNome();

            Console.Write("Por favor, informe a nova idade do(a) aluno(a): ");
            var idade = idadeAlunoValida.ObterIdade();

            Console.Write("Por favor, informe o nome da nova matéria favorita do(a) aluno(a): ");
            var materiaFavorita = materiaFavoritaValida.ObterMateriaFavorita();

            var editou = alunoServico.EditarDadosCadastrais(codigoMatricula, nome, idade, materiaFavorita);

            if (editou == true)
            {
                return $"O cadastro do(a) aluno(a) {nome} foi editado com sucesso.";
            }
            else
            {
                return $@"O cadastro do(a) aluno(a) {nome} não foi editado, pois o mesmo não foi encontrado.
Por favor, verifique se o código de matrícula informado é o correto e tente novamente.";
            }
        }

        private string EditarNotasAlunos()
        {
            var codigoMatriculaValido = new CodigoMatriculaValido();
            var notaValida = new NotaValida();

            AlunosComNomeCodigo();

            Console.Write("Por favor, informe o código de matrícula do(a) aluno(a) que deseja alterar os dados cadastrais: ");
            var codigoMatricula = codigoMatriculaValido.ObterCodigoMatriculaValido();

            Console.Write("Por favor, informe a nota 1 do(a) aluno a ser cadastrado: ");
            var nota1 = notaValida.ObterNota();

            Console.Write("Por favor, informe a nota 2 do(a) aluno a ser cadastrado: ");
            var nota2 = notaValida.ObterNota();

            Console.Write("Por favor, informe a nota 3 do(a) aluno a ser cadastrado: ");
            var nota3 = notaValida.ObterNota();

            var editou = alunoServico.EditarNotasAlunos(codigoMatricula, nota1, nota2, nota3);

            var alunoEditado = alunoServico.ObterAlunoPorCodigoMatricula(codigoMatricula);

            if (editou == true)
            {
                return $"O cadastro do(a) aluno {alunoEditado.Nome} foi editado(a) com sucesso.";
            }
            else
            {
                return $@"O cadastro do(a) aluno {alunoEditado.Nome} não foi editado, pois o mesmo não foi encontrado.
Por favor, verifique se o código de matrícula informado é o correto e tente novamente.";
            }

        }

        private string ObterListaDeNomes()
        {
            var aluno = alunoServico.ObterNomes();

            var listaAlunos = "";

            for (var i = 0; i < aluno.Count; i++)
            {
                var alunoAtual = aluno[i];

                listaAlunos = alunoAtual +
                    "\n" + listaAlunos;
            }

            return listaAlunos;
        }

        private void AlunosComNomeCodigo()
        {
            var alunos = alunoServico.ObterTodos();
            
            for (var i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];
                Console.WriteLine($"Nome: {alunoAtual.Nome} - Código de matrícula: {alunoAtual.CodigoMatricula}");
            }
        }
    }
}