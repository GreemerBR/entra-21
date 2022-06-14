using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForComTryCatch
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
            Console.Clear();
            Console.WriteLine("Bem vindo a Padaria do João");

            var quantidadeBolos = 0;
            var quantidadeDoces = 0;
            var quantidadeSanduiches = 0;
            var quantidadePizzas = 0;
            var quantidadeTotalProdutos = 0;
            var total = 0.0;
            var produtos = "";

            for (var i = 0; i != 16;)
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
16       SAIR
");

                try
                {
                    Console.Write("Informe o item desejado: ");
                    i = Convert.ToInt32(Console.ReadLine());

                    if (i < 0 || i > 16)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor informado não é valido. Por favor informe um número inteiro positivo que conste no MENU.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O valor informado não é valido. Por favor informe um número inteiro que conste no MENU.");
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                var quantidadeProdutos = 0;
                var teste = false;

                if (i != 16)
                {
                    while (teste == false)
                    {
                        try
                        {
                            Console.Write("Informe a quantidade de unidades: ");
                            quantidadeProdutos = Convert.ToInt32(Console.ReadLine());

                            if (quantidadeProdutos < 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("O valor informado não é valido. Por favor informe um número inteiro positivo.");
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                teste = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O valor informado não é valido. Por favor informe um número inteiro positivo.");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                }

                if (i == 1)
                {
                    produtos = produtos + "Bolo Brigadeiro R$ 29,50 " + quantidadeProdutos + " unidade(s) \n";
                    total = total + 29.50 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    quantidadeBolos = quantidadeBolos + quantidadeProdutos;
                }

                if (i == 2)
                {
                    produtos = produtos + "Bolo Floresta Negra R$ 2,00 " + quantidadeProdutos + " unidade(s) \n";
                    total = total + 2.00 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    quantidadeBolos = quantidadeBolos + quantidadeProdutos;
                }

                if (i == 3)
                {
                    produtos = produtos + "Bolo Leite com Nutella R$ 29,23 " + quantidadeProdutos + " unidade(s) \n";
                    total = total + 29.23 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    quantidadeBolos = quantidadeBolos + quantidadeProdutos;
                }

                if (i == 4)
                {
                    produtos = produtos + "Bolo Mousse de Chocolate R$ 7,10 " + quantidadeProdutos + " unidade(s) \n";
                    total = total + 7.10 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    quantidadeBolos = quantidadeBolos + quantidadeProdutos;
                }

                if (i == 5)
                {
                    produtos = produtos + "Bolo Nega Maluca R$ 19,33 " + quantidadeProdutos + " unidade(s) \n";
                    total = total + 19.33 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    quantidadeBolos = quantidadeBolos + quantidadeProdutos;
                }

                if (i == 6)
                {
                    produtos = produtos + "Bomba de Creme R$ 17,71 " + quantidadeProdutos + " unidade(s) \n";
                    total = total + 17.71 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    quantidadeDoces = quantidadeDoces + quantidadeProdutos;
                }

                if (i == 7)
                {
                    produtos = produtos + "Bomba de Morango R$ 4,82 " + quantidadeProdutos + " unidade(s) \n";
                    total = total + 4.82 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    quantidadeDoces = quantidadeDoces + quantidadeProdutos;
                }

                if (i == 8)
                {
                    produtos = produtos + "Sanduíche de Filé-Mignon com fritas e cheddar R$ 21,16 " + quantidadeProdutos + " unidade(s) \n";
                    total = total + 21.16 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    quantidadeSanduiches = quantidadeSanduiches + quantidadeProdutos;
                }

                if (i == 9)
                {
                    produtos = produtos + "Sanduíche de Hambúrguer com queijos, champignon e rúcula R$ 12,70 " + quantidadeProdutos + " unidade(s) \n";
                    total = total + 12.70 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    quantidadeSanduiches = quantidadeSanduiches + quantidadeProdutos;
                }

                if (i == 10)
                {
                    produtos = produtos + "Sanduíche de Provolone com salame R$ 19,70 " + quantidadeProdutos + " unidade(s) \n";
                    total = total + 19.70 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    quantidadeSanduiches = quantidadeSanduiches + quantidadeProdutos;
                }

                if (i == 11)
                {
                    produtos = produtos + "Sanduíche Vegetariano de berinjela R$ 28,22 " + quantidadeProdutos + " unidade(s) \n";
                    total = total + 28.22 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    quantidadeSanduiches = quantidadeSanduiches + quantidadeProdutos;
                }

                if (i == 12)
                {
                    produtos = produtos + "Pizza de Calabrea R$ 8,98 " + quantidadeProdutos + " unidade(s) \n";
                    total = total + 8.98 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    quantidadePizzas = quantidadePizzas + quantidadeProdutos;
                }

                if (i == 13)
                {
                    produtos = produtos + "Pizza Napolitana R$ 0,42 " + quantidadeProdutos + " unidade(s) \n";
                    total = total + 0.42 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    quantidadePizzas = quantidadePizzas + quantidadeProdutos;
                }

                if (i == 14)
                {
                    produtos = produtos + "Pizza Peruana R$ 18,36 " + quantidadeProdutos + " unidade(s) \n";
                    total = total + 18.36 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    quantidadePizzas = quantidadePizzas + quantidadeProdutos;
                }

                if (i == 15)
                {
                    produtos = produtos + "Pizza Portuguesa R$ 27,50 " + quantidadeProdutos + " unidade(s) \n";
                    total = total + 27.50 * quantidadeProdutos;
                    quantidadeTotalProdutos = quantidadeTotalProdutos + quantidadeProdutos;
                    quantidadePizzas = quantidadePizzas + quantidadeProdutos;
                }
            }

            Console.WriteLine(@"

LISTA DE PRODUTOS CONSUMIDOS");
            Console.Write(produtos);
            Console.WriteLine("VALOR TOTAL DA COMPRA: R$ " + total.ToString("F"));
            Console.WriteLine("Total de Bolos consumidos: " + quantidadeBolos);
            Console.WriteLine("Total de doces consumidos: " + quantidadeDoces);
            Console.WriteLine("Total de sanduíches consumidos: " + quantidadeSanduiches);
            Console.WriteLine("Total de pizzas consumidas: " + quantidadePizzas);
            Console.WriteLine("Total de produtos consumidos: " + quantidadeTotalProdutos);
            Console.WriteLine("O valor médio dos produtos foi de: R$ " + (total / quantidadeTotalProdutos).ToString("F"));

            Console.WriteLine();
        }
    }
}