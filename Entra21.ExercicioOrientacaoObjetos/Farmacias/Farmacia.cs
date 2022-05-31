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
            //var totalAntiInflamatóriosEsteroidais = 0.0;
            //var totalDrogaAntiReumáticaModificadoraDDoença = 0.0;

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
                
            }            

                return $"";
        }
    }
}
