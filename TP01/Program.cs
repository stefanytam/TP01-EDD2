using System;

namespace TP01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Vendedores meusVendedores = new Vendedores();
            string nome;
            int qtd;
            double valor, perc;

            int id=0, op;
            int diaR,qtdR;

            do
            {
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Cadastrar vendedor");
                Console.WriteLine("2 - Pesquisar vendedor");
                Console.WriteLine("3 - Excluir vendedor");
                Console.WriteLine("4 - Registrar venda"); 
                Console.WriteLine("5 - Listar vendedores");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        {
                            Console.ReadKey();
                            break;
                        }
                    case 1:
                        {
                            id++;
                            Console.WriteLine("Nome: ");
                            nome = Console.ReadLine();
                            Console.WriteLine("Quantidade de vendas: ");
                            qtd = int.Parse(Console.ReadLine());
                            Console.WriteLine("Valor de vendas: ");
                            valor = double.Parse(Console.ReadLine());
                            Console.WriteLine("Comissão de vendas: ");
                            perc = double.Parse(Console.ReadLine());
                            meusVendedores.addVendedor(new Vendedor(id,nome,perc,new Venda(qtd,valor)));
                            break;
                        }
                    case 2:
                        {
                            int idPesquisa;
                            Console.WriteLine("ID do vendedor: ");
                            idPesquisa=int.Parse(Console.ReadLine());
                            Console.WriteLine(meusVendedores.searchVendedor(new Vendedor(id)));
                           
                            break;
                        }
                    case 3:
                        {
                            int idDel;
                            Console.WriteLine("ID do vendedor: ");
                            idDel = int.Parse(Console.ReadLine());
                            meusVendedores.delVendedor(new Vendedor(id));
                            break;
                        }
                    case 4:
                        {
                            int idR;
                            Console.WriteLine("ID do vendedor: ");
                            idR = int.Parse(Console.ReadLine());
                            Console.WriteLine("Quantidade: ");
                            qtdR = int.Parse(Console.ReadLine());
                            Console.WriteLine("Dia");
                            diaR = int.Parse(Console.ReadLine());
                            Venda ve = meusVendedores.OsVendedores[idR].AsVendas[idR];
                            meusVendedores.OsVendedores[idR].registrarVenda(diaR, ve);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine(meusVendedores.mostrar());
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opção inválida!");
                            break;
                        }
                }
            } while (op != 0);

        }
    }
}
