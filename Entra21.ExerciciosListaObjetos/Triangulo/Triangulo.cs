﻿namespace Entra21.ExerciciosListaObjetos.Triangulo
{
    internal class Triangulo
    {
        public int Lado1;
        public int Lado2;
        public int Lado3;
        public int Codigo;

        public bool ValidarTriangulo()
        {
            var modulo12 = Math.Abs(Lado1 - Lado2);
            var modulo13 = Math.Abs(Lado1 - Lado3);
            var modulo23 = Math.Abs(Lado2 - Lado3);
            var soma12 = Lado1 + Lado2;
            var soma13 = Lado1 + Lado3;
            var soma23 = Lado2 + Lado3;

            if (modulo23 < Lado1 && Lado1 < soma23 && modulo13 < Lado2 && Lado2 < soma13 && modulo12 < Lado3 && Lado3 < soma12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}