using GeradorDeRelatoriosDeAnomalias.Entities;
using GeradorDeRelatoriosDeAnomalias.Entities.Enums;
using System;
using System.IO;

namespace GeradorDeRelatoriosDeAnomalias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DADOS DO RELATÓRIO");
            Console.WriteLine("---------------------------------");
            Console.Write("Digite a origem: ");
            string origem = Console.ReadLine();
            
            Console.Write("Número do processo: ");
            string processo = Console.ReadLine();

            Console.Write("Nome do relator: ");
            string relator = Console.ReadLine();

            Console.Write("Problema dos produtos: ");
            Problema problema = Enum.Parse<Problema>(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("DADOS DO PRODUTO");
            Console.WriteLine("--------------------------------------");

            Relatorio rel = new Relatorio(DateTime.Now, origem, processo, problema, relator);

            char op;
             
            do {
                Console.Write("Referencia: ");
                int refe = int.Parse(Console.ReadLine());
                Console.Write("Sigla: ");
                string sigla = Console.ReadLine();
                Console.Write("SIF: ");
                int sif = int.Parse(Console.ReadLine());
                Console.Write("Fabricação (dd/MM/aaaa): ");
                DateTime fab = DateTime.Parse(Console.ReadLine());
                Console.Write("Validade (dd/MM/aaaa): ");
                DateTime val = DateTime.Parse(Console.ReadLine());
                Console.Write("Quantidade: ");
                int quant = int.Parse(Console.ReadLine());           

                ProdutoAvaria pa = new ProdutoAvaria(refe, sigla, fab, val, sif, problema, quant);

                rel.Avarias.Add(pa);

                Console.WriteLine("Deseja Continuar? (S/N)");
                op = char.Parse(Console.ReadLine());

            } while (op == 's' || op == 'S');
            Console.Clear();
            

            Console.WriteLine();
            Console.WriteLine(rel);

            RelatorioParaTriagem rt = new RelatorioParaTriagem(path, DateTime.Now, origem, processo, problema, relator);

            rt.GerarRelatorio(rt.Path);
        }
    }
}
