using System;

namespace Aula53Exercicio01
{
    internal class Program
    {
        public class Compra
        {
            public bool isClienteVip { get;  set; }
            //public Produto[] produtosComprados { get;  set; }
            public double ValorProduto { get; set; }
           public DateTime dtCompra {get; set;}

         
        }
 

        static void Main(string[] args)
        {
            Compra cliente1 = new Compra();

            Console.Write("Qual o valor do produto comprado: ");
            cliente1.ValorProduto = double.Parse(Console.ReadLine());

            Console.Write("É um cliente vip? (S / N) ");
            string vip = Console.ReadLine();
           
            if(vip.Equals("s", StringComparison.CurrentCultureIgnoreCase))
            {
                cliente1.isClienteVip = true;
            }
            else
            {
                cliente1.isClienteVip = false;
            }

            Console.Write("Informe a data da compra (dd/mm/aaaa): ");
            string dataCompra = Console.ReadLine();
            DateTime dataCompraConvertida;
            DateTime.TryParse(dataCompra, out dataCompraConvertida);
            cliente1.dtCompra = dataCompraConvertida;

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Compra realizada no dia {cliente1.dtCompra:d}");
            
            if (cliente1.isClienteVip)
            {
                Console.WriteLine("No valor de R$" + cliente1.ValorProduto * 0.85);
                Console.WriteLine($"Com desconto de R${cliente1.ValorProduto - (cliente1.ValorProduto* 0.85)}, pois este é um cliente  vip");
            } else
            {
                Console.WriteLine("O valor do produto é R$" + cliente1.ValorProduto);
            }
            

        }
    }
}
