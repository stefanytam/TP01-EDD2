using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class Vendedor
    {
        private int id, qtde;
        private string nome;
        private double percComissao;
        private Venda[] asVendas =new Venda[31];

        public int Id { get => id; set => id = value; }
        public int Qtde { get => qtde; set => qtde = value; }
        public string Nome { get => nome; set => nome = value; }
        public double PercComissao { get => percComissao; set => percComissao = value; }
        public Venda[] AsVendas { get => asVendas; set => asVendas = value; }

        public Vendedor(int id,  string nome, double percComissao,  Venda v)
        {
            this.id = id;
            this.nome = nome;
            this.percComissao = percComissao;
            for (int i = 0; i < 31; ++i)
            {
               
                asVendas[i] = v;
                this.qtde = asVendas[i].Qtde;
            }
        }
        public Vendedor (int id) 
        {
            this.id = id;
        }

        public Vendedor()
        {
            this.id = 0;
            this.nome = "";
            this.percComissao = 0.10;
            asVendas = new Venda[31];
            for (int i = 0; i < 31; ++i)
            {

                asVendas[i] = new Venda();
                qtde = asVendas[i].Qtde;
            }
        }
    


        public void registrarVenda(int dia, Venda venda)
        {
            if (this.qtde < 31)
            {
                this.asVendas[this.qtde] = venda;
                this.qtde++;
            }
            else
            {
                Console.WriteLine("Quantidade máxima de vendas registradas atingida!");
            }
        }
        public double valorVendas()
        {
            double vlr = 0;
            for(int i = 0; i < 31; i++)
            {
                vlr = asVendas[i].Valor * this.qtde;
            }
            return vlr;
        }

        public double valorComissao()
        {
            double comissao = 0;
            for (int i = 0; i < 31; i++)
            {
                comissao = percComissao * asVendas[i].Valor;
            }
            return comissao;
        }

        public override string ToString()
        {
            return this.id.ToString() + " - " + this.nome + '\n';
        }

        public override bool Equals(object obj)
        {
            return this.id.Equals(((Vendedor)obj).id);
        }

    }
}
