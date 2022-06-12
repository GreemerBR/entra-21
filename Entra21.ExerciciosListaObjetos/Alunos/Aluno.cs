namespace Entra21.ExerciciosListaObjetos.Alunos
{
    internal class Aluno
    {
        public string Nome;
        public int CodigoMatricula;
        public int Idade;
        public string MateriaFavorita;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalcularMedia()
        {
            var media = (Nota1 + Nota2 + Nota3) / 3.0;

            return media;
        }

        public AlunoStatus ObterStatus()
        {
            var media = CalcularMedia();

            if (media >= 7.00)
            {
                return AlunoStatus.Aprovado;
            }
            else if (media < 5.00)
            {
                return AlunoStatus.Reprovado;
            }
            else
            {
                return AlunoStatus.EmExame;
            }
        }
    }
}