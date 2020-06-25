using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorDeRelatoriosDeAnomalias.Entities
{
    class Produto
    {
        public int Referencia{ get; set; }
        public string Sigla { get; set; }
        public DateTime Fab { get; set; }
        public DateTime Val { get; set; }
        public int Sif { get; set; }

        public Produto()
        {

        }

        public Produto(int reference, string sigla, DateTime fab, DateTime val, int sif)
        {
            Referencia = reference;
            Sigla = sigla;
            Fab = fab;
            Val = val;
            Sif = sif;
        }
    }
}
