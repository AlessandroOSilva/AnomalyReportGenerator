using GeradorDeRelatoriosDeAnomalias.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorDeRelatoriosDeAnomalias.Entities
{
    class Relatorio
    {
        public DateTime Data { get; set; }
        public string Origem { get; set; }
        public string Processo { get; set; }
        public Problema Problema { get; set; }
        public string Relator { get; set; }
        public List<ProdutoAvaria> Avarias { get; set; } = new List<ProdutoAvaria>();

        public Relatorio()
        {

        }

        public Relatorio(DateTime data, string origem, string processo, Problema problema, string relator)
        {
            Data = data;
            Origem = origem;
            Processo = processo;
            Problema = problema;
            Relator = relator;
        }

        public void AdicionarProduto(ProdutoAvaria produto)
        {
            Avarias.Add(produto);
        }

        public void RemoverProduto(ProdutoAvaria produto)
        {
            Avarias.Remove(produto);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DADOS DO RELATÓRIO");
            sb.AppendLine("-------------------------");
            sb.AppendLine(Data + " " + Origem + " " + Processo + " " + Problema + " " + Processo.Substring(3) + " " + Relator);


            sb.AppendLine("DADOS DOS PRODUTOS");
            sb.AppendLine("-------------------------");
            sb.AppendLine("REF.   " + "SIGLA " + "  SIF" + "      FABRICAÇÃO " + "   VALIDADE " + "     QUANT. " + " PROBLEMA ");
            foreach (ProdutoAvaria prod in Avarias)
            {
                sb.Append(prod);
            }

            return sb.ToString();
        }
    }


}
