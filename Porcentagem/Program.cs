using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porcentagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o nome de um produto");
            string NomeProduto = Console.ReadLine();

            Console.WriteLine("Entre com o preço do produto");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("entre com a porcentagem de desconto");
            double desconto = double.Parse(Console.ReadLine());


            double valorfinal = preco * (desconto / 100);
            Console.WriteLine(valorfinal);


            Console.ReadLine();


        }
    }
}
