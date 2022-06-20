namespace Entra21.ExerciciosListaObjetos.Triangulos
{
    public class Triangulo
    {
        public int Lado1;
        public int Lado2;
        public int Lado3;
        public int Codigo;
        public TrianguloTipo Tipo;

        public bool ValidarTriangulo()
        {
            if (ValidarLado1() == true && ValidarLado2() == true && ValidarLado3() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarLado1()
        {
            var modulo23 = Math.Abs(Lado2 - Lado3);
            var soma23 = Lado2 + Lado3;

            if (modulo23 < Lado1 && Lado1 < soma23)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarLado2()
        {
            var modulo13 = Math.Abs(Lado1 - Lado3);
            var soma13 = Lado1 + Lado3;

            if (modulo13 < Lado2 && Lado2 < soma13)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidarLado3()
        {
            var modulo12 = Math.Abs(Lado1 - Lado2);
            var soma12 = Lado1 + Lado2;

            if (modulo12 < Lado3 && Lado3 < soma12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public TrianguloTipo ObterTipoTriangulo()
        {           
            if (EhEquilatero() == true)
            {
                return TrianguloTipo.Equilatero;
            }
            else if (EhIsosceles() == true)
            {
                return TrianguloTipo.Isosceles;
            }
            else
            {
                return TrianguloTipo.Escaleno;
            }
        }

        private bool EhEquilatero()
        {
            if (Lado1 == Lado2 && Lado1 == Lado3)
            {
                return true;
            }

            return false;
        }
        
        private bool EhIsosceles()
        {
            if ((Lado1 == Lado2 || Lado1 == Lado3 || Lado2 == Lado3) && EhEquilatero() == false)
            {
                return true;
            }

            return false;
        }        
    }
}