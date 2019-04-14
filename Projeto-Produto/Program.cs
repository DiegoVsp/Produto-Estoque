using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto_Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Dados do Produto "+ p);

            Console.WriteLine("");
            Console.Write("Digite um número de produtos a ser adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qte);

            Console.WriteLine("");
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine("");
            Console.Write("Digite um número de produtos a ser removido no estoque: ");
             qte = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qte);

            Console.WriteLine("");
            Console.WriteLine("Dados Atualizados: " + p);



            Console.ReadKey();
        }
    }
}
