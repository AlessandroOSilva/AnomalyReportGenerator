using GeradorDeRelatoriosDeAnomalias.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorDeRelatoriosDeAnomalias.Entities
{
    class ProdutoAvaria : Produto
    {
        public Problema Problema { get; set; }
        public List<Foto> Fotos { get; set; } = new List<Foto>();
        public int Quantidade { get; set; }

        public ProdutoAvaria()
        {

        }

        public ProdutoAvaria(int reference, string sigla, DateTime fab, DateTime val, int sif, Problema problema, int quantidade) : base(reference, sigla, fab, val, sif)
        {
            Problema = problema;
            Quantidade = quantidade;
        }

        public void AdicionarFotos(Foto foto)
        {
            Fotos.Add(foto);
        }

        public void RemoverFotos(Foto foto)
        {
            Fotos.Add(foto);
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Referencia + "  " + Sigla + "   " + Sif + "    " + Fab.ToString("  dd/MM/yyyy ") + Val.ToString("   dd/MM/yyyy      ") + Quantidade+ "       " + Problema);

            return sb.ToString();

        }
    }
}
