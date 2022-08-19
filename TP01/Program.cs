using System;

namespace TP01
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();
            Venda v = new Venda(4, 120);
            vendedor.registrarVenda(1, v);
            Console.WriteLine(vendedor.valorVendas());
            Console.WriteLine(vendedor.valorComissao());
            Console.ReadKey();
        }
    }
}
