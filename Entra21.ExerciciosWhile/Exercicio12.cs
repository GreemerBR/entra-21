using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio12
    {
        /* A padaria do joão necessita armazenar os pedidos dos seus clientes, cada cliente
         * poderá realizar quantos pedidos desejar, porém para que o cliente possa solicitar
         * estes produtos o cardápio deve ser apresentado para ele.
         * Ao final de o cliente solicitar os produtos, deve-se apresentar o total dos pedidos e a
         * quantidade de produtos consumidos.
         * O critério para que não seja mais solicitado o código do produto ao cliente é se o mesmo
         * informar o código 16
         * Ao final apresentar:
         * ● A quantidade de bolos escolhidos;
         * ● A quantidade de doces escolhidos;
         * ● A quantidade de Sanduíches escolhidos;
         * ● A quantidade de pizzas escolhidas;
         * ● A média dos produtos.
         */
        public void Executar()
        {
            Console.WriteLine("Bem vindo(a) a padaria do João");

            int item = 0;
            int bolos = 0;
            int doces = 0;
            int sanduiches = 0;
            int pizzas = 0;
            string produtos = "";
            double total = 0.00;
            int quantidadeProdutos = 0;
            int quantidadeTotalProdutos = 0;
            double mediaProdutos = 0.00;

            while (item < 15)
            {
                Console.WriteLine(@"
-----------------------------------------MENU-----------------------------------------
ITEM        TIPO                          PRODUTO                              VALOR
 1       Bolos        Bolo Brigadeiro                                        R$ 29,50
 2       Bolos        Bolo Floresta Negra                                    R$ 2,00
 3       Bolos        Bolo Leite com Nutella                                 R$ 29,23
 4       Bolos        Bolo Mousse de Chocolate                               R$ 7,10
 5       Bolos        Bolo Nega Maluca                                       R$ 19,33
 6       Doces        Bomba de Creme                                         R$ 17,71
 7       Doces        Bomba de Morango                                       R$ 4,82
 8       Sanduíches   Filé-Mignon com fritas e cheddar                       R$ 21,16
 9       Sanduíches   Hambúrguer com queijos, champignon e rúcula            R$ 12,70
10       Sanduíches   Provolone com salame                                   R$ 19,70
11       Sanduíches   Vegetariano de berinjela                               R$ 28,22
12       Pizzas       Calabresa                                              R$ 8,98
13       Pizzas       Napolitana                                             R$ 0,42
14       Pizzas       Peruana                                                R$ 18,36
15       Pizzas       Portuguesa                                             R$ 27,50
16       SAIR");

                Console.Write(@"

Informe o item desejado: ");
                item = Convert.ToInt32(Console.ReadLine());

                if (item == 1)
                {
                    produtos = produtos + "Bolo Brigadeiro R$ 29,50 \n";
                    Console.Write("Informe a quantidade de unidades: ");
                    quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                    total = total + 29.50 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    bolos = bolos + 1;
                }
                else if (item == 2)
                {
                    produtos = produtos + "Bolo Floresta Negra R$ 2,00\n";
                    Console.Write("Informe a quantidade de unidades: ");
                    quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                    total = total + 2.00 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    bolos = bolos + 1;
                }
                else if (item == 3)
                {
                    produtos = produtos + "Bolo Leite com Nutella R$ 29,23\n";
                    Console.Write("Informe a quantidade de unidades: ");
                    quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                    total = total + 29.23 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    bolos = bolos + 1;
                }
                else if (item == 4)
                {
                    produtos = produtos + "Bolo Mousse de Chocolate R$ 7,10\n";
                    Console.Write("Informe a quantidade de unidades: ");
                    quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                    total = total + 7.10 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    bolos = bolos + 1;
                }
                else if (item == 5)
                {
                    produtos = produtos + "Bolo Nega Maluca R$ 19,33\n";
                    Console.Write("Informe a quantidade de unidades: ");
                    quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                    total = total + 19.33 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    bolos = bolos + 1;
                }
                else if (item == 6)
                {
                    produtos = produtos + "Bomba de Creme R$ 17,71\n";
                    Console.Write("Informe a quantidade de unidades: ");
                    quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                    total = total + 17.71 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    doces = doces + 1;
                }
                else if (item == 7)
                {
                    produtos = produtos + "Bomba de Morango R$ 4,82\n";
                    Console.Write("Informe a quantidade de unidades: ");
                    quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                    total = total + 4.82 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    doces = doces + 1;
                }
                else if (item == 8)
                {
                    produtos = produtos + "Sanduíche de Filé-Mignon com fritas e cheddar R$ 21,16\n";
                    Console.Write("Informe a quantidade de unidades: ");
                    quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                    total = total + 21.16 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    sanduiches = sanduiches + 1;
                }
                else if (item == 9)
                {
                    produtos = produtos + "Sanduíche de Hambúrguer com queijos, champignon e rúcula R$ 12,70\n";
                    Console.Write("Informe a quantidade de unidades: ");
                    quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                    total = total + 12.70 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    sanduiches = sanduiches + 1;
                }
                else if (item == 10)
                {
                    produtos = produtos + "Sanduíche de Provolone com salame R$ 19,70\n";
                    Console.Write("Informe a quantidade de unidades: ");
                    quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                    total = total + 19.70 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    sanduiches = sanduiches + 1;
                }
                else if (item == 11)
                {
                    produtos = produtos + "Sanduíche Vegetariano de berinjela R$ 28,22\n";
                    Console.Write("Informe a quantidade de unidades: ");
                    quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                    total = total + 28.22 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    sanduiches = sanduiches + 1;
                }
                else if (item == 12)
                {
                    produtos = produtos + "Pizza de Calabrea R$ 8,98\n";
                    Console.Write("Informe a quantidade de unidades: ");
                    quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                    total = total + 8.98 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    pizzas = pizzas + 1;
                }
                else if (item == 13)
                {
                    produtos = produtos + "Pizza Napolitana R$ 0,42\n";
                    Console.Write("Informe a quantidade de unidades: ");
                    quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                    total = total + 0.42 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    pizzas = pizzas + 1;
                }
                else if (item == 14)
                {
                    produtos = produtos + "Pizza Peruana R$ 18,36\n";
                    Console.Write("Informe a quantidade de unidades: ");
                    quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                    total = total + 18.36 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    pizzas = pizzas + 1;
                }
                else if (item == 15)
                {
                    produtos = produtos + "Pizza Portuguesa R$ 27,50\n";
                    Console.Write("Informe a quantidade de unidades: ");
                    quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                    total = total + 27.50 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    pizzas = pizzas + 1;
                }
                else if (item == 16);
                else
                {
                    item = 0;
                }
            }

            Console.WriteLine(@"

LISTA DE PRODUTOS CONSUMIDOS");
            Console.Write(produtos);
            Console.WriteLine("VALOR TOTAL DA COMPRA: R$ " + total.ToString("F"));
            Console.WriteLine("Total de bolos consumidos: " + bolos);
            Console.WriteLine("Total de doces consumidos: " + doces);
            Console.WriteLine("Total de sanduíches consumidos: " + sanduiches);
            Console.WriteLine("Total de pizzas consumidas: " + pizzas);
            Console.WriteLine("Total de produtos consumidos: " + quantidadeTotalProdutos);
            Console.WriteLine("O valor médio dos produtos foi de: R$ " + (total/quantidadeTotalProdutos).ToString("F"));
        }
    }
}