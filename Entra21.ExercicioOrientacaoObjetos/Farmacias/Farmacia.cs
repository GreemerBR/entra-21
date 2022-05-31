using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioOrientacaoObjetos.Farmacias
{
    public class Farmacia
    {
        public string RazaoSocial;
        public int Cnpj;
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
                if (CategoriaProduto[i] == "analgésicos" || CategoriaProduto[i] == "analgesicos")
                {
                    totalAnalgesicos = totalAnalgesicos + PrecoProduto[i];
                }

                if (CategoriaProduto[i] == "antibiótico" || CategoriaProduto[i] == "antibiotico")
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

                if (CategoriaProduto[i] == "antiepilépticos" || CategoriaProduto[i] == "antiepilepticos")
                {
                    totalAntiepilepticos = totalAntiepilepticos + PrecoProduto[i];
                }

                if (CategoriaProduto[i] == "antiepilépticos" || CategoriaProduto[i] == "antiepilepticos")
                {
                    totalAntiepilepticos = totalAntiepilepticos + PrecoProduto[i];
                }

                if (CategoriaProduto[i] == "anti psicóticos" || CategoriaProduto[i] == "anti psicoticos")
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

                if (CategoriaProduto[i] == "anti inflamatórios não esteroidais" || CategoriaProduto[i] == "anti inflamatorios não esteroidais"
                    || CategoriaProduto[i] == "anti inflamatorios nao esteroidais" || CategoriaProduto[i] == "anti inflamatórios nao esteroidais")
                {
                    totalAntiInflamatoriosNaoEsteroidais = totalAntiInflamatoriosNaoEsteroidais + PrecoProduto[i];
                }

                if (CategoriaProduto[i] == "anti inflamatórios esteroidais" || CategoriaProduto[i] == "anti inflamatorios esteroidais")
                {
                    totalAntiInflamatoriosEsteroidais = totalAntiInflamatoriosEsteroidais + PrecoProduto[i];
                }

                if (CategoriaProduto[i] == "droga anti reumática modificadora de doença" || CategoriaProduto[i] == "droga anti reumatica modificadora de doença")
                {
                    totalDrogaAntiReumaticaModificadoraDeDoenca = totalDrogaAntiReumaticaModificadoraDeDoenca + PrecoProduto[i];
                }
            }          

            if (totalAnalgesicos != 0.0)
            {
                return $"* Total Analgésicos: R${totalAnalgesicos.ToString("F")}\n";
            }

            if (totalAntibioticos != 0.0)
            {
                return $"* Total Antibióticos: R${totalAntibioticos.ToString("F")}\n";
            }

            if (totalAnticoagulantes != 0.0)
            {
                return $"* Total Anticoagulantes: R${totalAnticoagulantes.ToString("F")}\n";
            }

            if (totalAntidepressivos != 0.0)
            {
                return $"* Total Antidmmepressivos: R${totalAntidepressivos.ToString("F")}\n";
            }

            if (totalAnticancerosos != 0.0)
            {
                return $"* Total Anticancerosos: R${totalAnticancerosos.ToString("F")}\n";
            }

            if (totalAntiepilepticos != 0.0)
            {
                return $"* Total Antiepiléticos: R${totalAntiepilepticos.ToString("F")}\n";
            }

            if (totalAntiPsicoticos != 0.0)
            {
                return $"* Total Anti Psicóticos: R${totalAntiPsicoticos.ToString("F")}\n";
            }

            if (totalAntivirais != 0.0)
            {
                return $"* Total Antivirais: R${totalAntivirais.ToString("F")}\n";
            }

            if (totalSedativos != 0.0)
            {
                return $"* Total Sedativos: R${totalSedativos.ToString("F")}\n";
            }

            if (totalAntiInflamatoriosNaoEsteroidais != 0.0)
            {
                return $"* Total Anti Inflamatórios Não Esteroidais: R${totalAntiInflamatoriosNaoEsteroidais.ToString("F")}\n";
            }

            if (totalAntiInflamatoriosEsteroidais != 0.0)
            {
                return $"* Total Anti Inflamatórios Esteroidais: R${totalAntiInflamatoriosEsteroidais.ToString("F")}\n";
            }

            if (totalDrogaAntiReumaticaModificadoraDeDoenca != 0.0)
            {
                return $"* Total Droga Anti Reumática Modificadora de Doença: R${totalDrogaAntiReumaticaModificadoraDeDoenca.ToString("F")}";
            }

            return $"";
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
                if (CategoriaProduto[i] == "analgésicos" || CategoriaProduto[i] == "analgesicos")
                {
                    totalAnalgesicos = totalAnalgesicos + 1;
                }

                if (CategoriaProduto[i] == "antibiótico" || CategoriaProduto[i] == "antibiotico")
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

                if (CategoriaProduto[i] == "antiepilépticos" || CategoriaProduto[i] == "antiepilepticos")
                {
                    totalAntiepilepticos = totalAntiepilepticos + 1;
                }

                if (CategoriaProduto[i] == "antiepilépticos" || CategoriaProduto[i] == "antiepilepticos")
                {
                    totalAntiepilepticos = totalAntiepilepticos + 1;
                }

                if (CategoriaProduto[i] == "anti psicóticos" || CategoriaProduto[i] == "anti psicoticos")
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

                if (CategoriaProduto[i] == "anti inflamatórios não esteroidais" || CategoriaProduto[i] == "anti inflamatorios não esteroidais"
                    || CategoriaProduto[i] == "anti inflamatorios nao esteroidais" || CategoriaProduto[i] == "anti inflamatórios nao esteroidais")
                {
                    totalAntiInflamatoriosNaoEsteroidais = totalAntiInflamatoriosNaoEsteroidais + 1;
                }

                if (CategoriaProduto[i] == "anti inflamatórios esteroidais" || CategoriaProduto[i] == "anti inflamatorios esteroidais")
                {
                    totalAntiInflamatoriosEsteroidais = totalAntiInflamatoriosEsteroidais + 1;
                }

                if (CategoriaProduto[i] == "droga anti reumática modificadora de doença" || CategoriaProduto[i] == "droga anti reumatica modificadora de doença")
                {
                    totalDrogaAntiReumaticaModificadoraDeDoenca = totalDrogaAntiReumaticaModificadoraDeDoenca + 1;
                }
            }

            if (totalAnalgesicos != 0)
            {
                return $"* Total de Analgésicos: {totalAnalgesicos} unidade(s)\n";
            }

            if (totalAntibioticos != 0)
            {
                return $"* Total de Antibióticos: {totalAntibioticos} unidade(s)\n";
            }

            if (totalAnticoagulantes != 0)
            {
                return $"* Total de Anticoagulantes: {totalAnticoagulantes} unidade(s)\n";
            }

            if (totalAntidepressivos != 0)
            {
                return $"* Total de Antidepressivos: {totalAntidepressivos} unidade(s)\n";
            }

            if (totalAnticancerosos != 0)
            {
                return $"* Total de Anticancerosos: {totalAnticancerosos} unidade(s)\n";
            }

            if (totalAntiepilepticos != 0)
            {
                return $"* Total de Antiepiléticos: {totalAntiepilepticos} unidade(s)\n";
            }

            if (totalAntiPsicoticos != 0)
            {
                return $"* Total de Anti Psicóticos: {totalAntiPsicoticos} unidade(s)\n";
            }

            if (totalAntivirais != 0)
            {
                return $"* Total de Antivirais: {totalAntivirais} unidade(s)\n";
            }

            if (totalSedativos != 0)
            {
                return $"* Total de Sedativos: {totalSedativos} unidade(s)\n";
            }

            if (totalAntiInflamatoriosNaoEsteroidais != 0)
            {
                return $"* Total de Anti Inflamatórios Não Esteroidais: {totalAntiInflamatoriosNaoEsteroidais} unidade(s)\n";
            }

            if (totalAntiInflamatoriosEsteroidais != 0)
            {
                return $"* Total de Anti Inflamatórios Esteroidais: {totalAntiInflamatoriosEsteroidais} unidade(s)\n";
            }

            if (totalDrogaAntiReumaticaModificadoraDeDoenca != 0)
            {
                return $"* Total de Droga Anti Reumática Modificadora de Doença: {totalDrogaAntiReumaticaModificadoraDeDoenca} unidade(s)";
            }

            return $"";
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
            }

            return $"O produto mais caro do pedido é o {produtoMaisCaro} e ele custa R${maiorValor}.";
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
            }

            return $"O produto mais barato do pedido é o {produtoMaisBarato} e ele é da categoria {categoriaMaisBarato}.";
        }
    }
}
