using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorDeRelatoriosDeAnomalias.Entities
{
    class Foto
    {
        public DateTime Data { get; set; }
        public int NumeroFoto { get; set; }

        public Foto()
        {

        }
        public Foto(DateTime data, int numeroFoto)
        {
            Data = data;
            NumeroFoto = numeroFoto;
        }
    }
}
