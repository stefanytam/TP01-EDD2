using System;

namespace TP01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Vendedores meusVendedores = new Vendedores(5);
            meusVendedores.addVendedor(new Vendedor(1, 1, "Lola", 0.10, new Venda(1,100)));
            Console.WriteLine(meusVendedores.mostrar());
            Console.WriteLine("Valor vendas: {0}", meusVendedores.valorVendas());
            Console.WriteLine("Valor comissão: {0}", meusVendedores.valorComissao());
            Console.ReadKey();
        }
    }
}
