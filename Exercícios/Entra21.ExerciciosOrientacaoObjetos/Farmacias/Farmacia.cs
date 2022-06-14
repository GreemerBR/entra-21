using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Farmacias
{
    public class Farmacia
    {
        public string RazaoSocial;
        public long Cnpj;
        public string[] NomeProduto = new string[3];
        public double[] PrecoProduto = new double[3];
        public string[] CategoriaProduto = new string[3];

        public string ApresentarTotalDoPedido()
        {
            var totalDoPedido = 0.0;
            for (var i = 0; i < 3; i++)
            {
                totalDoPedido = totalDoPedido + PrecoProduto[i];
            }
            return $"O valor total do pedido foi de R${totalDoPedido.ToString("F")}.";
        }

        public string ApresentarTotalDoPedidoPorCategoriaDeProduto()
        {
            var totalAnalgesicos = 0.0;
            var totalAntibioticos = 0.0;
            var totalAnticoagulantes = 0.0;
            var totalAntidepressivos = 0.0;
            var totalAnticancerosos = 0.0;
            var totalAntiepilepticos = 0.0;
            var totalAntiPsicoticos = 0.0;
            var totalAntivirais = 0.0;
            var totalSedativos = 0.0;
            var totalAntiInflamatoriosNaoEsteroidais = 0.0;
            var totalAntiInflamatoriosEsteroidais = 0.0;
            var totalDrogaAntiReumaticaModificadoraDeDoenca = 0.0;

            for (var i = 0; i < 3; i++)
            {
                if (CategoriaProduto[i] == "analgésicos")
                {
                    totalAnalgesicos = totalAnalgesicos + PrecoProduto[i];
                }

                if (CategoriaProduto[i] == "antibióticos")
                {
                    totalAntibioticos = totalAntibioticos + PrecoProduto[i];
                }

                if (CategoriaProduto[i] == "anticoagulantes")
                {
                    totalAnticoagulantes = totalAnticoagulantes + PrecoProduto[i];
                }

                if (CategoriaProduto[i] == "antidepressivos")
                {
                    totalAntidepressivos = totalAntidepressivos + PrecoProduto[i];
                }

                if (CategoriaProduto[i] == "anticancerosos")
                {
                    totalAnticancerosos = totalAnticancerosos + PrecoProduto[i];
                }

                if (CategoriaProduto[i] == "antiepilépticos")
                {
                    totalAntiepilepticos = totalAntiepilepticos + PrecoProduto[i];
                }

                if (CategoriaProduto[i] == "anti psicóticos")
                {
                    totalAntiPsicoticos = totalAntiPsicoticos + PrecoProduto[i];
                }

                if (CategoriaProduto[i] == "antivirais")
                {
                    totalAntivirais = totalAntivirais + PrecoProduto[i];
                }

                if (CategoriaProduto[i] == "sedativos")
                {
                    totalSedativos = totalSedativos + PrecoProduto[i];
                }

                if (CategoriaProduto[i] == "anti inflamatórios não esteroidais")
                {
                    totalAntiInflamatoriosNaoEsteroidais = totalAntiInflamatoriosNaoEsteroidais + PrecoProduto[i];
                }

                if (CategoriaProduto[i] == "anti inflamatórios esteroidais")
                {
                    totalAntiInflamatoriosEsteroidais = totalAntiInflamatoriosEsteroidais + PrecoProduto[i];
                }

                if (CategoriaProduto[i] == "droga anti reumática modificadora de doença")
                {
                    totalDrogaAntiReumaticaModificadoraDeDoenca = totalDrogaAntiReumaticaModificadoraDeDoenca + PrecoProduto[i];
                }
            }

            var textoSaida = "";

            if (totalAnalgesicos != 0.0)
            {
                textoSaida = textoSaida + $"* Total Analgésicos: R${totalAnalgesicos.ToString("F")}\n";
            }

            if (totalAntibioticos != 0.0)
            {
                textoSaida = textoSaida + $"* Total Antibióticos: R${totalAntibioticos.ToString("F")}\n";
            }

            if (totalAnticoagulantes != 0.0)
            {
                textoSaida = textoSaida + $"* Total Anticoagulantes: R${totalAnticoagulantes.ToString("F")}\n";
            }

            if (totalAntidepressivos != 0.0)
            {
                textoSaida = textoSaida + $"* Total Antidepressivos: R${totalAntidepressivos.ToString("F")}\n";
            }

            if (totalAnticancerosos != 0.0)
            {
                textoSaida = textoSaida + $"* Total Anticancerosos: R${totalAnticancerosos.ToString("F")}\n";
            }

            if (totalAntiepilepticos != 0.0)
            {
                textoSaida = textoSaida + $"* Total Antiepiléticos: R${totalAntiepilepticos.ToString("F")}\n";
            }

            if (totalAntiPsicoticos != 0.0)
            {
                textoSaida = textoSaida + $"* Total Anti Psicóticos: R${totalAntiPsicoticos.ToString("F")}\n";
            }

            if (totalAntivirais != 0.0)
            {
                textoSaida = textoSaida + $"* Total Antivirais: R${totalAntivirais.ToString("F")}\n";
            }

            if (totalSedativos != 0.0)
            {
                textoSaida = textoSaida + $"* Total Sedativos: R${totalSedativos.ToString("F")}\n";
            }

            if (totalAntiInflamatoriosNaoEsteroidais != 0.0)
            {
                textoSaida = textoSaida + $"* Total Anti Inflamatórios Não Esteroidais: R${totalAntiInflamatoriosNaoEsteroidais.ToString("F")}\n";
            }

            if (totalAntiInflamatoriosEsteroidais != 0.0)
            {
                textoSaida = textoSaida + $"* Total Anti Inflamatórios Esteroidais: R${totalAntiInflamatoriosEsteroidais.ToString("F")}\n";
            }

            if (totalDrogaAntiReumaticaModificadoraDeDoenca != 0.0)
            {
                textoSaida = textoSaida + $"* Total Droga Anti Reumática Modificadora de Doença: R${totalDrogaAntiReumaticaModificadoraDeDoenca.ToString("F")}";
            }

            return textoSaida;
        }

        public string ApresentarQuantidadePorCategoria()
        {
            var totalAnalgesicos = 0;
            var totalAntibioticos = 0;
            var totalAnticoagulantes = 0;
            var totalAntidepressivos = 0;
            var totalAnticancerosos = 0;
            var totalAntiepilepticos = 0;
            var totalAntiPsicoticos = 0;
            var totalAntivirais = 0;
            var totalSedativos = 0;
            var totalAntiInflamatoriosNaoEsteroidais = 0;
            var totalAntiInflamatoriosEsteroidais = 0;
            var totalDrogaAntiReumaticaModificadoraDeDoenca = 0;

            for (var i = 0; i < 3; i++)
            {
                if (CategoriaProduto[i] == "analgésicos")
                {
                    totalAnalgesicos = totalAnalgesicos + 1;
                }

                if (CategoriaProduto[i] == "antibióticos")
                {
                    totalAntibioticos = totalAntibioticos + 1;
                }

                if (CategoriaProduto[i] == "anticoagulantes")
                {
                    totalAnticoagulantes = totalAnticoagulantes + 1;
                }

                if (CategoriaProduto[i] == "antidepressivos")
                {
                    totalAntidepressivos = totalAntidepressivos + 1;
                }

                if (CategoriaProduto[i] == "anticancerosos")
                {
                    totalAnticancerosos = totalAnticancerosos + 1;
                }

                if (CategoriaProduto[i] == "antiepilépticos")
                {
                    totalAntiepilepticos = totalAntiepilepticos + 1;
                }

                if (CategoriaProduto[i] == "anti psicóticos")
                {
                    totalAntiPsicoticos = totalAntiPsicoticos + 1;
                }

                if (CategoriaProduto[i] == "antivirais")
                {
                    totalAntivirais = totalAntivirais + 1;
                }

                if (CategoriaProduto[i] == "sedativos")
                {
                    totalSedativos = totalSedativos + 1;
                }

                if (CategoriaProduto[i] == "anti inflamatórios não esteroidais")
                { 
                    totalAntiInflamatoriosNaoEsteroidais = totalAntiInflamatoriosNaoEsteroidais + 1;
                }

                if (CategoriaProduto[i] == "anti inflamatórios esteroidais")
                {
                    totalAntiInflamatoriosEsteroidais = totalAntiInflamatoriosEsteroidais + 1;
                }

                if (CategoriaProduto[i] == "droga anti reumática modificadora de doença")
                {
                    totalDrogaAntiReumaticaModificadoraDeDoenca = totalDrogaAntiReumaticaModificadoraDeDoenca + 1;
                }
            }
            var textoSaida = "";

            if (totalAnalgesicos != 0)
            {
                textoSaida = textoSaida + $"* Total de Analgésicos: {totalAnalgesicos} unidade(s)\n";
            }

            if (totalAntibioticos != 0)
            {
                textoSaida = textoSaida + $"* Total de Antibióticos: {totalAntibioticos} unidade(s)\n";
            }

            if (totalAnticoagulantes != 0)
            {
                textoSaida = textoSaida + $"* Total de Anticoagulantes: {totalAnticoagulantes} unidade(s)\n";
            }

            if (totalAntidepressivos != 0)
            {
                textoSaida = textoSaida + $"* Total de Antidepressivos: {totalAntidepressivos} unidade(s)\n";
            }

            if (totalAnticancerosos != 0)
            {
                textoSaida = textoSaida + $"* Total de Anticancerosos: {totalAnticancerosos} unidade(s)\n";
            }

            if (totalAntiepilepticos != 0)
            {
                textoSaida = textoSaida + $"* Total de Antiepiléticos: {totalAntiepilepticos} unidade(s)\n";
            }

            if (totalAntiPsicoticos != 0)
            {
                textoSaida = textoSaida + $"* Total de Anti Psicóticos: {totalAntiPsicoticos} unidade(s)\n";
            }

            if (totalAntivirais != 0)
            {
                textoSaida = textoSaida + $"* Total de Antivirais: {totalAntivirais} unidade(s)\n";
            }

            if (totalSedativos != 0)
            {
                textoSaida = textoSaida + $"* Total de Sedativos: {totalSedativos} unidade(s)\n";
            }

            if (totalAntiInflamatoriosNaoEsteroidais != 0)
            {
                textoSaida = textoSaida + $"* Total de Anti Inflamatórios Não Esteroidais: {totalAntiInflamatoriosNaoEsteroidais} unidade(s)\n";
            }

            if (totalAntiInflamatoriosEsteroidais != 0)
            {
                textoSaida = textoSaida + $"* Total de Anti Inflamatórios Esteroidais: {totalAntiInflamatoriosEsteroidais} unidade(s)\n";
            }

            if (totalDrogaAntiReumaticaModificadoraDeDoenca != 0)
            {
                textoSaida = textoSaida + $"* Total de Droga Anti Reumática Modificadora de Doença: {totalDrogaAntiReumaticaModificadoraDeDoenca} unidade(s)";
            }

            return textoSaida;
        }

        public string ApresentarNomeProdutoMaisCaro()
        {
            var maiorValor = double.MinValue;
            var produtoMaisCaro = "";

            for (var i = 0; i < 3; i++)
            {
                if (PrecoProduto[i] > maiorValor)
                {
                    maiorValor = PrecoProduto[i];
                    produtoMaisCaro = NomeProduto[i];
                }
                else if (PrecoProduto[i] == maiorValor)
                {
                    maiorValor = PrecoProduto[i];
                    produtoMaisCaro = produtoMaisCaro + " / " + NomeProduto[i];
                }
            }

            return $"O(s) produto(s) mais caro(s) do pedido é(são): {produtoMaisCaro}, e ele(s) custa(m) R${maiorValor.ToString("F")}.";
        }

        public string ApresentarNomeCategoriaProdutoMaisBarato()
        {
            var menorValor = double.MaxValue;
            var produtoMaisBarato = "";
            var categoriaMaisBarato = "";

            for (var i = 0; i < 3; i++)
            {
                if (PrecoProduto[i] < menorValor)
                {
                    menorValor = PrecoProduto[i];
                    produtoMaisBarato = NomeProduto[i];
                    categoriaMaisBarato = CategoriaProduto[i];
                }
                else if (PrecoProduto[i] == menorValor)
                {
                    menorValor = PrecoProduto[i];
                    produtoMaisBarato = produtoMaisBarato + " / " + NomeProduto[i];
                    categoriaMaisBarato = categoriaMaisBarato + " / " + CategoriaProduto[i];
                }
            }

            return $"O(s) produto(s) mais barato(s) do pedido é(são): {produtoMaisBarato}, e ele(s) é(são) da(s) categoria(s) {categoriaMaisBarato}.";
        }
    }