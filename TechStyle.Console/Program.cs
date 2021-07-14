using System;
using TechStyle.Dominio.Modelo;
using TechStyle.Dominio.Repositorio;

namespace TechStyle.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             1 - para cadastrar categoria/sub
             2 - para cadastrar produtos
             3 - para vender produto
             */


            // digitou 1

            Console.WriteLine("Informe a categoria");
            var categoria = Console.ReadLine();

            Console.WriteLine("Informe a subcategoria");
            var subcategoria = Console.ReadLine();

            SegmentoRepositorio repoSeg = new SegmentoRepositorio();

            repoSeg.Incluir(categoria, subcategoria);
            repoSeg.Incluir("Masculino", "Social");
            repoSeg.Incluir("Infantil", "fantasias");
            repoSeg.Incluir("Feminino", "Social");
            repoSeg.Incluir("Feminino", "Saias");

            var lstSeg = repoSeg.SelecionarTudo();

            // ---------------------------------------------

            // digitou 2


            //Segmento seg = new Segmento();
            //seg.Cadastrar(2, "Calcados", "tenis");

            Console.WriteLine("Você deseja consultar o codigo da categoria/subcategoria ? s/n");
            var resposta = Console.ReadLine();
            if(resposta == "s")
            {
                var resultadoConsulta = repoSeg.SelecionarTudo();
                foreach (var item in resultadoConsulta)
                {
                    Console.WriteLine($"{item.Id} - {item.Categoria} / {item.Subcategoria}");
                }
            }

            Console.WriteLine("Informe o codigo desejado");
            var idSeg = int.Parse(Console.ReadLine());

            var segmento = repoSeg.SelecionarPorId(idSeg);

            Console.WriteLine($"{segmento.Id} - {segmento.Categoria} / {segmento.Subcategoria}");


            //Produto prod = new Produto();
            //prod.Cadastrar(10, "Kit de meias", "a1s5edf6a4", seg);



        }
    }
}
