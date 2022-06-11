using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosLista
{
    internal class Exemplo01
    {
        public void Executar()
        {
            // List<tipo> nome = new List<tipo>();
            // var nome = new List<tipo>

            List<int> numeros = new List<int>();

            // Adicionando elementos na lista
            // nome.Add(elemento para ser adicionado)
            numeros.Add(28);
            numeros.Add(9);
            numeros.Add(18);
            numeros.Add(15);

            //lista criada
            // 28, 9, 18, 15
            // 0   1  2   3 => índice
            // 1   2  3   4 => posição na lista

            // Contando a quantidade de elementos da lista
            var quantidadeElementos = numeros.Count;

            // Inserindo um elemento em um índice específico da lista
            // nome.Insert(índice a ser inserido, elemento para ser adicionado)
            numeros.Insert(4, 50);

            //lista nova
            // 28, 9, 18, 15, 50
            // 0   1  2   3   4 => índice
            // 1   2  3   4   5 => posição na lista

            // Alterando um elemento da lista
            // nome[índice do elemento para ser alterado] = novo elemento;
            numeros[3] = 32;

            //lista nova
            // 28, 9, 18, 32, 50
            // 0   1  2   3   4 => índice
            // 1   2  3   4   5 => posição na lista

            // Remover um elemento da lista: por elemento
            // nome.Remove(elemento para ser removido);
            numeros.Remove(9);

            //lista nova
            // 28, 18, 15, 50
            // 0   1   2   3   => índice
            // 1   2   3   4   => posição na lista

            // Remover um elemento da lista: por posição na lista
            // nome.Remove(posição do elemento para ser removido);
            numeros.RemoveAt(2);

            //lista nova
            // 28, 18, 50
            // 0   1   2   => índice
            // 1   2   3   => posição na lista

            // Descobrir o índice de um elemento da lista
            // nome.IndexOf(elemento para ser descoberto);
            numeros.IndexOf(50); // 2

            // Descobrir se a lista contém um elemento
            // nome.Contains(elemento para ser descoberto);
            numeros.Contains(9); // false

            // Apresentando a lista
            // Se usa um FOR
            Console.WriteLine($@"[0]: {numeros[0]}
[1]: {numeros[1]}
[2]: {numeros[2]}");

            //Como converter um vetor em uma lista
            int[] numerosNovos = new int[4];
            List<int> listaNumerosNovos = numerosNovos.ToList(); // Não esquecer de importar com Ctrl+. caso não esteja funcionando o ToList()

            //Como converter uma lista em um vetor
            int[] numerosVetor = listaNumerosNovos.ToArray(); // Não esquecer de importar com Ctrl+. caso não esteja funcionando o ToArray()

            // Como alterar um registro buscando por elemento
            var indiceNumero = numeros.IndexOf(28);
            numeros[indiceNumero] = Convert.ToInt32(Console.ReadLine());

            // Caso o elemento não exista na lista, o índice retornado será -1, por isso é interessante fazer um if para informar ao usuário se é ou
            // não possível realizar a alteração solicitada.
        }
    }
}
