using System;

namespace TP01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Vendedores meusVendedores = new Vendedores();
            meusVendedores.addVendedor(new Vendedor(1, 1, "Lola", 0.10, new Venda(1,100)));
            meusVendedores.addVendedor(new Vendedor(2, 1, "Lol", 0.10, new Venda(0,0)));
            Console.WriteLine(meusVendedores.mostrar());
            Console.WriteLine(meusVendedores.delVendedor(new Vendedor(2, 1, "Lol", 0.10, new Venda())));
            Console.WriteLine("Valor vendas: {0}", meusVendedores.valorVendas());
            Console.WriteLine(meusVendedores.mostrar());
            Console.WriteLine(meusVendedores.Qtde);
            Console.ReadKey();
        }
    }
}
