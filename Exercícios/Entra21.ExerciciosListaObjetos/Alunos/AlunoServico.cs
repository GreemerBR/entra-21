namespace Entra21.ExerciciosListaObjetos.Alunos
{
    internal class AlunoServico
    {
        private List<Aluno> alunos = new List<Aluno>();

        private int CodigoMatricula = 1;

        public void AdicionarAluno(string nome, int idade, string materiaFavorita, double nota1, double nota2, double nota3)
        {
            Aluno aluno = new Aluno();

            aluno.Nome = nome;
            aluno.Idade = idade;
            aluno.MateriaFavorita = materiaFavorita;
            aluno.Nota1 = nota1;
            aluno.Nota2 = nota2;
            aluno.Nota3 = nota3;
            aluno.CodigoMatricula = CodigoMatricula;

            alunos.Add(aluno);

            CodigoMatricula += 1;
        }

        public bool RemoverAluno(string nome)
        {
            var alunoParaRemover = ObterAlunoPorNome(nome);
            if (alunoParaRemover != null)
            {
                alunos.Remove(alunoParaRemover);

                return true;
            }

            return false;
        }

        public bool EditarDadosCadastrais(int codigoMatricula, string nome, int idade, string materiaFavorita)
        {
            var alunoParaEditarDados = ObterAlunoPorCodigoMatricula(codigoMatricula);

            if (alunoParaEditarDados != null)
            {
                alunoParaEditarDados.Nome = nome;
                alunoParaEditarDados.Idade = idade;
                alunoParaEditarDados.MateriaFavorita = materiaFavorita;

                return true;
            }

            return false;
        }

        public bool EditarNotasAlunos(int codigoMatricula, double nota1, double nota2, double nota3)
        {
            var alunoParaEditarNotas = ObterAlunoPorCodigoMatricula(codigoMatricula);

            if (alunoParaEditarNotas != null)
            {
                alunoParaEditarNotas.Nota1 = nota1;
                alunoParaEditarNotas.Nota2 = nota2;
                alunoParaEditarNotas.Nota3 = nota3;

                return true;
            }

            return false;
        }

        public List<string> ObterNomes()
        {
            var NomeAlunos = new List<string>();

            for (var i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i].Nome;

                NomeAlunos.Add(alunoAtual);
            }

            return NomeAlunos;
        }

        public List<double> ObterMedias()
        {
            var MediaAlunos = new List<double>();

            for (var i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                MediaAlunos.Add(alunoAtual.CalcularMedia());
            }

            return MediaAlunos;
        }

        public List<string> ObterAprovados()
        {
            var AlunosAprovados = new List<string>();

            for (var i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                if (alunoAtual.ObterStatus() == AlunoStatus.Aprovado)
                {
                    AlunosAprovados.Add(alunoAtual.Nome);
                }                
            }

            return AlunosAprovados;
        }

        public List<string> ObterReprovados()
        {
            var AlunosReprovado = new List<string>();

            for (var i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                if (alunoAtual.ObterStatus() == AlunoStatus.Reprovado)
                {
                    AlunosReprovado.Add(alunoAtual.Nome);
                }
            }

            return AlunosReprovado;
        }

        public List<string> ObtereEmExame()
        {
            var AlunoseEmExame = new List<string>();

            for (var i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                if (alunoAtual.ObterStatus() == AlunoStatus.EmExame)
                {
                    AlunoseEmExame.Add(alunoAtual.Nome);
                }
            }

            return AlunoseEmExame;
        }

        public double ObterMediaPorCodigoMatricula(int codigoMatricula)
        {
            var aluno = ObterAlunoPorCodigoMatricula(codigoMatricula);

            var media = aluno.CalcularMedia();        

            return media;
        }

        public AlunoStatus ObterStatusPorCodigoMatricula(int codigoMatricula)
        {
            var aluno = ObterAlunoPorCodigoMatricula(codigoMatricula);

            var status = aluno.ObterStatus();

            return status;
        }

        public double ObterMediaIdades()
        {
            var alunos = ObterTodos();

            var somaIdade = 0.0;

            for (var i = 0; i < alunos.Count; i++)
            {
                var idadeAlunoAtual = Convert.ToDouble(alunos[i].Idade);

                somaIdade = idadeAlunoAtual + somaIdade;
            }

            double mediaIdade = somaIdade / alunos.Count;

            return mediaIdade;
        }

        public List<Aluno> ObterTodos()
        {
            return alunos;
        }

        public Aluno ObterAlunoPorCodigoMatricula(int codigoMatricula)
        {
            var aluno = codigoMatricula;

            for (var i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                if (alunoAtual.CodigoMatricula == aluno)
                {
                    return alunoAtual;
                }
            }

            return null;
        }       

        private Aluno ObterAlunoPorNome(string nome)
        {
            var aluno = nome;

            for (var i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                if (alunoAtual.Nome == aluno)
                {
                    return alunoAtual;
                }
            }

            return null;
        }
    }
}