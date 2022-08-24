using System;

namespace TP01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Vendedores meusVendedores = new Vendedores();
            string nome;
            double perc;

            int id=0, op;
            int diaR;

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
                            Console.Write("Nome: ");
                            nome = Console.ReadLine();
                            Console.Write("Comissão de vendas: ");
                            perc = double.Parse(Console.ReadLine());
                            meusVendedores.addVendedor(new Vendedor(id,nome,perc,new Venda()));
                            break;
                        }
                    case 2:
                        {
                            int idPesquisa;
                            Console.Write("ID do vendedor: ");
                            idPesquisa = int.Parse(Console.ReadLine());

                            Console.WriteLine(meusVendedores.searchVendedor(new Vendedor(id)));
                            for (int i = 0; i <meusVendedores.OsVendedores[idPesquisa-1].AsVendas.Length; i++)
                            {
                               
                                if (meusVendedores.OsVendedores[idPesquisa-1].AsVendas[i].Qtde> 0)
                                {
                                    Console.WriteLine("Dia {0} - {1}",i+1,meusVendedores.OsVendedores[idPesquisa - 1].AsVendas[i].ToString());
                                }
                            }
                            
                            break;
                        }
                    case 3:
                        {
                            int idDel;
                            Console.Write("ID do vendedor: ");
                            idDel = int.Parse(Console.ReadLine());
                            if (meusVendedores.OsVendedores[idDel-1].valorVendas() > 0)
                            {
                                Console.WriteLine("Vendedor não pode ser excluído");
                            }
                            else
                            {
                                meusVendedores.delVendedor(new Vendedor(id));
                            }
                            break;
                        }
                    case 4:
                        {
                            int idr;
                            Venda venda = new Venda();
                           Console.Write("Digite o id do vendedor: ");
                            idr = int.Parse(Console.ReadLine());

                            Console.Write("Digite o dia da venda: ");
                            diaR = int.Parse(Console.ReadLine());

                            Console.Write("Vendas do dia: ");
                            venda.Qtde = int.Parse(Console.ReadLine());

                            Console.Write("Valor total de vendas: ");
                            venda.Valor = double.Parse(Console.ReadLine());

                            meusVendedores.OsVendedores[idr-1].registrarVenda(diaR, venda);

                            break;
                        }
                    case 5:
                        {
                            foreach (var vendedor in meusVendedores.OsVendedores)
                            {
                                if (vendedor.Id != 0)
                                {
                                    Console.WriteLine(vendedor.ToString());
                                }
                            }
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
