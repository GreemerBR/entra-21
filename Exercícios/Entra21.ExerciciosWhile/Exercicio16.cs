using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio16
    {
        //Solicite ao usuário um texto e contabilize a quantidade de caracteres que um texto possui.
        public void Executar()
        {
            Console.Write("Informe um texto: ");
            string texto = Console.ReadLine();

            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            int g = 0;
            int h = 0;
            int i = 0;
            int j = 0;
            int k = 0;
            int l = 0;
            int m = 0;
            int n = 0;
            int o = 0;
            int p = 0;
            int q = 0;
            int r = 0;
            int s = 0;
            int t = 0;
            int u = 0;
            int v = 0;
            int w = 0;
            int x = 0;
            int y = 0;
            int z = 0;

            int contador = 0;

            while (contador < texto.Length)
            {
                char caracter = Convert.ToChar(texto.ToLower().Substring(contador, 1));

                if (caracter == 'a')
                {
                    a = a + 1;
                }
                else if (caracter == 'b')
                {
                    b = b + 1;
                }
                else if (caracter == 'c')
                {
                    c = c + 1;
                }
                else if (caracter == 'd')
                {
                    d = d + 1;
                }
                else if (caracter == 'e')
                {
                    e = e + 1;
                }
                else if (caracter == 'f')
                {
                    f = f + 1;
                }
                else if (caracter == 'g')
                {
                    g = g + 1;
                }
                else if (caracter == 'h')
                {
                    h = h + 1;
                }
                else if (caracter == 'i')
                {
                    i = i + 1;
                }
                else if (caracter == 'j')
                {
                    j = j + 1;
                }
                else if (caracter == 'k')
                {
                    k = k + 1;
                }
                else if (caracter == 'l')
                {
                    l = l + 1;
                }
                else if (caracter == 'm')
                {
                    m = m + 1;
                }
                else if (caracter == 'n')
                {
                    n = n + 1;
                }
                else if (caracter == 'o')
                {
                    o = o + 1;
                }
                else if (caracter == 'p')
                {
                    p = p + 1;
                }
                else if (caracter == 'q')
                {
                    q = q + 1;
                }
                else if (caracter == 'r')
                {
                    r = r + 1;
                }
                else if (caracter == 's')
                {
                    s = s + 1;
                }
                else if (caracter == 't')
                {
                    t = t + 1;
                }
                else if (caracter == 'u')
                {
                    u = u + 1;
                }
                else if (caracter == 'v')
                {
                    v = v + 1;
                }
                else if (caracter == 'w')
                {
                    w = w + 1;
                }
                else if (caracter == 'x')
                {
                    x = x + 1;
                }
                else if (caracter == 'y')
                {
                    y = y + 1;
                }
                else if (caracter == 'z')
                {
                    z = z + 1;
                }

                contador = contador + 1;
            }

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("e = " + e);
            Console.WriteLine("f = " + f);
            Console.WriteLine("g = " + g);
            Console.WriteLine("h = " + h);
            Console.WriteLine("i = " + i);
            Console.WriteLine("j = " + j);
            Console.WriteLine("k = " + k);
            Console.WriteLine("l = " + l);
            Console.WriteLine("m = " + m);
            Console.WriteLine("n = " + n);
            Console.WriteLine("o = " + o);
            Console.WriteLine("p = " + p);
            Console.WriteLine("q = " + q);
            Console.WriteLine("r = " + r);
            Console.WriteLine("s = " + s);
            Console.WriteLine("t = " + t);
            Console.WriteLine("u = " + u);
            Console.WriteLine("v = " + v);
            Console.WriteLine("w = " + w);
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
        }

    }
}
