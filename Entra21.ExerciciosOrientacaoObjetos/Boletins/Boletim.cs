using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Boletins
{
    public class Boletim
    {
        public double[] NotasMatematica = new double[3];
        public double[] NotasPortugues = new double[3];
        public double[] NotasFisica = new double[3];
        public double[] NotasQuimica = new double[3];
        public double[] NotasGeografia = new double[3];
        public double[] NotasHistoria = new double[3];
        public double[] NotasFilosofia = new double[3];
        public double[] NotasSociologia = new double[3];
        public double[] NotasBiologia = new double[3];
        public int QuantidadeDiasLetivos, QuantidadePresencas;

        public double CalcularMediaMatematica()
        {
            var somaNotasMatematica = 0.0;

            for (var i = 0; i < 3; i++)
            {
                somaNotasMatematica = somaNotasMatematica + NotasMatematica[i];
            }

            var mediaMatematica = somaNotasMatematica / 3;

            return mediaMatematica;
        }

        public double CalcularMediaPortugues()
        {
            var somaNotasPortugues = 0.0;

            for (var i = 0; i < 3; i++)
            {
                somaNotasPortugues = somaNotasPortugues + NotasPortugues[i];
            }

            var mediaPortugues = somaNotasPortugues / 3;

            return mediaPortugues;
        }

        public double CalcularMediaFisica()
        {
            var somaNotasFisica = 0.0;

            for (var i = 0; i < 3; i++)
            {
                somaNotasFisica = somaNotasFisica + NotasFisica[i];
            }

            var mediaFisica = somaNotasFisica / 3;

            return mediaFisica;
        }

        public double CalcularMediaQuimica()
        {
            var somaNotasQuimica = 0.0;

            for (var i = 0; i < 3; i++)
            {
                somaNotasQuimica = somaNotasQuimica + NotasQuimica[i];
            }

            var mediaQuimica = somaNotasQuimica / 3;

            return mediaQuimica;
        }

        public double CalcularMediaGeografia()
        {
            var somaNotasGeografia = 0.0;

            for (var i = 0; i < 3; i++)
            {
                somaNotasGeografia = somaNotasGeografia + NotasGeografia[i];
            }

            var mediaGeografia = somaNotasGeografia / 3;

            return mediaGeografia;
        }

        public double CalcularMediaHistoria()
        {
            var somaNotasHistoria = 0.0;

            for (var i = 0; i < 3; i++)
            {
                somaNotasHistoria = somaNotasHistoria + NotasHistoria[i];
            }

            var mediaHistoria = somaNotasHistoria / 3;

            return mediaHistoria;
        }

        public double CalcularMediaFilosofia()
        {
            var somaNotasFilosofia = 0.0;

            for (var i = 0; i < 3; i++)
            {
                somaNotasFilosofia = somaNotasFilosofia + NotasFilosofia[i];
            }

            var mediaFilosofia = somaNotasFilosofia / 3;

            return mediaFilosofia;
        }

        public double CalcularMediaSociologia()
        {
            var somaNotasSociologia = 0.0;

            for (var i = 0; i < 3; i++)
            {
                somaNotasSociologia = somaNotasSociologia + NotasSociologia[i];
            }

            var mediaSociologia = somaNotasSociologia / 3;

            return mediaSociologia;
        }

        public double CalcularMediaBiologia()
        {
            var somaNotasBiologia = 0.0;

            for (var i = 0; i < 3; i++)
            {
                somaNotasBiologia = somaNotasBiologia + NotasBiologia[i];
            }

            var mediaBiologia = somaNotasBiologia / 3;

            return mediaBiologia;
        }

        public int CalcularQuantidadeDeFaltas()
        {
            var quantidadeDeFaltas = QuantidadeDiasLetivos - QuantidadePresencas;

            return quantidadeDeFaltas;
        }

        public double CalcularPercentualDePresencas()
        {
            var percentualDePresencas = QuantidadePresencas * 100 / QuantidadeDiasLetivos;

            return percentualDePresencas;
        }

        public double CalcularPercentualDeFaltas()
        {
            var quantidadeDeFaltas = CalcularQuantidadeDeFaltas();
            var percentualDeFaltas = quantidadeDeFaltas * 100 / QuantidadeDiasLetivos;

            return percentualDeFaltas;
        }

        public double CalcularMediaGeral()
        {
            var mediaMatematica = CalcularMediaMatematica();
            var mediaPortugues = CalcularMediaPortugues();
            var mediaFisica = CalcularMediaFisica();
            var mediaQuimica = CalcularMediaQuimica();
            var mediaGeografia = CalcularMediaMatematica();
            var mediaHistoria = CalcularMediaHistoria();
            var mediaFilosofia = CalcularMediaFilosofia();
            var mediaSociologia = CalcularMediaSociologia();
            var mediaBiologia = CalcularMediaBiologia();

            var mediaGeral = (mediaMatematica + mediaPortugues + mediaFisica + mediaQuimica + mediaGeografia +
                mediaHistoria + mediaFilosofia + mediaSociologia + mediaBiologia) / 9;

            return mediaGeral;
        }


    }
}